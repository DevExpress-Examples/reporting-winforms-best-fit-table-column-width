<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))
* [XtraReport1.cs](./CS/Report/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/Report/XtraReport1.vb))
* **[ReportHelper.cs](./CS/ReportHelper/ReportHelper.cs) (VB: [ReportHelper.vb](./VB/ReportHelper/ReportHelper.vb))**
<!-- default file list end -->
# XRTable - How to best fit columns


<p>Currently, <a href="https://documentation.devexpress.com/#XtraReports/clsDevExpressXtraReportsUIXRTabletopic">XRTable</a> does not provide the best fit column functionality for several reasons. It is not quite clear how this feature should work in the case of multi-line text in cells. Being applied to a grid, the best-fit feature resizes grid columns so you can use the horizontal scrollbar to reach all of them. Reports does not provide interactivity like content scrolling and it is difficult to foresee how a user would want to change the report layout in the case of large column content. <br /><br /></p>
<p>For these reasons, a generic solution is not always possible. However, we can implement this manually if required. This example demonstrates how to do so. <br /><br />Here are implementation details.<br />1. Create a document by using the Report's <a href="http://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsUIXtraReport_CreateDocumenttopic">CreateDocument Method</a>.<br />2. Iterate through all report bricks to obtain the maximum text width within a certain column.<br />Since XRTable rows act independently and know nothing about each other, to detect the max width of the text in a certain column, we need to iterate through report table bricks manually (for instance,<strong> </strong>using BricksIterator) and calculate the text width (using the <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressXtraPrintingBrickGraphics_MeasureStringtopic">PrintingSystem.Graph.MeasureString</a> method).<br />3. Re-set the XRTableCell's WidthF property according to calculation results.<br />4. Re-create the report document.<br /><br />See also:<br /><a href="https://www.devexpress.com/Support/Center/p/A2747">How to set the label width so that it is always equal to its text (AutoWidth)</a><br /><a href="https://www.devexpress.com/Support/Center/p/E20053">Customizing row height at runtime to a maximum best fit value</a></p>

<br/>


