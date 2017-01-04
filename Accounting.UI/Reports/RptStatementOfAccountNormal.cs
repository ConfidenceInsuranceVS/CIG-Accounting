using System;
using System.Collections.Generic;
using DevExpress.XtraReports.UI;

namespace Accounting.Reports
{
    public partial class RptStatementOfAccountNormal : iReport
    {
        public RptStatementOfAccountNormal()
        {
            InitializeComponent();
        }

        private void xrLabel2_EvaluateBinding(object sender, BindingEventArgs e)
        {
            var rec = ((StatementOfAccount)GetCurrentRow());
            e.Value = string.Format("{0}{1}", rec.Type, rec.Reference.ToString().PadLeft(8));
        }
        private void xrLabel13_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrLabel13.Text = lblCriteria.Text;
        }

        private void gfAccount_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var rec = ((StatementOfAccount)GetCurrentRow());
            if (rec.Balance < 0)
            {
                lblResult.Text = "Creditor Balance";
                lblBalanceDebit.Visible = true;
                lblBalanceCredit.Visible = false;
            }
            else if (rec.Balance > 0)
            {
                lblResult.Text = "Debtor Balance";
                lblBalanceDebit.Visible = false;
                lblBalanceCredit.Visible = true;
            }
            else if (rec.Balance == 0)
            {
                lblResult.Visible = lblBalanceDebit.Visible = lblBalanceCredit.Visible = false;
            }
        }

        private void ReportHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            e.Cancel = true;
        }

        private void xrLabel18_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrLabel18.Text = lblCompany.Text;
            xrLabel17.Text = lblTitle.Text;
        }

        private void xrLabel19_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrLabel19.Text = lblInfo.Text;
        }
    }
}
