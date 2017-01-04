using System;
using System.Linq;
using System.Collections.Generic;
using efControls;
using System.Text;
using Accounting.Reports;

namespace Accounting
{
    public partial class FormTrialBalanceFT : FormReportBase
    {
        int? currencyid, level, colWidth;
        bool beforeClosing;
        DateTime? fDate, tDate;
        List<TrialBalance> lResult;
        public FormTrialBalanceFT()
        {
            InitializeComponent();

            //deFrom.Properties.MinValue = deTo.Properties.MinValue = new DateTime(App.WorkingYear, 1, 1);
            //deFrom.Properties.MaxValue = deTo.Properties.MaxValue = new DateTime(App.WorkingYear, 12, 31); // stopped by Samir BU 6/12/2016-1
            using (AccountingEntities ae = new AccountingEntities(App.MainConnectionString))
            {
                var ca = ae.Chartofaccounts.Where(c => c.Code.Length == 1).Select(c=> new { c.Code }).ToList();
                spnFromClass.Properties.MinValue = spnToClass.Properties.MinValue = ca.Min(c => decimal.Parse(c.Code));
                spnFromClass.Properties.MaxValue = spnToClass.Properties.MaxValue = ca.Max(c => decimal.Parse(c.Code));
                spnLevel.Properties.MinValue = ae.Chartofaccounts.Min(c => c.Code.Length);
                spnLevel.Properties.MaxValue = ae.Chartofaccounts.Max(c => c.Code.Length);
            }


            // deFrom.EditValue = new DateTime(App.WorkingYear, 1, 1);  by Samir BU 6/12/2016-1
            deFrom.EditValue = new DateTime(DateTime.Now.Year,DateTime.Now.Month, 1);
            deTo.EditValue = DateTime.Now.Date;
            spnLevel.EditValue = null;

            gvResult.OptionsBehavior.Editable = false;
            gvResult.OptionsBehavior.ReadOnly = true;

            colSC.Visible = App.HasSubCompanies;
            colDescription.Width = App.HasSubCompanies == false ? colDescription.Width + colSC.Width : colDescription.Width;
            colWidth = colDescription.Width;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            spnFromClass.EditValue = spnFromClass.Properties.MinValue;
            spnToClass.EditValue = spnFromClass.Properties.MaxValue;
            spnLevel.EditValue = spnLevel.Properties.MaxValue;
            rgType.EditValue = 1;
            chkSkipOverZeros.Checked = true;
            //proceed();
        }
        protected override void proceed()
        {
            if (deFrom.EditValue != null)
                fDate = (DateTime)deFrom.EditValue;

            if (deTo.EditValue != null)
                tDate = (DateTime)deTo.EditValue;


            currencyid = (int?)cboCurrencies.EditValue ?? 0;
            beforeClosing = chkBeforeClosing.Checked;
            level = Convert.ToInt32(spnLevel.EditValue);
            using (AccountingEntities ae = new AccountingEntities(App.MainConnectionString))
            {
                lResult = ae.TrialBalance(fDate, tDate, currencyid, beforeClosing, level).ToList();
                setFilter();
            }
        }
        private void lcgCriteria_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if (e.Button.Properties.Tag.ToString() == "CF")
            {
                deFrom.EditValue = deTo.EditValue = cboCurrencies.EditValue = spnLevel.EditValue = null;
                proceed();
            }
        }
        protected override void print(bool toPrint)
        {
            proceed();
            //
            List<TrialBalance> bsReport = new List<TrialBalance>();
            for (int i = 0; i < gvResult.DataRowCount; i++)
            {
                var row = (TrialBalance)bsResult[gvResult.GetDataSourceRowIndex(i)];
                bsReport.Add(row);
            }
            //
            if (bsReport.Count == 0) { return; }
            //
            if (rgType.SelectedIndex == 3)
                using (var rep = new RptTrialBalance())
                {
                    rep.bsReport.DataSource = bsReport;
                    rep.lblCompany.Text = App.CompanyName;
                    rep.lblTitle.Text = Text.TrimEnd();
                    rep.lblCriteria.Text = getCriteria();

                    Report.show<RptTrialBalance>(MdiParent as efMainForm, rep, toPrint);
                }
            else
                using (var rep = new RptTrialBalanceCurrency())
                {
                    rep.currency = rgType.SelectedIndex;
                    rep.bsReport.DataSource = bsReport;
                    rep.lblCompany.Text = App.CompanyName;
                    rep.lblTitle.Text = Text.TrimEnd();
                    rep.lblCriteria.Text = getCriteria();

                    Report.show<RptTrialBalanceCurrency>(MdiParent as efMainForm, rep, toPrint);
                }
        }
        private string getCriteria()
        {
            StringBuilder sb = new StringBuilder();
            if (fDate != null)
                sb.AppendFormat("  From Date : {0} To Date : {1}  ", ((DateTime)fDate).ToShortDateString(), ((DateTime)tDate).ToShortDateString());
            
            if (currencyid != 0)
            {
                using (AccountingEntities ae = new AccountingEntities(App.MainConnectionString))
                {
                    sb.AppendFormat("  Currency : {0}  ", ae.Currencies.FirstOrDefault(c => c.ID == currencyid).Code);
                }
            }

            string filter = string.IsNullOrEmpty(gvResult.ActiveFilterString) ? string.Empty : string.Format("Filter : {0}", gvResult.ActiveFilterString);
            if (!string.IsNullOrEmpty(filter))
                sb.AppendFormat("{0}{1}", Environment.NewLine, filter);

            return sb.ToString();
        }
        private void rgType_EditValueChanged(object sender, EventArgs e)
        {
            setFilter();
        }
        private void chkSkipBalanceZero_EditValueChanged(object sender, EventArgs e)
        {
            setFilter();
        }

        private void spnFromClass_EditValueChanged(object sender, EventArgs e)
        {
            if ((decimal)spnToClass.EditValue < (decimal)spnFromClass.EditValue) { return; }
            setFilter();
        }

        private void spnToClass_EditValueChanged(object sender, EventArgs e)
        {
            if ((decimal)spnToClass.EditValue < (decimal)spnFromClass.EditValue) { return; }
            setFilter();
        }

        private void setFilter()
        {
            if (lResult == null) { return; }
            var eRec = lResult;

            var fromClass = spnFromClass.EditValue.ToString();
            var toClass = spnToClass.EditValue.ToString();
            eRec = eRec.Where(c => int.Parse(c.Account.Substring(0,1)) >= int.Parse(fromClass) & int.Parse(c.Account.Substring(0, 1)) <= int.Parse(toClass)).ToList();

            if (chkSkipOverZeros.Checked)
                switch (rgType.SelectedIndex)
                {
                    //case 0:
                    //    eRec = eRec.Where(c => c.Debit1st + c.Credit1st != 0).ToList();
                    //    break;

                    case 0:
                        eRec = eRec.Where(c => c.Debit2nd + c.Credit2nd != 0).ToList();
                        break;

                    case 1:
                        eRec = eRec.Where(c => c.Debit + c.Credit != 0).ToList();
                        break;

                    default:
                        break;
                }

            if (chkSkipBalanceZero.Checked)
                eRec = eRec
                    .Where(c => c.Debit - c.Credit != 0)
                    .Where(c => c.Debit1st - c.Credit1st != 0)
                    .Where(c => c.Debit2nd - c.Credit2nd != 0)
                    .ToList();

            switch (rgType.SelectedIndex)
            {
                //case 0:
                //    colCurrency.Visible = true;
                //    colDebit.Visible = colCredit.Visible = colBalance.Visible = true;
                //    colDebit.VisibleIndex = 3;
                //    colCredit.VisibleIndex = 4;
                //    colBalance.VisibleIndex = 5;

                //    colDebit1st.Visible = colCredit1st.Visible = colBalance1st.Visible = false;
                //    colDebit2nd.Visible = colCredit2nd.Visible = colBalance2nd.Visible = false;
                //    break;

                case 0:
                    colCurrency.Visible = false;
                    colDescription.Width = (int)colWidth + colCurrency.Width;
                    colDebit1st.Visible = colCredit1st.Visible = colBalance1st.Visible = true;
                    colDebit1st.VisibleIndex = 3;
                    colCredit1st.VisibleIndex = 4;
                    colBalance1st.VisibleIndex = 5;

                    colDebit.Visible = colCredit.Visible = colBalance.Visible = false;
                    colDebit2nd.Visible = colCredit2nd.Visible = colBalance2nd.Visible = false;
                    break;

                case 1:
                    colCurrency.Visible = false;
                    colDescription.Width = (int)colWidth + colCurrency.Width;
                    colDebit2nd.Visible = colCredit2nd.Visible = colBalance2nd.Visible = true;
                    colDebit2nd.VisibleIndex = 3;
                    colCredit2nd.VisibleIndex = 4;
                    colBalance2nd.VisibleIndex = 5;

                    colDebit.Visible = colCredit.Visible = colBalance.Visible = false;
                    colDebit1st.Visible = colCredit1st.Visible = colBalance1st.Visible = false;
                    break;

                case 2:
                    colCurrency.Visible = true;
                    colDescription.Width = (int)colWidth;
                    colDebit.Visible = colCredit.Visible = colBalance.Visible = true;
                    colDebit1st.Visible = colCredit1st.Visible = colBalance1st.Visible = true;
                    colDebit2nd.Visible = colCredit2nd.Visible = colBalance2nd.Visible = true;
                    //
                    colDebit.VisibleIndex = 4;
                    colCredit.VisibleIndex = 5;
                    colBalance.VisibleIndex = 6;
                    //
                    colDebit1st.VisibleIndex = 7;
                    colCredit1st.VisibleIndex = 8;
                    colBalance1st.VisibleIndex = 9;
                    //
                    colDebit2nd.VisibleIndex = 10;
                    colCredit2nd.VisibleIndex = 11;
                    colBalance2nd.VisibleIndex = 12;
                    break;

                default:
                    break;
            }
            bsResult.DataSource = eRec;
        }
    }
}
