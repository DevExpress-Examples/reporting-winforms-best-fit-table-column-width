Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Linq
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrinting.Native
Imports DevExpress.XtraReports.UI

Namespace dxSample

    Public Class ReportHelper

        Private Const AdditionalCellWidth As Single = 0

        Private Shared cellColumnWidthCollection As Dictionary(Of XRControl, Single)

        Public Function CreateReportWithAutoCellWidth(ByVal xtraReport As XtraReport) As XtraReport
            ' I need this for a later excel-export to simulate endless paper (all report pages on one sheet)
            xtraReport.PaperKind = PaperKind.Custom
            xtraReport.ReportUnit = ReportUnit.Pixels
            xtraReport.PageWidth = 3000
            xtraReport.RollPaper = True
            cellColumnWidthCollection = New Dictionary(Of XRControl, Single)()
            xtraReport.CreateDocument()
            FillColumnCellWidthCollection(xtraReport)
            ApplyNewWidthToReportCells(xtraReport)
            xtraReport.CreateDocument()
            Return xtraReport
        End Function

        Private Sub ApplyNewWidthToReportCells(ByVal xtraReport As XtraReport)
            Dim tables As IList(Of KeyValuePair(Of XRTable, List(Of XRTable))) = FindTables(xtraReport)
            For Each table In tables
                Dim totalWidth As Single = 0
                For Each dc As XRTableCell In table.Key.Rows(0).Cells
                    Dim newWidth As Single = cellColumnWidthCollection(dc)
                    For Each otherTable In table.Value
                        newWidth = Math.Max(newWidth, cellColumnWidthCollection(otherTable.Rows(0).Cells(dc.Index)))
                    Next

                    newWidth += AdditionalCellWidth
                    totalWidth += newWidth
                Next

                table.Key.WidthF = totalWidth
                For Each otherTable In table.Value
                    otherTable.WidthF = totalWidth
                Next

                table.Key.BeginInit()
                For Each otherTable In table.Value
                    otherTable.BeginInit()
                Next

                For Each dc As XRTableCell In table.Key.Rows(0).Cells
                    Dim newWidth As Single = cellColumnWidthCollection(dc)
                    For Each otherTable In table.Value
                        newWidth = Math.Max(newWidth, cellColumnWidthCollection(otherTable.Rows(0).Cells(dc.Index)))
                    Next

                    newWidth += AdditionalCellWidth
                    dc.WidthF = newWidth
                    For Each otherTable In table.Value
                        otherTable.Rows(0).Cells(dc.Index).WidthF = newWidth
                    Next
                Next

                table.Key.EndInit()
                For Each otherTable In table.Value
                    otherTable.EndInit()
                Next
            Next
        End Sub

        Private Function FindTables(ByVal xtraReport As XtraReport) As IList(Of KeyValuePair(Of XRTable, List(Of XRTable)))
            Dim result = New List(Of KeyValuePair(Of XRTable, List(Of XRTable)))()
            Dim allTables As IEnumerable(Of XRTable) = xtraReport.AllControls(Of XRTable)().Where(Function(t) t.Visible)
            For Each table In allTables
                Dim subResult = New List(Of XRTable)()
                Dim dataCells As XRTableCellCollection = table.Rows(0).Cells
                Dim match As Boolean = True
                Dim candidates As IEnumerable(Of XRTable) = allTables.Where(Function(t) t.Visible AndAlso t IsNot table)
                For Each candidate In candidates
                    If candidate.Rows(0).Cells.Count = dataCells.Count Then
                        Dim cells As XRTableCellCollection = candidate.Rows(0).Cells
                        For i As Integer = 0 To cells.Count - 1
                            match = match And Compare(dataCells(i).WidthF, candidate.Rows(0).Cells(i).WidthF, 5) = 0
                        Next

                        If match Then
                            subResult.Add(candidate)
                        End If
                    End If
                Next

                result.Add(New KeyValuePair(Of XRTable, List(Of XRTable))(table, subResult))
            Next

            Return result
        End Function

        Private Sub FillColumnCellWidthCollection(ByVal xtraReport As XtraReport)
            For Each page As PSPage In xtraReport.Pages
                Dim iterator As NestedBrickIterator = New NestedBrickIterator(page.InnerBricks)
                While iterator.MoveNext()
                    If TypeOf iterator.CurrentBrick Is VisualBrick AndAlso TypeOf CType(iterator.CurrentBrick, VisualBrick).BrickOwner Is XRTableCell Then
                        Dim text As String = CType(iterator.CurrentBrick, VisualBrick).Text
                        Dim cell As XRTableCell = TryCast(CType(iterator.CurrentBrick, VisualBrick).BrickOwner, XRTableCell)
                        Dim actualWidth As Single = BrickGraphics.MeasureString(text, cell.GetEffectiveFont(), 0, CType(StringFormat.GenericTypographic.Clone(), StringFormat), GraphicsUnit.Document).Width
                        Select Case xtraReport.ReportUnit
                            Case ReportUnit.HundredthsOfAnInch
                                actualWidth = GraphicsUnitConverter.Convert(actualWidth, GraphicsUnit.Document, GraphicsUnit.Inch) * 100
                            Case ReportUnit.TenthsOfAMillimeter
                                actualWidth = GraphicsUnitConverter.Convert(actualWidth, GraphicsUnit.Document, GraphicsUnit.Millimeter) * 10
                            Case ReportUnit.Pixels
                                actualWidth = GraphicsUnitConverter.Convert(actualWidth, GraphicsUnit.Document, GraphicsUnit.Pixel)
                        End Select

                        actualWidth += 1 'the returned text metrics are slighly off regarding what it actually takes to render the text
                        If Not cellColumnWidthCollection.ContainsKey(cell) Then
                            cellColumnWidthCollection.Add(cell, actualWidth)
                        Else
                            Dim value As Single = cellColumnWidthCollection(cell)
                            If actualWidth > value Then
                                cellColumnWidthCollection(cell) = actualWidth
                            End If
                        End If
                    End If
                End While
            Next
        End Sub
    End Class
End Namespace
