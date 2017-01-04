using efControls;
using System;
using System.IO;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid;
using Accounting.Reports;
using DevExpress.XtraEditors;
using System.ComponentModel;
using DevExpress.XtraBars;
using static Accounting.AccountingServices;
using efControls.Data;
using DevExpress.Pdf;
using System.Text;
using DevExpress.XtraBars.Alerter;

namespace Accounting
{
    public partial class FormTransactions : efDataSearchForm
    {
        protected string defaultType = "JV";
        protected string defaultDc = "D";
        private string jvDescription = string.Empty;
        private bool isAudit = false;
        protected int _id = -1;

        private Journalparent parent;
        private Journalchild child;
        public FormTransactions()
        {
            InitializeComponent();

            de = new AllFormExtensions<Journalparent>() { f = this };
            //
            bsMaster.DataMember = "JV";
            bsDetails.DataMember = "Journalchilds";
            //
            new efGridNewRowHelper(this, gvDetails);

            gvCollect.OptionsBehavior.Editable = false;
            colDocument1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Like;

            ripceCollect.QueryResultValue += ripceCollect_QueryResultValue;
            ripceCollect.QueryPopUp += ripceCollect_QueryPopUp;
            ripceCollect.KeyDown += ripceCollect_KeyDown;
            ripceCollect.Closed += RipceCollect_Closed;
            riAccounts.MaxLength = App.AccLength;

            colSC.Visible = App.HasSubCompanies;

            gvDetails.OptionsView.EnableAppearanceEvenRow = gvDetails.OptionsView.EnableAppearanceOddRow = false;
        }


        #region ripceCollect
        private void RipceCollect_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            var rec = (Journalchild)bsDetails.Current;
            var dr = (Collect)gvCollect.GetRow(gvCollect.FocusedRowHandle);
            if (dr != null)
            {
                rec.Maturity = dr.Maturity;
                rec.Currencyid = dbContext.Set<Currency>().FirstOrDefault(c => c.Code == dr.cur).ID;
                rec.Amount = dr.Amount;
                rec.Bankid = dbContext.Set<Bank>().FirstOrDefault(c => c.Description == dr.Bank).ID;
                gvDetails.ValidateEditor();
                updateTotals();
            }
            gvCollect.ActiveFilterString = string.Empty;
        }
        private void ripceCollect_KeyDown(object sender, KeyEventArgs e)
        {
            var rec = (Journalchild)bsDetails.Current;
            bsCollect.DataSource = null;
            AccountStatu status = null;
            switch (e.KeyCode.ToString())
            {
                case "F2":
                    bsCollect.DataSource = ((AccountingEntities)dbContext).Collect(e.KeyCode.ToString(), null, null);
                    break;

                case "F5":
                    status = dbContext.Set<AccountStatu>().FirstOrDefault(c => c.Code == "P");
                    if (status != null)
                        bsCollect.DataSource = ((AccountingEntities)dbContext).Collect(e.KeyCode.ToString(), rec.Accountid, status.ID);
                    break;

                case "F6":
                    status = dbContext.Set<AccountStatu>().FirstOrDefault(c => c.Code == "E");
                    if (status != null)
                        bsCollect.DataSource = ((AccountingEntities)dbContext).Collect(e.KeyCode.ToString(), rec.Accountid, status.ID);
                    break;

                default:
                    break;
            }
            if (bsCollect.Count > 0)
            {
                ((PopupContainerEdit)gvDetails.ActiveEditor).ShowPopup();
            }
        }
        private void ripceCollect_QueryPopUp(object sender, CancelEventArgs e)
        {
            if (bsCollect == null || bsCollect.Count == 0) { e.Cancel = true; }

            gvCollect.FocusedRowHandle = GridControl.AutoFilterRowHandle;
            gvCollect.FocusedColumn = gvCollect.Columns[0];
        }
        private void ripceCollect_QueryResultValue(object sender, DevExpress.XtraEditors.Controls.QueryResultValueEventArgs e)
        {
            var dr = (Collect)gvCollect.GetRow(gvCollect.FocusedRowHandle);
            if (dr != null)
                e.Value = dr.Document;
        }
        #endregion

        #region onFormFunctions
        protected override void onFormLoadSearchData()
        {
            base.onFormLoadSearchData();
            var _id = currentID;
            bsSearch.DataSource = listJVs((AccountingEntities)dbContext, App.WorkingYear, defaultType);
            de.setPosition<JournalSearchList>(_id);
        }
        protected override void onFormCurrentChanged()
        {
            bsMaster.DataSource = ((JournalSearchList)bsSearch.Current).JV;

            refreshScan();
            updateTotals();
        }
        protected override string onFormGetDeleteString()
        {
            var rec = (Journalparent)bsMaster.Current;
            return string.Format("{0} {1}", cboVoucherTypes.Text, rec.Reference);
        }
        public override Exception onFormCanEdit()
        {
            var rec = (Journalparent)bsMaster.Current;
            var posted = rec.Isposted ?? false;
            if ((bool)posted)
                return new AppException("Posted Record");
            else
                return null;
        }
        protected override void onFormRefresh()
        {
            try
            {
                btnGridAdd.Enabled = btnGridDelete.Enabled = btnGridInsert.Enabled = btnCopyFrom.Enabled = btnSave.Enabled;
            }
            catch (Exception)
            {
            }
        }
        protected override void onShownSetPosition()
        {
            if (_id > 0)
            {
                int rh = gvSearch.LocateByValue("ID", _id);
                if (rh != GridControl.InvalidRowHandle)
                    gvSearch.FocusedRowHandle = rh;
            }
            else
            {
                var vCode = dbContext.Set<Vouchertype>().FirstOrDefault(c => c.Code == defaultType).Code;
                var sc = getDefaultSubCompanyCode();
                //
                gvSearch.SetRowCellValue(GridControl.AutoFilterRowHandle, colSearch, vCode);
                gvSearch.SetRowCellValue(GridControl.AutoFilterRowHandle, colSC, sc);
                gvSearch.MoveLast();
            }
            //
            base.onShownSetPosition();
        }
        private void setAutoFilter()
        {
            string type = string.Empty, sub = string.Empty;
            if (_id > 0)
            {
                int rh = gvSearch.LocateByValue("ID", _id);
                if (rh != GridControl.InvalidRowHandle)
                {
                    gvSearch.FocusedRowHandle = rh;
                    var rec = (vJournalParents)gvSearch.GetFocusedRow();
                    type = dbContext.Set<Vouchertype>().FirstOrDefault(c => c.ID == rec.Vouchertypeid).Code;
                    if (!string.IsNullOrEmpty(rec.SC)) { sub = rec.SC; }
                }
            }
            else
            {
                if (cboVoucherTypes.GetSelectedDataRow() != null) { type = ((ucVoucherTypes)cboVoucherTypes.GetSelectedDataRow()).Code; }
                if (cboSubCompanies.GetSelectedDataRow() != null) { sub = ((SubCompany)cboSubCompanies.GetSelectedDataRow()).Code; }
            }
            gvSearch.SetRowCellValue(GridControl.AutoFilterRowHandle, colSearch, type);
            gvSearch.SetRowCellValue(GridControl.AutoFilterRowHandle, colSC, sub);
            //
            if (_id == -1)
                if (gvSearch.RowCount > 0)
                    gvSearch.MoveLast();
                else
                    bsMaster.Clear();
        }
        protected override void onFormExtraBinding()
        {
            base.onFormExtraBinding();
            bciPosted.DataBindings.Add(new Binding("Checked", this.bsSearch, "isPosted", true));
        }
        protected override void onFormPostSave()
        {
            base.onFormPostSave();
            if (chkPrint.Checked) { btnPrint.PerformClick(); }
            if (chkNew.Checked) { btnNew.PerformClick(); }
        }
        protected override void onFormGetLookupData()
        {
            base.onFormGetLookupData();
            bsCurrencies.DataSource = dbContext.Set<Currency>().OrderBy(c => c.OrderID).ThenBy(c => c.Description).ToList();
            bsBanks.DataSource = getBanks((AccountingEntities)dbContext);
            bsAccounts.DataSource = getAccounts((AccountingEntities)dbContext, null, null);
        }
        protected override bool onFormValidate()
        {
            var rec = (Journalparent)bsMaster.Current;
            if (rec.Journalchilds.Count == 0)
                throw new AppException("Empty Voucher");

            var invalids = rec.Journalchilds.Where(c => c.Accountid == null).ToList();
            foreach (var invalid in invalids) { rec.Journalchilds.Remove(invalid); }

            var childs = rec.Journalchilds
                    .Where(c => c.Currencyid == null
                        || c.Dc == null || c.Dc == ""
                        || c.Description == null || c.Description == ""
                        || (c.Amount + c.Amount1st + c.Amount2nd == 0)).ToList();

            if (childs.Count != 0)
            {
                for (int i = childs.Count - 1; i >= 0; i--)
                {
                    var child = childs[i];

                    if (child.Chartofaccount.Accountstatusid != null)
                        if (child.Chartofaccount.AccountStatu.Code == "A") { childs.Remove(child); }
                }

                if (childs.Count != 0)
                    throw new AppException("Check For Empty Lines !!");
            }

            if (!updateTotals())
                throw new AppException("Unbalanced Voucher");
            return true;
        }
        public override bool onFormValidateRow()
        {
            var jv = (Journalparent)bsMaster.Current;
            var chk = jv.Journalchilds
                .Where(c => c.Accountid == null
                    || c.Currencyid == null
                    || c.Dc == null || c.Dc == "").Count();
            var result = chk == 0;
            if (result) { updateTotals(); }
            return result;
        }
        public override bool onFormAddNewRow(efGridView gv)
        {
            if (base.onFormAddNewRow(gv))
            {
                parent = (Journalparent)bsMaster.Current;
                child = (Journalchild)bsDetails.Current;
                var jc = new Journalchild();
                if (child != null)
                {
                    var line = parent.Journalchilds.Max(c => c.Line) ?? 0;
                    jc.Line = line + 1;
                    jc.Currencyid = child.Currencyid;
                    jc.Ratecurrency = child.Ratecurrency;
                    jc.Amount = child.Amount;
                    jc.Description = jvDescription;
                    jc.Dc = child.Dc == "D" ? "C" : "D";
                    jc.Amount1st = child.Amount1st;
                    jc.Amount2nd = child.Amount2nd;
                }
                else
                {
                    jc.Line = 1;
                    jc.Dc = defaultDc;
                    jc.Description = jvDescription;
                    jc.Amount = jc.Amount1st = jc.Amount2nd = 0;
                }
                jc.Ydate = ((DateTime)parent.Jvdate).Year;
                jc.Mdate = ((DateTime)parent.Jvdate).Month;

                bsDetails.Add(jc);
            }
            gvDetails.FocusedRowHandle = gvDetails.RowCount;
            gvDetails.FocusedColumn = colAccount;
            gvDetails.Focus();
            return true;
        }
        #endregion

        #region Local Form Functions
        public void refreshScan()
        {
            parent = (Journalparent)bsMaster.Current;
            var type = cboVoucherTypes.GetSelectedDataRow();
            var sub = cboSubCompanies.GetSelectedDataRow();
            var exist = false;
            if (parent != null && type != null && sub != null)
                exist = File.Exists(getfileName(parent.ID));
            btnScan.ItemAppearance.Normal.BackColor = exist ? Color.GreenYellow : Color.Transparent;
            btnScan.Border = exist ? DevExpress.XtraEditors.Controls.BorderStyles.Simple : DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
        }
        protected bool updateTotals()
        {
            bool result = true;
            try
            {
                var jc = bsDetails.List.OfType<Journalchild>().ToList();
                txtBalance1st.Properties.AppearanceReadOnly.BackColor = txtBalance2nd.Properties.AppearanceReadOnly.BackColor = Color.LightGreen;
                //
                var d1stAmounts = jc.Where(c => c.Accountid != null & c.Dc == "D").Sum(c => c.Amount1st);
                var c1stAmounts = jc.Where(c => c.Accountid != null & c.Dc == "C").Sum(c => c.Amount1st);
                txtDebit1st.Text = d1stAmounts.ToString();
                txtCredit1st.Text = c1stAmounts.ToString();
                txtBalance1st.Text = (d1stAmounts - c1stAmounts).ToString();
                if (d1stAmounts != c1stAmounts)
                {
                    txtBalance1st.Properties.AppearanceReadOnly.BackColor = Color.LightPink;
                    throw new Exception();
                }
                //
                var d2ndAmounts = jc.Where(c => c.Accountid != null & c.Dc == "D").Sum(c => c.Amount2nd);
                var c2ndAmounts = jc.Where(c => c.Accountid != null & c.Dc == "C").Sum(c => c.Amount2nd);
                txtDebit2nd.Text = d2ndAmounts.ToString();
                txtCredit2nd.Text = c2ndAmounts.ToString();
                txtBalance2nd.Text = (d2ndAmounts - c2ndAmounts).ToString();
                if (d2ndAmounts != c2ndAmounts)
                {
                    txtBalance2nd.Properties.AppearanceReadOnly.BackColor = Color.LightPink;
                    throw new Exception();
                }
                Validate();
            }
            catch (Exception)
            {
                result = false;
            }
            //
            return result;
        }
        private decimal? setCurrencyRate(int currencyid, DateTime jvdate)
        {
            decimal? cRate = 0;
            var rate = dbContext.Set<CurrencyRate>().Where(c => c.Currencyid == currencyid & c.Ratedate <= jvdate).OrderByDescending(c => c.Ratedate).ToList();
            if (rate.Count > 0)
                cRate = rate.FirstOrDefault().Rate;
            else
                cRate = dbContext.Set<Currency>().FirstOrDefault(c => c.ID == currencyid).Rate;
            return cRate;
        }
        private int getNextReference()
        {
            int jvRef = -1;
            parent = (Journalparent)bsMaster.Current;
            if (App.HasSubCompanies)
                jvRef = getMaxReference((AccountingEntities)dbContext, App.WorkingYear, (int)parent.Vouchertypeid, (int)parent.SC) + 1;
            else
                jvRef = getMaxReference((AccountingEntities)dbContext, App.WorkingYear, (int)parent.Vouchertypeid) + 1;
            return jvRef;
        }
        private void colAmountsStatus()
        {
            child = (Journalchild)bsDetails.Current;
            if (child != null)
            {
                if (child.Currencyid == App.LocalCurreny)
                {
                    colAmount1st.OptionsColumn.ReadOnly = true;
                    colAmount2nd.OptionsColumn.ReadOnly = false;
                }
                else if (child.Currencyid == App.ForeignCurreny)
                {
                    colAmount1st.OptionsColumn.ReadOnly = false;
                    colAmount2nd.OptionsColumn.ReadOnly = true;
                }
                else
                {
                    colAmount1st.OptionsColumn.ReadOnly = false;
                    colAmount2nd.OptionsColumn.ReadOnly = false;
                }
            }
        }
        #endregion

        #region C.R.U.D
        protected override void onFormNew()
        {
            parent = (Journalparent)bsMaster.Current;
            var sType = gvSearch.GetRowCellValue(GridControl.AutoFilterRowHandle, colSearch);
            parent.Vouchertypeid = sType == null ? getDefaultVoucherTypeID(defaultType) : getDefaultVoucherTypeID(sType.ToString());

            if (App.HasSubCompanies)
            {
                var sc = gvSearch.GetRowCellValue(GridControl.AutoFilterRowHandle, colSC);
                parent.SC = sc == null ? getDefaultSubCompanyID() : getDefaultSubCompanyID(sc.ToString());
            }

            parent.Reference = getNextReference();
            parent.Jvdate = DateTime.Now;
            parent.Rate2nd = setCurrencyRate(App.ForeignCurreny, DateTime.Now);
            bsMaster.ResetCurrentItem();
            updateTotals();
            cboVoucherTypes.ReadOnly = true; 

            if (App.HasSubCompanies)
            {
                cboSubCompanies.Focus();
              //  cboSubCompanies.Select();
            } // added by samir 30/11
            else
                deDate.Focus();
        }
        protected override void onFormEdit()
        {
            cboVoucherTypes.ReadOnly = true;
            deDate.Focus();
        }
        protected override void onFormSave()
        {
            meDetails.SelectionStart = 0;
            meDetails.ScrollToCaret();

            parent = (Journalparent)bsMaster.Current;
            switch (xState)
            {
                case Enums.State.New:
                    var next = getNextReference();
                    if (parent.Reference != next)
                    {
                        parent.Reference = next;
                        Alert.Show(string.Format("New Reference : {0}", next), "Reference Changed", Enums.AlertType.Information, 10000);
                    }
                    bsMaster.ResetCurrentItem();
                    dbContext.InsertRecord<Journalparent>(parent);
                    break;

                case Enums.State.Edit:
                    dbContext.UpdateRecord<Journalparent>(parent);
                    break;
            }
            gvSearch.SetRowCellValue(GridControl.AutoFilterRowHandle, colSearch, parent.Vouchertype.Code);
            if (App.HasSubCompanies) { gvSearch.SetRowCellValue(GridControl.AutoFilterRowHandle, colSC, getSubCompanyCode((int)parent.SC)); }
            cboVoucherTypes.ReadOnly = false;
        }
        protected override void onFormCancel()
        {
            base.onFormCancel();
            bsDetails.ResetCurrentItem();

            meDetails.SelectionStart = 0;
            meDetails.ScrollToCaret();

            var par = (Journalparent)bsMaster.Current;
            if (par != null)
            {
                var childs = par.Journalchilds.Where(c => c.ID == 0).ToList();
                foreach (var child in childs)
                {
                    par.Journalchilds.Remove(child);
                }
            }
            cboVoucherTypes.ReadOnly = false;
        }
        protected override bool onFormPrint(bool toPrint)
        {
            string jv = string.Empty;
            var rec = (Journalparent)bsMaster.Current;
            if (Name.ToUpper() == "FORMJOURNALVOUCHERS")
                jv = "JV";
            else
                jv = rec.Vouchertype.Code;

            switch (jv)
            {
                case "CN":
                case "RV":
                    using (var rep = new RptOtherVouchers())
                    {
                        rep.bsReport.DataSource = rec.Journalchilds.Where(c => c.Dc == "C").OrderBy(c => c.Line);
                        rep.lblCompany.Text = App.CompanyName;
                        rep.lblTitle.Text = string.Format("{0} # {1}", cboVoucherTypes.Text, rec.Reference.ToString().PadLeft(6, '0'));
                        rep.lblCriteria.Text = string.Empty;

                        Report.show<RptOtherVouchers>(MdiParent as efMainForm, rep, toPrint);
                    }
                    break;

                case "DN":
                case "PV":
                    using (var rep = new RptOtherVouchers())
                    {
                        rep.bsReport.DataSource = rec.Journalchilds.Where(c => c.Dc == "D").OrderBy(c => c.Line);
                        rep.lblCompany.Text = App.CompanyName;
                        rep.lblTitle.Text = string.Format("{0} # {1}", cboVoucherTypes.Text, rec.Reference.ToString().PadLeft(6, '0'));
                        rep.lblCriteria.Text = string.Empty;

                        Report.show<RptOtherVouchers>(MdiParent as efMainForm, rep, toPrint);
                    }
                    break;

                default:
                    using (var rep = new RptJournalVouchers())
                    {
                        rep.bsReport.DataSource = rec.Journalchilds.OrderBy(c => c.Line);
                        rep.lblCompany.Text = App.CompanyName;
                        rep.lblTitle.Text = string.Format("{0}/{1}", cboVoucherTypes.Text, rec.Reference.ToString().PadLeft(6, '0'));
                        rep.lblCriteria.Text = string.Empty;

                        Report.show<RptJournalVouchers>(MdiParent as efMainForm, rep, toPrint);
                    }
                    break;
            }

            return true;
        }
        #endregion

        #region gvDetails
        private void gvDetails_CellValueChanging(object sender, CellValueChangedEventArgs e)
        {
            if (e.Column == colDescription)
                txtDescription.Text = e.Value.ToString();
        }
        private void gvDetails_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            if (e.Column == colAccount || e.Column == colAmount || e.Column == colAmount1st || e.Column == colAmount2nd)
                updateTotals();
        }
        private void gvDetails_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (DesignMode) { return; }
            if (xState == Enums.State.None) { return; }
            //
            colAmountsStatus();
            //
        }
        private void gvDetails_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        {
            if (DesignMode) { return; }
            if (xState == Enums.State.None) { return; }

            parent = (Journalparent)bsMaster.Current;
            child = (Journalchild)bsDetails.Current;
            bool showAlert = false;
            string message = string.Empty;
            //
            colAmountsStatus();
            //
            if (e.FocusedColumn == colDocument && showAlert)
                Alert.Show(message, "Collect !!", Enums.AlertType.Help, 10000);

            if (e.FocusedColumn == colBank)
                Alert.Show("Press [F4] For Banks List", Enums.AlertType.Help);

            if (e.FocusedColumn == colAccount)
                Alert.Show("Press [F4] For Accounts List", Enums.AlertType.Help);
            //
            switch (e.PrevFocusedColumn.FieldName.ToUpper())
            {
                case "ACCOUNTID":
                    if (child.Accountid != null)
                    {
                        dbContext.Entry(child).Reference(p => p.Chartofaccount).Load();
                        if (child.Chartofaccount.Accountstatusid != null)
                        {
                            if (Functions.InList(child.Chartofaccount.AccountStatu.Code, "P", "E"))
                            {
                                showAlert = true;
                                if (child.Chartofaccount.AccountStatu.Code == "P")
                                    Alert.Show("Press [F2] or [F5] to collect Cheques", Enums.AlertType.Help);
                                else if (child.Chartofaccount.AccountStatu.Code == "E")
                                    Alert.Show("Press [F6] to collect Notes", Enums.AlertType.Help);
                            }
                        }
                    }
                    break;

                default:
                    break;
            }
        }
        private void gvDetails_KeyDown(object sender, KeyEventArgs e)
        {
            CancelEventArgs args = new CancelEventArgs(false);
            gvDetails_ShowingEditor(sender, args);
            if (e.KeyData == Keys.Enter && args.Cancel)
            {
                gvDetails.FocusedColumn = gvDetails.VisibleColumns[gvDetails.FocusedColumn.VisibleIndex + 1];
            }
        }
        private void gvDetails_ShownEditor(object sender, EventArgs e)
        {
            if (DesignMode) { return; }
            if (xState == Enums.State.None) { return; }

            gvDetails.ActiveEditor.IsModified = true;
        }
        private void gvDetails_ShowingEditor(object sender, CancelEventArgs e)
        {
            if (DesignMode) { return; }
            if (xState == Enums.State.None) { return; }

            var gv = (efGridView)sender;
            var acc = gv.GetRowCellDisplayText(gv.FocusedRowHandle, colAccount);

            if (gv.FocusedColumn.FieldName.ToUpper() != "ACCOUNTID")
            {
                if (string.IsNullOrEmpty(acc))
                    e.Cancel = true;
                else if (gv.FocusedColumn.FieldName.ToUpper() == "BANKID")
                    if (acc.Substring(0, 1) != "5")
                    {
                        e.Cancel = true;
                    }
            }
        }
        private void gvDetails_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (DesignMode) { return; }
            if (xState == Enums.State.None) { return; }

            var gv = (efGridView)sender;
            if (gv.IsFilterRow(gv.FocusedRowHandle)) { return; }

            child = (Journalchild)bsDetails.Current;
            if (child == null) { return; }
            var result = true;
            try
            {
                switch (gv.FocusedColumn.FieldName.ToUpper())
                {
                    case "DESCRIPTION":
                        child.Description = jvDescription = e.Value.ToString();
                        break;

                    case "ACCOUNTID":
                        if (e.Value == null)
                            result = false;
                        else
                        {
                            child.Accountid = (int)e.Value;
                            dbContext.Entry(child).Reference(p => p.Chartofaccount).Load();

                            if (child.Chartofaccount.AccountStatu == null)
                                isAudit = false;
                            else
                                isAudit = child.Chartofaccount.AccountStatu.Code == "A" ? true : false;

                            if (child.Chartofaccount.Currencyid != null)
                                child.Currencyid = child.Chartofaccount.Currencyid;
                            else
                                child.Currencyid = App.ForeignCurreny;

                            recalculate(child);
                            //showAccountBalance(child);
                        }
                        break;

                    case "AMOUNT":
                    case "CURRENCYID":
                        if (gv.FocusedColumn.FieldName.ToUpper() == "CURRENCYID")
                            child.Currencyid = (int)e.Value;
                        else
                            child.Amount = (decimal)e.Value;

                        recalculate(child);
                        break;

                    case "AMOUNT1ST":
                        child.Amount1st = (decimal)e.Value;
                        break;

                    case "AMOUNT2ND":
                        child.Amount2nd = (decimal)e.Value;
                        break;

                    case "DC":
                        child.Dc = e.Value.ToString();
                        if (string.IsNullOrEmpty(child.Dc))
                            result = false;
                        else
                            updateTotals();
                        break;

                    default:
                        break;
                }

                if (child.Accountid != null) { cboAccounts.EditValue = child.Accountid; }
                if (child.Currencyid != null) { cboCurrencies.EditValue = child.Currencyid; }
                if (child.Bankid != null) { cboBanks.EditValue = child.Bankid; }
                if (child.Ratecurrency != 0) { txtRate.Text = child.Ratecurrency.ToString(); }
            }
            catch (Exception ex)
            {
                Alert.Show(ex.Message, "Access Denied ...", Enums.AlertType.Critical);
                result = false;
            }
            gv.RefreshEditor(true);
            gv.RefreshRow(gv.FocusedRowHandle);
            e.ErrorText = string.Empty;
            e.Valid = result;
            (sender as efGridView).ActiveEditor.IsModified = !result;
        }
        private void recalculate(Journalchild child)
        {
            if (child.Currencyid == null | child.Amount == null) { return; }

            child.Ratecurrency = setCurrencyRate((int)child.Currencyid, (DateTime)parent.Jvdate);
            if (child.Amount != null)
            {
                child.Amount1st = Math.Round(decimal.Parse(child.Amount.ToString()) * (decimal)child.Ratecurrency, 2);
                child.Amount2nd = Math.Round((decimal)(child.Amount1st / parent.Rate2nd), 2);
                updateTotals();
            }
        }
        private void gvDetails_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            if (e.RowHandle < 0 || e.RowHandle == efGridControl.AutoFilterRowHandle) { return; }

            efGridView gv = sender as efGridView;
            var row = (Journalchild)gv.GetRow(e.RowHandle);
            try
            {
                if (row.Accountid != null)
                {
                    // Money Laundry
                    var accstatus = row.Chartofaccount.AccountStatu;
                    if (accstatus != null && accstatus.Code == "P")
                    {
                        var Local1st = decimal.Parse(XML.Read(App.PreferencesFile, "Application", "Ml1stLocal"));
                        var Local2nd = decimal.Parse(XML.Read(App.PreferencesFile, "Application", "Ml2ndLocal"));

                        if ((!string.IsNullOrEmpty(row.Document) && row.Document.Trim().Length < 8) && (row.Amount1st >= Local1st || row.Amount2nd >= Local2nd))
                        {
                            e.Appearance.BackColor = Color.LightYellow;
                            e.Appearance.ForeColor = Color.Red;
                            e.Appearance.Font = new Font(e.Appearance.Font.FontFamily, e.Appearance.Font.Size, FontStyle.Bold);
                        }
                    }
                }

                // DC
                if (e.Appearance.BackColor != Color.LightYellow)
                    e.Appearance.BackColor = row.Dc == "C" ? Color.LavenderBlush : Color.Azure;
            }
            catch (Exception ex)
            {
                //Alert.Show(ex.Message); samir  BU 28/12/2017 
            }
        }
        private void gvDetails_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.RowHandle < 0 || e.RowHandle == efGridControl.AutoFilterRowHandle) { return; }
            efGridView gv = sender as efGridView;

            // Maturity
            if (e.Column == colMaturity)
            {
                if (e.CellValue != null)
                {
                    if ((DateTime)e.CellValue <= ((DateTime)deDate.EditValue))
                        e.Column.AppearanceCell.ForeColor = Color.Red;
                }
            }
        }

        #region Move Details Row
        private void gvDetails_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
                pmGrid.ShowPopup(PointToScreen(new Point(e.X, e.Y)));
        }
        private void bbiMoveUP_ItemClick(object sender, ItemClickEventArgs e)
        {
            var cRec = (Journalchild)bsDetails.Current;
            if (cRec.Line == 1) { return; }

            var pRec = bsDetails.List.OfType<Journalchild>().FirstOrDefault(c => c.Line == cRec.Line - 1);
            gvDetails.Columns[0].SortOrder = DevExpress.Data.ColumnSortOrder.None;
            cRec.Line -= 1;
            pRec.Line += 1;
            gvDetails.Columns[0].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;

            dbContext.SaveChanges();
        }
        private void bbiMoveDOWN_ItemClick(object sender, ItemClickEventArgs e)
        {
            var cRec = (Journalchild)bsDetails.Current;
            if (cRec.Line == bsDetails.Count) { return; }

            var pRec = bsDetails.List.OfType<Journalchild>().FirstOrDefault(c => c.Line == cRec.Line + 1);
            gvDetails.Columns[0].SortOrder = DevExpress.Data.ColumnSortOrder.None;
            cRec.Line += 1;
            pRec.Line -= 1;
            gvDetails.Columns[0].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;

            dbContext.SaveChanges();
        }
        private void beMoveTO_EditValueChanged(object sender, EventArgs e)
        {
            var val = int.Parse(beMoveTO.EditValue.ToString());
            if (val > bsDetails.Count | val < 0) { return; }
            var cRec = (Journalchild)bsDetails.Current;
            var pRec = bsDetails.List.OfType<Journalchild>().FirstOrDefault(c => c.Line == val);
            gvDetails.Columns[0].SortOrder = DevExpress.Data.ColumnSortOrder.None;
            pRec.Line = cRec.Line;
            cRec.Line = val;
            gvDetails.Columns[0].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;

            dbContext.SaveChanges();
        }
        private void bbiInsert_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (xState != Enums.State.New & xState != Enums.State.Edit) { return; }

            var cRec = (Journalchild)bsDetails.Current;
            var cLine = cRec.Line;
            var pRecs = bsDetails.List.OfType<Journalchild>().Where(c => c.Line >= cLine).ToList();
            foreach (var pRec in pRecs)
                pRec.Line += 1;

            var jc = new Journalchild() { Line = cLine, Dc = "D", Amount = 0, Amount1st = 0, Amount2nd = 0 };
            bsDetails.Add(jc);
        }
        #endregion

        #endregion

        #region Form Controls
        private void cboVoucherTypes_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
        }
        private void cboVoucherTypes_EditValueChanged(object sender, EventArgs e)
        {
            if (cboVoucherTypes.EditValue == null || string.IsNullOrEmpty(cboVoucherTypes.Text)) { return; }

            switch (xState)
            {
                case Enums.State.None:
                    setAutoFilter();
                    break;

                case Enums.State.New:
                    parent = (Journalparent)bsMaster.Current;
                    parent.Reference = getNextReference();
                    break;
            }
        }
        private void cboSubCompanies_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
        }
        private void cboSubCompanies_EditValueChanged(object sender, EventArgs e)
        {
            if (cboSubCompanies.EditValue == null || string.IsNullOrEmpty(cboSubCompanies.Text)) { return; }
            switch (xState)
            {
                case Enums.State.None:
                    setAutoFilter();
                    break;

                case Enums.State.New:
                    parent = (Journalparent)bsMaster.Current;
                    parent.SC = (int)cboSubCompanies.EditValue;
                    parent.Reference = getNextReference();
                    break;
            }
        }
        private void deDate_Validating(object sender, CancelEventArgs e)
        {
            if (xState == Enums.State.None) { return; }

            var date = (DateTime)deDate.EditValue;
            if (date.Year != App.WorkingYear)
            {
                Alert.Show(string.Format("You are working in {0}", App.WorkingYear), Enums.AlertType.Warning);
                deDate.EditValue = new DateTime(App.WorkingYear, 1, 1);
            }
        }
        private void deDate_Validated(object sender, EventArgs e)
        {
            if (xState == Enums.State.None) { return; }

            var rec = (Journalparent)bsMaster.Current;
            var date = (DateTime)rec.Jvdate;
            rec.Rate2nd = setCurrencyRate(App.ForeignCurreny, date);
            bsMaster.ResetCurrentItem();

            if (xState == Enums.State.New)
            {
                if (gvDetails.RowCount == 0)
                    onFormAddNewRow(null);
                gvDetails.ShowEditor();
            }
        }
        private void bsDetails_PositionChanged(object sender, EventArgs e)
        {
            foreach (AlertForm form in accBalances.AlertFormList) { form.Close(); }
            //
            var rec = (Journalchild)bsDetails.Current;
            if (rec == null || rec.Accountid == null) { return; }

            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Cur : {0,18:0,0.00}", rec.TrialBalance.Balance).AppendLine();
            sb.AppendFormat("1st : {0,18:0,0.00}", rec.TrialBalance.Balance1st).AppendLine();
            sb.AppendFormat("2nd : {0,18:0,0.00}", rec.TrialBalance.Balance2nd);
            //
            accBalances.Show(this, rec.Chartofaccount.Code.PadLeft(24, ' '), sb.ToString());
        }
        private void riCurrencies_EditValueChanged(object sender, EventArgs e)
        {
            gvDetails.CloseEditor();
            gvDetails.PostEditor();
            gvDetails.ShowEditor();
        }
        private void txtReference_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (xState != Enums.State.None) { return; }
            if (App.UserGroupID != App.AdminGroupID) { return; }

            if (e.Button.Index == 0)
            {
                try
                {
                    parent = (Journalparent)bsMaster.Current;
                    var value = string.Empty;
                    var dr = Functions.InputBox("Enter New Reference", "Reference", ref value);
                    if (dr != System.Windows.Forms.DialogResult.OK) { return; }

                    var newRef = int.Parse(value);
                    var jp = dbContext.Set<Journalparent>()
                        .Where(c => c.Vouchertypeid == (int)cboVoucherTypes.EditValue & c.Reference == newRef & c.YDate == App.WorkingYear)
                        .FirstOrDefault();
                    if (jp != null) { throw new Exception("Reference Already In Use !!!"); }

                    int maxRef = getMaxReference((AccountingEntities)dbContext, App.WorkingYear, (int)cboVoucherTypes.EditValue);
                    if (newRef > maxRef) { throw new Exception("Invalid Reference !!!"); }

                    parent.Reference = newRef;
                    dbContext.UpdateRecord<Journalparent>(parent);

                    onFormLoadSearchData();
                }
                catch (Exception ex)
                {
                    Alert.Show(ex.Message);
                }
            }
        }
        #endregion

        #region Toolbars Buttons
        private void btnCopyFrom_ItemClick(object sender, ItemClickEventArgs e)
        {
            AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            try
            {
                Journalparent jp = null;
                var rec = (Journalparent)bsMaster.Current;
                using (var form = new FormImportVoucher() { jvType = (int)cboVoucherTypes.EditValue })
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK) { jp = form.jp; }

                    if (jp != null)
                    {
                        var jvs = jp.Journalchilds.Select(c =>
                            new Journalchild
                            {
                                Accountid = c.Accountid,
                                Document = c.Document,
                                Maturity = c.Maturity,
                                Currencyid = c.Currencyid,
                                Amount = c.Amount,
                                Dc = c.Dc,
                                Description = c.Description,
                                Bankid = c.Bankid,
                                Amount1st = c.Amount1st,
                                Amount2nd = c.Amount2nd
                            });


                        var invalids = rec.Journalchilds.Where(c => c.Accountid == null).ToList();
                        foreach (var invalid in invalids) { rec.Journalchilds.Remove(invalid); }

                        if (rec.Journalchilds.Count == 0)
                        {
                            txtFromTo.Text = jp.Fromto;
                            meDetails.Text = jp.Details;
                        }

                        foreach (var jv in jvs)
                        {
                            var line = bsDetails.List.OfType<Journalchild>().Max(c => c.Line) ?? 0;
                            jv.Line = line + 1;
                            bsDetails.Add(jv);
                        }
                    }
                }
                updateTotals();
                Refresh();
            }
            catch (Exception ex)
            {
                Alert.ShowMessage(string.Format("{0}\n\r{1}", ex.Message, ex.StackTrace));
            }
            AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
        }
        private void bbiImportPDF_ItemClick(object sender, ItemClickEventArgs e)
        {
            PdfDocumentProcessor pdp = new PdfDocumentProcessor();
            var pdf = getfileName(parent.ID);

            if (!File.Exists(pdf))
                pdp.CreateEmptyDocument(pdf);
            else
                pdp.LoadDocument(pdf);


            openFileDialog.DefaultExt = "PDF";
            openFileDialog.ShowDialog();
            var PDFi = openFileDialog.FileName;

            pdp.AppendDocument(PDFi);
            pdp.SaveDocument(pdf);
        }
        private void btnGridAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            onFormAddNewRow(gvDetails);
        }
        private void btnGridDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            var par = (Journalparent)bsMaster.Current;
            var rec = (Journalchild)bsDetails.Current;
            var line = rec.Line;
            par.Journalchilds.Remove(rec);

            foreach (var p in par.Journalchilds)
            {
                if (p.Line < line) { continue; }
                p.Line -= 1;
                gvDetails.RefreshEditor(true);
            }

            updateTotals();
        }
        private void btnGridInsert_ItemClick(object sender, ItemClickEventArgs e)
        {
            bbiInsert.PerformClick();
        }
        private void btnScan_ItemClick(object sender, ItemClickEventArgs e)
        {
            parent = (Journalparent)bsMaster.Current;
            var type = cboVoucherTypes.GetSelectedDataRow();
            var sub = cboSubCompanies.GetSelectedDataRow();
            ucScan sc = new ucScan(this, getfileName(parent.ID));
        }
        #endregion

        #region Collect Documents
        private void gcCollect_DoubleClick(object sender, EventArgs e)
        {
            pccCollect.OwnerEdit.ClosePopup();
        }
        private void gcCollect_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                pccCollect.OwnerEdit.ClosePopup();
        }
        #endregion
    }
}
