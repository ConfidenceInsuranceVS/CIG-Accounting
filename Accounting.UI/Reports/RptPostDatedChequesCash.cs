using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Windows.Forms;

namespace Accounting.Reports
{
    public partial class RptPostDatedChequesCash : Accounting.iReport
    {
        public RptPostDatedChequesCash(BindingSource bs)
        {
            InitializeComponent();
            bsReport.DataSource = bs.DataSource;
        }

        private void xrLabel9_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var rec = (CashReport)GetCurrentRow();
            xrLabel9.Text = string.Format("Total {0}", rec.Currency);
        }

        private void ReportHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
