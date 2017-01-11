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
        List<PostDatedChequesInstant_Result> result1;//BU 05/01/2017-1 

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

            //var rec = (PostDatedChequesDetailed)bsResult.Current; stopped by samir 09/01/2017
            //if (e.Clicks == 2) stopped by samir 09/01/2017
            //{
            //    if (rec.JvID > 0)stopped by samir 09/01/2017
            //        CallTransactionForm.callTransactionForm((FormMain)this.MdiParent, ((DateTime)rec.Jvdate).Year, rec.Type, (int)rec.JvID);stopped by samir 09/01/2017
            //}
            //else stopped by samir 09/01/2017
            //{
            //    if (e.Column == colScan) { showPDF((int)rec.JvID); }stopped by samir 09/01/2017
            //}

            try// try catch  added by samir 09/01/2017 on instant when clicking on row or cell click it was giving error and closing application
            {
                switch (rgType.SelectedIndex)
                {
                    case 0:

                        break;// missing or what? check with fadi

                    case 1:
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

                        break;
                    case 2:// missing or what? check with fadi
                        break;
                }

            }
            catch
            { }
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
            //var list = new List<PostDatedChequesDetailed>(); //stopped by samir //BU 05/01/2017-2 
            //for (int i = 0; i < gvResult.DataRowCount; i++) //stopped by samir //BU 05/01/2017-2 
            //{
            //    var row = (PostDatedChequesDetailed)bsResult[gvResult.GetDataSourceRowIndex(i)];
            //    list.Add(row);
            //}
            ////
            //if (list.Count == 0) { return; }
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
                    var listInstant = new List<PostDatedChequesInstant_Result>();//BU 05/01/2017-2 
                    for (int i = 0; i < gvResult.DataRowCount; i++)//BU 05/01/2017-2 
                    {
                        var row = (PostDatedChequesInstant_Result)bsResult[gvResult.GetDataSourceRowIndex(i)];
                        listInstant.Add(row); //BU 05/01/2017-2 
                    }
                    if (listInstant.Count == 0) { return; }//BU 05/01/2017-2 

                    // using (rep = new RptPostDatedChequesInstant()) //BU 05/01/2017-2
                    using (rep = new RptPostDatedChequesInstant())////BU 05/01/2017-2
                    {
                        var bsReport = listInstant.Select(c => new PostDatedChequesInstantResult
                        {
                            Maturity = c.Maturity,
                            Currency = c.Currency,
                            Balance1st=c.Balance1st,
                            Balance2nd=c.Balance2nd
                            //  Amount=c.a
                            // fir
                            // Amount=c.a

                            //Amount =cboAccounts.
                            //  Document = c.Document,
                            //  Bank = c.Bank,

                            //  Sc = c.Sc,
                            //  Debit = c.Debit,

                            //  Credit = c.Credit,


                        });
                        //.GroupBy(c => new { c.Bank, c.Document, c.Sc })
                        //.Select(s => new PostDatedDetailedResult
                        //{
                        //    Maturity = s.First().Maturity,
                        //  //  Document = s.First().Document,
                        // //   Bank = s.First().Bank,
                        //   // Cur = s.First().Cur,
                        //    Debit = s.Sum(c => c.Debit),
                        //   // DBType = s.Max(c => c.DBType),
                        //  //  DBReference = s.Max(c => c.DBReference),
                        //    Credit = s.Sum(c => c.Credit),
                        //  //  CRType = s.Max(c => c.CRType),
                        //   // CRReference = s.Max(c => c.CRReference),
                        //});

                        //rep.bsReport.DataSource = bsReport;
                        //rep.lblCompany.Text = App.CompanyName;
                        //rep.lblTitle.Text = Text.TrimEnd();
                        //rep.lblCriteria.Text = getCriteriaString();
                        //rep.srSummary.ReportSource = new RptPostDatedChequesSummary(bsSummary);
                        //Report.show<RptPostDatedChequesDetailed>(MdiParent as efMainForm, rep, toPrint);


                        rep.bsReport.DataSource = bsReport;
                        rep.lblCompany.Text = App.CompanyName;
                        rep.lblTitle.Text = string.Empty;
                        rep.lblCriteria.Text = "INSTANT POSTDATED CHECKS";

                        // if (deCash.EditValue != null)
                        //{
                        //     bsSummary.DataSource = ae.CashReport(App.WorkingYear, tdate, 0).ToList();
                        //     rep.srSummary.ReportSource = new RptPostDatedChequesCash(bsSummary);
                        // }
                        Report.show<RptPostDatedChequesInstant>(MdiParent as efMainForm, rep, toPrint);

                    }

                    break;

                case 1:
                case 2:
                    var list = new List<PostDatedChequesDetailed>();//BU 05/01/2017-2 
                    for (int i = 0; i < gvResult.DataRowCount; i++)//BU 05/01/2017-2 
                    {
                        var row = (PostDatedChequesDetailed)bsResult[gvResult.GetDataSourceRowIndex(i)];
                        list.Add(row);
                    }
                    //
                    if (list.Count == 0) { return; }//BU 05/01/2017-2 
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
                    // colAmount.FieldName = "colAmount"; //BU 05/01/2017-1 
                    colDebit.FieldName = "Balance1st";
                    colDebit.Caption = "Local 1st";
                    colCredit.FieldName = "Balance2nd"; //BU 09/01/2017-1 
                    colCredit.Caption = "Local 2nd";
                    lciSummary.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always; //BU 05/01/2017-1 
                    colDebit1.Caption = "Local 1st";//BU 05/01/2017-1 
                    colCredit1.Caption = "Local 2nd";//BU 05/01/2017-1 
                    colDebitBalance.Visible = false;//BU 05/01/2017-1 
                    colCreditBalance.Visible = false;//BU 05/01/2017-1 
                    break;

                case 1:
                case 2:
                    colAmount.FieldName = "colAmount";
                    colDebit.FieldName = colDebit.Caption = "Debit";
                    colCredit.FieldName = colCredit.Caption = "Credit";
                    lciSummary.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    colDebitBalance.Visible = true;//BU 05/01/2017-1 
                    colCreditBalance.Visible = true;//BU 05/01/2017-1 
                    colDebit1.Caption = "Debit";//BU 09/01/2017-1 
                    colCredit1.Caption = "Credit";//BU 09/01/2017-1 

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
                    result1 = ae.PostDatedChequesInstant(fdate, tdate, adate, App.LocalCurreny, App.ForeignCurreny).ToList(); //BU 05/01/2017-1 

                    bsResult.DataSource = result1;
                    fillSummaryInstant(result1, string.Empty);  //BU 05/01/2017-1 

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

        private void fillSummaryInstant(List<PostDatedChequesInstant_Result> rs, string sc) //BU 05/01/2017-2 
        {
            var list = new List<PostDatedChequesInstant_Result>();
            for (int i = 0; i < gvResult.DataRowCount; i++)
            {
                var row = (PostDatedChequesInstant_Result)bsResult[gvResult.GetDataSourceRowIndex(i)];
                list.Add(row);
            }
            //
            var summary = list.GroupBy(c => new { c.Currency, c.Sc })
                .Select(s => new PostdatedChequesInstantSummary //BU 05/01/2017-2 
                {
                    Sc = s.First().Sc,
                    Currency = s.First().Currency, //BU 05/01/2017-2 
                    Cheques = s.Count(),
                    Debit = s.Sum(c => c.Balance1st),
                    Credit = s.Sum(c => c.Balance2nd),
                    //  DebitBalance = s.Sum(c => c.Balance1st - c.Balance2nd) > 0 ? s.Sum(c => c.Balance1st - c.Balance2nd) : 0,
                    //  CreditBalance = s.Sum(c => c.Debit2nd - c.Credit2nd) < 0 ? s.Sum(c => c.Debit2nd - c.Credit2nd) : 0
                });
            //
            bsSummary.DataSource = summary;
        }
    }
}
