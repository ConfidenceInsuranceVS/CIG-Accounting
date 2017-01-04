using System;
using System.Collections.Generic;
using System.Linq;

namespace Accounting.Reports
{
    public partial class RptProfitAndLoss : Accounting.iReport
    {
        public RptProfitAndLoss()
        {
            InitializeComponent();
        }

        private void xrLabel16_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var rec = (Accounting.ProfitAndLoss)GetCurrentRow();
            xrLabel16.Text = rec.Code.Substring(0,1) == "6" ? "Total Charges" : "Total Incomes"; 
        }

        private void xrLabel17_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var result = bsReport.List.OfType<Accounting.ProfitAndLoss>().Sum(c => c.Debit - c.Credit);
            xrLabel17.Text = result < 0 ? "Result  *** LOSS ***" : "Result";
        }
    }
}
