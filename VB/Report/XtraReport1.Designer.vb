Namespace dxSample
	Partial Public Class XtraReport1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim selectQuery1 As New DevExpress.DataAccess.Sql.SelectQuery()
			Dim column1 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression1 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim table1 As New DevExpress.DataAccess.Sql.Table()
			Dim column2 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression2 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column3 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression3 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column4 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression4 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column5 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression5 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column6 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression6 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column7 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression7 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column8 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression8 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column9 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression9 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column10 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression10 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column11 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression11 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column12 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression12 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column13 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression13 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column14 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression14 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column15 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression15 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column16 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression16 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column17 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression17 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(XtraReport1))
			Me.xrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.paramFirstNameMaxLength = New DevExpress.XtraReports.Parameters.Parameter()
			Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
			Me.paramTitleColumnMaxLength = New DevExpress.XtraReports.Parameters.Parameter()
			CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' xrTableCell8
			' 
			Me.xrTableCell8.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[HireDate]")})
			Me.xrTableCell8.Name = "xrTableCell8"
			Me.xrTableCell8.Text = "xrTableCell8"
			Me.xrTableCell8.Weight = 0.11111111111111111R
			' 
			' TopMargin
			' 
			Me.TopMargin.Name = "TopMargin"
			' 
			' xrTableRow1
			' 
			Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell1, Me.xrTableCell2, Me.xrTableCell3, Me.xrTableCell4, Me.xrTableCell5, Me.xrTableCell6, Me.xrTableCell7, Me.xrTableCell8, Me.xrTableCell9, Me.xrTableCell10, Me.xrTableCell12, Me.xrTableCell13, Me.xrTableCell14, Me.xrTableCell15, Me.xrTableCell16})
			Me.xrTableRow1.Name = "xrTableRow1"
			Me.xrTableRow1.Weight = 11.5R
			' 
			' xrTableCell1
			' 
			Me.xrTableCell1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Address]")})
			Me.xrTableCell1.Name = "xrTableCell1"
			Me.xrTableCell1.Text = "xrTableCell1"
			Me.xrTableCell1.Weight = 0.11111111111111111R
			Me.xrTableCell1.WordWrap = False
			' 
			' xrTableCell2
			' 
			Me.xrTableCell2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BirthDate]")})
			Me.xrTableCell2.Name = "xrTableCell2"
			Me.xrTableCell2.Text = "xrTableCell2"
			Me.xrTableCell2.Weight = 0.11111111111111111R
			' 
			' xrTableCell3
			' 
			Me.xrTableCell3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[City]")})
			Me.xrTableCell3.Name = "xrTableCell3"
			Me.xrTableCell3.Text = "xrTableCell3"
			Me.xrTableCell3.Weight = 0.11111111111111111R
			' 
			' xrTableCell4
			' 
			Me.xrTableCell4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Country]")})
			Me.xrTableCell4.Name = "xrTableCell4"
			Me.xrTableCell4.Text = "xrTableCell4"
			Me.xrTableCell4.Weight = 0.11111111111111111R
			' 
			' xrTableCell5
			' 
			Me.xrTableCell5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[EmployeeID]")})
			Me.xrTableCell5.Name = "xrTableCell5"
			Me.xrTableCell5.Text = "xrTableCell5"
			Me.xrTableCell5.Weight = 0.11111111111111111R
			' 
			' xrTableCell6
			' 
			Me.xrTableCell6.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Extension]")})
			Me.xrTableCell6.Name = "xrTableCell6"
			Me.xrTableCell6.Text = "xrTableCell6"
			Me.xrTableCell6.Weight = 0.11111111111111111R
			' 
			' xrTableCell7
			' 
			Me.xrTableCell7.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[FirstName]")})
			Me.xrTableCell7.Name = "xrTableCell7"
			Me.xrTableCell7.Text = "xrTableCell7"
			Me.xrTableCell7.Weight = 0.11111111111111111R
			' 
			' xrTableCell9
			' 
			Me.xrTableCell9.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[HomePhone]")})
			Me.xrTableCell9.Name = "xrTableCell9"
			Me.xrTableCell9.Text = "xrTableCell9"
			Me.xrTableCell9.Weight = 0.11111111111111111R
			' 
			' xrTableCell10
			' 
			Me.xrTableCell10.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[LastName]")})
			Me.xrTableCell10.Name = "xrTableCell10"
			Me.xrTableCell10.Text = "xrTableCell10"
			Me.xrTableCell10.Weight = 0.11111111111111111R
			' 
			' xrTableCell12
			' 
			Me.xrTableCell12.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PostalCode]")})
			Me.xrTableCell12.Name = "xrTableCell12"
			Me.xrTableCell12.Text = "xrTableCell12"
			Me.xrTableCell12.Weight = 0.11111111111111111R
			' 
			' xrTableCell13
			' 
			Me.xrTableCell13.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Region]")})
			Me.xrTableCell13.Name = "xrTableCell13"
			Me.xrTableCell13.Text = "xrTableCell13"
			Me.xrTableCell13.Weight = 0.11111111111111111R
			' 
			' xrTableCell14
			' 
			Me.xrTableCell14.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ReportsTo]")})
			Me.xrTableCell14.Name = "xrTableCell14"
			Me.xrTableCell14.Text = "xrTableCell14"
			Me.xrTableCell14.Weight = 0.11111111111111111R
			' 
			' xrTableCell15
			' 
			Me.xrTableCell15.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Title]")})
			Me.xrTableCell15.Name = "xrTableCell15"
			Me.xrTableCell15.Text = "xrTableCell15"
			Me.xrTableCell15.Weight = 0.11111111111111111R
			' 
			' xrTableCell16
			' 
			Me.xrTableCell16.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TitleOfCourtesy]")})
			Me.xrTableCell16.Name = "xrTableCell16"
			Me.xrTableCell16.Text = "xrTableCell16"
			Me.xrTableCell16.Weight = 0.11111111111111111R
			' 
			' paramFirstNameMaxLength
			' 
			Me.paramFirstNameMaxLength.Description = "Parameter1"
			Me.paramFirstNameMaxLength.Name = "paramFirstNameMaxLength"
			Me.paramFirstNameMaxLength.Type = GetType(Integer)
			Me.paramFirstNameMaxLength.ValueInfo = "0"
			Me.paramFirstNameMaxLength.Visible = False
			' 
			' xrTable1
			' 
			Me.xrTable1.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrTable1.Name = "xrTable1"
			Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow1})
			Me.xrTable1.SizeF = New System.Drawing.SizeF(1800F, 25F)
			Me.xrTable1.StylePriority.UseBorders = False
			' 
			' BottomMargin
			' 
			Me.BottomMargin.Name = "BottomMargin"
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable1})
			Me.Detail.HeightF = 25F
			Me.Detail.Name = "Detail"
			' 
			' sqlDataSource1
			' 
			Me.sqlDataSource1.ConnectionName = "dxSample.Properties.Settings.nwindConnectionString"
			Me.sqlDataSource1.Name = "sqlDataSource1"
			columnExpression1.ColumnName = "EmployeeID"
			table1.Name = "Employees"
			columnExpression1.Table = table1
			column1.Expression = columnExpression1
			columnExpression2.ColumnName = "LastName"
			columnExpression2.Table = table1
			column2.Expression = columnExpression2
			columnExpression3.ColumnName = "FirstName"
			columnExpression3.Table = table1
			column3.Expression = columnExpression3
			columnExpression4.ColumnName = "Title"
			columnExpression4.Table = table1
			column4.Expression = columnExpression4
			columnExpression5.ColumnName = "TitleOfCourtesy"
			columnExpression5.Table = table1
			column5.Expression = columnExpression5
			columnExpression6.ColumnName = "BirthDate"
			columnExpression6.Table = table1
			column6.Expression = columnExpression6
			columnExpression7.ColumnName = "HireDate"
			columnExpression7.Table = table1
			column7.Expression = columnExpression7
			columnExpression8.ColumnName = "Address"
			columnExpression8.Table = table1
			column8.Expression = columnExpression8
			columnExpression9.ColumnName = "City"
			columnExpression9.Table = table1
			column9.Expression = columnExpression9
			columnExpression10.ColumnName = "Region"
			columnExpression10.Table = table1
			column10.Expression = columnExpression10
			columnExpression11.ColumnName = "PostalCode"
			columnExpression11.Table = table1
			column11.Expression = columnExpression11
			columnExpression12.ColumnName = "Country"
			columnExpression12.Table = table1
			column12.Expression = columnExpression12
			columnExpression13.ColumnName = "HomePhone"
			columnExpression13.Table = table1
			column13.Expression = columnExpression13
			columnExpression14.ColumnName = "Extension"
			columnExpression14.Table = table1
			column14.Expression = columnExpression14
			columnExpression15.ColumnName = "Photo"
			columnExpression15.Table = table1
			column15.Expression = columnExpression15
			columnExpression16.ColumnName = "Notes"
			columnExpression16.Table = table1
			column16.Expression = columnExpression16
			columnExpression17.ColumnName = "ReportsTo"
			columnExpression17.Table = table1
			column17.Expression = columnExpression17
			selectQuery1.Columns.Add(column1)
			selectQuery1.Columns.Add(column2)
			selectQuery1.Columns.Add(column3)
			selectQuery1.Columns.Add(column4)
			selectQuery1.Columns.Add(column5)
			selectQuery1.Columns.Add(column6)
			selectQuery1.Columns.Add(column7)
			selectQuery1.Columns.Add(column8)
			selectQuery1.Columns.Add(column9)
			selectQuery1.Columns.Add(column10)
			selectQuery1.Columns.Add(column11)
			selectQuery1.Columns.Add(column12)
			selectQuery1.Columns.Add(column13)
			selectQuery1.Columns.Add(column14)
			selectQuery1.Columns.Add(column15)
			selectQuery1.Columns.Add(column16)
			selectQuery1.Columns.Add(column17)
			selectQuery1.Name = "Employees"
			selectQuery1.Tables.Add(table1)
			Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { selectQuery1})
			Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
			' 
			' paramTitleColumnMaxLength
			' 
			Me.paramTitleColumnMaxLength.Description = "Parameter1"
			Me.paramTitleColumnMaxLength.Name = "paramTitleColumnMaxLength"
			Me.paramTitleColumnMaxLength.Type = GetType(Integer)
			Me.paramTitleColumnMaxLength.ValueInfo = "0"
			Me.paramTitleColumnMaxLength.Visible = False
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.TopMargin, Me.Detail, Me.BottomMargin})
			Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() { Me.sqlDataSource1})
			Me.DataMember = "Employees"
			Me.DataSource = Me.sqlDataSource1
			Me.Landscape = True
			Me.PageHeight = 850
			Me.PageWidth = 2000
			Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
			Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() { Me.paramFirstNameMaxLength, Me.paramTitleColumnMaxLength})
			Me.ScriptReferencesString = "DevExpress.XtraEditors.v14.2" & vbCrLf & "DevExpress.Utils.v14.2"
			Me.Version = "19.1"
			CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private xrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell14 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell15 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell16 As DevExpress.XtraReports.UI.XRTableCell
		Private paramFirstNameMaxLength As DevExpress.XtraReports.Parameters.Parameter
		Private xrTable1 As DevExpress.XtraReports.UI.XRTable
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
		Private paramTitleColumnMaxLength As DevExpress.XtraReports.Parameters.Parameter

	End Class
End Namespace
