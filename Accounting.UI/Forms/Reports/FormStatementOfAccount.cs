using Accounting.Reports;
using DevExpress.XtraGrid.Views.Grid;
using efControls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static Accounting.AccountingServices;

namespace Accounting
{
    public partial class FormStatementOfAccount : FormReportBase
    {
        private enum BalanceType
        {
            Currency,
            Local1st,
            Local2nd
        };
        int? currencyID;
        string fromAccount, toAccount;
        DateTime? from, to;
        List<StatementOfAccount> soa;

        //public FormStatementOfAccount() // stopped by samir  UE-6/12/2016-1
        //{
        //    InitializeComponent();

        //    cboAccountFrom.Leave += cboAccountFrom_Leave;
        //    deFrom.EditValue = new DateTime(App.WorkingYear, 1, 1);
        //    deTo.EditValue = getMaxDate(App.WorkingYear);
        //    gvResult.OptionsBehavior.Editable = false;
        //    bsAccounts.DataSource = getAccounts(null, null);
        //    deFrom.Focus();

        //    colSC.Visible = App.HasSubCompanies;
        //    coldescription1.Width = App.HasSubCompanies == false ? coldescription1.Width + colSC.Width : coldescription1.Width;
        //}

        //public FormStatementOfAccount(string AccountFrom ,string AccountTo, DateTime? FromDate, DateTime? ToDate,int? IdCurrency) //  added by Samir UE-6/12/2016-1
        //{           
        // InitializeComponent();


        //    deFrom.EditValue = FromDate;
        //    deTo.EditValue = ToDate;
        //    cboAccountFrom.Code = AccountFrom;
        //    cboAccountTo.Code = AccountTo;
        //    cboCurrencies.EditValue = (int?)IdCurrency;
        //    bsResult = new BindingSource();
        //    fromAccount = AccountFrom;
        //    toAccount = AccountTo;
        //    from = FromDate;
        //    to = ToDate;
        //    currencyID = IdCurrency;


        //    using (AccountingEntities ae = new AccountingEntities(App.MainConnectionString))
        //    {
        //        soa = ae.StatementOfAccount(fromAccount, toAccount, from, to, currencyID).ToList();
        //    }
        //    bsResult.DataSource = soa;
        //    calculateBalance();
        //}

        public FormStatementOfAccount() // added by Samir UE-6/12/2016-1
        {
            InitializeComponent();

            cboAccountFrom.Leave += cboAccountFrom_Leave;
            deFrom.EditValue = new DateTime(App.WorkingYear, 1, 1);
            deTo.EditValue = getMaxDate(App.WorkingYear);
            gvResult.OptionsBehavior.Editable = false;
            bsAccounts.DataSource = getAccounts(null, null);
            deFrom.Focus();

            colSC.Visible = App.HasSubCompanies;
            coldescription1.Width = App.HasSubCompanies == false ? coldescription1.Width + colSC.Width : coldescription1.Width;
        }

        public FormStatementOfAccount(int AccountFrom, int AccountTo, DateTime? FromDate, DateTime? ToDate, int? IdCurrency) : this() // added by Samir UE-6/12/2016-1
        {
            deFrom.EditValue = FromDate;
            deTo.EditValue = ToDate;
            cboAccountFrom.EditValue = AccountFrom;
            cboAccountTo.EditValue = AccountTo;
            cboCurrencies.EditValue = IdCurrency;
            Refresh();

            proceed();
        }



        private void cboAccountFrom_Leave(object sender, EventArgs e)
        {
            using (AccountingEntities ae = new AccountingEntities(App.MainConnectionString))
            {
                var rec = ae.Chartofaccounts.FirstOrDefault(c => c.ID == cboAccountFrom.id);
                if (rec != null) { cboCurrencies.EditValue = rec.Currencyid; }
            }
            //if (string.IsNullOrEmpty(ucAccountTo.Code))
            //{
                cboAccountTo.EditValue = cboAccountFrom.EditValue;
            //}
        }
        protected override void print(bool toPrint)
        {
            proceed();
            //
            List<StatementOfAccount> bsReport = new List<StatementOfAccount>();
            for (int i = 0; i < gvResult.DataRowCount; i++)
            {
                var row = (StatementOfAccount)bsResult[gvResult.GetDataSourceRowIndex(i)];
                bsReport.Add(row);
            }
            //
            if (bsReport.Count == 0) { return; }
            //
            switch (rgType.SelectedIndex)
            {
                case 0:
                    using (var rep = new RptStatementOfAccountNormal())
                    {
                        rep.bsReport.DataSource = bsReport;
                        rep.lblCompany.Text = App.CompanyName;
                        rep.lblTitle.Text = Text.TrimEnd();
                        rep.lblCriteria.Text = getCriteriaString();

                        Report.show<RptStatementOfAccountNormal>(MdiParent as efMainForm, rep, toPrint);
                    }
                    break;

                case 1:
                    using (var rep = new RptStatementOfAccountBalanced())
                    {
                        rep.bsReport.DataSource = bsReport;
                        rep.lblCompany.Text = App.CompanyName;
                        rep.lblTitle.Text = Text.TrimEnd();
                        rep.lblCriteria.Text = getCriteriaString();

                        Report.show<RptStatementOfAccountBalanced>(MdiParent as efMainForm, rep, toPrint);
                    }
                    break;

                case 2:
                    using (var rep = new RptStatementOfAccountGlLocal())
                    {
                        rep.bsReport.DataSource = bsReport;
                        rep.lblCompany.Text = App.CompanyName;
                        rep.lblTitle.Text = "General Ledger / Local 1st";
                        rep.lblCriteria.Text = getCriteriaString();

                        Report.show<RptStatementOfAccountGlLocal>(MdiParent as efMainForm, rep, toPrint);
                    }
                    break;

                case 3:
                    using (var rep = new RptStatementOfAccountGlForeign())
                    {
                        rep.bsReport.DataSource = bsReport;
                        rep.lblCompany.Text = App.CompanyName;
                        rep.lblTitle.Text = "General Ledger / Local 2nd";
                        rep.lblCriteria.Text = getCriteriaString();

                        Report.show<RptStatementOfAccountGlForeign>(MdiParent as efMainForm, rep, toPrint);
                    }
                    break;
            }
        }
        private string getCriteriaString()
        {
            string filter = string.IsNullOrEmpty(gvResult.ActiveFilterString) ? string.Empty : string.Format("Filter : {0}", gvResult.ActiveFilterString);
            return string.Format("From : {0} To : {1} {2}{3}", ((DateTime)from).ToShortDateString(), ((DateTime)to).ToShortDateString(), Environment.NewLine, filter);
        }
        protected override void proceed()
        {
            fromAccount = cboAccountFrom.Code;
            toAccount = cboAccountTo.Code;
            from = (DateTime?)deFrom.EditValue;
            to = (DateTime?)deTo.EditValue;
            currencyID = (int?)cboCurrencies.EditValue;
            using (AccountingEntities ae = new AccountingEntities(App.MainConnectionString))
            {
                soa = ae.StatementOfAccount(fromAccount, toAccount, from, to, currencyID).ToList();
            }
            bsResult.DataSource = soa;
            calculateBalance();
        }
        private void calculateBalance()
        {
            decimal? balance = 0, balance1st = 0, balance2nd = 0;
            string Account = string.Empty;
            string Currency = string.Empty;
          
            for (int i = 0; i < gvResult.DataRowCount; i++)
            {
                var row = (StatementOfAccount)bsResult[gvResult.GetDataSourceRowIndex(i)];
                if (Account != row.Account && Currency != row.Currency)
                    balance = balance1st = balance2nd = 0;

                Account = row.Account;
                Currency = row.Currency;
                //
                balance += row.Debit - row.Credit;
                balance1st += row.Debit1st - row.Credit1st;
                balance2nd += row.Debit2nd - row.Credit2nd;
                //
                row.Balance = balance;
                row.Balance1st = balance1st;
                row.Balance2nd = balance2nd;
            }
            gvResult.RefreshData();
        }
        private void gvResult_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Row == null) { return; }
            if (e.IsGetData)
            {
                var rec = (StatementOfAccount)e.Row;
                if (rec.ID != null)
                {
                    var doc = getfileName((int)rec.ID);
                    if (File.Exists(doc))
                        e.Value = formImages.Images[0];
                    else
                        e.Value = null;
                }
            }
        }

        private void rgType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gvResult_CustomSummaryExists(object sender, DevExpress.Data.CustomSummaryExistEventArgs e)
        {
            if (currencyID == null) { e.Exists = false; }
        }

        private void gvResult_ColumnFilterChanged(object sender, EventArgs e)
        {
            calculateBalance();
        }
        private void gvResult_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            var rec = (StatementOfAccount)bsResult.Current;
            if (e.Clicks == 2)
                CallTransactionForm.callTransactionForm((FormMain)this.MdiParent, ((DateTime)rec.JvDate).Year, rec.Type, (int)rec.ID);
            else
                if (e.Column == colScan) { showPDF((int)rec.ID); }
        }
    }
}
