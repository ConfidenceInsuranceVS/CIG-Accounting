using System;
using System.Collections.Generic;
using DevExpress.XtraReports.UI;

namespace Accounting.Reports
{
    public partial class RptStatementOfAccountGlForeign : Accounting.iReport
    {
        public RptStatementOfAccountGlForeign()
        {
            InitializeComponent();
        }
        private void xrLabel13_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrLabel13.Text = lblCriteria.Text;
        }

        private void ReportHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            e.Cancel = true;
        }

        private void xrLabel18_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrLabel18.Text = lblCompany.Text;
            xrLabel17.Text = lblTitle.Text;
            xrLabel19.Text = lblInfo.Text;
        }
    }
}
