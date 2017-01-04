using System;
using System.Collections.Generic;
using DevExpress.XtraReports.UI;

namespace Accounting.Reports
{
    public partial class RptPostDatedChequesDetailed : Accounting.iReport
    {
        public RptPostDatedChequesDetailed()
        {
            InitializeComponent();
        }

        private void xrLabel2_EvaluateBinding(object sender, BindingEventArgs e)
        {
            var rec = ((PostDatedDetailedResult)GetCurrentRow());
            e.Value = string.Format("{0}{1}", rec.DBType, rec.DBReference.ToString().PadLeft(8));
        }
        private void xrPanel_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var rec = ((PostDatedDetailedResult)GetCurrentRow());
            if (((DateTime)rec.Maturity).Date < DateTime.Now.Date)
                xrPanel.BackColor = xrPanel1.BackColor = System.Drawing.Color.LightGray;
            else
                xrPanel.BackColor = xrPanel1.BackColor = System.Drawing.Color.Transparent;
        }

        private void xrLabel12_EvaluateBinding(object sender, BindingEventArgs e)
        {
            var rec = ((PostDatedDetailedResult)GetCurrentRow());
            //    e.Value = rec.Document.Substring(0, rec.Document.IndexOf(' ')); modified by  samir 8/12/2016 BU 8/12/2016-1
            e.Value = ((PostDatedDetailedResult)GetCurrentRow()).Document;
        }

        private void xrLabel16_EvaluateBinding(object sender, BindingEventArgs e)
        {
            var rec = ((PostDatedDetailedResult)GetCurrentRow());
            //e.Value = rec.Document.Substring(rec.Document.IndexOf(' ')).Trim(); modified by  samir 8/12/2016 BU 8/12/2016-1
            e.Value = ((PostDatedDetailedResult)GetCurrentRow()).Document;
        }

        private void SubBand1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var rec = ((PostDatedDetailedResult)GetCurrentRow());
            var len = rec.Document.TrimEnd().Length;
            if (len <= 7) { e.Cancel = true; }
        }

        private void xrPanel1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
        }

        private void xrLabel17_EvaluateBinding(object sender, BindingEventArgs e)
        {
            var rec = ((PostDatedDetailedResult)GetCurrentRow());
            e.Value = string.Format("{0}{1}", rec.CRType, rec.CRReference.ToString().PadLeft(8));
        }
    }
}
