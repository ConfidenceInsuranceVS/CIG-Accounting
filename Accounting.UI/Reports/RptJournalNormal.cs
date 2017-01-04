using System;
using System.Collections.Generic;
using DevExpress.XtraReports.UI;
using System.Linq;

namespace Accounting.Reports
{
    public partial class RptJournalNormal : Accounting.iReport
    {
        public RptJournalNormal()
        {
            InitializeComponent();
        }
        private void xrLabel2_EvaluateBinding(object sender, BindingEventArgs e)
        {
            var rec = (Accounting.JournalNormal)GetCurrentRow();
            string posted = string.Empty;
            if (rec.Isposted != null)
                posted = (bool)rec.Isposted ? "Y" : string.Empty;
            e.Value = string.Format("{0}{1}{2}", rec.Type, rec.reference.ToString().PadLeft(6, '0'), posted);
        }
        private void xrLabel23_EvaluateBinding(object sender, BindingEventArgs e)
        {
            var rec = (Accounting.JournalNormal)GetCurrentRow();
            e.Value = string.Format("{0} {1}", rec.account, rec.AccountDescription);
        }

        private void xrLabel30_EvaluateBinding(object sender, BindingEventArgs e)
        {
            e.Value = string.Format("No. Of Vouchers : {0}", RowCount);
        }
    }
}
