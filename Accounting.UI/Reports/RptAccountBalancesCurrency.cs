using System;
using System.Collections.Generic;
using DevExpress.XtraReports.UI;

namespace Accounting.Reports
{
    public partial class RptAccountBalancesCurrency : Accounting.iReport
    {
        public int currency;
        public RptAccountBalancesCurrency()
        {
            InitializeComponent();
        }

        private void lblDebit_EvaluateBinding(object sender, BindingEventArgs e)
        {
            switch (currency)
            {
                case 0:
                    e.Value = ((AccountBalance)GetCurrentRow()).Debit;
                    break;
                case 1:
                    e.Value = ((AccountBalance)GetCurrentRow()).Debit1st;
                    break;
                case 2:
                    e.Value = ((AccountBalance)GetCurrentRow()).Debit2nd;
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
                    e.Value = ((AccountBalance)GetCurrentRow()).Credit;
                    break;
                case 1:
                    e.Value = ((AccountBalance)GetCurrentRow()).Credit1st;
                    break;
                case 2:
                    e.Value = ((AccountBalance)GetCurrentRow()).Credit2nd;
                    break;
                default:
                    break;
            }
        }

        private void lblBalance_EvaluateBinding(object sender, BindingEventArgs e)
        {
            var rec = (AccountBalance)GetCurrentRow();
            switch (currency)
            {
                case 0:
                    e.Value = rec.Debit-rec.Credit;
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
    }
}
