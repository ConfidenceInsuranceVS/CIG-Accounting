using Accounting.Reports;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using efControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using static Accounting.AccountingServices;

namespace Accounting
{
    public partial class FormNotesReceivables : FormReportBase
    {
        int? currencyID, Accountid;
        DateTime? from, to, till;
        public FormNotesReceivables()
        {
            InitializeComponent();
            rgType.SelectedIndex = 1;
            gvResult.OptionsBehavior.Editable = false;
            deFrom.EditValue = new DateTime(App.WorkingYear, 1, 1);
            deTo.EditValue = deAsAt.EditValue = DateTime.Now.Date;
            deFrom.Focus();

            colSC.Visible = App.HasSubCompanies;
            colDescription.Width = App.HasSubCompanies == false ? colDescription.Width + colSC.Width : colDescription.Width;
        }
        protected override void proceed()
        {
            Accountid = cboAccounts.id;
            from = (DateTime?)deFrom.EditValue;
            to = (DateTime?)deTo.EditValue;
            till = (DateTime?)deAsAt.EditValue;
            currencyID = (int?)cboCurrencies.EditValue;
            //gvResult.FormatRules.AddRule(getFormatRules());


            using (AccountingEntities ae = new AccountingEntities(App.MainConnectionString))
            {
                var nrs = ae.NotesReceivables(from, to, till, Accountid, currencyID).ToList();
                switch (rgType.SelectedIndex)
                {
                    case 0:
                        bsResult.DataSource = nrs
                            .Where(c => c.debit != c.credit)
                            .GroupBy(g => new { currency = g.currency, maturity = g.maturity })
                            .Select(g => new NotesReceivables()
                            {
                                currency = g.Key.currency,
                                maturity = g.Key.maturity,
                                document = string.Empty,
                                account = string.Empty,
                                description = string.Empty,
                                debit = g.Sum(c => c.debit),
                                debit1st = 0,
                                debit2nd = g.Sum(c => c.debit2nd),
                                credit = g.Sum(c => c.credit),
                                credit1st = 0,
                                credit2nd = g.Sum(c => c.credit2nd),
                                type = string.Empty,
                                reference = 0,
                                jvdate = g.Select(c => c.jvdate).FirstOrDefault()
                            })
                            .OrderBy(c => c.currency).ThenBy(c => c.maturity);
                        break;

                    case 1:
                        bsResult.DataSource = nrs.OrderBy(c => c.currency).ThenBy(c => c.account).ThenBy(c => c.maturity);
                        break;

                    case 2:
                        bsResult.DataSource = nrs.Where(c=>c.credit != c.debit).OrderBy(c => c.currency).ThenBy(c => c.account).ThenBy(c => c.maturity);
                        break;
                }
            }
            showSummary();
        }
        private void showSummary()
        {
            try
            {
                var totals = bsResult.List.OfType<NotesReceivables>().ToList();
                bsTotals.DataSource = totals.GroupBy(l => l.currency)
                        .Select(cl => new NotesReceivables
                        {
                            currency = cl.FirstOrDefault().currency,
                            account = "",
                            description = "",
                            debit = cl.Sum(c => c.debit),
                            credit = cl.Sum(c => c.credit),
                            debit1st = cl.Sum(c => c.debit1st),
                            credit1st = cl.Sum(c => c.credit1st),
                            debit2nd = cl.Sum(c => c.debit2nd),
                            credit2nd = cl.Sum(c => c.credit2nd),
                        }).ToList();

            }
            catch (Exception)
            {
            }
        }

        private void rgType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gvResult_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            var rec = (NotesReceivables)bsResult.Current;
            if (e.Clicks == 2)
                CallTransactionForm.callTransactionForm((FormMain)this.MdiParent, ((DateTime)rec.jvdate).Year, rec.type, (int)rec.ID);
            else
                if (e.Column == colScan) { showPDF((int)rec.ID); }
        }
        private void gvResult_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Row == null) { return; }
            if (e.IsGetData)
            {
                if (e.Column == colScan)
                {
                    var rec = (NotesReceivables)e.Row;
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
        }
        private void gvResult_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            efGridView gv = sender as efGridView;
            if (e.RowHandle != efGridControl.AutoFilterRowHandle)
            {
                var txtMaturity = gv.GetRowCellDisplayText(e.RowHandle, colmaturity);
                if (!string.IsNullOrEmpty(txtMaturity))
                {
                    var maturity = DateTime.Parse(txtMaturity);
                    if (maturity < till) { e.Appearance.ForeColor = Color.Red; }
                }
            }
        }
        protected override void print(bool toPrint)
        {
            proceed();
            switch (rgType.SelectedIndex)
            {
                case 0:
                    using (var rep = new RptNotesReceivablesInstant())
                    {
                        rep.bsReport.DataSource = bsResult.DataSource;
                        rep.lblCompany.Text = App.CompanyName;
                        rep.lblTitle.Text = string.Format("Instant {0} Till {1}", Text.TrimEnd(), deAsAt.Text);
                        rep.lblCriteria.Text = string.Format("From : {0} To : {1}", deFrom.Text, deTo.Text);

                        Report.show<RptNotesReceivablesInstant>(MdiParent as efMainForm, rep, toPrint);
                    }
                    break;

                case 1:
                    using (var rep = new RptNotesReceivables())
                    {
                        rep.NotesReceivablesSummary.ReportSource = new RptNotesReceivablesSummary(summary(true));
                        rep.bsReport.DataSource = bsResult.DataSource;
                        rep.lblCompany.Text = App.CompanyName;
                        rep.lblTitle.Text = string.Format("Detailed {0} Till {1}",Text.TrimEnd(), deAsAt.Text);
                        rep.lblCriteria.Text = string.Format("From : {0} To : {1}", deFrom.Text, deTo.Text);
                        rep.till = till;

                        Report.show<RptNotesReceivables>(MdiParent as efMainForm, rep, toPrint);
                    }
                    break;

                case 2:
                    using (var rep = new RptNotesReceivables())
                    {
                        rep.NotesReceivablesSummary.ReportSource = new RptNotesReceivablesSummary(summary(false));
                        rep.bsReport.DataSource = bsResult.DataSource;
                        rep.lblCompany.Text = App.CompanyName;
                        rep.lblTitle.Text = string.Format("In House {0} Till {1}", Text.TrimEnd(), deAsAt.Text);
                        rep.lblCriteria.Text = string.Format("From : {0} To : {1}", deFrom.Text, deTo.Text);
                        rep.till = till;

                        Report.show<RptNotesReceivables>(MdiParent as efMainForm, rep, toPrint);
                    }
                    break;

                case 3:
                    break;
            }
        }
        private List<NotesSummary> summary(bool all)
        {
            List<NotesSummary> lns = new List<NotesSummary>();
            if (all)
            {
                lns.AddRange(bsResult.List.OfType<NotesReceivables>()
                    .Where(c => c.debit - c.credit == 0)
                    .GroupBy(c => c.currency, (key, g) => new NotesSummary()
                    {
                        currency = key,
                        count = g.Count(),
                        description = string.Format("{0} {1} {2}", g.Count(), "Paid Note(s) In".PadLeft(25, ' '), key),
                        debit = g.Sum(c => c.debit),
                        credit = g.Sum(c => c.credit),
                        balance = g.Sum(c => c.debit - c.credit)
                    }).ToList());

                lns.AddRange(bsResult.List.OfType<NotesReceivables>()
                    .Where(c => c.debit - c.credit != 0)
                    .GroupBy(c => c.currency, (key, g) => new NotesSummary()
                    {
                        currency = key,
                        count = g.Count(),
                        description = string.Format("{0} {1} {2}", g.Count(), "Partially Paid Note(s) In".PadLeft(25, ' '), key),
                        debit = g.Sum(c => c.debit),
                        credit = g.Sum(c => c.credit),
                        balance = g.Sum(c => c.debit - c.credit)
                    }).ToList());

                lns.AddRange(bsResult.List.OfType<NotesReceivables>()
                    .Where(c => c.credit == 0)
                    .GroupBy(c => c.currency, (key, g) => new NotesSummary()
                    {
                        currency = key,
                        count = g.Count(),
                        description = string.Format("{0} {1} {2}", g.Count(), "Unpaid Note(s) In".PadLeft(25, ' '), key),
                        debit = g.Sum(c => c.debit),
                        credit = g.Sum(c => c.credit),
                        balance = g.Sum(c => c.debit - c.credit)
                    }).ToList());
            }

            lns.AddRange(bsResult.List.OfType<NotesReceivables>()
                .GroupBy(c => c.currency, (key, g) => new NotesSummary()
                {
                    currency = key,
                    count = g.Count(),
                    description = string.Format("{0} {1} {2}", g.Count(), "Note(s) In".PadLeft(25, ' '), key),
                    debit = g.Sum(c => c.debit),
                    credit = g.Sum(c => c.credit),
                    balance = g.Sum(c => c.debit - c.credit)
                }).ToList());

            lns.AddRange(bsResult.List.OfType<NotesReceivables>()
                .Where(c => c.maturity <= till)
                .GroupBy(c => c.currency, (key, g) => new NotesSummary()
                {
                    currency = key,
                    count = g.Count(),
                    description = string.Format("{0} {1} {2}", g.Count(), "Due Note(s) In".PadLeft(25, ' '), key),
                    debit = g.Sum(c => c.debit),
                    credit = g.Sum(c => c.credit),
                    balance = g.Sum(c => c.debit - c.credit)
                }).ToList());

            lns.AddRange(bsResult.List.OfType<NotesReceivables>()
                .Where(c => c.maturity > till)
                .GroupBy(c => c.currency, (key, g) => new NotesSummary()
                {
                    currency = key,
                    count = g.Count(),
                    description = string.Format("{0} {1} {2}", g.Count(), "Not Due Note(s) In".PadLeft(25, ' '), key),
                    debit = g.Sum(c => c.debit),
                    credit = g.Sum(c => c.credit),
                    balance = g.Sum(c => c.debit - c.credit)
                }).ToList());

            return lns;
        }
    }
}
