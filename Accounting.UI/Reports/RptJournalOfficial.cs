using System;
using System.Collections.Generic;
using DevExpress.XtraReports.UI;
using System.Linq;
using System.Globalization;

namespace Accounting.Reports
{
    public partial class RptJournalOfficial : Accounting.iReport
    {
        public RptJournalOfficial()
        {
            InitializeComponent();
        }
        private void xrLabel2_EvaluateBinding(object sender, BindingEventArgs e)
        {
            var rec = (Accounting.JournalOfficial)GetCurrentRow();
            try
            {
                e.Value = string.Format("{0}{1}", rec.type, rec.reference.ToString().PadLeft(6));
            }
            catch (Exception)
            {
                e.Value = string.Empty;
            }
        }
        private void xrLabel23_EvaluateBinding(object sender, BindingEventArgs e)
        {
            var rec = (Accounting.JournalOfficial)GetCurrentRow();
            try
            {
                e.Value = string.Format("{0} {1}", rec.Account, rec.AccountDescription);
            }
            catch (Exception)
            {
                e.Value = string.Empty;
            }
        }

        private void xrLabel19_EvaluateBinding(object sender, BindingEventArgs e)
        {
            var rec = (Accounting.JournalOfficial)GetCurrentRow();
            e.Value = string.Format("Month Of : {0}", CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(((DateTime)rec.jvdate).Month));
        }

        private void xrLabel20_EvaluateBinding(object sender, BindingEventArgs e)
        {
            var rec = (Accounting.JournalOfficial)GetCurrentRow();
            e.Value = string.Format("Total Month Of : {0}", CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(((DateTime)rec.jvdate).Month));
        }
    }
}
