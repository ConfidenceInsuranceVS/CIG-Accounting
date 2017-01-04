using System;
using System.Collections.Generic;
using DevExpress.XtraReports.UI;

namespace Accounting.Reports
{
    public partial class RptTreasury : Accounting.iReport
    {
        public RptTreasury()
        {
            InitializeComponent();
        }

        private void xrLabel6_EvaluateBinding(object sender, BindingEventArgs e)
        {
            e.Value = string.Format("CURRENCY {0}", e.Value);
        }

        private void xrLabel17_EvaluateBinding(object sender, BindingEventArgs e)
        {
            e.Value = string.Format("Total {0}", e.Value);
        }
    }
}
