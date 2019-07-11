using System;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace dxSample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void simpleButton1_Click(object sender, EventArgs e) {
            XtraReport report = new XtraReport1();
            new ReportHelper().CreateReportWithAutoCellWidth(report);
            report.ShowPreview();
        }
    }
}
