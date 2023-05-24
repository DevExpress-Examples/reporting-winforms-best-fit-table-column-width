Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrinting.Native
Imports DevExpress.XtraReports.UI
Imports System
Imports System.Collections.Generic
Imports DevExpress.Drawing.Printing
Imports System.Linq

Namespace dxSample

    Public Class ReportHelper

        Private Const additionalCellSpace As Single = 3

        Private Shared cellColumnWidthCollection As Dictionary(Of XRControl, Single) = New Dictionary(Of XRControl, Single)()

        Public Function CreateReportWithAutoCellWidth(ByVal report As XtraReport) As XtraReport
            InitializeReport(report)
            CreateDocument(report)
            FillColumnCellWidthCollection(report)
            ApplyNewWidthToReportCells(report)
            CreateDocument(report)
            Return report
        End Function

        Private Sub CreateDocument(ByVal report As XtraReport)
            report.CreateDocument()
        End Sub

        Private Sub InitializeReport(ByVal targetReport As XtraReport)
            targetReport.PaperKind = DXPaperKind.Custom
            targetReport.ReportUnit = ReportUnit.Pixels
            targetReport.PageWidth = 3000
            targetReport.RollPaper = True
        End Sub

        Private Sub ApplyNewWidthToReportCells(ByVal report As XtraReport)
            Dim tables As IList(Of KeyValuePair(Of XRTable, List(Of XRTable))) = FindTables(report)
            For Each table In tables
                Dim totalWidth As Single = 0
                For Each dc As XRTableCell In table.Key.Rows(0).Cells
                    Dim newWidth As Single = cellColumnWidthCollection(dc)
                    For Each otherTable In table.Value
                        newWidth = Math.Max(newWidth, cellColumnWidthCollection(otherTable.Rows(0).Cells(dc.Index)))
                    Next

                    newWidth += additionalCellSpace
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

                    newWidth += additionalCellSpace
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

        Private Sub FillColumnCellWidthCollection(ByVal currentReport As XtraReport)
            For Each page As PSPage In currentReport.Pages
                Dim iterator As NestedBrickIterator = New NestedBrickIterator(page.InnerBricks)
                While iterator.MoveNext()
                    If TypeOf iterator.CurrentBrick Is VisualBrick AndAlso TypeOf CType(iterator.CurrentBrick, VisualBrick).BrickOwner Is XRTableCell Then
                        Dim cell As XRTableCell = TryCast(CType(iterator.CurrentBrick, VisualBrick).BrickOwner, XRTableCell)
                        Dim currentCellText As String = CType(iterator.CurrentBrick, VisualBrick).Text
                        Dim bestCellWidthForProvidedText As Single = BestSizeEstimator.GetBoundsToFitText(currentCellText, CType(iterator.CurrentBrick, VisualBrick).Style, currentReport.ReportUnit).Width
                        If Not cellColumnWidthCollection.ContainsKey(cell) Then
                            cellColumnWidthCollection.Add(cell, bestCellWidthForProvidedText)
                        Else
                            Dim value As Single = cellColumnWidthCollection(cell)
                            If bestCellWidthForProvidedText > value Then
                                cellColumnWidthCollection(cell) = bestCellWidthForProvidedText
                            End If
                        End If
                    End If
                End While
            Next
        End Sub
    End Class
End Namespace
