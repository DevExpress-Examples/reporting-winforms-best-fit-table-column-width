<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))
* [XtraReport1.cs](./CS/Report/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/Report/XtraReport1.vb))
* **[ReportHelper.cs](./CS/ReportHelper/ReportHelper.cs) (VB: [ReportHelper.vb](./VB/ReportHelper/ReportHelper.vb))**
<!-- default file list end -->
# Table Report - How to resize report columns to best fit cells' content

<p>To implement the best fit column functionality for <a href="https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XRTable">XRTable</a>, you should use the following approach. <br /></p>
<p>Use the <a href="https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XtraReport.CreateDocument">XtraReport.CreateDocument method</a> to create a report document and thus, generate a collection of document <a href="https://docs.devexpress.com/WindowsForms/88/Controls-and-Libraries/Printing-Exporting/Concepts/Basic-Terms/Brickss">bricks</a>. Then iterate through the bricks collection to obtain the maximum text width per column, use BricksIterator to loop through visual bricks and calculate the optimal text width using the <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressXtraPrintingBrickGraphics_MeasureStringtopic">PrintingSystem.Graph.MeasureString</a> method. <br /></p><p>Eventually, set the <a href="https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XRTableCell.WidthF">XRTableCell.WidthF</a> property according to the calculation result and recreate the report document.<br /></p>
<p>See also:<br /><a href="https://www.devexpress.com/Support/Center/p/A2747">How to set the label width so that it is always equal to its text (AutoWidth)</a><br /><a href="https://www.devexpress.com/Support/Center/p/E20053">Customizing row height at runtime to a maximum best fit value</a></p>

<br/>
