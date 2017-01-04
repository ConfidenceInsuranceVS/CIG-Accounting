using System;
using System.Collections.Generic;
using DevExpress.XtraReports.UI;

namespace Accounting.Reports
{
    public partial class RptPostDatedChequesInstant : Accounting.iReport
    {
        decimal? s1st = 0, s2nd = 0;
        public RptPostDatedChequesInstant()
        {
            InitializeComponent();
        }

        private void xrLabel3_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
        }

        private void xrLabel3_EvaluateBinding(object sender, BindingEventArgs e)
        {
            s1st += (decimal?)e.Value ?? 0;
            xrLabel12.Text = String.Format("{0:#,#0.00;;\"\"}", s1st);
            //s1st.ToString();
        }

        private void xrLabel15_EvaluateBinding(object sender, BindingEventArgs e)
        {
            s2nd += (decimal?)e.Value ?? 0;
            xrLabel9.Text = String.Format("{0:#,#0.00;;\"\"}", s2nd);
            //s2nd.ToString();
        }

        private void xrLabel15_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
        }
    }
}
