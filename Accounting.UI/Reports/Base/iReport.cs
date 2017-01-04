using System;
using DevExpress.XtraReports.UI;

namespace Accounting
{
    public partial class iReport : XtraReport
    {
        public string reportName;

        public iReport()
        {
            InitializeComponent();
            lblCompany.Text = App.CompanyName;
            lblInfo.Text = string.Format("Printed On {0} By {1}", DateTime.Now, efControls.App.UserName);
        }

        private void lblInfo_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            e.Cancel = !App.PrintSubtitle;
        }
    }
}
