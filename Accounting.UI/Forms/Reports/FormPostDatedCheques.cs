using Accounting.Reports;
using efControls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static Accounting.AccountingServices;

namespace Accounting
{
    public partial class FormPostDatedCheques : FormReportBase
    {
        DateTime fdate, tdate, adate;
        AccountingEntities ae;
        List<PostDatedChequesDetailed> result;
       
        public FormPostDatedCheques()
        {
            InitializeComponent();

            deFrom.EditValue = DateTime.Now; // new DateTime(App.WorkingYear, 1, 1);
            deTo.EditValue = DateTime.Now; // new DateTime(App.WorkingYear, 12, 31);
            deTill.EditValue = DateTime.Now; // deCash.EditValue = getMaxDate(App.WorkingYear);
            deCash.EditValue = DateTime.Now; 

            colSC.Visible = colSC1.Visible = App.HasSubCompanies;
            colDescription.Width = App.HasSubCompanies == false ? colDescription.Width + colSC.Width : colDescription.Width;
            rgType.SelectedIndex = 0;
            gvResult.OptionsBehavior.Editable = false;
        }
        private string getCriteriaString()
        {
            string filter = string.IsNullOrEmpty(gvResult.ActiveFilterString) ? string.Empty : string.Format("Filter : {0}", gvResult.ActiveFilterString);
            return string.Format("From : {0} To : {1} {2}{3}", ((DateTime)fdate).ToShortDateString(), ((DateTime)tdate).ToShortDateString(), Environment.NewLine, filter);
        }

        private void gvResult_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            var rec = (PostDatedChequesDetailed)bsResult.Current;
            if (e.Clicks == 2)
            {
                if (rec.JvID > 0)
                    CallTransactionForm.callTransactionForm((FormMain)this.MdiParent, ((DateTime)rec.Jvdate).Year, rec.Type, (int)rec.JvID);
            }
            else
            {
                if (e.Column == colScan) { showPDF((int)rec.JvID); }
            }
        }

        private void gvResult_ColumnFilterChanged(object sender, EventArgs e)
        {
            var cfi = gvResult.Columns["Sc"].FilterInfo;
            var cfValue = cfi.Value == null ? string.Empty : cfi.Value.ToString();
            fillSummary(result, cfValue);

            //ColumnFilterInfo cfinfo = new ColumnFilterInfo(cfi.FilterCriteria);
            //gvSummary.Columns["Sc"].FilterInfo = cfinfo;
        }
        protected override void print(bool toPrint)
        {
            proceed();
            //
            var list = new List<PostDatedChequesDetailed>();
            for (int i = 0; i < gvResult.DataRowCount; i++)
            {
                var row = (PostDatedChequesDetailed)bsResult[gvResult.GetDataSourceRowIndex(i)];
                list.Add(row);
            }
            //
            if (list.Count == 0) { return; }
            //
            dynamic rep;
            switch (rgType.SelectedIndex)
            {
                case 0:
                    //using (rep = new RptPostDatedChequesInstant())
                    //{
                    //    rep.bsReport.DataSource = bsReport;
                    //    rep.lblCompany.Text = App.CompanyName;
                    //    rep.lblTitle.Text = Text.TrimEnd();
                    //    rep.lblCriteria.Text = string.Empty;
                    //    if (deCash.EditValue != null)
                    //    {
                    //        bsSummary.DataSource = ae.CashReport(App.WorkingYear, tdate, 0).ToList();
                    //        rep.srSummary.ReportSource = new RptPostDatedChequesCash(bsSummary);
                    //    }
                    //    Report.show<RptPostDatedChequesInstant>(rep, false);
                    //}
                    break;

                case 1:
                case 2:
                    using (rep = new RptPostDatedChequesDetailed())
                    {
                        var bsReport = list.Select(c => new PostDatedDetailedResult
                        {
                            Maturity = c.Maturity,
                            Document = c.Document,
                            Bank = c.Bank,
                            Cur = c.Cur,
                            Sc = c.Sc,
                            Debit = c.Debit,
                            DBType = c.Dc == "D" ? c.Type : string.Empty,
                            DBReference = c.Dc == "D" ? c.Reference : 0,
                            Credit = c.Credit,
                            CRType = c.Dc == "C" ? c.Type : string.Empty,
                            CRReference = c.Dc == "C" ? c.Reference : 0
                        })
                            .GroupBy(c => new { c.Bank, c.Document, c.Cur, c.Sc })
                            .Select(s => new PostDatedDetailedResult
                            {
                                Maturity = s.First().Maturity,
                                Document = s.First().Document,
                                Bank = s.First().Bank,
                                Cur = s.First().Cur,
                                Debit = s.Sum(c => c.Debit),
                                DBType = s.Max(c => c.DBType),
                                DBReference = s.Max(c => c.DBReference),
                                Credit = s.Sum(c => c.Credit),
                                CRType = s.Max(c => c.CRType),
                                CRReference = s.Max(c => c.CRReference),
                            });

                        rep.bsReport.DataSource = bsReport;
                        rep.lblCompany.Text = App.CompanyName;
                        rep.lblTitle.Text = Text.TrimEnd();
                        rep.lblCriteria.Text = getCriteriaString();
                        rep.srSummary.ReportSource = new RptPostDatedChequesSummary(bsSummary);
                        Report.show<RptPostDatedChequesDetailed>(MdiParent as efMainForm, rep, toPrint);
                    }
                    break;
            }
        }

        private void rgType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (rgType.SelectedIndex)
            {
                case 0:
                    colAmount.FieldName = "colAmount";
                    colDebit.FieldName = "Balance1st";
                    colDebit.Caption = "Local 1st";
                    colCredit.FieldName = "Balance2nd";
                    colCredit.Caption = "Local 2nd";
                    lciSummary.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    break;

                case 1:
                case 2:
                    colAmount.FieldName = "colAmount";
                    colDebit.FieldName = colDebit.Caption = "Debit";
                    colCredit.FieldName = colCredit.Caption = "Credit";
                    lciSummary.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;

                    break;
            }
            bsResult.DataSource = bsSummary.DataSource = null;
        }
        private void gvResult_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Row == null) { return; }
            try
            {
                if (e.Column == colScan & e.IsGetData)
                {
                    var rec = (PostDatedChequesDetailed)e.Row;
                    var doc = getfileName((int)rec.JvID);
                    if (File.Exists(doc))
                        e.Value = formImages.Images[0];
                    else
                        e.Value = null;
                }
            }
            catch (Exception)
            {
                e.Value = null;
            }
        }

        protected override void proceed()
        {
            fdate = (DateTime)deFrom.EditValue;
            tdate = (DateTime)deTo.EditValue;
            adate = (DateTime)deTill.EditValue;
            ae = new AccountingEntities(App.MainConnectionString);

            switch (rgType.SelectedIndex)
            {
                case 0:
                    //result = ae.PostDatedChequesInstant(fdate, tdate, adate, App.LocalCurreny, App.ForeignCurreny).ToList();
                   
                    int resultInstant = 0; // added by samir ref BU 9/12/2016-1
                                           //using (AccountingEntities ae = new AccountingEntities(App.MainConnectionString))//added by samir ref BU 9/12/2016-1
                                           //{
                   // AccountingEntities ae = new AccountingEntities(App.MainConnectionString);
                    resultInstant = ae.PostDatedChequesInstant(fdate, tdate, adate, App.LocalCurreny, App.ForeignCurreny);//added by samir ref BU 9/12/2016-1
                    //}

                    bsResult.DataSource = resultInstant;// added by samir ref BU 9/12/2016-1
                                                        
                    break;

                case 1:
                case 2:
                    var inHouse = rgType.SelectedIndex == 2 ? true : false;
                    result = ae.PostDatedChequesDetailed(fdate, tdate, adate, App.LocalCurreny, App.ForeignCurreny, inHouse).ToList();
                    bsResult.DataSource = result;
               fillSummary(result, string.Empty); 
                    break;
            }
        }
        private void fillSummary(List<PostDatedChequesDetailed> rs, string sc)
        {
            var list = new List<PostDatedChequesDetailed>();
            for (int i = 0; i < gvResult.DataRowCount; i++)
            {
                var row = (PostDatedChequesDetailed)bsResult[gvResult.GetDataSourceRowIndex(i)];
                list.Add(row);
            }
            //
            var summary = list.GroupBy(c => new { c.Cur, c.Sc })
                .Select(s => new PostdatedChequesSummary
                {
                    Sc = s.First().Sc,
                    Cur = s.First().Cur,
                    Cheques = s.Count(),
                    Debit = s.Sum(c => c.Debit),
                    Credit = s.Sum(c => c.Credit),
                    DebitBalance = s.Sum(c => c.Debit - c.Credit) > 0 ? s.Sum(c => c.Debit - c.Credit) : 0,
                    CreditBalance = s.Sum(c => c.Debit - c.Credit) < 0 ? s.Sum(c => c.Debit - c.Credit) : 0
                });
            //
            bsSummary.DataSource = summary;
        }
    }
}
