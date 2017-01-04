using System;
using System.Collections.Generic;
using DevExpress.XtraReports.UI;

namespace Accounting.Reports
{
    public partial class RptTrialBalance : Accounting.iReport
    {
        public RptTrialBalance()
        {
            InitializeComponent();
        }

        private void xrLabel2_EvaluateBinding(object sender, BindingEventArgs e)
        {
            var rec = ((StatementOfAccount)GetCurrentRow());
            e.Value = string.Format("{0}{1}", rec.Type, rec.Reference.ToString().PadLeft(8));
        }

    }
}
