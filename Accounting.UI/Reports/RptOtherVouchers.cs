using DevExpress.XtraReports.UI;
using efControls;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Accounting.Reports
{
    public partial class RptOtherVouchers : Accounting.iReport
    {
        public RptOtherVouchers()
        {
            InitializeComponent();
        }

        private void efReportLabel3_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var rec = (OtherVouchers)GetCurrentRow();
            //var name = string.IsNullOrEmpty(rec.Journalparent.Fromto) ? rec.Chartofaccount.Description.TrimEnd() : rec.Journalparent.Fromto.TrimEnd(); BU 03/01/2017-1
            //efReportLabel3.Text = string.Format("{0} / {1}", name, rec.Chartofaccount.Code.TrimEnd());
            efReportLabel3.Text = rec.fromTo;
        }

        private void efReportLabel4_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var rec = (OtherVouchers)GetCurrentRow();
            // efReportLabel4.Text = NumberToWords.getExpression(rec.Amount.ToString(), DataFormServices.getCurrencyName(rec.Currency.Code));
            efReportLabel4.Text = (rec.amount.ToString());//rec.getExpression(rec.amount.ToString(), DataFormServices.getCurrencyName(rec.cur));
        }

        private void xrLabel1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var rec = (OtherVouchers)GetCurrentRow();
            // xrLabel1.Text = string.Format("{1} {0}", decimal.Parse(rec.Amount.ToString()).ToString("#,###.00").PadLeft(15, '*'), rec.Currency.Code);
            xrLabel1.Text= string.Format("{1} {0}", decimal.Parse(rec.amount.ToString()).ToString("#,###.00").PadLeft(15, '*'), rec.cur);
        }

        private void efReportLabel8_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var rec = (OtherVouchers)GetCurrentRow();
            //if (string.IsNullOrEmpty(rec.Journalparent.Details))
            //    e.Cancel = true;
        }

        private void efReportLabel7_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var rec = (OtherVouchers)GetCurrentRow();
            //if (string.IsNullOrEmpty(rec.Journalparent.Details))
            //    e.Cancel = true;
        }
    }
}
