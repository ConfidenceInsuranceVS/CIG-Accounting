namespace Accounting
{
    partial class FormReconciliation
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
            DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule compareAgainstControlValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression1 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReconciliation));
            this.deFrom = new efControls.efDateEdit();
            this.colIsposted = new efControls.efGridColumn();
            this.cboCurrencies = new Accounting.cboCurrencies();
            this.lciCurrency = new efControls.lci();
            this.bsResult = new System.Windows.Forms.BindingSource(this.components);
            this.colCode = new efControls.efGridColumn();
            this.colDescription = new efControls.efGridColumn();
            this.rgType = new efControls.efRadioGroup();
            this.lciType = new efControls.lci();
            this.lciFromDate = new efControls.lci();
            this.deTo = new efControls.efDateEdit();
            this.lciToDate = new efControls.lci();
            this.gcResult = new efControls.efGridControl();
            this.gvResult = new efControls.efGridView();
            this.colScan = new efControls.efGridColumn();
            this.peScan = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.colSC = new efControls.efGridColumn();
            this.riSubCompanies = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bsSubCompanies = new System.Windows.Forms.BindingSource(this.components);
            this.colJvdate = new efControls.efGridColumn();
            this.colVouchertypeid = new efControls.efGridColumn();
            this.riVoucherTypes = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bsVoucherTypes = new System.Windows.Forms.BindingSource(this.components);
            this.colReference = new efControls.efGridColumn();
            this.colMaturity = new efControls.efGridColumn();
            this.colDescription1 = new efControls.efGridColumn();
            this.colCurrencyid = new efControls.efGridColumn();
            this.riCurrencies = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bsCurrencies = new System.Windows.Forms.BindingSource(this.components);
            this.colDebit = new efControls.efGridColumn();
            this.colCredit = new efControls.efGridColumn();
            this.colBalance = new efControls.efGridColumn();
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.lciGridResult = new efControls.lci();
            this.cboAccounts = new Accounting.cboAccounts();
            this.cboAccountsView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lciAccount = new efControls.lci();
            this.sbdcGrid = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.lciGridBar = new efControls.lci();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar = new DevExpress.XtraBars.Bar();
            this.bbiGridAdd = new DevExpress.XtraBars.BarButtonItem();
            this.bbiGridDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiGridSave = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bbiPost = new DevExpress.XtraBars.BarButtonItem();
            this.bbiUnpost = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.lcReport)).BeginInit();
            this.lcReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcgReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCurrencies.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCurrency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFromDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciToDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peScan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riSubCompanies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSubCompanies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riVoucherTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVoucherTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riCurrencies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCurrencies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGridResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAccounts.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAccountsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGridBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            this.SuspendLayout();
            // 
            // lcReport
            // 
            this.lcReport.Appearance.ControlReadOnly.BackColor = System.Drawing.Color.Transparent;
            this.lcReport.Appearance.ControlReadOnly.Options.UseBackColor = true;
            this.lcReport.Controls.Add(this.sbdcGrid);
            this.lcReport.Controls.Add(this.cboAccounts);
            this.lcReport.Controls.Add(this.gcResult);
            this.lcReport.Controls.Add(this.deTo);
            this.lcReport.Controls.Add(this.deFrom);
            this.lcReport.Controls.Add(this.rgType);
            this.lcReport.Controls.Add(this.cboCurrencies);
            this.lcReport.OptionsFocus.EnableAutoTabOrder = false;
            // 
            // lcgReport
            // 
            this.lcgReport.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciType,
            this.lciGridResult,
            this.lciGridBar,
            this.lciAccount,
            this.lciCurrency,
            this.lciFromDate,
            this.lciToDate});
            this.lcgReport.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            // 
            // lcMain
            // 
            this.lcMain.OptionsFocus.EnableAutoTabOrder = false;
            this.lcMain.Size = new System.Drawing.Size(853, 503);
            this.lcMain.Controls.SetChildIndex(this.ucCtrlNavigator, 0);
            this.lcMain.Controls.SetChildIndex(this.lcReport, 0);
            // 
            // lcgMain
            // 
            this.lcgMain.Size = new System.Drawing.Size(853, 503);
            // 
            // ucCtrlNavigator
            // 
            this.ucCtrlNavigator.AlwaysEnabled = true;
            this.ucCtrlNavigator.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.ucCtrlNavigator.Appearance.Options.UseBackColor = true;
            this.ucCtrlNavigator.NavigatableControl = this.gcResult;
            // 
            // deFrom
            // 
            this.deFrom.AllowLeadingSpace = false;
            this.deFrom.DefaultState = efControls.Enums.ControlState.Default;
            this.deFrom.DisplayType = efControls.Enums.DisplayType.Default;
            this.deFrom.EditValue = null;
            this.deFrom.EnterMoveNextControl = true;
            this.deFrom.Information = null;
            this.deFrom.Location = new System.Drawing.Point(58, 4);
            this.deFrom.Name = "deFrom";
            this.deFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deFrom.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.deFrom.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.deFrom.Size = new System.Drawing.Size(77, 20);
            this.deFrom.StyleController = this.lcReport;
            this.deFrom.TabIndex = 0;
            // 
            // colIsposted
            // 
            this.colIsposted.AlwaysDisabled = false;
            this.colIsposted.AppearanceHeader.Options.UseTextOptions = true;
            this.colIsposted.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIsposted.Caption = "P";
            this.colIsposted.CustomData = "";
            this.colIsposted.EditDisabled = false;
            this.colIsposted.FieldName = "Isposted";
            this.colIsposted.Name = "colIsposted";
            this.colIsposted.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIsposted.OptionsColumn.TabStop = false;
            this.colIsposted.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colIsposted.Visible = true;
            this.colIsposted.VisibleIndex = 3;
            this.colIsposted.Width = 20;
            // 
            // cboCurrencies
            // 
            this.cboCurrencies.bs = null;
            this.cboCurrencies.DefaultState = efControls.Enums.ControlState.AlwaysEnabled;
            this.cboCurrencies.EnterMoveNextControl = true;
            this.cboCurrencies.Location = new System.Drawing.Point(193, 28);
            this.cboCurrencies.Name = "cboCurrencies";
            this.cboCurrencies.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboCurrencies.Properties.Name = "efComboBox";
            this.cboCurrencies.Size = new System.Drawing.Size(51, 20);
            this.cboCurrencies.StyleController = this.lcReport;
            this.cboCurrencies.TabIndex = 3;
            this.cboCurrencies.ValueToDisplay = Accounting.cboCurrencies.DisplayValue.Description;
            // 
            // lciCurrency
            // 
            this.lciCurrency.Control = this.cboCurrencies;
            this.lciCurrency.CustomizationFormText = "Currency";
            this.lciCurrency.IsRequired = null;
            this.lciCurrency.Location = new System.Drawing.Point(135, 24);
            this.lciCurrency.Name = "lciCurrency";
            this.lciCurrency.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 200, 2, 2);
            this.lciCurrency.Size = new System.Drawing.Size(307, 24);
            this.lciCurrency.Text = "Currency";
            this.lciCurrency.TextSize = new System.Drawing.Size(50, 13);
            // 
            // bsResult
            // 
            this.bsResult.DataSource = typeof(Accounting.Bankreconciliation);
            // 
            // colCode
            // 
            this.colCode.AlwaysDisabled = false;
            this.colCode.CustomData = "";
            this.colCode.EditDisabled = false;
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 0;
            this.colCode.Width = 200;
            // 
            // colDescription
            // 
            this.colDescription.AlwaysDisabled = false;
            this.colDescription.CustomData = "";
            this.colDescription.EditDisabled = false;
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            this.colDescription.Width = 200;
            // 
            // rgType
            // 
            this.rgType.Location = new System.Drawing.Point(446, 12);
            this.rgType.MaximumSize = new System.Drawing.Size(0, 25);
            this.rgType.MinimumSize = new System.Drawing.Size(100, 25);
            this.rgType.Name = "rgType";
            this.rgType.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgType.Properties.Appearance.Options.UseBackColor = true;
            this.rgType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rgType.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "ALL"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Posted"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Unposted")});
            this.rgType.Size = new System.Drawing.Size(139, 25);
            this.rgType.StyleController = this.lcReport;
            this.rgType.TabIndex = 4;
            this.rgType.SelectedIndexChanged += new System.EventHandler(this.rgType_SelectedIndexChanged);
            // 
            // lciType
            // 
            this.lciType.Control = this.rgType;
            this.lciType.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lciType.CustomizationFormText = "lciType";
            this.lciType.IsRequired = null;
            this.lciType.Location = new System.Drawing.Point(442, 0);
            this.lciType.Name = "lciType";
            this.lciType.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 10, 10);
            this.lciType.Size = new System.Drawing.Size(143, 48);
            this.lciType.TextSize = new System.Drawing.Size(0, 0);
            this.lciType.TextVisible = false;
            // 
            // lciFromDate
            // 
            this.lciFromDate.Control = this.deFrom;
            this.lciFromDate.CustomizationFormText = "From Date";
            this.lciFromDate.IsRequired = null;
            this.lciFromDate.Location = new System.Drawing.Point(0, 0);
            this.lciFromDate.MaxSize = new System.Drawing.Size(135, 24);
            this.lciFromDate.MinSize = new System.Drawing.Size(135, 24);
            this.lciFromDate.Name = "lciFromDate";
            this.lciFromDate.Size = new System.Drawing.Size(135, 24);
            this.lciFromDate.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciFromDate.Text = "From Date";
            this.lciFromDate.TextSize = new System.Drawing.Size(50, 13);
            // 
            // deTo
            // 
            this.deTo.AllowLeadingSpace = false;
            this.deTo.DefaultState = efControls.Enums.ControlState.Default;
            this.deTo.DisplayType = efControls.Enums.DisplayType.Default;
            this.deTo.EditValue = null;
            this.deTo.EnterMoveNextControl = true;
            this.deTo.Information = null;
            this.deTo.Location = new System.Drawing.Point(58, 28);
            this.deTo.Name = "deTo";
            this.deTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deTo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.deTo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.deTo.Size = new System.Drawing.Size(77, 20);
            this.deTo.StyleController = this.lcReport;
            this.deTo.TabIndex = 1;
            compareAgainstControlValidationRule1.CompareControlOperator = DevExpress.XtraEditors.DXErrorProvider.CompareControlOperator.GreaterOrEqual;
            compareAgainstControlValidationRule1.Control = this.deFrom;
            compareAgainstControlValidationRule1.ErrorText = "This value is not valid";
            this.ValidationProvider.SetValidationRule(this.deTo, compareAgainstControlValidationRule1);
            // 
            // lciToDate
            // 
            this.lciToDate.Control = this.deTo;
            this.lciToDate.CustomizationFormText = "To Date";
            this.lciToDate.IsRequired = null;
            this.lciToDate.Location = new System.Drawing.Point(0, 24);
            this.lciToDate.MaxSize = new System.Drawing.Size(135, 24);
            this.lciToDate.MinSize = new System.Drawing.Size(135, 24);
            this.lciToDate.Name = "lciToDate";
            this.lciToDate.Size = new System.Drawing.Size(135, 24);
            this.lciToDate.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciToDate.Text = "To Date";
            this.lciToDate.TextSize = new System.Drawing.Size(50, 13);
            // 
            // gcResult
            // 
            this.gcResult.DataSource = this.bsResult;
            this.gcResult.DefaultState = efControls.Enums.ControlState.AlwaysEnabled;
            this.gcResult.EmbeddedNavigatorHideButtons = false;
            this.gcResult.Location = new System.Drawing.Point(4, 52);
            this.gcResult.MainView = this.gvResult;
            this.gcResult.Name = "gcResult";
            this.gcResult.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riVoucherTypes,
            this.riCurrencies,
            this.peScan,
            this.riSubCompanies});
            this.gcResult.Size = new System.Drawing.Size(581, 190);
            this.gcResult.TabIndex = 17;
            this.gcResult.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvResult});
            // 
            // gvResult
            // 
            this.gvResult.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colScan,
            this.colSC,
            this.colJvdate,
            this.colIsposted,
            this.colVouchertypeid,
            this.colReference,
            this.colMaturity,
            this.colDescription1,
            this.colCurrencyid,
            this.colDebit,
            this.colCredit,
            this.colBalance});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Column = this.colIsposted;
            gridFormatRule1.Name = "FormatPosted";
            formatConditionRuleExpression1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            formatConditionRuleExpression1.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression1.Expression = "[Isposted] = True";
            gridFormatRule1.Rule = formatConditionRuleExpression1;
            this.gvResult.FormatRules.Add(gridFormatRule1);
            this.gvResult.GridControl = this.gcResult;
            this.gvResult.HighLightFocusedRow = true;
            this.gvResult.Images = this.imageCollection;
            this.gvResult.Name = "gvResult";
            this.gvResult.OptionsBehavior.ReadOnly = true;
            this.gvResult.OptionsCustomization.AllowColumnMoving = false;
            this.gvResult.OptionsDetail.EnableMasterViewMode = false;
            this.gvResult.OptionsFind.AllowFindPanel = false;
            this.gvResult.OptionsMenu.EnableColumnMenu = false;
            this.gvResult.OptionsMenu.EnableFooterMenu = false;
            this.gvResult.OptionsMenu.EnableGroupPanelMenu = false;
            this.gvResult.OptionsNavigation.AutoFocusNewRow = true;
            this.gvResult.OptionsNavigation.EnterMoveNextColumn = true;
            this.gvResult.OptionsView.ColumnAutoWidth = false;
            this.gvResult.OptionsView.EnableAppearanceEvenRow = true;
            this.gvResult.OptionsView.ShowAutoFilterRow = true;
            this.gvResult.OptionsView.ShowFooter = true;
            this.gvResult.OptionsView.ShowGroupPanel = false;
            this.gvResult.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gvResult.OptionsView.ShowIndicator = false;
            this.gvResult.ParentForm = null;
            this.gvResult.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gvResult.VisibleAutoFilterRow = true;
            this.gvResult.VisibleGroupPanel = false;
            this.gvResult.VisibleIndicator = false;
            this.gvResult.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gvResult_RowCellClick);
            this.gvResult.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.gvResult_ShowingEditor);
            this.gvResult.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gvResult_CustomUnboundColumnData);
            // 
            // colScan
            // 
            this.colScan.AlwaysDisabled = false;
            this.colScan.AppearanceHeader.Options.UseTextOptions = true;
            this.colScan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colScan.Caption = " ";
            this.colScan.ColumnEdit = this.peScan;
            this.colScan.CustomData = "";
            this.colScan.EditDisabled = false;
            this.colScan.FieldName = "colScan";
            this.colScan.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.colScan.ImageIndex = 7;
            this.colScan.Name = "colScan";
            this.colScan.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colScan.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            this.colScan.Visible = true;
            this.colScan.VisibleIndex = 0;
            this.colScan.Width = 25;
            // 
            // peScan
            // 
            this.peScan.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("peScan.Appearance.Image")));
            this.peScan.Appearance.Options.UseImage = true;
            this.peScan.InitialImage = ((System.Drawing.Image)(resources.GetObject("peScan.InitialImage")));
            this.peScan.Name = "peScan";
            this.peScan.NullText = " ";
            this.peScan.ZoomAccelerationFactor = 1D;
            // 
            // colSC
            // 
            this.colSC.AlwaysDisabled = false;
            this.colSC.AppearanceHeader.Options.UseTextOptions = true;
            this.colSC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSC.ColumnEdit = this.riSubCompanies;
            this.colSC.CustomData = "";
            this.colSC.EditDisabled = false;
            this.colSC.FieldName = "SC";
            this.colSC.Image = ((System.Drawing.Image)(resources.GetObject("colSC.Image")));
            this.colSC.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.colSC.Name = "colSC";
            this.colSC.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSC.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colSC.Visible = true;
            this.colSC.VisibleIndex = 1;
            this.colSC.Width = 25;
            // 
            // riSubCompanies
            // 
            this.riSubCompanies.AutoHeight = false;
            this.riSubCompanies.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.riSubCompanies.DataSource = this.bsSubCompanies;
            this.riSubCompanies.DisplayMember = "Code";
            this.riSubCompanies.Name = "riSubCompanies";
            this.riSubCompanies.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.riSubCompanies.ValueMember = "ID";
            // 
            // bsSubCompanies
            // 
            this.bsSubCompanies.DataSource = typeof(efControls.Data.SubCompany);
            // 
            // colJvdate
            // 
            this.colJvdate.AlwaysDisabled = false;
            this.colJvdate.AppearanceHeader.Options.UseTextOptions = true;
            this.colJvdate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colJvdate.Caption = "Date";
            this.colJvdate.CustomData = "";
            this.colJvdate.EditDisabled = false;
            this.colJvdate.FieldName = "Jvdate";
            this.colJvdate.Name = "colJvdate";
            this.colJvdate.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colJvdate.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colJvdate.Visible = true;
            this.colJvdate.VisibleIndex = 2;
            this.colJvdate.Width = 65;
            // 
            // colVouchertypeid
            // 
            this.colVouchertypeid.AlwaysDisabled = false;
            this.colVouchertypeid.AppearanceHeader.Options.UseTextOptions = true;
            this.colVouchertypeid.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colVouchertypeid.ColumnEdit = this.riVoucherTypes;
            this.colVouchertypeid.CustomData = "";
            this.colVouchertypeid.EditDisabled = false;
            this.colVouchertypeid.FieldName = "Vouchertypeid";
            this.colVouchertypeid.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.colVouchertypeid.ImageIndex = 5;
            this.colVouchertypeid.Name = "colVouchertypeid";
            this.colVouchertypeid.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colVouchertypeid.OptionsColumn.TabStop = false;
            this.colVouchertypeid.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colVouchertypeid.Visible = true;
            this.colVouchertypeid.VisibleIndex = 4;
            this.colVouchertypeid.Width = 30;
            // 
            // riVoucherTypes
            // 
            this.riVoucherTypes.AutoHeight = false;
            this.riVoucherTypes.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 25, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.riVoucherTypes.DataSource = this.bsVoucherTypes;
            this.riVoucherTypes.DisplayMember = "Code";
            this.riVoucherTypes.Name = "riVoucherTypes";
            this.riVoucherTypes.NullText = "";
            this.riVoucherTypes.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.riVoucherTypes.ValueMember = "ID";
            // 
            // bsVoucherTypes
            // 
            this.bsVoucherTypes.DataSource = typeof(Accounting.Vouchertype);
            // 
            // colReference
            // 
            this.colReference.AlwaysDisabled = false;
            this.colReference.AppearanceHeader.Options.UseTextOptions = true;
            this.colReference.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colReference.Caption = "Ref.";
            this.colReference.CustomData = "";
            this.colReference.EditDisabled = false;
            this.colReference.FieldName = "Reference";
            this.colReference.Name = "colReference";
            this.colReference.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colReference.OptionsColumn.TabStop = false;
            this.colReference.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colReference.Visible = true;
            this.colReference.VisibleIndex = 5;
            this.colReference.Width = 40;
            // 
            // colMaturity
            // 
            this.colMaturity.AlwaysDisabled = false;
            this.colMaturity.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaturity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaturity.Caption = "Value";
            this.colMaturity.CustomData = "";
            this.colMaturity.EditDisabled = false;
            this.colMaturity.FieldName = "Maturity";
            this.colMaturity.Name = "colMaturity";
            this.colMaturity.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colMaturity.OptionsColumn.TabStop = false;
            this.colMaturity.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colMaturity.Visible = true;
            this.colMaturity.VisibleIndex = 6;
            this.colMaturity.Width = 65;
            // 
            // colDescription1
            // 
            this.colDescription1.AlwaysDisabled = false;
            this.colDescription1.AppearanceHeader.Options.UseTextOptions = true;
            this.colDescription1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDescription1.Caption = "Description";
            this.colDescription1.CustomData = "";
            this.colDescription1.EditDisabled = false;
            this.colDescription1.FieldName = "Description";
            this.colDescription1.Name = "colDescription1";
            this.colDescription1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDescription1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDescription1.Visible = true;
            this.colDescription1.VisibleIndex = 7;
            this.colDescription1.Width = 245;
            // 
            // colCurrencyid
            // 
            this.colCurrencyid.AlwaysDisabled = false;
            this.colCurrencyid.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCurrencyid.Caption = " ";
            this.colCurrencyid.ColumnEdit = this.riCurrencies;
            this.colCurrencyid.CustomData = "";
            this.colCurrencyid.EditDisabled = false;
            this.colCurrencyid.FieldName = "Currencyid";
            this.colCurrencyid.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.colCurrencyid.ImageIndex = 2;
            this.colCurrencyid.Name = "colCurrencyid";
            this.colCurrencyid.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCurrencyid.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colCurrencyid.Visible = true;
            this.colCurrencyid.VisibleIndex = 8;
            this.colCurrencyid.Width = 30;
            // 
            // riCurrencies
            // 
            this.riCurrencies.AutoHeight = false;
            this.riCurrencies.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.riCurrencies.DataSource = this.bsCurrencies;
            this.riCurrencies.DisplayMember = "Code";
            this.riCurrencies.Name = "riCurrencies";
            this.riCurrencies.NullText = "";
            this.riCurrencies.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.riCurrencies.ValueMember = "ID";
            // 
            // bsCurrencies
            // 
            this.bsCurrencies.DataSource = typeof(Accounting.Currency);
            // 
            // colDebit
            // 
            this.colDebit.AlwaysDisabled = false;
            this.colDebit.AppearanceHeader.Options.UseTextOptions = true;
            this.colDebit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDebit.CustomData = "";
            this.colDebit.DisplayFormat.FormatString = "{0:#,#0.00;;\"\"}";
            this.colDebit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colDebit.EditDisabled = false;
            this.colDebit.FieldName = "Debit";
            this.colDebit.Name = "colDebit";
            this.colDebit.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDebit.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDebit.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Debit", "{0:#,#0.00;;\"\"}")});
            this.colDebit.Visible = true;
            this.colDebit.VisibleIndex = 9;
            this.colDebit.Width = 90;
            // 
            // colCredit
            // 
            this.colCredit.AlwaysDisabled = false;
            this.colCredit.AppearanceHeader.Options.UseTextOptions = true;
            this.colCredit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCredit.CustomData = "";
            this.colCredit.DisplayFormat.FormatString = "{0:#,#0.00;;\"\"}";
            this.colCredit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colCredit.EditDisabled = false;
            this.colCredit.FieldName = "Credit";
            this.colCredit.Name = "colCredit";
            this.colCredit.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCredit.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colCredit.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Credit", "{0:#,#0.00;;\"\"}")});
            this.colCredit.Visible = true;
            this.colCredit.VisibleIndex = 10;
            this.colCredit.Width = 90;
            // 
            // colBalance
            // 
            this.colBalance.AlwaysDisabled = false;
            this.colBalance.AppearanceHeader.Options.UseTextOptions = true;
            this.colBalance.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBalance.CustomData = "";
            this.colBalance.DisplayFormat.FormatString = "{0:#,#0.00;;\"\"}";
            this.colBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colBalance.EditDisabled = false;
            this.colBalance.FieldName = "Balance";
            this.colBalance.Name = "colBalance";
            this.colBalance.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colBalance.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colBalance.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colBalance.Visible = true;
            this.colBalance.VisibleIndex = 11;
            this.colBalance.Width = 90;
            // 
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.InsertGalleryImage("addfile_16x16.png", "office2013/actions/addfile_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/addfile_16x16.png"), 0);
            this.imageCollection.Images.SetKeyName(0, "addfile_16x16.png");
            this.imageCollection.InsertGalleryImage("deletelist_16x16.png", "office2013/actions/deletelist_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/deletelist_16x16.png"), 1);
            this.imageCollection.Images.SetKeyName(1, "deletelist_16x16.png");
            this.imageCollection.InsertGalleryImage("currency_16x16.png", "office2013/miscellaneous/currency_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/miscellaneous/currency_16x16.png"), 2);
            this.imageCollection.Images.SetKeyName(2, "currency_16x16.png");
            this.imageCollection.Images.SetKeyName(3, "checked.png");
            this.imageCollection.Images.SetKeyName(4, "unchecked.png");
            this.imageCollection.InsertGalleryImage("tag_16x16.png", "office2013/programming/tag_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/programming/tag_16x16.png"), 5);
            this.imageCollection.Images.SetKeyName(5, "tag_16x16.png");
            this.imageCollection.InsertGalleryImage("save_16x16.png", "office2013/save/save_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/save/save_16x16.png"), 6);
            this.imageCollection.Images.SetKeyName(6, "save_16x16.png");
            this.imageCollection.InsertGalleryImage("notes_16x16.png", "office2013/content/notes_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/content/notes_16x16.png"), 7);
            this.imageCollection.Images.SetKeyName(7, "notes_16x16.png");
            // 
            // lciGridResult
            // 
            this.lciGridResult.Control = this.gcResult;
            this.lciGridResult.CustomizationFormText = "lciGridResult";
            this.lciGridResult.IsRequired = null;
            this.lciGridResult.Location = new System.Drawing.Point(0, 48);
            this.lciGridResult.Name = "lciGridResult";
            this.lciGridResult.Size = new System.Drawing.Size(585, 194);
            this.lciGridResult.TextSize = new System.Drawing.Size(0, 0);
            this.lciGridResult.TextVisible = false;
            // 
            // cboAccounts
            // 
            this.cboAccounts.AccountStatusFlag = null;
            this.cboAccounts.bs = null;
            this.cboAccounts.DefaultState = efControls.Enums.ControlState.Default;
            this.cboAccounts.DropdownWidth = 0;
            this.cboAccounts.EnterMoveNextControl = true;
            this.cboAccounts.Location = new System.Drawing.Point(193, 4);
            this.cboAccounts.Name = "cboAccounts";
            this.cboAccounts.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboAccounts.Properties.ContextImage = ((System.Drawing.Image)(resources.GetObject("cboAccounts.Properties.ContextImage")));
            this.cboAccounts.Properties.ContextImageAlignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.cboAccounts.Properties.NullText = "";
            this.cboAccounts.Properties.NullValuePrompt = "Select Account Or Leave Blank";
            this.cboAccounts.Properties.NullValuePromptShowForEmptyValue = true;
            this.cboAccounts.Properties.PopupFormMinSize = new System.Drawing.Size(350, 200);
            this.cboAccounts.Properties.ValidateOnEnterKey = true;
            this.cboAccounts.Properties.View = this.cboAccountsView;
            this.cboAccounts.ShowAccountNumber = true;
            this.cboAccounts.ShowContextImage = true;
            this.cboAccounts.Size = new System.Drawing.Size(249, 20);
            this.cboAccounts.StartWith = null;
            this.cboAccounts.StyleController = this.lcReport;
            this.cboAccounts.TabIndex = 2;
            this.cboAccounts.ToolTip = "...";
            this.cboAccounts.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.cboAccounts.ToolTipTitle = "Press [CTRL+DELETE] To Clear Value ...";
            this.cboAccounts.EditValueChanged += new System.EventHandler(this.cboAccounts_Leave);
            this.cboAccounts.Leave += new System.EventHandler(this.cboAccounts_Leave);
            // 
            // cboAccountsView
            // 
            this.cboAccountsView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.cboAccountsView.Name = "cboAccountsView";
            this.cboAccountsView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.cboAccountsView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.cboAccountsView.OptionsCustomization.AllowColumnMoving = false;
            this.cboAccountsView.OptionsCustomization.AllowColumnResizing = false;
            this.cboAccountsView.OptionsCustomization.AllowFilter = false;
            this.cboAccountsView.OptionsFilter.AllowFilterEditor = false;
            this.cboAccountsView.OptionsFind.AllowFindPanel = false;
            this.cboAccountsView.OptionsFind.ShowClearButton = false;
            this.cboAccountsView.OptionsFind.ShowCloseButton = false;
            this.cboAccountsView.OptionsFind.ShowFindButton = false;
            this.cboAccountsView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.cboAccountsView.OptionsView.EnableAppearanceEvenRow = true;
            this.cboAccountsView.OptionsView.EnableAppearanceOddRow = true;
            this.cboAccountsView.OptionsView.ShowAutoFilterRow = true;
            this.cboAccountsView.OptionsView.ShowGroupPanel = false;
            this.cboAccountsView.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.cboAccountsView.OptionsView.ShowIndicator = false;
            this.cboAccountsView.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            // 
            // lciAccount
            // 
            this.lciAccount.Control = this.cboAccounts;
            this.lciAccount.IsRequired = null;
            this.lciAccount.Location = new System.Drawing.Point(135, 0);
            this.lciAccount.Name = "lciAccount";
            this.lciAccount.Size = new System.Drawing.Size(307, 24);
            this.lciAccount.Text = "Account";
            this.lciAccount.TextSize = new System.Drawing.Size(50, 13);
            // 
            // sbdcGrid
            // 
            this.sbdcGrid.CausesValidation = false;
            this.sbdcGrid.Location = new System.Drawing.Point(4, 246);
            this.sbdcGrid.Name = "sbdcGrid";
            this.sbdcGrid.Size = new System.Drawing.Size(581, 31);
            this.sbdcGrid.Text = "standaloneBarDockControl1";
            // 
            // lciGridBar
            // 
            this.lciGridBar.Control = this.sbdcGrid;
            this.lciGridBar.IsRequired = null;
            this.lciGridBar.Location = new System.Drawing.Point(0, 242);
            this.lciGridBar.Name = "lciGridBar";
            this.lciGridBar.Size = new System.Drawing.Size(585, 35);
            this.lciGridBar.TextSize = new System.Drawing.Size(0, 0);
            this.lciGridBar.TextVisible = false;
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.DockControls.Add(this.sbdcGrid);
            this.barManager.Form = this;
            this.barManager.Images = this.imageCollection;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiGridAdd,
            this.bbiGridDelete,
            this.bbiPost,
            this.bbiUnpost,
            this.bbiGridSave});
            this.barManager.MaxItemId = 8;
            // 
            // bar
            // 
            this.bar.BarName = "Tools";
            this.bar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Standalone;
            this.bar.DockCol = 0;
            this.bar.DockRow = 0;
            this.bar.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.bar.FloatLocation = new System.Drawing.Point(305, 578);
            this.bar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiGridAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiGridDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiGridSave, true)});
            this.bar.OptionsBar.DrawBorder = false;
            this.bar.OptionsBar.UseWholeRow = true;
            this.bar.StandaloneBarDockControl = this.sbdcGrid;
            this.bar.Text = "Tools";
            // 
            // bbiGridAdd
            // 
            this.bbiGridAdd.Caption = "Add";
            this.bbiGridAdd.Id = 0;
            this.bbiGridAdd.ImageIndex = 0;
            this.bbiGridAdd.Name = "bbiGridAdd";
            this.bbiGridAdd.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiGridAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiGridAdd_ItemClick);
            // 
            // bbiGridDelete
            // 
            this.bbiGridDelete.Caption = "Delete";
            this.bbiGridDelete.Id = 2;
            this.bbiGridDelete.ImageIndex = 1;
            this.bbiGridDelete.Name = "bbiGridDelete";
            this.bbiGridDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiGridDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiGridDelete_ItemClick);
            // 
            // bbiGridSave
            // 
            this.bbiGridSave.Caption = "Save";
            this.bbiGridSave.Id = 5;
            this.bbiGridSave.ImageIndex = 6;
            this.bbiGridSave.Name = "bbiGridSave";
            this.bbiGridSave.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiGridSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiGridSave_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(853, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 503);
            this.barDockControlBottom.Size = new System.Drawing.Size(853, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 503);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(853, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 503);
            // 
            // bbiPost
            // 
            this.bbiPost.Id = 6;
            this.bbiPost.Name = "bbiPost";
            // 
            // bbiUnpost
            // 
            this.bbiUnpost.Id = 7;
            this.bbiUnpost.Name = "bbiUnpost";
            // 
            // FormReconciliation
            // 
            this.ClientSize = new System.Drawing.Size(853, 503);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormReconciliation";
            this.Text = "Bank Reconciliation";
            this.Controls.SetChildIndex(this.barDockControlTop, 0);
            this.Controls.SetChildIndex(this.barDockControlBottom, 0);
            this.Controls.SetChildIndex(this.barDockControlRight, 0);
            this.Controls.SetChildIndex(this.barDockControlLeft, 0);
            this.Controls.SetChildIndex(this.lblFocus, 0);
            this.Controls.SetChildIndex(this.lcMain, 0);
            ((System.ComponentModel.ISupportInitialize)(this.lcReport)).EndInit();
            this.lcReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcgReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCurrencies.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCurrency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFromDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciToDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peScan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riSubCompanies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSubCompanies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riVoucherTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVoucherTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riCurrencies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCurrencies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGridResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAccounts.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAccountsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGridBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private cboCurrencies cboCurrencies;
        private efControls.lci lciCurrency;
        private System.Windows.Forms.BindingSource bsResult;
        private efControls.efGridColumn colCode;
        private efControls.efGridColumn colDescription;
        private efControls.efGridControl gcResult;
        private efControls.efGridView gvResult;
        private efControls.efDateEdit deTo;
        private efControls.efDateEdit deFrom;
        private efControls.efRadioGroup rgType;
        private efControls.lci lciType;
        private efControls.lci lciFromDate;
        private efControls.lci lciToDate;
        private efControls.lci lciGridResult;
        private cboAccounts cboAccounts;
        private efControls.lci lciAccount;
        private DevExpress.XtraGrid.Views.Grid.GridView cboAccountsView;
        private DevExpress.XtraBars.StandaloneBarDockControl sbdcGrid;
        private efControls.lci lciGridBar;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem bbiGridAdd;
        private DevExpress.XtraBars.BarButtonItem bbiGridDelete;
        private DevExpress.Utils.ImageCollection imageCollection;
        private efControls.efGridColumn colJvdate;
        private efControls.efGridColumn colScan;
        private efControls.efGridColumn colIsposted;
        private efControls.efGridColumn colVouchertypeid;
        private efControls.efGridColumn colReference;
        private efControls.efGridColumn colMaturity;
        private efControls.efGridColumn colDescription1;
        private efControls.efGridColumn colCurrencyid;
        private efControls.efGridColumn colDebit;
        private efControls.efGridColumn colCredit;
        private efControls.efGridColumn colBalance;
        private DevExpress.XtraBars.BarButtonItem bbiPost;
        private DevExpress.XtraBars.BarButtonItem bbiUnpost;
        private System.Windows.Forms.BindingSource bsVoucherTypes;
        private System.Windows.Forms.BindingSource bsCurrencies;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riVoucherTypes;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riCurrencies;
        private DevExpress.XtraBars.BarButtonItem bbiGridSave;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit peScan;
        private efControls.efGridColumn colSC;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riSubCompanies;
        private System.Windows.Forms.BindingSource bsSubCompanies;
    }
}
