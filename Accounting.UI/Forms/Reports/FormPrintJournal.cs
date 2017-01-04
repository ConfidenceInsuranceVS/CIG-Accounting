using Accounting.Reports;
using efControls;
using System;
using System.Collections.Generic;
using System.Linq;
using static Accounting.AccountingServices;

namespace Accounting
{
    public partial class FormPrintJournal : FormReportBase
    {
        int? AccountID, VoucherTypeID, FromRef, ToRef;
        DateTime? FromDate, ToDate;
        List<JournalNormal> resultNormal;
        List<JournalOfficial> resultOfficial;
        List<JournalVouchers> resultVouchers;
        List<PrintVouchers> pv;
        public FormPrintJournal()
        {
            InitializeComponent();
            rgType.SelectedIndex = 0;
            enableObjects();

            gvResult.OptionsBehavior.Editable = false;
            //deFrom.Properties.MinValue = deTo.Properties.MinValue = new DateTime(App.WorkingYear, 1, 1); //stopped by Samir  ref UE-12/12/2016-1
            //deFrom.Properties.MaxValue = deTo.Properties.MaxValue = new DateTime(App.WorkingYear, 12, 31);//stopped by Samir  ref UE-12/12/2016-1
            //deFrom.EditValue = new DateTime(App.WorkingYear, 1, 1);//stopped by Samir ref UE-12/12/2016-1
            //deTo.EditValue = getMaxDate(App.WorkingYear); //DateTime.Now.Date;//stopped by Samir ref UE-12/12/2016-1

            colSC.Visible = App.HasSubCompanies;
            colDescription.Width = App.HasSubCompanies == false ? colDescription.Width + colSC.Width : colDescription.Width;

            cboAccounts.Focus();
        }
        protected override void print(bool toPrint)
        {
            proceed();
            //
            string filter = string.IsNullOrEmpty(gvResult.ActiveFilterString) ? string.Empty : string.Format("{0}Filter : {1}", Environment.NewLine, gvResult.ActiveFilterString);
            using (AccountingEntities ae = new AccountingEntities(App.MainConnectionString))
            {
                switch (rgType.SelectedIndex)
                {
                    case 0:
                        var bsNormal = new List<JournalNormal>();
                        for (int i = 0; i < gvResult.DataRowCount; i++)
                        {
                            var row = (PrintVouchers)bsResult[gvResult.GetDataSourceRowIndex(i)];
                            bsNormal.Add(new JournalNormal()
                            {
                                jvdate = row.JvDate,
                                Type = row.Type,
                                reference = row.Reference,
                                account = row.Account,
                                AccountDescription = row.AccountDescription,
                                Description = row.Description,
                                Currency = row.Currency,
                                Amount = row.Amount,
                                Amount1st = row.Amount1st,
                                Amount2nd = row.Amount2nd,
                                dc = row.DC,
                                SC = row.SC,
                                ID = row.ID
                            });
                        }
                        //
                        if (bsNormal.Count == 0) { return; }
                        //
                        using (var rep = new RptJournalNormal())
                        {
                            rep.bsReport.DataSource = bsNormal;
                            rep.lblTitle.Text = "Journal";
                            rep.lblCompany.Text = App.CompanyName;
                            rep.lblCriteria.Text = string.Format("From : {0} To : {1} {2}", ((DateTime)FromDate).ToShortDateString(), ((DateTime)ToDate).ToShortDateString(), filter);
                            rep.lblCriteria1.Text = string.Format("Document {0}\t\t\t Account {1}", VoucherTypeID == null ? "ALL" : cboVoucherTypes.Text, AccountID == null ? "ALL" : cboAccounts.Code);
                            rep.lblCriteria2.Text = FromRef != null ? string.Format("Reference {0} - {1}", FromRef, ToRef) : string.Empty;
                            rep.NoOfVouchers.Value = string.Format("No. Of Vouchers : {0}", resultNormal.Select(c => new { c.Type, c.reference }).Distinct().Count().ToString());
                            Report.show<RptJournalNormal>(MdiParent as efMainForm, rep, toPrint);
                        }
                        break;

                    case 1:
                        var bsOfficial = new List<JournalOfficial>();
                        for (int i = 0; i < gvResult.DataRowCount; i++)
                        {
                            var row = (PrintVouchers)bsResult[gvResult.GetDataSourceRowIndex(i)];
                            bsOfficial.Add(new JournalOfficial()
                            {
                                jvdate = row.JvDate,
                                type = row.Type,
                                reference = row.Reference,
                                Account = row.Account,
                                AccountDescription = row.AccountDescription,
                                description = row.Description,
                                Currency = row.Currency,
                                Amount = row.Amount,
                                Dc = row.DC,
                                SC = row.SC,
                                ID = row.ID
                            });
                        }
                        //
                        if (bsOfficial.Count > 0)
                        {
                            using (var rep = new RptJournalOfficial())
                            {
                                rep.bsReport.DataSource = bsOfficial;
                                rep.lblTitle.Text = "Journal";
                                rep.lblCompany.Text = App.CompanyName;
                                rep.lblCriteria.Text = filter;
                                Report.show<RptJournalOfficial>(MdiParent as efMainForm, rep, toPrint);
                            }
                        }
                        break;

                    case 2:
                        if (cboVoucherTypes.EditValue == null) { return; }

                        var type = ae.Vouchertypes.FirstOrDefault(c => c.ID == (int)cboVoucherTypes.EditValue).Code;
                        if (type == "JV")
                        {
                            var bsVouchers = new List<JournalVouchers>();
                            for (int i = 0; i < gvResult.DataRowCount; i++)
                            {
                                var row = (PrintVouchers)bsResult[gvResult.GetDataSourceRowIndex(i)];
                                bsVouchers.Add(new JournalVouchers()
                                {
                                    Ratecurrency = row.RateCurrency,//added by samir 03/01/2017 BU 03/01/2017-1
                                    jvdate = row.JvDate,
                                    type = row.Type,
                                    reference = row.Reference,
                                    Account = row.Account,
                                    AccountDescription = row.AccountDescription,
                                    description = row.Description,
                                    Currency = row.Currency,
                                    Amount = row.Amount,
                                    Amount1st = row.Amount1st,
                                    Amount2nd = row.Amount2nd,
                                    Dc = row.DC,
                                    SC = row.SC,
                                    ID = row.ID
                                });
                            }
                            //
                            if (bsVouchers.Count > 0)
                            {
                                using (var rep = new RptJournalVouchers())
                                {
                                    rep.bsReport.DataSource = bsVouchers;
                                    rep.lblTitle.Text = "Journal";
                                    rep.lblCompany.Text = App.CompanyName;
                                    rep.lblCriteria.Text = filter;
                                    Report.show<RptJournalVouchers>(MdiParent as efMainForm, rep, toPrint);
                                }
                            }
                        }
                        else
                        {
                            //  using (var rep = new RptOtherVouchers()) //stopped by samir 03/01/2017 BU 03/01/2017-1
                            using (var rep = new RptJournalVouchers()) // added by samir 03/01/2017 BU 03/01/2017-1
                            {
                                //  var bsOthers = new List<OtherVouchers>(); //stopped by samir 30/12/2016
                                //  var bsOthers = new List<OtherVouchers>();//stopped by samir 03/01/2017 BU 03/01/2017-1
                                var bsOthers = new List<JournalVouchers>();
                                for (int i = 0; i < gvResult.DataRowCount; i++)
                                {
                                    var row = (PrintVouchers)bsResult[gvResult.GetDataSourceRowIndex(i)];
                                    // bsOthers.Add(new OtherVouchers();//stopped by samir 03/01/2017 BU 03/01/2017-1
                                    bsOthers.Add(new JournalVouchers() 
                                    {   Ratecurrency = row.RateCurrency,//added by samir 03/01/2017 BU 03/01/2017-1
                                        Dc =row.DC,//added by samir 03/01/2017
                                        jvdate = row.JvDate,
                                        type = row.Type,
                                        reference = row.Reference,
                                        Account = row.Account,
                                        AccountDescription = row.AccountDescription,
                                        description = row.Description,
                                        Currency = row.Currency,
                                        Amount = row.Amount,
                                        Amount1st = row.Amount1st,
                                        Amount2nd = row.Amount2nd,
                                        TypeDescription = row.TypeDescription,
                                        // cvCur = row.cvCur, // stopped by samir 03/01/2017       BU 03/01/2017-1
                                        // cvAmount = row.cvAmount, //// stopped by samir 03/01/2017  BU 03/01/2017-1
                                        Fromto = row.fromTo,
                                        Details = row.details,
                                        SC = row.SC,
                                        ID = row.ID
                                    });
                                }
                                switch (type)
                                {
                                    case "PV":
                                    case "DN":
                                        //   rep.bsReport.DataSource = getOtherVouchers(bsOthers, "D"); // stopped by samir 03/01/2017 BU 03/01/2017-1
                                        break;
                                    case "RV":
                                    case "CN":
                                        // rep.bsReport.DataSource = getOtherVouchers(bsOthers, "C");// stopped by samir 03/01/2017 BU 03/01/2017-1
                                        break;
                                }

                                try
                                {

                                    if (bsOthers.Count > 0)
                                    {
                                      
                                        rep.bsReport.DataSource = bsOthers;
                                        rep.lblTitle.Text = "Journal";
                                        rep.lblCompany.Text = App.CompanyName;
                                        rep.lblCriteria.Text = filter;
                                       
                                        Report.show<RptJournalVouchers>(MdiParent as efMainForm, rep, toPrint);//added by samir 03/01/2016 BU 03/01/2017-1
                                    }
                                }
                                catch (Exception ex)
                                {

                                }
                            }
                        }
                        break;
                }
            }
        }
        private List<OtherVouchers> getOtherVouchers(List<OtherVouchers> vouchers, string dc)
        {
            var cd = dc == "D" ? "C" : "D";
            List<OtherVouchers> result = vouchers
                .GroupBy(t => new { t.jvdate, t.type, t.reference, t.description })
                .Select(r => new OtherVouchers
                {
                    jvdate = r.Key.jvdate,
                    type = r.Key.type,
                    reference = r.Key.reference,
                    description = r.Key.description,
                    cur = r.Max(c => c.Dc == dc ? c.cur : string.Empty),
                    amount = r.Sum(c => c.Dc == dc ? c.amount : 0),
                    cvCur = r.Max(c => c.Dc == cd ? c.cur : string.Empty),
                    cvAmount = r.Sum(c => c.Dc == cd ? c.amount : 0),
                    account = r.Max(c => c.Dc == dc ? c.account : string.Empty),
                    accountDescription = r.Max(c => c.Dc == dc ? c.accountDescription : string.Empty),
                    fromTo = r.Max(c => c.Dc == dc ? c.fromTo : string.Empty),
                    details = r.Max(c => c.Dc == dc ? c.details : string.Empty) ,
                    typeDescription = r.Max(c=>c.typeDescription)
                }).ToList();
            return result;
        }

        private void gvResult_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            var rec = (PrintVouchers)bsResult.Current;
            if (e.Clicks == 2)
                CallTransactionForm.callTransactionForm((FormMain)this.MdiParent, ((DateTime)rec.JvDate).Year, rec.Type, (int)rec.ID);
        }

        protected override void proceed()
        {
            fillVars();
            pv = null;
            bsResult.DataSource = null;
            using (AccountingEntities ae = new AccountingEntities(App.MainConnectionString))
            {
                switch (rgType.SelectedIndex)
                {
                    case 0:
                        resultNormal = ae.JournalNormal(App.WorkingYear, AccountID, FromDate, ToDate, VoucherTypeID, FromRef, ToRef).ToList();
                        pv = resultNormal.Select(c => new PrintVouchers
                        {
                            JvDate = c.jvdate,
                            Type = c.Type,
                            Reference = c.reference,
                            Account = c.account,
                            AccountDescription = c.AccountDescription,
                            Description = c.Description,
                            Currency = c.Currency,
                            Amount = c.Amount,
                            Amount1st = c.Amount1st,
                            Amount2nd = c.Amount2nd,
                            DC = c.dc,
                            SC = c.SC,
                            ID = c.ID
                        }).ToList();
                        break;

                    case 1:
                        resultOfficial = ae.JournalOfficial(App.WorkingYear, FromDate, ToDate).OrderBy(c => c.jvdate).ThenBy(c => c.type).ThenBy(c => c.reference).ToList();
                        pv = resultOfficial.Select(c => new PrintVouchers
                        {
                            JvDate = c.jvdate,
                            Type = c.type,
                            Reference = c.reference,
                            Account = c.Account,
                            AccountDescription = c.AccountDescription,
                            Description = c.description,
                            Currency = c.Currency,
                            Amount = c.Amount,
                            DC = c.Dc,
                            SC = c.SC,
                            ID = (int)c.ID
                        }).ToList();
                        break;

                    case 2:
                        if (cboVoucherTypes.EditValue == null)
                            Alert.ShowMessage("Please Choose A Voucher Type To Proceed !");
                        else
                        {
                            resultVouchers = ae.JournalVouchers(App.WorkingYear, AccountID, FromDate, ToDate, VoucherTypeID, FromRef, ToRef).ToList();
                            pv = resultVouchers.Select(c => new PrintVouchers
                            {   RateCurrency = c.Ratecurrency,// added by samir 3/1/2017 BU 03/01/2017-1
                                Amount1st =c.Amount1st,// added by samir 3/1/2017 BU 03/01/2017-1
                                Amount2nd =c.Amount2nd,// added by samir 3/1/2017 BU 03/01/2017-1
                                JvDate = c.jvdate,
                                Type = c.type,
                                Reference = c.reference,
                                Account = c.Account,
                                AccountDescription = c.AccountDescription,
                                Description = c.description,
                                Currency = c.Currency,
                                Amount = c.Amount,
                                DC = c.Dc,
                                SC = c.SC,
                                TypeDescription = c.TypeDescription,
                                fromTo = c.Fromto,
                                details = c.Details,
                                ID = c.ID
                            }).ToList();
                        }
                        break;
                }
            }
            bsResult.DataSource = pv;
        }
        private void fillVars()
        {
            AccountID = cboAccounts.id == 0 ? null : (int?)cboAccounts.id; 
            VoucherTypeID = (int?)cboVoucherTypes.EditValue;
            FromRef = txtFromReference.EditValue == null ? null : (int?)int.Parse(txtFromReference.EditValue.ToString());
            ToRef = txtToReference.EditValue == null ? null : (int?)int.Parse(txtToReference.EditValue.ToString());
            FromDate = (DateTime?)deFrom.EditValue;
            ToDate = (DateTime?)deTo.EditValue;
        }
        private void enableObjects()
        {
            switch (rgType.SelectedIndex)
            {
                case 0:
                case 2:
                    cboAccounts.Enabled = true;
                    deFrom.Enabled = deTo.Enabled = true;
                    cboVoucherTypes.Enabled = txtFromReference.Enabled = txtToReference.Enabled = true;
                    break;
                case 1:
                    cboAccounts.Enabled = false;
                    deFrom.Enabled = deTo.Enabled = true;
                    cboVoucherTypes.Enabled = txtFromReference.Enabled = txtToReference.Enabled = false;
                    cboVoucherTypes.EditValue = null;
                    txtFromReference.EditValue = txtToReference.EditValue = null;
                    break;
            }
        }
        private void rgType_SelectedIndexChanged(object sender, EventArgs e)
        {
            enableObjects();
        }
    }
}
