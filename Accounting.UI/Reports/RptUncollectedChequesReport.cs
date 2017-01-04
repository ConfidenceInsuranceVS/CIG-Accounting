using System;
using System.Collections.Generic;

namespace Accounting.Reports
{
    public partial class RptUncollectedChequesReport : Accounting.iReport
    {
        private decimal? _Balance = 0, _Pending = 0;
        public DateTime _ToDate;
        private void lblBalance_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var rec = (UncollectedCheques)GetCurrentRow();
            _Balance += rec.Debit - rec.Credit;
            lblBalance.Text = _Balance.ToString();
        }

        private void xrLabel4_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var rec = (UncollectedCheques)GetCurrentRow();
            _Pending += rec.Maturity > DateTime.Now ? rec.Debit - rec.Credit : 0;
            xrLabel4.Text = _Pending.ToString();
        }
        private void xrPanelDetail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var rec = (UncollectedCheques)GetCurrentRow();
            if (rec.Debit != rec.Credit && rec.Maturity <= _ToDate)
                xrPanelDetail.BackColor = System.Drawing.Color.LightGray;
            else
                xrPanelDetail.BackColor = System.Drawing.Color.Transparent;
        }

        public RptUncollectedChequesReport()
        {
            InitializeComponent();
        }
    }
}
