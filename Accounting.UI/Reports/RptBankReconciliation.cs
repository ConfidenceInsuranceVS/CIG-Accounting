using System;
using System.Collections.Generic;
using System.Linq;

namespace Accounting.Reports
{
    public partial class RptBankReconciliation : Accounting.iReport
    {
        public RptBankReconciliation()
        {
            InitializeComponent();
        }
        private void xrLabel4_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var rec = (Bankreconciliation)GetCurrentRow();
            if (rec.Vouchertypeid == null || rec.Vouchertypeid == 0)
                e.Cancel = true;
            else
                using (var ae = new AccountingEntities(App.MainConnectionString))
                {
                    var type = ae.Vouchertypes.FirstOrDefault(c => c.ID == rec.Vouchertypeid).Code;
                    xrLabel4.Text = string.Format("{0}{1}", type, rec.Reference.ToString().PadLeft(8, ' '));
                }
        }
        private void xrPanel1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var rec = (Bankreconciliation)GetCurrentRow();
            if (rec.Flag == "1" || rec.ID == -1)
                xrPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            else
                xrPanel1.BackColor = System.Drawing.Color.Transparent;
        }
        private void xrLabel13_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var ds = bsReport.List.OfType<Bankreconciliation>();
            var bal = ds.Sum(c => c.Debit ?? 0) - ds.Sum(c => c.Credit ?? 0);
            xrLabel13.Text = bal > 0 ? bal.ToString() : string.Empty;
        }
        private void xrLabel6_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var ds = bsReport.List.OfType<Bankreconciliation>();
            var bal = ds.Sum(c => c.Debit ?? 0) - ds.Sum(c => c.Credit ?? 0);
            xrLabel6.Text = bal < 0 ? bal.ToString() : string.Empty;
        }
    }
}
