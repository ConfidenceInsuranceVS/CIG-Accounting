using System;
using System.IO;
using System.Linq;
using System.Data.Entity;
using System.Windows.Forms;
using System.ComponentModel;
using DevExpress.XtraBars;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using System.Collections.Generic;
using System.Drawing;

namespace efControls
{
    public partial class efDataForm : efBaseForm
    {
        #region Variables
        public DbContext dbContext;
        public bool isSecurity = false;
        protected FileStream fLock;
        protected string delString = "Are you sure you want to delete {0} ?";
        public bool loadMaster;
        public string lockName;
        protected internal int currentID = -1;
        #endregion
        //
        #region xProperties
        [Category("xProperties"), Browsable(true)]
        public efGridView PrintableGrid { get; set; }

        [Category("xProperties"), Browsable(true)]
        public efGridView NavigationGrid { get; set; }

        [Category("xProperties"), Browsable(true)]
        public string ReportTitle { get; set; }
        #endregion
        //
        public efDataForm()
        {
            InitializeComponent();
            lockName = Name;
        }
        //
        #region System Overrides
        protected override void OnLoad(EventArgs e)
        {
            if (base.DesignMode) { return; }
            if (!sccMain.Horizontal)
                sccMain.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1;
            //
            base.OnLoad(e);
            xState = Enums.State.None;
            LoadData();
            onFormExtraBinding();
        }
        protected override void OnShown(EventArgs e)
        {
            if (base.DesignMode) { return; }
            //
            onShownSetPosition();
            base.OnShown(e);
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (xState != Enums.State.None) { e.Cancel = true; }
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            de = null;
        }
        #endregion
        //
        #region Form Virtuals
        protected virtual void onFormRowChanged() { de.showUserInfo(bsMaster.Current); }
        protected virtual void onFormExtraBinding()
        {
            bsiCreatedBy.DataBindings.Add(new Binding("Caption", this.bsSearch, "CreatedBy", true));
            bsiModifiedBy.DataBindings.Add(new Binding("Caption", this.bsSearch, "ModifiedBy", true));
        }
        protected virtual void onShownSetPosition() { }
        protected virtual void onFormGetLookupData() { dbContext = de.getDbContext(isSecurity); }
        protected virtual void onFormLoadSearchData() { dbContext = de.getDbContext(isSecurity); }
        protected virtual void onFormGetMasterData() { }
        protected virtual void onFormFocus() { }
        protected virtual void onFormRefresh() { }
        protected virtual bool onFormValidate() { return ValidateChildren(ValidationConstraints.Enabled); }
        protected virtual string onFormGetDeleteString() { return string.Empty; }
        //protected virtual DbContext getDbContext() { return null; }
        public virtual bool onFormValidateRow() { return false; }
        public virtual Exception onFormCanEdit() { return null; }
        public virtual bool onFormCanDelete() { return true; }
        public virtual bool onFormAddNewRow(efGridView gv)
        {
            var result = false;
            if (gv == null)
                result = true;
            else
            {
                gv.ValidateEditor();
                result = onFormValidateRow();
            }
            return result;
        }
        #endregion

        #region C.R.U.D

        #region xNew
        protected virtual void onFormNew() { }
        private void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            clearValidation();
            ActiveControl = lcMain;
            try
            {
                if (!AllowAdd & App.UserLevel != 1) { throw new PrivilegeException(); }

                if (bsMaster != null)
                {
                    sccMain.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Both;
                    xState = Enums.State.New;
                    bsMaster.AddNew();
                    onFormNew();
                }
            }
            catch (Exception ex)
            {
                Alert.ShowMessage(string.Format("{0}\n\r{1}", ex.Message, ex.StackTrace));
                xState = Enums.State.None;
            }
            AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            bsiCreatedBy.Visibility = bsiModifiedBy.Visibility = BarItemVisibility.Never;
        }
        #endregion

        #region xEdit
        protected virtual void onFormEdit() { de.xEdit(); }
        private void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            clearValidation();
            try
            {
                if (!AllowEdit & App.UserLevel != 1) { throw new PrivilegeException(); }
                currentID = ((ITableAll)bsMaster.Current).ID;
                checkAvailability(currentID);

                var err = onFormCanEdit();
                if (err == null)
                {
                    fLock = Lock.RecordLock(lockName, ((ITableAll)bsMaster.Current).ID);
                    //
                    xState = Enums.State.Edit;
                    sccMain.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Both;
                    onFormEdit();
                }
                else
                    throw err;
            }
            catch (NotFoundException ex)
            {
                Alert.Show(ex.Message, "Record Not Found !!!", Enums.AlertType.Critical);
            }
            catch (AppException ex)
            {
                Alert.Show(ex.Message, Enums.AlertType.None);
            }
            catch (Exception ex)
            {
                Alert.ShowMessage(string.Format("{0}\n\r{1}", ex.Message, ex.StackTrace));
                if (fLock != null) { fLock.Close(); }
                xState = Enums.State.None;
                e.Link.Focus();
            }
            AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
        }
        #endregion

        #region xDelete
        protected virtual void onFormDelete() { de.xDelete(); }
        private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            lcMain.Enabled = false;
            try
            {
                if (!AllowDelete) { throw new PrivilegeException(); }
                checkAvailability(((ITableAll)bsMaster.Current).ID);
                //
                if (onFormCanDelete())
                {
                    fLock = Lock.RecordLock(lockName, ((ITableAll)bsMaster.Current).ID);
                    //
                    var yn = Alert.ShowDialogMessage(string.Format(delString, onFormGetDeleteString()));
                    if (yn == DialogResult.Yes)
                    {
                        xState = Enums.State.Delete;
                        onFormDelete();
                        NavigationGrid.DeleteRow(NavigationGrid.FocusedRowHandle);
                    }
                }
                else
                    Alert.Show("Cannot Delete", Enums.AlertType.Warning);
            }
            catch (NotFoundException ex)
            {
                Alert.Show(ex.Message, "Record Not Found !!!", Enums.AlertType.Critical);
                //LoadData();
            }
            catch (Exception ex)
            {
                Alert.ShowMessage(string.Format("{0}\n\r{1}", ex.Message, ex.StackTrace));
            }

            if (fLock != null) { fLock.Close(); }
            showCurrentRow();
            xState = Enums.State.None;
            lcMain.Enabled = true;
        }
        #endregion

        #region xSave
        protected virtual void onFormSave() { de.xSave(); }
        protected virtual void onFormPostSave() { }
        private void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                //PostEditors(this);
                if (lcMain.ActiveControl != null & lcMain.ActiveControl.GetType() == typeof(efGridControl))
                     foreach (efGridView gv in ((efGridControl)lcMain.ActiveControl).Views) { if (gv.OptionsBehavior.ReadOnly == false) { gv.PostEditor(); } }

                var aa = ValidationProvider.GetInvalidControls();
                if (!ValidationProvider.Validate())
                    throw new AppException("Validation Error !!");

                if (onFormValidate())
                {
                    lblFocus.Focus();
                    bsMaster.EndEdit();
                    //
                    clearValidation();
                    onFormSave();
                    //
                    if (fLock != null) { fLock.Close(); }
                    xState = Enums.State.None;
                    //
                    currentID = ((ITableAll)bsMaster.Current).ID;
                    onFormLoadSearchData();
                    onFormPostSave();
                    de.showUserInfo(bsMaster.Current);
                    if (!sccMain.Horizontal)
                        sccMain.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1;
                }
            }
            catch (AppException ex)
            {
                Alert.Show(ex.Message, Enums.AlertType.Warning);
            }
            catch (Exception ex)
            {
                Alert.ShowMessage(string.Format("{0}\n\r{1}", ex.Message, ex.StackTrace));
            }
            showCurrentRow();
            Cursor = Cursors.Default;
        }
        #endregion

        #region xCancel
        protected virtual void onFormCancel() { de.xRefreshContext(); }
        private void btnCancel_ItemClick(object sender, ItemClickEventArgs e)
        {
            AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            var oldState = xState;
            try
            {
                clearValidation();
                //
                if (dbContext.ChangeTracker.HasChanges())
                {
                    if (Alert.ShowDialogMessage("Are you sure you want to cancel and loose the typed data ?") != System.Windows.Forms.DialogResult.Yes)
                        throw new Exception();
                }
                bsMaster.CancelEdit();
                onFormCancel();
                //
                xState = Enums.State.None;
                onFormLoadSearchData();
                //
                if (fLock != null) { fLock.Close(); }
                de.showUserInfo(bsMaster.Current);
                if (!sccMain.Horizontal)
                    sccMain.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1;
            }
            catch (Exception)
            {
                xState = oldState;
            }
            showCurrentRow();
            AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
        }
        #endregion

        #region xPrint
        protected virtual bool onFormPrint(bool toPrint) { return false; }
        private void btnPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            print(false);
        }
        private void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            print(true);
        }
        private void print(bool toPrint)
        {
            try
            {
                if (bsMaster == null | bsMaster.Count == 0) { throw new Exception("End Of File, Nothing To Print !!!"); }
                checkAvailability(((ITableAll)bsMaster.Current).ID);
                //
                fLock = Lock.RecordLock(lockName, ((ITableAll)bsMaster.Current).ID);
                //
                if (!onFormPrint(toPrint))
                    gridPrintPreview((efGridView)PrintableGrid);
                    //((efGridView)PrintableGrid).ShowPrintPreview();
            }
            catch (Exception ex)
            {
                Alert.Show(ex.Message, "Cannot Print...", Enums.AlertType.Warning);
            }
            if (fLock != null) { fLock.Close(); }
            showCurrentRow();
        }
        #endregion

        #region xExit
        protected virtual void onFormExit() { }
        private void btnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            onFormExit();
            Close();
        }
        #endregion
        #endregion

        #region Refresh Data
        protected virtual void checkAvailability(int id)
        {
            if (bsMaster == null | bsMaster.Count == 0)
                throw new Exception("End Of File, Nothing To Do !!!");

            if (!de.xRecordExist(id))
                throw new NotFoundException();

            onFormLoadSearchData();
        }
        protected virtual void LoadData()
        {
            //
            onFormGetLookupData();
            onFormLoadSearchData();
            //
            RefreshControl(this);
            //
            showCurrentRow();
        }
        private void showCurrentRow()
        {
            var gv = (efGridView)NavigationGrid;
            if (gv.IsRowVisible(gv.FocusedRowHandle) == RowVisibleState.Hidden)
                gv.MakeRowVisible(gv.FocusedRowHandle);
        }
        #endregion
        //
        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (xState != Enums.State.None | bsMaster.Current == null) { return; }
            LoadData();
            bsSearch.ResetBindings(false);
            bsMaster.ResetBindings(false);
        }
        protected void ControlValidate(Control c)
        {
            if (!isActiveForm()) { return; }

            var cvr = (ConditionValidationRule)ValidationProvider.GetValidationRule(c);
            if (cvr != null)
            {
                cvr.Value1 = c.Text;
                ValidationProvider.SetValidationRule(c, cvr);
                ValidationProvider.Validate(c);
            }
        }
        protected void ControlValidate(Control c, string error)
        {
            if (!isActiveForm()) { return; }

            var cvr = (ConditionValidationRule)ValidationProvider.GetValidationRule(c);
            if (cvr != null)
            {
                //cvr.Value1 = c.Text;
                cvr.ErrorText = error;
                ValidationProvider.SetValidationRule(c, cvr);
                ValidationProvider.Validate(c);
            }
        }
        protected override void FormRefresh()
        {
            RefreshControl(this);

            switch (xState)
            {
                case Enums.State.New:
                case Enums.State.Edit:
                    lcSearch.Enabled = btnNew.Enabled = btnEdit.Enabled = btnDelete.Enabled 
                        = btnPrint.Enabled = btnExit.Enabled = false;
                    lcMain.Enabled = btnSave.Enabled = btnCancel.Enabled = true;
                    break;
                case Enums.State.None:
                case Enums.State.Empty:
                case Enums.State.Delete:
                    lcMain.Enabled = lcSearch.Enabled = btnNew.Enabled 
                        = btnEdit.Enabled = btnDelete.Enabled = btnPrint.Enabled = btnExit.Enabled = true;
                    btnSave.Enabled = btnCancel.Enabled = false;
                    break;
                default:
                    lcMain.Enabled = btnNew.Enabled = btnEdit.Enabled = btnDelete.Enabled =
                    btnPrint.Enabled = btnExit.Enabled = btnSave.Enabled = btnCancel.Enabled = false;
                    break;
            }
            onFormRefresh();
        }
        protected void getNextCode<T>(GridView gv, DevExpress.XtraGrid.Columns.GridColumn col) where T : class, ITableCode
        {
            col.SortOrder = DevExpress.Data.ColumnSortOrder.None;
            var rec = (T)bsMaster.Current;
            var code = dbContext.Set<T>().Max(c => c.Code);
            if (code == null)
                rec.Code = "1";
            else
                rec.Code = (int.Parse(code) + 1).ToString();

            gv.RefreshEditor(true);
            col.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
        }

        private void gridPrintPreview(efGridView gv)
        {
            PrintingSystem ps = new PrintingSystem();
            PrintableComponentLink pcl = new PrintableComponentLink(ps) { Component = gv.GridControl };
            PageHeaderFooter phf = pcl.PageHeaderFooter as PageHeaderFooter;

            // Clear the PageHeaderFooter's contents.
            phf.Header.Content.Clear();

            // Add custom information to the link's header.
            phf.Header.Content.AddRange(new string[] { string.Empty, ReportTitle, "[Date Printed] [Time Printed]" });
            phf.Header.LineAlignment = BrickAlignment.Far;

            var parent = MdiParent as efMainForm;
            efPrintPreview pf = new efPrintPreview(parent);
            pf.bbiSettings.Visibility = BarItemVisibility.Never;
            pf.documentViewer.PrintingSystem = ps;
            pcl.CreateDocument();
            pf.ShowDialog(parent);
        }
        private void bciPosted_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            var rec = (ITablePosted)bsMaster.Current;
            e.Item.Visibility = (bool)rec.Isposted ? BarItemVisibility.Never : BarItemVisibility.Always;
        }
    }
}
