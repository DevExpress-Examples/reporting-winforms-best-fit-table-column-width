Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI

Namespace dxSample
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			Dim report As XtraReport = New XtraReport1()
			Call (New ReportHelper()).CreateReportWithAutoCellWidth(report)
			report.ShowPreview()
		End Sub
	End Class
End Namespace
