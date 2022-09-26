Namespace dxSample

    Partial Class XtraReport1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim tableQuery1 As DevExpress.DataAccess.Sql.TableQuery = New DevExpress.DataAccess.Sql.TableQuery()
            Dim tableInfo1 As DevExpress.DataAccess.Sql.TableInfo = New DevExpress.DataAccess.Sql.TableInfo()
            Dim columnInfo1 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo2 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo3 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo4 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo5 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo6 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo7 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo8 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo9 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo10 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo11 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo12 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo13 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo14 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo15 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo16 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo17 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dxSample.XtraReport1))
            Me.xrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.paramFirstNameMaxLength = New DevExpress.XtraReports.Parameters.Parameter()
            Me.xrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrTableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource()
            Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.paramTitleColumnMaxLength = New DevExpress.XtraReports.Parameters.Parameter()
            Me.xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            CType((Me.xrTable1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' xrTableCell8
            ' 
            Me.xrTableCell8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Employees.HireDate")})
            Me.xrTableCell8.Name = "xrTableCell8"
            Me.xrTableCell8.Text = "xrTableCell8"
            Me.xrTableCell8.Weight = 0.11111111111111111R
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.HeightF = 100F
            Me.TopMargin.Name = "TopMargin"
            ' 
            ' xrTableRow1
            ' 
            Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell1, Me.xrTableCell2, Me.xrTableCell3, Me.xrTableCell4, Me.xrTableCell5, Me.xrTableCell6, Me.xrTableCell7, Me.xrTableCell8, Me.xrTableCell9, Me.xrTableCell10, Me.xrTableCell12, Me.xrTableCell13, Me.xrTableCell14, Me.xrTableCell15, Me.xrTableCell16})
            Me.xrTableRow1.Name = "xrTableRow1"
            Me.xrTableRow1.Weight = 11.5R
            ' 
            ' xrTableCell7
            ' 
            Me.xrTableCell7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Employees.FirstName")})
            Me.xrTableCell7.Name = "xrTableCell7"
            Me.xrTableCell7.Text = "xrTableCell7"
            Me.xrTableCell7.Weight = 0.11111111111111111R
            ' 
            ' paramFirstNameMaxLength
            ' 
            Me.paramFirstNameMaxLength.Description = "Parameter1"
            Me.paramFirstNameMaxLength.Name = "paramFirstNameMaxLength"
            Me.paramFirstNameMaxLength.Type = GetType(Integer)
            Me.paramFirstNameMaxLength.ValueInfo = "0"
            Me.paramFirstNameMaxLength.Visible = False
            ' 
            ' xrTableCell14
            ' 
            Me.xrTableCell14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Employees.ReportsTo")})
            Me.xrTableCell14.Name = "xrTableCell14"
            Me.xrTableCell14.Text = "xrTableCell14"
            Me.xrTableCell14.Weight = 0.11111111111111111R
            ' 
            ' xrTableCell9
            ' 
            Me.xrTableCell9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Employees.HomePhone")})
            Me.xrTableCell9.Name = "xrTableCell9"
            Me.xrTableCell9.Text = "xrTableCell9"
            Me.xrTableCell9.Weight = 0.11111111111111111R
            ' 
            ' xrTable1
            ' 
            Me.xrTable1.Borders = CType(((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrTable1.Name = "xrTable1"
            Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow1})
            Me.xrTable1.SizeF = New System.Drawing.SizeF(1800F, 25F)
            Me.xrTable1.StylePriority.UseBorders = False
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.HeightF = 100F
            Me.BottomMargin.Name = "BottomMargin"
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable1})
            Me.Detail.HeightF = 25F
            Me.Detail.Name = "Detail"
            ' 
            ' xrTableCell15
            ' 
            Me.xrTableCell15.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Employees.Title")})
            Me.xrTableCell15.Name = "xrTableCell15"
            Me.xrTableCell15.Text = "xrTableCell15"
            Me.xrTableCell15.Weight = 0.11111111111111111R
            ' 
            ' xrTableCell3
            ' 
            Me.xrTableCell3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Employees.City")})
            Me.xrTableCell3.Name = "xrTableCell3"
            Me.xrTableCell3.Text = "xrTableCell3"
            Me.xrTableCell3.Weight = 0.11111111111111111R
            ' 
            ' xrTableCell13
            ' 
            Me.xrTableCell13.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Employees.Region")})
            Me.xrTableCell13.Name = "xrTableCell13"
            Me.xrTableCell13.Text = "xrTableCell13"
            Me.xrTableCell13.Weight = 0.11111111111111111R
            ' 
            ' xrTableCell10
            ' 
            Me.xrTableCell10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Employees.LastName")})
            Me.xrTableCell10.Name = "xrTableCell10"
            Me.xrTableCell10.Text = "xrTableCell10"
            Me.xrTableCell10.Weight = 0.11111111111111111R
            ' 
            ' xrTableCell5
            ' 
            Me.xrTableCell5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Employees.EmployeeID")})
            Me.xrTableCell5.Name = "xrTableCell5"
            Me.xrTableCell5.Text = "xrTableCell5"
            Me.xrTableCell5.Weight = 0.11111111111111111R
            ' 
            ' xrTableCell16
            ' 
            Me.xrTableCell16.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Employees.TitleOfCourtesy")})
            Me.xrTableCell16.Name = "xrTableCell16"
            Me.xrTableCell16.Text = "xrTableCell16"
            Me.xrTableCell16.Weight = 0.11111111111111111R
            ' 
            ' sqlDataSource1
            ' 
            Me.sqlDataSource1.ConnectionName = "dxSample.Properties.Settings.nwindConnectionString"
            Me.sqlDataSource1.Name = "sqlDataSource1"
            tableQuery1.Name = "Employees"
            tableInfo1.Name = "Employees"
            columnInfo1.Name = "EmployeeID"
            columnInfo2.Name = "LastName"
            columnInfo3.Name = "FirstName"
            columnInfo4.Name = "Title"
            columnInfo5.Name = "TitleOfCourtesy"
            columnInfo6.Name = "BirthDate"
            columnInfo7.Name = "HireDate"
            columnInfo8.Name = "Address"
            columnInfo9.Name = "City"
            columnInfo10.Name = "Region"
            columnInfo11.Name = "PostalCode"
            columnInfo12.Name = "Country"
            columnInfo13.Name = "HomePhone"
            columnInfo14.Name = "Extension"
            columnInfo15.Name = "Photo"
            columnInfo16.Name = "Notes"
            columnInfo17.Name = "ReportsTo"
            tableInfo1.SelectedColumns.AddRange(New DevExpress.DataAccess.Sql.ColumnInfo() {columnInfo1, columnInfo2, columnInfo3, columnInfo4, columnInfo5, columnInfo6, columnInfo7, columnInfo8, columnInfo9, columnInfo10, columnInfo11, columnInfo12, columnInfo13, columnInfo14, columnInfo15, columnInfo16, columnInfo17})
            tableQuery1.Tables.AddRange(New DevExpress.DataAccess.Sql.TableInfo() {tableInfo1})
            Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {tableQuery1})
            Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
            ' 
            ' xrTableCell4
            ' 
            Me.xrTableCell4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Employees.Country")})
            Me.xrTableCell4.Name = "xrTableCell4"
            Me.xrTableCell4.Text = "xrTableCell4"
            Me.xrTableCell4.Weight = 0.11111111111111111R
            ' 
            ' xrTableCell12
            ' 
            Me.xrTableCell12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Employees.PostalCode")})
            Me.xrTableCell12.Name = "xrTableCell12"
            Me.xrTableCell12.Text = "xrTableCell12"
            Me.xrTableCell12.Weight = 0.11111111111111111R
            ' 
            ' paramTitleColumnMaxLength
            ' 
            Me.paramTitleColumnMaxLength.Description = "Parameter1"
            Me.paramTitleColumnMaxLength.Name = "paramTitleColumnMaxLength"
            Me.paramTitleColumnMaxLength.Type = GetType(Integer)
            Me.paramTitleColumnMaxLength.ValueInfo = "0"
            Me.paramTitleColumnMaxLength.Visible = False
            ' 
            ' xrTableCell6
            ' 
            Me.xrTableCell6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Employees.Extension")})
            Me.xrTableCell6.Name = "xrTableCell6"
            Me.xrTableCell6.Text = "xrTableCell6"
            Me.xrTableCell6.Weight = 0.11111111111111111R
            ' 
            ' xrTableCell2
            ' 
            Me.xrTableCell2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Employees.BirthDate")})
            Me.xrTableCell2.Name = "xrTableCell2"
            Me.xrTableCell2.Text = "xrTableCell2"
            Me.xrTableCell2.Weight = 0.11111111111111111R
            ' 
            ' xrTableCell1
            ' 
            Me.xrTableCell1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Employees.Address")})
            Me.xrTableCell1.Name = "xrTableCell1"
            Me.xrTableCell1.Text = "xrTableCell1"
            Me.xrTableCell1.Weight = 0.11111111111111111R
            ' 
            ' XtraReport2
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.Detail, Me.BottomMargin})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.sqlDataSource1})
            Me.DataMember = "Employees"
            Me.DataSource = Me.sqlDataSource1
            Me.Landscape = True
            Me.PageHeight = 850
            Me.PageWidth = 2000
            Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
            Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.paramFirstNameMaxLength, Me.paramTitleColumnMaxLength})
            Me.ScriptReferencesString = "DevExpress.XtraEditors.v14.2" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "DevExpress.Utils.v14.2"
            Me.Version = "14.2"
            CType((Me.xrTable1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
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
