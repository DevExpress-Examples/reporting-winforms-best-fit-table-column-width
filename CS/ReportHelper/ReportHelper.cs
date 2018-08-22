using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Native;
using DevExpress.XtraReports.UI;

namespace dxSample
{
    public class ReportHelper
    {
        private const float AdditionalCellWidth = 0;

        private static Dictionary<XRControl, float> cellColumnWidthCollection;
        /// <summary>
        /// Indicates whether or not the specified Printing System command can be handled.
        /// </summary>
        /// <param name="command">A <see cref="T:DevExpress.XtraPrinting.PrintingSystemCommand" /> enumeration value.</param>
        /// <param name="printControl">An object implementing the <see cref="T:DevExpress.XtraPrinting.IPrintControl" /> interface (typically, this is a <see cref="T:DevExpress.XtraPrinting.Control.PrintControl" /> instance).</param>
        /// <returns>
        ///   true, if the command can be handled; otherwise, false.
        /// </returns>
        public virtual bool CanHandleCommand(PrintingSystemCommand command, IPrintControl printControl)
        {
            bool canBeHandled = command == PrintingSystemCommand.ExportXlsx || command == PrintingSystemCommand.ExportXls || command == PrintingSystemCommand.ExportCsv;
            return canBeHandled;
        }

        public DevExpress.XtraReports.UI.XtraReport CreateReportWithAutoCellWidth(DevExpress.XtraReports.UI.XtraReport xtraReport)
        {
            // I need this for a later excel-export to simulate endless paper (all report pages on one sheet)
            xtraReport.PaperKind = PaperKind.Custom;
            xtraReport.ReportUnit = ReportUnit.Pixels;
            xtraReport.PageWidth = 3000;
            xtraReport.RollPaper = true;

            cellColumnWidthCollection = new Dictionary<XRControl, float>();
            xtraReport.CreateDocument();
            FillColumnCellWidthCollection(xtraReport);
            ApplyNewWidthToReportCells(xtraReport);
            xtraReport.CreateDocument();

            return xtraReport;
        }

        private void ApplyNewWidthToReportCells(DevExpress.XtraReports.UI.XtraReport xtraReport)
        {
            IList<KeyValuePair<XRTable, List<XRTable>>> tables = FindTables(xtraReport);
            foreach (var table in tables)
            {
                float totalWidth = 0;
                foreach (XRTableCell dc in table.Key.Rows[0].Cells)
                {
                    float newWidth = cellColumnWidthCollection[dc];
                    foreach (var otherTable in table.Value)
                    {
                        newWidth = Math.Max(newWidth, cellColumnWidthCollection[otherTable.Rows[0].Cells[dc.Index]]);
                    }

                    newWidth += AdditionalCellWidth;
                    totalWidth += newWidth;
                }

                table.Key.WidthF = totalWidth;
                foreach (var otherTable in table.Value)
                {
                    otherTable.WidthF = totalWidth;
                }

                table.Key.BeginInit();
                foreach (var otherTable in table.Value)
                {
                    otherTable.BeginInit();
                }

                foreach (XRTableCell dc in table.Key.Rows[0].Cells)
                {
                    float newWidth = cellColumnWidthCollection[dc];
                    foreach (var otherTable in table.Value)
                    {
                        newWidth = Math.Max(newWidth, cellColumnWidthCollection[otherTable.Rows[0].Cells[dc.Index]]);
                    }

                    newWidth += AdditionalCellWidth;
                    dc.WidthF = newWidth;
                    foreach (var otherTable in table.Value)
                    {
                        otherTable.Rows[0].Cells[dc.Index].WidthF = newWidth;
                    }
                }

                table.Key.EndInit();
                foreach (var otherTable in table.Value)
                {
                    otherTable.EndInit();
                }
            }
        }

        private IList<KeyValuePair<XRTable, List<XRTable>>> FindTables(DevExpress.XtraReports.UI.XtraReport xtraReport)
        {
            var result = new List<KeyValuePair<XRTable, List<XRTable>>>();
            IEnumerable<XRTable> allTables = xtraReport.AllControls<XRTable>().Where(t => t.Visible);
            foreach (var table in allTables)
            {
                var subResult = new List<XRTable>();
                XRTableCellCollection dataCells = table.Rows[0].Cells;

                bool match = true;
                IEnumerable<XRTable> candidates = allTables.Where(t => t.Visible && t != table);
                foreach (var candidate in candidates)
                {
                    if (candidate.Rows[0].Cells.Count == dataCells.Count)
                    {
                        XRTableCellCollection cells = candidate.Rows[0].Cells;
                        for (int i = 0; i < cells.Count; i++)
                        {
                            match &= FloatComparer.Compare(dataCells[i].WidthF, candidate.Rows[0].Cells[i].WidthF, 5) == 0;
                        }

                        if (match)
                        {
                            subResult.Add(candidate);
                        }
                    }
                }

                result.Add(new KeyValuePair<XRTable, List<XRTable>>(table, subResult));
            }

            return result;
        }

        private void FillColumnCellWidthCollection(DevExpress.XtraReports.UI.XtraReport xtraReport)
        {
            foreach (PSPage page in xtraReport.Pages)
            {
                NestedBrickIterator iterator = new NestedBrickIterator(page.InnerBricks);
                while (iterator.MoveNext())
                {
                    if (iterator.CurrentBrick is VisualBrick && ((VisualBrick)iterator.CurrentBrick).BrickOwner is XRTableCell)
                    {
                        string text = ((VisualBrick)iterator.CurrentBrick).Text;
                        XRTableCell cell = ((VisualBrick)iterator.CurrentBrick).BrickOwner as XRTableCell;
                        float actualWidth = BrickGraphics.MeasureString(text, cell.GetEffectiveFont(), 0, (StringFormat)StringFormat.GenericTypographic.Clone(), GraphicsUnit.Document).Width;

                        switch (xtraReport.ReportUnit)
                        {
                            case ReportUnit.HundredthsOfAnInch:
                                actualWidth = GraphicsUnitConverter.Convert(actualWidth, GraphicsUnit.Document, GraphicsUnit.Inch) * 100;
                                break;
                            case ReportUnit.TenthsOfAMillimeter:
                                actualWidth = GraphicsUnitConverter.Convert(actualWidth, GraphicsUnit.Document, GraphicsUnit.Millimeter) * 10;
                                break;
                            case ReportUnit.Pixels:
                                actualWidth = GraphicsUnitConverter.Convert(actualWidth, GraphicsUnit.Document, GraphicsUnit.Pixel);
                                break;
                        }
                        actualWidth += 1; //the returned text metrics are slighly off regarding what it actually takes to render the text

                        if (!cellColumnWidthCollection.ContainsKey(cell))
                        {
                            cellColumnWidthCollection.Add(cell, actualWidth);
                        }
                        else
                        {
                            float value = cellColumnWidthCollection[cell];
                            if (actualWidth > value)
                            {
                                cellColumnWidthCollection[cell] = actualWidth;
                            }
                        }
                    }
                }
            }
        }
    }
}
