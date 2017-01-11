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

        private void xrLabel3_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) // added by samir BU 05/01/2017-2 
        {
            var rec = ((PostDatedChequesInstantResult)GetCurrentRow());
            //   xrLabel3.Text = String.Format("{0:#,#0.00;;\"\"}", rec.Balance1st); same like below
            getFormat(sender, rec.Balance1st);
        }


        private void xrLabel13_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) // added by samir BU 05/01/2017-2 
        {
            var rec = ((PostDatedChequesInstantResult)GetCurrentRow());
            getFormat(sender, rec.Balance1st);
            s1st += rec.Balance1st;
            xrLabel13.Text = String.Format("{0:#,#0.00;;\"\"}", s1st);
        }
        private void xrLabel9_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) // added by samir
        {
            var rec = ((PostDatedChequesInstantResult)GetCurrentRow());
            getFormat(sender, rec.Balance1st);
            s2nd += rec.Balance2nd;
            xrLabel9.Text = String.Format("{0:#,#0.00;;\"\"}", s2nd);
        }
        private void xrLabel15_EvaluateBinding(object sender, BindingEventArgs e)
        {
            s2nd += (decimal?)e.Value ?? 0;
            //  xrLabel9.Text = String.Format("{0:#,#0.00;;\"\"}", s2nd);
            //s2nd.ToString();
        }

        private void xrLabel15_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var rec = ((PostDatedChequesInstantResult)GetCurrentRow()); // added by samir 09/01/2017                                                                  
            getFormat(sender, rec.Balance2nd);
        }

        private void getFormat(object sender, decimal? amount) // added by samir 09/01/2017
        {
            var xrl = sender as XRLabel;
            xrl.DataBindings.Clear();
            if (amount == null)
                xrl.Text = "0.00";
            else if (amount.ToString().Length <= 12)
                xrl.Text = decimal.Parse(amount.ToString()).ToString("#,###.00");
            else
                xrl.Text = decimal.Parse(amount.ToString()).ToString("#.00");
        }
    }
}
