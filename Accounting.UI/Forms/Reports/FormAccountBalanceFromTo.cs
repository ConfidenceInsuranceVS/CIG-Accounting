using System;
using System.Linq;
using System.Collections.Generic;
using Accounting.Reports;
using efControls;
using System.Text;
using static Accounting.AccountingServices;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using System.Globalization;

namespace Accounting
{
    public partial class FormAccountBalanceFromTo : FormReportBase
    {
        int? currencyid;
        DateTime? fDate, tDate;
        string fAccount, tAccount;
        bool skipZeros;
        List<AccountBalance> lResult;

    
        public FormAccountBalanceFromTo()
        {
            InitializeComponent();

            cboAccountFrom.Leave += cboAccountFrom_Leave;
            //deFrom.Properties.MinValue = deTo.Properties.MinValue = new DateTime(App.WorkingYear, 1, 1); // stopped by Samir ref UE-12/12/2016-2
            //deFrom.Properties.MaxValue = deTo.Properties.MaxValue = new DateTime(App.WorkingYear, 12, 31);//stopped by Samir ref UE-12/12/2016-2
            //deFrom.EditValue = new DateTime(App.WorkingYear, 1, 1);//stopped by Samir ref UE-12/12/2016-2
            var dLast = new DateTime(App.WorkingYear, 12, 31);
            //if (DateTime.Now.Date > dLast)  //stopped by Samir ref UE-12/12/2016-2
            //    deTo.EditValue = new DateTime(App.WorkingYear, 12, 31); //stopped by Samir ref UE-12/12/2016-2
            //else
            //    deTo.EditValue = DateTime.Now.Date;//stopped by Samir ref UE-12/12/2016-2
            gvResult.OptionsBehavior.Editable = false;
            bsAccounts.DataSource = getAccounts(null, null);

            colSC.Visible = App.HasSubCompanies;
            colDescription.Width = App.HasSubCompanies == false ? colDescription.Width + colSC.Width : colDescription.Width;
        }

        private void cboAccountFrom_Leave(object sender, EventArgs e)
        {
            //using (AccountingEntities ae = new AccountingEntities(App.MainConnectionString))
            //{
            //    var rec = ae.Chartofaccounts.FirstOrDefault(c => c.ID == cboAccountFrom.id);
            //    if (rec != null) { cboCurrencies.EditValue = rec.Currencyid; }
            //}
            //if (string.IsNullOrEmpty(cboAccountTo.Code)) { cboAccountTo.EditValue = cboAccountFrom.EditValue; }
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            deFrom.Focus();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //proceed();
            chkSkipZeros.Checked = true;
            rgType.EditValue = 0;
        }
        protected override void proceed()
        {
            fAccount = string.IsNullOrEmpty(cboAccountFrom.Code) ? string.Empty : cboAccountFrom.Code;
            if (string.IsNullOrEmpty(fAccount)) { return; }
            tAccount = string.IsNullOrEmpty(cboAccountTo.Code) ? string.Empty : cboAccountTo.Code;

            if (deFrom.EditValue != null)
                fDate = (DateTime)deFrom.EditValue;

            if (deTo.EditValue != null)
                tDate = (DateTime)deTo.EditValue;

            currencyid = (int?)cboCurrencies.EditValue ?? 0;
            skipZeros = chkSkipZeros.Checked;

            using (AccountingEntities ae = new AccountingEntities(App.MainConnectionString))
            {
                lResult = ae.AccountBalance(App.WorkingYear, fAccount, tAccount, fDate, tDate, currencyid, skipZeros).ToList();
                setFilter();
            }
            showSummary();
        }
        private void showSummary()
        {
            try
            {
                var totals = lResult.ToList();
                bsTotals.DataSource = totals.GroupBy(l => l.Currency)
                        .Select(cl => new AccountBalance
                        {
                            Currency = rgType.SelectedIndex == 0 ? cl.Key : string.Empty,
                            Account = "",
                            Description = "",
                            Debit = cl.Sum(c => c.Debit),
                            Credit = cl.Sum(c => c.Credit),
                            Debit1st = cl.Sum(c => c.Debit1st),
                            Credit1st = cl.Sum(c => c.Credit1st),
                            Debit2nd = cl.Sum(c => c.Debit2nd),
                            Credit2nd = cl.Sum(c => c.Credit2nd),
                        }).ToList();

            }
            catch (Exception)
            {
            }
        }
        private void lcgCriteria_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if (e.Button.Properties.Tag.ToString() == "CF")
            {
                deFrom.EditValue = new DateTime(App.WorkingYear, 1, 1);
                deTo.EditValue = DateTime.Now.Date;
                cboCurrencies.EditValue = null;
                cboAccountFrom.clear();
                cboAccountTo.clear();
                bsResult.Clear();
                bsTotals.Clear();
            }
        }
        protected override void print(bool toPrint)
        {
            var bsReport = new List<AccountBalance>();
            for (int i = 0; i < gvResult.DataRowCount; i++)
            {
                var row = (AccountBalance)bsResult[gvResult.GetDataSourceRowIndex(i)];
                bsReport.Add(row);
            }
            //
            if (bsReport.Count == 0) { return; }
            if (string.IsNullOrEmpty(fAccount)) { return; }

            using (var rep = new RptAccountBalancesCurrency())
            {
                rep.currency = rgType.SelectedIndex;
                rep.bsReport.DataSource = bsReport;
                rep.lblCompany.Text = App.CompanyName;
                rep.lblTitle.Text = Text.TrimEnd();
                rep.lblCriteria.Text = getCriteria();

                Report.show<RptAccountBalancesCurrency>(MdiParent as efMainForm, rep, toPrint);
            }
        }
        private string getCriteria()
        {
            string filter = string.IsNullOrEmpty(gvResult.ActiveFilterString) ? string.Empty : string.Format("Filter : {0}", gvResult.ActiveFilterString, Environment.NewLine);
            StringBuilder sb = new StringBuilder();
            if (fDate != null)
                sb.AppendFormat("  From Date : {0} To Date : {1}  ", ((DateTime)fDate).ToShortDateString(), ((DateTime)tDate).ToShortDateString());
            if (!string.IsNullOrEmpty(fAccount))
                sb.AppendFormat("  From Account : {0} To Account : {1}  ", fAccount, tAccount);

            if (currencyid != 0)
            {
                using (AccountingEntities ae = new AccountingEntities(App.MainConnectionString))
                {
                    sb.AppendFormat("  Currency : {0}  ", ae.Currencies.FirstOrDefault(c => c.ID == currencyid).Code);
                }
            }
            if (skipZeros) { sb.Append("  Skip Over Zeros"); }

            if (!string.IsNullOrEmpty(filter))
            {
                sb.AppendLine();
                sb.AppendLine(filter);
            }
            return sb.ToString();
        }
        private void rgType_EditValueChanged(object sender, EventArgs e)
        {
            setFilter();
            showSummary();
        }

        private void gvResult_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            if (e.RowHandle < 1) { return; }

            efGridView gv = sender as efGridView;
            if (e.RowHandle != efGridControl.AutoFilterRowHandle)
            {
                var rec = (AccountBalance)gv.GetRow(e.RowHandle);
                using (AccountingEntities ae = new AccountingEntities(App.MainConnectionString))
                {
                    var cid = ae.Chartofaccounts.FirstOrDefault(c => c.Code == rec.Account).Currencyid;
                    if (cid != rec.Currencyid)
                        e.Appearance.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        private void chkSkipZeros_EditValueChanged(object sender, EventArgs e)
        {
            setFilter();
        }
        private void setFilter()
        {
            if (lResult == null) { return; }
            var eRec = lResult;

            #region Skip over zeros
            if (chkSkipZeros.Checked)
            {
                eRec = eRec
                    .Where(c => c.Debit + c.Credit != 0)
                    .Where(c => c.Debit1st + c.Credit1st != 0)
                    .Where(c => c.Debit2nd + c.Credit2nd != 0)
                    .ToList();
            }
            #endregion

            #region Currencies
            switch (rgType.SelectedIndex)
            {
                case 0:
                    colCurrency.Visible = coltCurrency.Visible = true;
                    colDebit.Visible = colCredit.Visible = true;
                    colDebit.VisibleIndex = 4;
                    colCredit.VisibleIndex = 5;

                    colDebit1st.Visible = colCredit1st.Visible = false;
                    colDebit2nd.Visible = colCredit2nd.Visible = false;

                    coltDebit.Visible = coltCredit.Visible = true;
                    coltDebit.VisibleIndex = 4;
                    coltCredit.VisibleIndex = 5;

                    coltDebit1st.Visible = coltCredit1st.Visible = false;
                    coltDebit2nd.Visible = coltCredit2nd.Visible = false;
                    break;

                case 1:
                    colCurrency.Visible = coltCurrency.Visible = false;
                    colDebit1st.Visible = colCredit1st.Visible = true;
                    colDebit1st.VisibleIndex = 4;
                    colCredit1st.VisibleIndex = 5;

                    colDebit.Visible = colCredit.Visible = false;
                    colDebit2nd.Visible = colCredit2nd.Visible = false;

                    coltDebit1st.Visible = coltCredit1st.Visible = true;
                    coltDebit1st.VisibleIndex = 4;
                    coltCredit1st.VisibleIndex = 5;

                    coltDebit.Visible = coltCredit.Visible = false;
                    coltDebit2nd.Visible = coltCredit2nd.Visible = false;
                    break;

                case 2:
                    colCurrency.Visible = coltCurrency.Visible = false;
                    colDebit2nd.Visible = colCredit2nd.Visible = true;
                    colDebit2nd.VisibleIndex = 4;
                    colCredit2nd.VisibleIndex = 5;

                    colDebit.Visible = colCredit.Visible = false;
                    colDebit1st.Visible = colCredit1st.Visible = false;

                    coltDebit2nd.Visible = coltCredit2nd.Visible = true;
                    coltDebit2nd.VisibleIndex = 4;
                    coltCredit2nd.VisibleIndex = 5;

                    coltDebit.Visible = coltCredit.Visible = false;
                    coltDebit1st.Visible = coltCredit1st.Visible = false;
                    break;

                //case 3:
                //    colDebit.Visible = colCredit.Visible = true;
                //    colDebit1st.Visible = colCredit1st.Visible = true;
                //    colDebit2nd.Visible = colCredit2nd.Visible = true;
                //    colDebit.VisibleIndex = 3;
                //    colCredit.VisibleIndex = 4;

                //    colDebit1st.VisibleIndex = 5;
                //    colCredit1st.VisibleIndex = 6;

                //    colDebit2nd.VisibleIndex = 7;
                //    colCredit2nd.VisibleIndex = 8;

                //    coltDebit.Visible = coltCredit.Visible = true;
                //    coltDebit1st.Visible = coltCredit1st.Visible = true;
                //    coltDebit2nd.Visible = coltCredit2nd.Visible = true;
                //    coltDebit.VisibleIndex = 3;
                //    coltCredit.VisibleIndex = 4;

                //    coltDebit1st.VisibleIndex = 5;
                //    coltCredit1st.VisibleIndex = 6;

                //    coltDebit2nd.VisibleIndex = 7;
                //    coltCredit2nd.VisibleIndex = 8;
                //    break;

                default:
                    break;
            }
            #endregion

            bsResult.DataSource = eRec;
        }
        //private void gvResult_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)// added by samir 5/12/2016  UE-6/12/2016-1
        //{

        //    var rec = (AccountBalance)bsResult.Current;
        //    if (e.Clicks == 2)

        //    {
        //        fromAccount = cboAccountFrom.Code;
        //        toAccount = cboAccountTo.Code;
        //        from = (DateTime?)deFrom.EditValue;
        //        to = (DateTime?)deTo.EditValue;
        //        currencyID = (int?)cboCurrencies.EditValue;

        //        Form form = new FormStatementOfAccount(cboAccountFrom.Code, cboAccountTo.Code, from, to, currencyID);

        //        form.MdiParent = (FormMain)this.MdiParent;
        //        form.StartPosition = FormStartPosition.CenterScreen;
        //        form.Show();
        //    }

        //}
        private void gvResult_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)  // modified by Samir UE-6/12/2016-1
        {
            var rec = (AccountBalance)bsResult.Current;
            if (e.Clicks == 2)
            {
                Form form = new FormStatementOfAccount((int)rec.Accountid, (int)rec.Accountid, (DateTime?)deFrom.EditValue, (DateTime?)deTo.EditValue, rec.Currencyid)
                {
                    MdiParent = (FormMain)this.MdiParent,
                    StartPosition = FormStartPosition.CenterScreen
                };
                form.Show();
            }
        }

    }
}
