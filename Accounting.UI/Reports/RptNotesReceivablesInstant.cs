using System;
using System.Collections.Generic;
using DevExpress.XtraReports.UI;

namespace Accounting.Reports
{
    public partial class RptNotesReceivablesInstant : Accounting.iReport
    {
        public DateTime? till;
        decimal? sum1st = 0, sum2nd = 0;
        public RptNotesReceivablesInstant()
        {
            InitializeComponent();
        }
        private void gfAccount_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
        }
        private void lblReference_EvaluateBinding(object sender, BindingEventArgs e)
        {
            var rec = (NotesReceivables)GetCurrentRow();
            e.Value = string.Format("{0}/{1}", rec.type.TrimEnd(), rec.reference.ToString().PadLeft(5,'0'));
        }

        private void lblBalanceDebit_EvaluateBinding(object sender, BindingEventArgs e)
        {
            if ((decimal)e.Value < 0) { e.Value = 0; }
            else { e.Value = Math.Abs((decimal)e.Value); }
        }

        private void lblBalanceCredit_EvaluateBinding(object sender, BindingEventArgs e)
        {
            if ((decimal)e.Value > 0) { e.Value = 0; }
            else { e.Value = Math.Abs((decimal)e.Value); }
        }

        private void xrLabel17_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
        }

        private void xrLabel17_EvaluateBinding(object sender, BindingEventArgs e)
        {
            var rec = (NotesReceivables)GetCurrentRow();
            sum1st += rec.debit1st - rec.credit1st;
            e.Value = sum1st;
        }

        private void xrLabel18_EvaluateBinding(object sender, BindingEventArgs e)
        {
            var rec = (NotesReceivables)GetCurrentRow();
            sum2nd += rec.debit2nd - rec.credit2nd;
            e.Value = sum2nd;
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var rec = (NotesReceivables)GetCurrentRow();
            if (rec.maturity < till)
                xrPanel1.BackColor = System.Drawing.Color.Gainsboro;
            else
                xrPanel1.BackColor = System.Drawing.Color.Transparent;
        }
    }
}
