Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrinting.Native
Imports DevExpress.XtraReports.UI
Imports System
Imports System.Collections.Generic
Imports System.Drawing.Printing
Imports System.Linq

Namespace dxSample
	Public Class ReportHelper
		Private Const additionalCellSpace As Single = 3
		Private Shared cellColumnWidthCollection As New Dictionary(Of XRControl, Single)()
		Public Function CreateReportWithAutoCellWidth(ByVal report As DevExpress.XtraReports.UI.XtraReport) As DevExpress.XtraReports.UI.XtraReport
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
			targetReport.PaperKind = PaperKind.Custom
			targetReport.ReportUnit = ReportUnit.Pixels
			targetReport.PageWidth = 3000
			targetReport.RollPaper = True
		End Sub
		Private Sub ApplyNewWidthToReportCells(ByVal report As DevExpress.XtraReports.UI.XtraReport)
			Dim tables As IList(Of KeyValuePair(Of XRTable, List(Of XRTable))) = FindTables(report)
			For Each table In tables
				Dim totalWidth As Single = 0
				For Each dc As XRTableCell In table.Key.Rows(0).Cells
					Dim newWidth As Single = cellColumnWidthCollection(dc)
					For Each otherTable In table.Value
						newWidth = Math.Max(newWidth, cellColumnWidthCollection(otherTable.Rows(0).Cells(dc.Index)))
					Next otherTable
					newWidth += additionalCellSpace
					totalWidth += newWidth
				Next dc
				table.Key.WidthF = totalWidth
				For Each otherTable In table.Value
					otherTable.WidthF = totalWidth
				Next otherTable
				table.Key.BeginInit()
				For Each otherTable In table.Value
					otherTable.BeginInit()
				Next otherTable
				For Each dc As XRTableCell In table.Key.Rows(0).Cells
					Dim newWidth As Single = cellColumnWidthCollection(dc)
					For Each otherTable In table.Value
						newWidth = Math.Max(newWidth, cellColumnWidthCollection(otherTable.Rows(0).Cells(dc.Index)))
					Next otherTable
					newWidth += additionalCellSpace
					dc.WidthF = newWidth
					For Each otherTable In table.Value
						otherTable.Rows(0).Cells(dc.Index).WidthF = newWidth
					Next otherTable
				Next dc
				table.Key.EndInit()
				For Each otherTable In table.Value
					otherTable.EndInit()
				Next otherTable
			Next table
		End Sub

		Private Function FindTables(ByVal xtraReport As DevExpress.XtraReports.UI.XtraReport) As IList(Of KeyValuePair(Of XRTable, List(Of XRTable)))
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
							match = match And FloatComparer.Compare(dataCells(i).WidthF, candidate.Rows(0).Cells(i).WidthF, 5) = 0
						Next i
						If match Then
							subResult.Add(candidate)
						End If
					End If
				Next candidate
				result.Add(New KeyValuePair(Of XRTable, List(Of XRTable))(table, subResult))
			Next table
			Return result
		End Function

		Private Sub FillColumnCellWidthCollection(ByVal currentReport As DevExpress.XtraReports.UI.XtraReport)
			For Each page As PSPage In currentReport.Pages
				Dim iterator As New NestedBrickIterator(page.InnerBricks)
				Do While iterator.MoveNext()
					If TypeOf iterator.CurrentBrick Is VisualBrick AndAlso TypeOf (CType(iterator.CurrentBrick, VisualBrick)).BrickOwner Is XRTableCell Then
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
				Loop
			Next page
		End Sub
	End Class
End Namespace
