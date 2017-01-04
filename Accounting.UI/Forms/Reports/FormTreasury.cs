using Accounting.Reports;
using efControls;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Accounting
{
    public partial class FormTreasury : FormReportBase
    {
        DateTime? date;
        public FormTreasury()
        {
            InitializeComponent();
            deFrom.Properties.MinValue = new DateTime(App.WorkingYear, 1, 1);
            deFrom.Properties.MaxValue = new DateTime(App.WorkingYear, 12, 31);
            deFrom.EditValue = DateTime.Now.Date;

            colSC.Visible = App.HasSubCompanies;
            colDescription1.Width = App.HasSubCompanies == false ? colDescription1.Width + colSC.Width : colDescription1.Width;
        }
        protected override void proceed()
        {
            date = (DateTime?)deFrom.EditValue;
            using (AccountingEntities ae = new AccountingEntities(App.MainConnectionString))
            {
                bsResult.DataSource = ae.Treasury(date);
            }
        }
        protected override void print(bool toPrint)
        {
            proceed();
            //
            List<Treasury> bsReport = new List<Treasury>();
            for (int i = 0; i < gvResult.DataRowCount; i++)
            {
                var row = (Treasury)bsResult[gvResult.GetDataSourceRowIndex(i)];
                bsReport.Add(row);
            }
            //
            if (bsReport.Count == 0) { return; }
            //
            using (var rep = new RptTreasury())
            {
                rep.bsReport.DataSource = bsReport;
                rep.lblCompany.Text = App.CompanyName;
                rep.lblTitle.Text = Text.TrimEnd();
                rep.lblCriteria.Text = ((DateTime)date).ToLongDateString();

                Report.show<RptTreasury>(MdiParent as efMainForm, rep, toPrint);
            }
        }
    }
}
