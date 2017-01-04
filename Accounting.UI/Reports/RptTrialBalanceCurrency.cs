using System;
using System.Collections.Generic;
using DevExpress.XtraReports.UI;

namespace Accounting.Reports
{
    public partial class RptTrialBalanceCurrency : Accounting.iReport
    {
        public int currency;
        public RptTrialBalanceCurrency()
        {
            InitializeComponent();
        }

        private void lblDebit_EvaluateBinding(object sender, BindingEventArgs e)
        {
            switch (currency)
            {
                case 0:
                    e.Value = ((Accounting.TrialBalance)GetCurrentRow()).Debit;
                    break;
                case 1:
                    e.Value = ((Accounting.TrialBalance)GetCurrentRow()).Debit1st;
                    break;
                case 2:
                    e.Value = ((Accounting.TrialBalance)GetCurrentRow()).Debit2nd;
                    break;
                default:
                    break;
            }
        }

        private void lblCredit_EvaluateBinding(object sender, BindingEventArgs e)
        {
            switch (currency)
            {
                case 0:
                    e.Value = ((Accounting.TrialBalance)GetCurrentRow()).Credit;
                    break;
                case 1:
                    e.Value = ((Accounting.TrialBalance)GetCurrentRow()).Credit1st;
                    break;
                case 2:
                    e.Value = ((Accounting.TrialBalance)GetCurrentRow()).Credit2nd;
                    break;
                default:
                    break;
            }
        }

        private void lblBalance_EvaluateBinding(object sender, BindingEventArgs e)
        {
            var rec = (Accounting.TrialBalance)GetCurrentRow();
            switch (currency)
            {
                case 0:
                    e.Value = rec.Debit - rec.Credit;
                    break;
                case 1:
                    e.Value = rec.Debit1st - rec.Credit1st;
                    break;
                case 2:
                    e.Value = rec.Debit2nd - rec.Credit2nd;
                    break;
                default:
                    break;
            }
        }

        private void xrLabel4_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            e.Cancel = currency != 0;
        }

        private void xrLabel6_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            e.Cancel = currency != 0;
        }

        private void ReportFooter_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            e.Cancel = currency == 0;
        }
    }
}
