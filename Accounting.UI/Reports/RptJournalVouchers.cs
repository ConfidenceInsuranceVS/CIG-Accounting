using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Accounting.Reports
{
    public partial class RptJournalVouchers : Accounting.iReport
    {
        public RptJournalVouchers()
        {
            InitializeComponent();
        }

        private void getFormat(object sender, decimal? amount)
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
        private void xrLabel2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) //added by samir 03/01/2017  BU 03/01/2017-1
        {
            var rec = (JournalVouchers)GetCurrentRow();           
            xrLabel2.Text = rec.AccountDescription;
        }
        private void xrLabel24_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            using (AccountingEntities ae = new AccountingEntities(App.MainConnectionString))
            {
                xrLabel24.Text = ae.Currencies.FirstOrDefault(c => c.ID == App.ForeignCurreny).Code;
            }
        }
        private void xrLabel20_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) //added by samir  BU 03/01/2017-1
        {
            var rec = (JournalVouchers)GetCurrentRow();
            var date = (DateTime)rec.jvdate;
            xrLabel20.Text = date.ToString("dd/MM/yyyy");
        }

        private void xrLabel21_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) //added by samir  BU 03/01/2017-1
        {
            var rec = (JournalVouchers)GetCurrentRow();
            if (rec.Ratecurrency == null)
                xrLabel21.Text = "0.00";
            else if (rec.Ratecurrency.ToString().Length <= 12)
                xrLabel21.Text = decimal.Parse(rec.Ratecurrency.ToString()).ToString("#,###.00");
            else
                xrLabel21.Text = decimal.Parse(rec.Ratecurrency.ToString()).ToString("#.00");
        }
        private void xrLabel1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) //added by samir  BU 03/01/2017-1
        {
            var rec = (JournalVouchers)GetCurrentRow();
            xrLabel1.Text = rec.Account;
        }
        private void xrLabel5_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) //added by samir  BU 03/01/2017-1
        {
            var rec = (JournalVouchers)GetCurrentRow();
            xrLabel5.Text = rec.Dc;
           
        }
        private void xrLabel3_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) //added by samir BU 03/01/2017-1
        {
            var rec = (JournalVouchers)GetCurrentRow();            
            xrLabel3.Text = rec.Currency;
          
        }
        private void lblAmtdLL_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var rec = (JournalVouchers)GetCurrentRow();
            getFormat(sender, rec.Amount1st);
            e.Cancel = rec.Dc == "C";
        }
        private void lblAmtcLL_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var rec = (JournalVouchers)GetCurrentRow();
            getFormat(sender, rec.Amount1st);
            e.Cancel = rec.Dc == "D";
        }
        private void lblAmtdUSD_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var rec = (JournalVouchers)GetCurrentRow();
            getFormat(sender, rec.Amount2nd);
            e.Cancel = rec.Dc == "C";
        }
        private void lblAmtcUSD_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var rec = (JournalVouchers)GetCurrentRow();
            getFormat(sender, rec.Amount2nd);
            e.Cancel = rec.Dc == "D";
        }
        private void xrLabel4_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var rec = (JournalVouchers)GetCurrentRow();
            getFormat(sender, rec.Amount);
        }

        private void xrLabel9_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var val = bsReport.List.OfType<JournalVouchers>().Where(c => c.Dc == "D").Sum(c => c.Amount1st);
            getFormat(sender, val);
        }
        private void xrLabel10_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var val = bsReport.List.OfType<JournalVouchers>().Where(c => c.Dc == "C").Sum(c => c.Amount1st);
            getFormat(sender, val);
        }
        private void xrLabel11_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var val = bsReport.List.OfType<JournalVouchers>().Where(c => c.Dc == "D").Sum(c => c.Amount2nd);
            getFormat(sender, val);
        }
        private void xrLabel12_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var val = bsReport.List.OfType<JournalVouchers>().Where(c => c.Dc == "C").Sum(c => c.Amount2nd);
            getFormat(sender, val);
        }
    }
}
