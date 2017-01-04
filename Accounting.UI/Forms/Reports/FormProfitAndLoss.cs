using efControls;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Accounting
{
    public partial class FormProfitAndLoss : FormReportBase
    {
        public FormProfitAndLoss()
        {
            InitializeComponent();

            spnLevel.Properties.MinValue = 1;
            spnLevel.Properties.MaxValue = App.AccLength;
            spnFromMonth.Properties.MinValue = spnToMonth.Properties.MinValue = 1;
            spnFromMonth.Properties.MaxValue = spnToMonth.Properties.MaxValue = 12;

            spnLevel.EditValue = App.AccLength;
            spnToMonth.EditValue = 12;

            colSC.Visible = App.HasSubCompanies;
            colDescription.Width = App.HasSubCompanies == false ? colDescription.Width + colSC.Width : colDescription.Width;
        }
        protected override void proceed()
        {
            var level = int.Parse(spnLevel.Text);
            var fmonth = int.Parse(spnFromMonth.Text);
            var tmonth = int.Parse(spnToMonth.Text);
            var ctype = rgCurrencyType.SelectedIndex;
            var bclose = chkBeforeClosing.Checked ? 1 : 0;
            using (AccountingEntities ae = new AccountingEntities(App.MainConnectionString))
            {
                bsResult.DataSource = ae.ProfitAndLoss
                    (
                        App.WorkingYear,
                        level,
                        fmonth,
                        tmonth,
                        ctype,
                        bclose
                    );
            }
        }
        protected override void print(bool toPrint)
        {
            proceed();
            string filter = string.IsNullOrEmpty(gvResult.ActiveFilterString) ? string.Empty : string.Format("Filter : {0}", gvResult.ActiveFilterString);
            using (var rep = new Reports.RptProfitAndLoss())
            {
                rep.bsReport.DataSource = bsResult.DataSource;
                rep.lblCompany.Text = App.CompanyName;
                rep.lblTitle.Text = Text.TrimEnd();
                rep.lblCriteria.Text = filter;

                Report.show<Reports.RptProfitAndLoss>(MdiParent as efMainForm, rep, toPrint);
            }
        }

    }
}
