using efControls;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Accounting
{
    public partial class FormUncollectedCheques : FormReportBase
    {
        int? account;
        DateTime? to;
        public FormUncollectedCheques()
        {
            InitializeComponent();
            deFrom.EditValue = DateTime.Now;

            colSC.Visible = App.HasSubCompanies;
            colDescription1.Width = App.HasSubCompanies == false ? colDescription1.Width + colSC.Width : colDescription1.Width;
        }

        protected override void proceed()
        {
            account = cboAccounts.id;
            if (account == null)
            {
                Alert.Show("Enter Account Number", "ATTENTION !!!", Enums.AlertType.Warning);
                cboAccounts.Focus();
            }
            else
            {
                to = (DateTime?)deFrom.EditValue;
                using (AccountingEntities ae = new AccountingEntities(App.MainConnectionString))
                {
                    bsResult.DataSource = ae.UncollectedCheques(to, account);
                }
            }
        }
        protected override void print(bool toPrint)
        {
            proceed();
            //
            List<UncollectedCheques> bsReport = new List<UncollectedCheques>();
            for (int i = 0; i < gvResult.DataRowCount; i++)
            {
                var row = (UncollectedCheques)bsResult[gvResult.GetDataSourceRowIndex(i)];
                bsReport.Add(row);
            }
            //
            if (bsReport.Count == 0) { return; }
            //
            using (var rep = new Reports.RptUncollectedChequesReport())
            {
                rep.bsReport.DataSource = bsReport;
                rep.lblCompany.Text = App.CompanyName;
                rep.lblTitle.Text = Text.TrimEnd();
                rep._ToDate = (DateTime)to;
                rep.lblCriteria.Text = string.Format("Date : {0} - Account : {1} {2}", ((DateTime)to).Date.ToShortDateString(), cboAccounts.Code, cboAccounts.Description);

                Report.show<Reports.RptUncollectedChequesReport>(MdiParent as efMainForm, rep, toPrint);
            }
        }
        private string getCriteriaString()
        {
            string filter = string.IsNullOrEmpty(gvResult.ActiveFilterString) ? string.Empty : string.Format("Filter : {0}", gvResult.ActiveFilterString);
            return string.Format("Date : {0} - Account : {1} {2} {3} {4}", ((DateTime)to).Date.ToShortDateString(), cboAccounts.Code, cboAccounts.Description, Environment.NewLine, filter);
        }

    }
}
