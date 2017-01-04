namespace Accounting
{
    partial class FormJournalChecker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJournalChecker));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.lcMain = new efControls.efLayoutControl();
            this.ucControlNavigator1 = new efControls.ucControlNavigator();
            this.gcResult = new DevExpress.XtraGrid.GridControl();
            this.bsResult = new System.Windows.Forms.BindingSource(this.components);
            this.gvResult = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colChecked = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colResult = new DevExpress.XtraGrid.Columns.GridColumn();
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.txtAmount = new DevExpress.XtraEditors.TimeEdit();
            this.rgDT = new efControls.efRadioGroup();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.StatusBar = new DevExpress.XtraBars.Bar();
            this.bciShowResults = new DevExpress.XtraBars.BarCheckItem();
            this.bciCheckAll = new DevExpress.XtraBars.BarCheckItem();
            this.bbiConfirm = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveChecked = new DevExpress.XtraBars.BarButtonItem();
            this.bbiExit = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.cboUsers = new efControls.efComboBox();
            this.bsUsers = new System.Windows.Forms.BindingSource(this.components);
            this.cboAccount = new Accounting.cboAccounts();
            this.cboAccountView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.rgChecker = new efControls.efRadioGroup();
            this.cboVoucherTypes = new Accounting.cboVoucherTypes();
            this.lcg = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciVoucherType = new efControls.lci();
            this.lcgCriteria = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciRgChecker = new efControls.lci();
            this.lciUser = new efControls.lci();
            this.lciDateTime = new efControls.lci();
            this.lciAmount = new efControls.lci();
            this.lciAccount = new efControls.lci();
            this.lciResult = new efControls.lci();
            this.lci1 = new efControls.lci();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboUsers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAccount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAccountView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgChecker.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboVoucherTypes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciVoucherType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgCriteria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRgChecker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDateTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci1)).BeginInit();
            this.SuspendLayout();
            // 
            // ValidationProvider
            // 
            this.ValidationProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.ucControlNavigator1);
            this.lcMain.Controls.Add(this.txtAmount);
            this.lcMain.Controls.Add(this.rgDT);
            this.lcMain.Controls.Add(this.cboUsers);
            this.lcMain.Controls.Add(this.gcResult);
            this.lcMain.Controls.Add(this.cboAccount);
            this.lcMain.Controls.Add(this.rgChecker);
            this.lcMain.Controls.Add(this.cboVoucherTypes);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 0);
            this.lcMain.Name = "lcMain";
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(957, 132, 524, 683);
            this.lcMain.Root = this.lcg;
            this.lcMain.Size = new System.Drawing.Size(689, 373);
            this.lcMain.TabIndex = 18;
            this.lcMain.Text = "efLayoutControl1";
            // 
            // ucControlNavigator1
            // 
            this.ucControlNavigator1.AlwaysEnabled = false;
            this.ucControlNavigator1.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.ucControlNavigator1.Appearance.Options.UseBackColor = true;
            this.ucControlNavigator1.Location = new System.Drawing.Point(194, 342);
            this.ucControlNavigator1.MaximumSize = new System.Drawing.Size(0, 26);
            this.ucControlNavigator1.MinimumSize = new System.Drawing.Size(185, 26);
            this.ucControlNavigator1.Name = "ucControlNavigator1";
            this.ucControlNavigator1.NavigatableControl = this.gcResult;
            this.ucControlNavigator1.Size = new System.Drawing.Size(490, 26);
            this.ucControlNavigator1.TabIndex = 33;
            // 
            // gcResult
            // 
            this.gcResult.DataSource = this.bsResult;
            this.gcResult.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.gcResult.Location = new System.Drawing.Point(194, 29);
            this.gcResult.MainView = this.gvResult;
            this.gcResult.Name = "gcResult";
            this.gcResult.Size = new System.Drawing.Size(490, 309);
            this.gcResult.TabIndex = 29;
            this.gcResult.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvResult});
            // 
            // bsResult
            // 
            this.bsResult.DataSource = typeof(Accounting.voucherChecker);
            // 
            // gvResult
            // 
            this.gvResult.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colChecked,
            this.colResult});
            this.gvResult.GridControl = this.gcResult;
            this.gvResult.Images = this.imageCollection;
            this.gvResult.Name = "gvResult";
            this.gvResult.OptionsView.ColumnAutoWidth = false;
            this.gvResult.OptionsView.EnableAppearanceEvenRow = true;
            this.gvResult.OptionsView.ShowGroupPanel = false;
            this.gvResult.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gvResult.OptionsView.ShowIndicator = false;
            this.gvResult.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gvResult.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colResult, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvResult.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gvResult_RowCellClick);
            // 
            // colChecked
            // 
            this.colChecked.AppearanceHeader.Options.UseTextOptions = true;
            this.colChecked.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colChecked.Caption = " ";
            this.colChecked.FieldName = "Ischecked";
            this.colChecked.ImageIndex = 1;
            this.colChecked.Name = "colChecked";
            this.colChecked.Visible = true;
            this.colChecked.VisibleIndex = 0;
            this.colChecked.Width = 30;
            // 
            // colResult
            // 
            this.colResult.AppearanceCell.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colResult.AppearanceCell.Options.UseFont = true;
            this.colResult.FieldName = "Result";
            this.colResult.Name = "colResult";
            this.colResult.OptionsColumn.AllowEdit = false;
            this.colResult.OptionsColumn.FixedWidth = true;
            this.colResult.OptionsColumn.ReadOnly = true;
            this.colResult.Visible = true;
            this.colResult.VisibleIndex = 1;
            this.colResult.Width = 450;
            // 
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.InsertGalleryImage("loadfrom_16x16.png", "office2013/actions/loadfrom_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/loadfrom_16x16.png"), 0);
            this.imageCollection.Images.SetKeyName(0, "loadfrom_16x16.png");
            this.imageCollection.InsertGalleryImage("checkbox_16x16.png", "office2013/content/checkbox_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/content/checkbox_16x16.png"), 1);
            this.imageCollection.Images.SetKeyName(1, "checkbox_16x16.png");
            this.imageCollection.InsertGalleryImage("save_16x16.png", "office2013/save/save_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/save/save_16x16.png"), 2);
            this.imageCollection.Images.SetKeyName(2, "save_16x16.png");
            // 
            // txtAmount
            // 
            this.txtAmount.EditValue = new System.DateTime(2017, 1, 4, 0, 0, 0, 0);
            this.txtAmount.Enabled = false;
            this.txtAmount.Location = new System.Drawing.Point(131, 334);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtAmount.Properties.Mask.EditMask = "HH:mm";
            this.txtAmount.Size = new System.Drawing.Size(56, 20);
            this.txtAmount.StyleController = this.lcMain;
            this.txtAmount.TabIndex = 32;
            this.txtAmount.ToolTip = "fill time HH:mm";
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Required!";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.ValidationProvider.SetValidationRule(this.txtAmount, conditionValidationRule1);
            // 
            // rgDT
            // 
            this.rgDT.Enabled = false;
            this.rgDT.Location = new System.Drawing.Point(8, 334);
            this.rgDT.MenuManager = this.barManager;
            this.rgDT.Name = "rgDT";
            this.rgDT.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgDT.Properties.Appearance.Options.UseBackColor = true;
            this.rgDT.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rgDT.Properties.Columns = 2;
            this.rgDT.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Days"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Time")});
            this.rgDT.Size = new System.Drawing.Size(106, 23);
            this.rgDT.StyleController = this.lcMain;
            this.rgDT.TabIndex = 31;
            this.rgDT.SelectedIndexChanged += new System.EventHandler(this.rgDT_SelectedIndexChanged);
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.StatusBar});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Images = this.imageCollection;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.bciShowResults,
            this.bciCheckAll,
            this.bbiConfirm,
            this.bbiSaveChecked,
            this.bbiExit});
            this.barManager.MaxItemId = 8;
            this.barManager.StatusBar = this.StatusBar;
            // 
            // StatusBar
            // 
            this.StatusBar.BarName = "Status bar";
            this.StatusBar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.StatusBar.DockCol = 0;
            this.StatusBar.DockRow = 0;
            this.StatusBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.StatusBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bciShowResults),
            new DevExpress.XtraBars.LinkPersistInfo(this.bciCheckAll, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiConfirm, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiSaveChecked, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiExit, true)});
            this.StatusBar.OptionsBar.AllowQuickCustomization = false;
            this.StatusBar.OptionsBar.DrawDragBorder = false;
            this.StatusBar.OptionsBar.UseWholeRow = true;
            this.StatusBar.Text = "Status bar";
            // 
            // bciShowResults
            // 
            this.bciShowResults.Caption = "Show Checked Results";
            this.bciShowResults.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.bciShowResults.Id = 3;
            this.bciShowResults.Name = "bciShowResults";
            // 
            // bciCheckAll
            // 
            this.bciCheckAll.Caption = "Check ALL";
            this.bciCheckAll.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.bciCheckAll.Id = 4;
            this.bciCheckAll.Name = "bciCheckAll";
            // 
            // bbiConfirm
            // 
            this.bbiConfirm.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bbiConfirm.Caption = "Confirm";
            this.bbiConfirm.Id = 5;
            this.bbiConfirm.ImageIndex = 1;
            this.bbiConfirm.Name = "bbiConfirm";
            this.bbiConfirm.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiConfirm.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiConfirm_ItemClick);
            // 
            // bbiSaveChecked
            // 
            this.bbiSaveChecked.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bbiSaveChecked.Caption = "&Save Checked";
            this.bbiSaveChecked.Id = 6;
            this.bbiSaveChecked.ImageIndex = 2;
            this.bbiSaveChecked.Name = "bbiSaveChecked";
            this.bbiSaveChecked.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiSaveChecked.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSaveChecked_ItemClick);
            // 
            // bbiExit
            // 
            this.bbiExit.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bbiExit.Caption = "&Exit";
            this.bbiExit.Id = 7;
            this.bbiExit.ImageIndex = 0;
            this.bbiExit.Name = "bbiExit";
            this.bbiExit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiExit_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(689, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 373);
            this.barDockControlBottom.Size = new System.Drawing.Size(689, 27);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 373);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(689, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 373);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // cboUsers
            // 
            this.cboUsers.DefaultState = efControls.Enums.ControlState.AlwaysEnabled;
            this.cboUsers.Enabled = false;
            this.cboUsers.EnterMoveNextControl = true;
            this.cboUsers.Location = new System.Drawing.Point(35, 294);
            this.cboUsers.MenuManager = this.barManager;
            this.cboUsers.Name = "cboUsers";
            this.cboUsers.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboUsers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboUsers.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.cboUsers.Properties.DataSource = this.bsUsers;
            this.cboUsers.Properties.DisplayMember = "Name";
            this.cboUsers.Properties.Name = "efComboBox";
            this.cboUsers.Properties.NullText = "";
            this.cboUsers.Properties.NullValuePrompt = "Select User";
            this.cboUsers.Properties.NullValuePromptShowForEmptyValue = true;
            this.cboUsers.Properties.ValueMember = "ID";
            this.cboUsers.Size = new System.Drawing.Size(152, 20);
            this.cboUsers.StyleController = this.lcMain;
            this.cboUsers.TabIndex = 30;
            // 
            // bsUsers
            // 
            this.bsUsers.DataSource = typeof(efControls.Data.User);
            // 
            // cboAccount
            // 
            this.cboAccount.AccountStatusFlag = null;
            this.cboAccount.bs = null;
            this.cboAccount.DefaultState = efControls.Enums.ControlState.Default;
            this.cboAccount.DropdownWidth = 0;
            this.cboAccount.EnterMoveNextControl = true;
            this.cboAccount.Location = new System.Drawing.Point(263, 5);
            this.cboAccount.Name = "cboAccount";
            this.cboAccount.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboAccount.Properties.ContextImage = ((System.Drawing.Image)(resources.GetObject("cboAccount.Properties.ContextImage")));
            this.cboAccount.Properties.ContextImageAlignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.cboAccount.Properties.NullText = "";
            this.cboAccount.Properties.NullValuePrompt = "Select Account Or Leave Blank";
            this.cboAccount.Properties.NullValuePromptShowForEmptyValue = true;
            this.cboAccount.Properties.PopupFormMinSize = new System.Drawing.Size(350, 200);
            this.cboAccount.Properties.ValidateOnEnterKey = true;
            this.cboAccount.Properties.View = this.cboAccountView;
            this.cboAccount.ShowAccountNumber = true;
            this.cboAccount.ShowContextImage = true;
            this.cboAccount.Size = new System.Drawing.Size(421, 20);
            this.cboAccount.StartWith = null;
            this.cboAccount.StyleController = this.lcMain;
            this.cboAccount.TabIndex = 28;
            this.cboAccount.ToolTip = "...";
            this.cboAccount.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.cboAccount.ToolTipTitle = "Press [CTRL+DELETE] To Clear Value ...";
            // 
            // cboAccountView
            // 
            this.cboAccountView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.cboAccountView.Name = "cboAccountView";
            this.cboAccountView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.cboAccountView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.cboAccountView.OptionsCustomization.AllowColumnMoving = false;
            this.cboAccountView.OptionsCustomization.AllowColumnResizing = false;
            this.cboAccountView.OptionsCustomization.AllowFilter = false;
            this.cboAccountView.OptionsFilter.AllowFilterEditor = false;
            this.cboAccountView.OptionsFind.AllowFindPanel = false;
            this.cboAccountView.OptionsFind.ShowClearButton = false;
            this.cboAccountView.OptionsFind.ShowCloseButton = false;
            this.cboAccountView.OptionsFind.ShowFindButton = false;
            this.cboAccountView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.cboAccountView.OptionsView.EnableAppearanceEvenRow = true;
            this.cboAccountView.OptionsView.EnableAppearanceOddRow = true;
            this.cboAccountView.OptionsView.ShowAutoFilterRow = true;
            this.cboAccountView.OptionsView.ShowGroupPanel = false;
            this.cboAccountView.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.cboAccountView.OptionsView.ShowIndicator = false;
            this.cboAccountView.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            // 
            // rgChecker
            // 
            this.rgChecker.Location = new System.Drawing.Point(8, 32);
            this.rgChecker.Name = "rgChecker";
            this.rgChecker.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgChecker.Properties.Appearance.Options.UseBackColor = true;
            this.rgChecker.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rgChecker.Properties.Columns = 1;
            this.rgChecker.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Journal Checker"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Description Checker"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Maturity Date Checker"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Currency Checker"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Edited After")});
            this.rgChecker.Size = new System.Drawing.Size(179, 250);
            this.rgChecker.StyleController = this.lcMain;
            this.rgChecker.TabIndex = 20;
            this.rgChecker.SelectedIndexChanged += new System.EventHandler(this.rgChecker_SelectedIndexChanged);
            // 
            // cboVoucherTypes
            // 
            this.cboVoucherTypes.DefaultState = efControls.Enums.ControlState.AlwaysEnabled;
            this.cboVoucherTypes.EnterMoveNextControl = true;
            this.cboVoucherTypes.Filter = Accounting.cboVoucherTypes.jvFilter.JV;
            this.cboVoucherTypes.Location = new System.Drawing.Point(74, 5);
            this.cboVoucherTypes.Name = "cboVoucherTypes";
            this.cboVoucherTypes.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboVoucherTypes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboVoucherTypes.Properties.Name = "efComboBox";
            this.cboVoucherTypes.Size = new System.Drawing.Size(116, 20);
            this.cboVoucherTypes.StyleController = this.lcMain;
            this.cboVoucherTypes.TabIndex = 18;
            // 
            // lcg
            // 
            this.lcg.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcg.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciVoucherType,
            this.lcgCriteria,
            this.lciAccount,
            this.lciResult,
            this.lci1});
            this.lcg.Location = new System.Drawing.Point(0, 0);
            this.lcg.Name = "Root";
            this.lcg.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.lcg.Size = new System.Drawing.Size(689, 373);
            this.lcg.TextVisible = false;
            // 
            // lciVoucherType
            // 
            this.lciVoucherType.Control = this.cboVoucherTypes;
            this.lciVoucherType.IsRequired = null;
            this.lciVoucherType.Location = new System.Drawing.Point(0, 0);
            this.lciVoucherType.Name = "lciVoucherType";
            this.lciVoucherType.Size = new System.Drawing.Size(189, 24);
            this.lciVoucherType.Text = "Voucher Type";
            this.lciVoucherType.TextLocation = DevExpress.Utils.Locations.Left;
            this.lciVoucherType.TextSize = new System.Drawing.Size(66, 13);
            // 
            // lcgCriteria
            // 
            this.lcgCriteria.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciRgChecker,
            this.lciUser,
            this.lciDateTime,
            this.lciAmount});
            this.lcgCriteria.Location = new System.Drawing.Point(0, 24);
            this.lcgCriteria.Name = "lcgCriteria";
            this.lcgCriteria.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcgCriteria.Size = new System.Drawing.Size(189, 343);
            this.lcgCriteria.TextVisible = false;
            // 
            // lciRgChecker
            // 
            this.lciRgChecker.Control = this.rgChecker;
            this.lciRgChecker.IsRequired = null;
            this.lciRgChecker.Location = new System.Drawing.Point(0, 0);
            this.lciRgChecker.MinSize = new System.Drawing.Size(104, 102);
            this.lciRgChecker.Name = "lciRgChecker";
            this.lciRgChecker.Size = new System.Drawing.Size(183, 254);
            this.lciRgChecker.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciRgChecker.TextSize = new System.Drawing.Size(0, 0);
            this.lciRgChecker.TextVisible = false;
            // 
            // lciUser
            // 
            this.lciUser.Control = this.cboUsers;
            this.lciUser.IsRequired = null;
            this.lciUser.Location = new System.Drawing.Point(0, 254);
            this.lciUser.Name = "lciUser";
            this.lciUser.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 10, 10);
            this.lciUser.Size = new System.Drawing.Size(183, 40);
            this.lciUser.Text = "User";
            this.lciUser.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.lciUser.TextSize = new System.Drawing.Size(22, 13);
            this.lciUser.TextToControlDistance = 5;
            // 
            // lciDateTime
            // 
            this.lciDateTime.Control = this.rgDT;
            this.lciDateTime.IsRequired = null;
            this.lciDateTime.Location = new System.Drawing.Point(0, 294);
            this.lciDateTime.Name = "lciDateTime";
            this.lciDateTime.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 10, 10);
            this.lciDateTime.Size = new System.Drawing.Size(110, 43);
            this.lciDateTime.TextSize = new System.Drawing.Size(0, 0);
            this.lciDateTime.TextVisible = false;
            // 
            // lciAmount
            // 
            this.lciAmount.Control = this.txtAmount;
            this.lciAmount.IsRequired = null;
            this.lciAmount.Location = new System.Drawing.Point(110, 294);
            this.lciAmount.Name = "lciAmount";
            this.lciAmount.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 10, 10);
            this.lciAmount.Size = new System.Drawing.Size(73, 43);
            this.lciAmount.Text = ">";
            this.lciAmount.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.lciAmount.TextSize = new System.Drawing.Size(8, 13);
            this.lciAmount.TextToControlDistance = 5;
            // 
            // lciAccount
            // 
            this.lciAccount.Control = this.cboAccount;
            this.lciAccount.IsRequired = null;
            this.lciAccount.Location = new System.Drawing.Point(189, 0);
            this.lciAccount.Name = "lciAccount";
            this.lciAccount.Size = new System.Drawing.Size(494, 24);
            this.lciAccount.Text = "Account";
            this.lciAccount.TextLocation = DevExpress.Utils.Locations.Left;
            this.lciAccount.TextSize = new System.Drawing.Size(66, 13);
            // 
            // lciResult
            // 
            this.lciResult.Control = this.gcResult;
            this.lciResult.IsRequired = null;
            this.lciResult.Location = new System.Drawing.Point(189, 24);
            this.lciResult.Name = "lciResult";
            this.lciResult.Size = new System.Drawing.Size(494, 313);
            this.lciResult.TextSize = new System.Drawing.Size(0, 0);
            this.lciResult.TextVisible = false;
            // 
            // lci1
            // 
            this.lci1.Control = this.ucControlNavigator1;
            this.lci1.IsRequired = null;
            this.lci1.Location = new System.Drawing.Point(189, 337);
            this.lci1.Name = "lci1";
            this.lci1.Size = new System.Drawing.Size(494, 30);
            this.lci1.TextSize = new System.Drawing.Size(0, 0);
            this.lci1.TextVisible = false;
            // 
            // FormJournalChecker
            // 
            this.ClientSize = new System.Drawing.Size(689, 400);
            this.ControlBox = false;
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormJournalChecker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Journal Checker";
            this.Controls.SetChildIndex(this.barDockControlTop, 0);
            this.Controls.SetChildIndex(this.barDockControlBottom, 0);
            this.Controls.SetChildIndex(this.barDockControlRight, 0);
            this.Controls.SetChildIndex(this.barDockControlLeft, 0);
            this.Controls.SetChildIndex(this.lcMain, 0);
            this.Controls.SetChildIndex(this.lblFocus, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboUsers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAccount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAccountView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgChecker.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboVoucherTypes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciVoucherType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgCriteria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRgChecker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDateTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private efControls.efLayoutControl lcMain;
        private DevExpress.XtraLayout.LayoutControlGroup lcg;
        private efControls.efRadioGroup rgChecker;
        private cboVoucherTypes cboVoucherTypes;
        private efControls.lci lciVoucherType;
        private efControls.lci lciRgChecker;
        private DevExpress.Utils.ImageCollection imageCollection;
        private DevExpress.XtraLayout.LayoutControlGroup lcgCriteria;
        private cboAccounts cboAccount;
        private efControls.lci lciAccount;
        private DevExpress.XtraGrid.Views.Grid.GridView cboAccountView;
        private DevExpress.XtraGrid.GridControl gcResult;
        private DevExpress.XtraGrid.Views.Grid.GridView gvResult;
        private DevExpress.XtraGrid.Columns.GridColumn colResult;
        private efControls.lci lciResult;
        private System.Windows.Forms.BindingSource bsResult;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar StatusBar;
        private DevExpress.XtraBars.BarCheckItem bciShowResults;
        private DevExpress.XtraBars.BarCheckItem bciCheckAll;
        private DevExpress.XtraBars.BarButtonItem bbiConfirm;
        private DevExpress.XtraBars.BarButtonItem bbiSaveChecked;
        private DevExpress.XtraBars.BarButtonItem bbiExit;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        // private efControls.efTextBox txtAmount; samir 04/01/2017
        private DevExpress.XtraEditors.TimeEdit txtAmount;   // added by samir samir 04/01/2017
        private efControls.efRadioGroup rgDT;
        private efControls.efComboBox cboUsers;
        private efControls.lci lciUser;
        private efControls.lci lciDateTime;
        private efControls.lci lciAmount;
        private System.Windows.Forms.BindingSource bsUsers;
        private efControls.ucControlNavigator ucControlNavigator1;
        private efControls.lci lci1;
        private DevExpress.XtraGrid.Columns.GridColumn colChecked;
    }
}
