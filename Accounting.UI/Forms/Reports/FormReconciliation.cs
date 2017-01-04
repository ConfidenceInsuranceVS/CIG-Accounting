using DevExpress.XtraGrid.Views.Grid;
using efControls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using static Accounting.AccountingServices;

namespace Accounting
{
    public partial class FormReconciliation : FormReportBase
    {
        int account, currency;
        DateTime defrom, deto;
        public FormReconciliation()
        {
            InitializeComponent();

            //de = new AllFormExtensions<Bankreconciliation>() { f = this };

            deFrom.EditValue = new DateTime(App.WorkingYear, 1, 1);
            deTo.EditValue = getMaxDate(App.WorkingYear);

            bsVoucherTypes.DataSource = getVoucherTypes();
            bsCurrencies.DataSource = getCurrencies();
            bsSubCompanies.DataSource = getSubCompanies();
            rgType.SelectedIndex = 2;

            gcResult.Enabled = true;
            gvResult.OptionsBehavior.ReadOnly = false;
            gvResult.OptionsBehavior.Editable = true;

            colSC.Visible = App.HasSubCompanies;
            colDescription1.Width = App.HasSubCompanies == false ? colDescription1.Width + colSC.Width : colDescription1.Width;
        }
        protected override void print(bool toPrint)
        {
            proceed();
            //
            List<Bankreconciliation> bsReport = new List<Bankreconciliation>();
            for (int i = 0; i < gvResult.DataRowCount; i++)
            {
                var row = (Bankreconciliation)bsResult[gvResult.GetDataSourceRowIndex(i)];
                bsReport.Add(row);
            }
            //
            if (bsReport.Count == 0) { return; }
            //
            using (var rep = new Reports.RptBankReconciliation())
            {
                rep.bsReport.DataSource = bsReport;
                rep.lblCompany.Text = App.CompanyName;
                rep.lblTitle.Text = Text.TrimEnd();
                //
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("From : {0} To : {1}", defrom.ToShortDateString(), deto.ToShortDateString());
                sb.AppendLine();
                sb.AppendFormat("Account : {0}       {1}  ", cboAccounts.Code, cboAccounts.Description);
                sb.AppendFormat("Currency : {0}", bsCurrencies.List.OfType<ucCurrencies>().FirstOrDefault(c => c.ID == currency).Description);
                //
                rep.lblCriteria.Text = sb.ToString();

                Report.show<Reports.RptBankReconciliation>(MdiParent as efMainForm, rep, toPrint);
            }
        }
        protected override void proceed()
        {
            account = cboAccounts.EditValue == null ? 0 : (int)cboAccounts.EditValue;
            defrom = (DateTime)deFrom.EditValue;
            deto = (DateTime)deTo.EditValue;
            currency = cboCurrencies.EditValue == null ? 0 : (int)cboCurrencies.EditValue;

            if (account == 0 || currency == 0) { return; }
            lcgMain.Enabled = false;
            Splash.Show(this);
            Splash.SetCaption("Please Wait");
            Splash.SetDescription("Gathering Data ...");
            AccountingEntities ae = new AccountingEntities(App.MainConnectionString);
            var result = ae.Bank_Reconciliation
                (
                    (int)cboAccounts.EditValue,
                    (DateTime)deFrom.EditValue,
                    (DateTime)deTo.EditValue,
                    (int)cboCurrencies.EditValue
                ).ToList();

            switch (rgType.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    result = result.Where(c => c.Isposted == true || c.ID == -1).ToList();
                    break;
                case 2:
                    result = result.Where(c => c.Isposted == false || c.ID == -1).ToList();
                    break;
            }

            if (result.Count > 0)
                bsResult.DataSource = result.Select(c => new Bankreconciliation
                {
                    Accountid = (int)cboAccounts.EditValue,
                    Debit = c.Debit,
                    Credit = c.Credit,
                    Jvdate = c.Jvdate,
                    Ispassed = c.Ispassed,
                    Isposted = c.Isposted,
                    Vouchertypeid = c.Vouchertypeid,
                    Reference = c.Reference,
                    Maturity = c.Maturity,
                    Description = c.Description,
                    Currencyid = c.Currencyid,
                    Rowguid = c.Rowguid,
                    ID = (int)c.ID,
                    Flag = c.Flag,
                    Voucherid = c.Voucherid,
                    SC = c.SC
                });

            lcgMain.Enabled = true;
            Splash.Close();
        }
        private void gvResult_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Row == null) { return; }
            if (e.IsGetData)
            {
                GridView view = (GridView)sender;
                switch (e.Column.FieldName.ToUpper())
                {
                    case "BALANCE":
                        decimal total = 0m;
                        int rHandle = view.GetRowHandle(e.ListSourceRowIndex);
                        for (int i = -1; i <= rHandle - 1; i++)
                        {
                            total += Convert.ToDecimal(view.GetRowCellValue(i + 1, "Debit")) - Convert.ToDecimal(view.GetRowCellValue(i + 1, "Credit"));
                        }
                        e.Value = total;
                        break;

                    case "COLSCAN":
                        var rec = (Bankreconciliation)e.Row;
                        if (rec.Voucherid != null)
                        {
                            var doc = getfileName((int)rec.Voucherid);
                            if (File.Exists(doc))
                                e.Value = imageCollection.Images[7];
                            else
                                e.Value = null;
                        }
                        break;
                }
            }
        }

        private void rgType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (rgType.SelectedIndex)
            {
                case 0:
                    bbiUnpost.Enabled = true;
                    break;
                case 1:
                    bbiUnpost.Enabled = true;
                    break;
                case 2:
                    bbiUnpost.Enabled = false;
                    break;
            }
            proceed();
        }
        private void gvResult_ShowingEditor(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var view = sender as efGridView;
            var rec = (Bankreconciliation)bsResult.Current;
            if (view.FocusedColumn == colBalance 
                | view.FocusedColumn == colScan 
                | view.FocusedColumn == colCurrencyid
                | view.FocusedColumn == colVouchertypeid 
                | view.FocusedColumn == colReference) { e.Cancel = true; }
            else if (rec.Flag != "1") { if (view.FocusedColumn != colIsposted) { e.Cancel = true; } }
            //else if (view.FocusedColumn == colIsposted | view.FocusedColumn == colVouchertypeid | view.FocusedColumn == colReference) { e.Cancel = true; }
        }
        private void bbiGridAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cboCurrencies.EditValue == null | cboAccounts.EditValue == null) { return; }

            var br = new Bankreconciliation()
            {
                Flag = "1",
                Jvdate = DateTime.Now.Date,
                SC = getDefaultSubCompanyID(),
                Currencyid = (int)cboCurrencies.EditValue,
                Accountid = (int)cboAccounts.EditValue,
                Isposted = false
            };

            bsResult.Add(br);
            gvResult.FocusedRowHandle = gvResult.RowCount;
            gvResult.FocusedColumn = colJvdate;
            gvResult.Focus();
        }
        private void bbiGridDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var rec = (Bankreconciliation)bsResult.Current;
            if (rec.Vouchertypeid != null && rec.Reference != null) { return; }

            if (Alert.ShowDialogMessage("Are you sure to delete selected record?") == System.Windows.Forms.DialogResult.No)
                return;

            using (var ae = new AccountingEntities(App.MainConnectionString))
            {
                var br = ae.Bankreconciliations.FirstOrDefault(c => c.ID == rec.ID);
                ae.Bankreconciliations.Remove(br);
                ae.SaveChanges();
            };
            gvResult.DeleteSelectedRows();
        }

        private void cboAccounts_Leave(object sender, EventArgs e)
        {
            using (AccountingEntities ae = new AccountingEntities(App.MainConnectionString))
            {
                var rec = ae.Chartofaccounts.FirstOrDefault(c => c.ID == cboAccounts.id);
                if (rec != null) { cboCurrencies.EditValue = rec.Currencyid; }
            }
        }

        private void bbiGridSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Alert.ShowDialogMessage("Are you sure to save changes?") == System.Windows.Forms.DialogResult.No)
                return;

            gvResult.PostEditor();


            var invalids = bsResult.List.OfType<Bankreconciliation>()
                .Where(c => (c.Debit == null | c.Debit == 0) & (c.Credit == null | c.Credit == 0))
                .ToList();
            foreach (var invalid in invalids) { bsResult.Remove(invalid); }

            using (var ae = new AccountingEntities(App.MainConnectionString))
            {
                // Records In JournalParents
                var brs = bsResult.List.OfType<Bankreconciliation>().Where(c => c.Isposted != c.Ispassed).ToList();
                foreach (var br in brs)
                {
                    var jc = ae.Journalchilds.FirstOrDefault(c => c.ID == br.ID);
                    if (jc != null) { jc.Isposted = br.Isposted; }
                }

                // Records In BankReconciliation
                brs = bsResult.List.OfType<Bankreconciliation>().Where(c => c.Flag == "1").ToList();
                Bankreconciliation nbr = null;
                foreach (var br in brs)
                {
                    nbr = ae.Bankreconciliations.FirstOrDefault(c => c.ID == br.ID);
                    if (nbr == null)
                    {
                        nbr = new Bankreconciliation();
                        ae.Bankreconciliations.Add(nbr);
                    }

                    nbr.Flag = br.Flag;
                    nbr.Accountid = br.Accountid;
                    nbr.SC = br.SC;
                    nbr.Description = br.Description;
                    nbr.Currencyid = br.Currencyid;
                    nbr.Debit = br.Debit;
                    nbr.Credit = br.Credit;
                    nbr.Ispassed = br.Ispassed;
                    nbr.Isposted = br.Isposted;
                    nbr.Jvdate = br.Jvdate;
                    nbr.Maturity = br.Maturity;
                }
                ae.SaveChanges();
            }
            proceed();
        }
        private void gvResult_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            var rec = (Bankreconciliation)bsResult.Current;
            if (e.Clicks == 2)
            {
                if (rec.Voucherid != null)
                {
                    var jvType = bsVoucherTypes.List.OfType<ucVoucherTypes>().FirstOrDefault(c => c.ID == rec.Vouchertypeid).Code;
                    CallTransactionForm.callTransactionForm((FormMain)this.MdiParent, ((DateTime)rec.Jvdate).Year, jvType, (int)rec.Voucherid);
                }
            }
            else
            {
                if (e.Column == colScan & rec.Voucherid != null) { showPDF((int)rec.Voucherid); }
            }
        }
    }
}
