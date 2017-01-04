namespace Accounting
{
    partial class FormStatementOfAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStatementOfAccount));
            this.deFrom = new efControls.efDateEdit();
            this.cboCurrencies = new Accounting.cboCurrencies();
            this.lciCurrency = new efControls.lci();
            this.colCode = new efControls.efGridColumn();
            this.colDescription = new efControls.efGridColumn();
            this.rgType = new efControls.efRadioGroup();
            this.lciType = new efControls.lci();
            this.lciFromDate = new efControls.lci();
            this.deTo = new efControls.efDateEdit();
            this.lciToDate = new efControls.lci();
            this.gcResult = new efControls.efGridControl();
            this.bsResult = new System.Windows.Forms.BindingSource(this.components);
            this.gvResult = new efControls.efGridView();
            this.colScan = new efControls.efGridColumn();
            this.peScan = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.colSC = new efControls.efGridColumn();
            this.colAccount = new efControls.efGridColumn();
            this.coljvdate = new efControls.efGridColumn();
            this.coltype = new efControls.efGridColumn();
            this.colreference = new efControls.efGridColumn();
            this.coldescription1 = new efControls.efGridColumn();
            this.colcur = new efControls.efGridColumn();
            this.colDebit = new efControls.efGridColumn();
            this.colCredit = new efControls.efGridColumn();
            this.colBalance = new efControls.efGridColumn();
            this.colDebit1st = new efControls.efGridColumn();
            this.colCredit1st = new efControls.efGridColumn();
            this.colBalance1st = new efControls.efGridColumn();
            this.colDebit2nd = new efControls.efGridColumn();
            this.colCredit2nd = new efControls.efGridColumn();
            this.colBalance2nd = new efControls.efGridColumn();
            this.colVouchertypeid = new efControls.efGridColumn();
            this.formImages = new DevExpress.Utils.ImageCollection(this.components);
            this.lciGridResult = new efControls.lci();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.cboAccountFrom = new Accounting.cboAccounts();
            this.bsAccounts = new System.Windows.Forms.BindingSource(this.components);
            this.cboAccountFromView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lciAccountFrom = new efControls.lci();
            this.cboAccountTo = new Accounting.cboAccounts();
            this.cboAccountToView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lciAccountTo = new efControls.lci();
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
            ((System.ComponentModel.ISupportInitialize)(this.rgType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFromDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciToDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peScan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGridResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAccountFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAccountFromView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAccountFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAccountTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAccountToView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAccountTo)).BeginInit();
            this.SuspendLayout();
            // 
            // lcReport
            // 
            this.lcReport.Controls.Add(this.cboAccountTo);
            this.lcReport.Controls.Add(this.cboAccountFrom);
            this.lcReport.Controls.Add(this.gcResult);
            this.lcReport.Controls.Add(this.deTo);
            this.lcReport.Controls.Add(this.deFrom);
            this.lcReport.Controls.Add(this.rgType);
            this.lcReport.Controls.Add(this.cboCurrencies);
            this.lcReport.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1028, 516, 250, 350);
            this.lcReport.OptionsFocus.EnableAutoTabOrder = false;
            this.lcReport.Size = new System.Drawing.Size(894, 473);
            // 
            // lcgReport
            // 
            this.lcgReport.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciGridResult,
            this.lciFromDate,
            this.lciToDate,
            this.lciCurrency,
            this.emptySpaceItem1,
            this.lciAccountFrom,
            this.lciAccountTo,
            this.lciType});
            this.lcgReport.Name = "Root";
            this.lcgReport.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.lcgReport.Size = new System.Drawing.Size(894, 473);
            // 
            // lcMain
            // 
            this.lcMain.Size = new System.Drawing.Size(902, 511);
            this.lcMain.Controls.SetChildIndex(this.ucCtrlNavigator, 0);
            this.lcMain.Controls.SetChildIndex(this.lcReport, 0);
            // 
            // lcgMain
            // 
            this.lcgMain.Size = new System.Drawing.Size(902, 511);
            // 
            // ucCtrlNavigator
            // 
            this.ucCtrlNavigator.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.ucCtrlNavigator.Appearance.Options.UseBackColor = true;
            this.ucCtrlNavigator.Location = new System.Drawing.Point(4, 481);
            this.ucCtrlNavigator.NavigatableControl = this.gcResult;
            // 
            // deFrom
            // 
            this.deFrom.AllowLeadingSpace = false;
            this.deFrom.DefaultState = efControls.Enums.ControlState.AlwaysEnabled;
            this.deFrom.DisplayType = efControls.Enums.DisplayType.Default;
            this.deFrom.EditValue = null;
            this.deFrom.EnterMoveNextControl = true;
            this.deFrom.Information = null;
            this.deFrom.Location = new System.Drawing.Point(76, 6);
            this.deFrom.Name = "deFrom";
            this.deFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deFrom.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.deFrom.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.deFrom.Size = new System.Drawing.Size(76, 20);
            this.deFrom.StyleController = this.lcReport;
            this.deFrom.TabIndex = 0;
            // 
            // cboCurrencies
            // 
            this.cboCurrencies.bs = null;
            this.cboCurrencies.DefaultState = efControls.Enums.ControlState.AlwaysEnabled;
            this.cboCurrencies.EnterMoveNextControl = true;
            this.cboCurrencies.Location = new System.Drawing.Point(564, 30);
            this.cboCurrencies.Name = "cboCurrencies";
            this.cboCurrencies.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboCurrencies.Properties.Name = "efComboBox";
            this.cboCurrencies.Size = new System.Drawing.Size(120, 20);
            this.cboCurrencies.StyleController = this.lcReport;
            this.cboCurrencies.TabIndex = 4;
            this.cboCurrencies.ValueToDisplay = Accounting.cboCurrencies.DisplayValue.Description;
            // 
            // lciCurrency
            // 
            this.lciCurrency.Control = this.cboCurrencies;
            this.lciCurrency.CustomizationFormText = "Currency";
            this.lciCurrency.IsRequired = null;
            this.lciCurrency.Location = new System.Drawing.Point(558, 24);
            this.lciCurrency.MinSize = new System.Drawing.Size(1, 1);
            this.lciCurrency.Name = "lciCurrency";
            this.lciCurrency.Size = new System.Drawing.Size(124, 24);
            this.lciCurrency.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciCurrency.Text = "Currency";
            this.lciCurrency.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.lciCurrency.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciCurrency.TextSize = new System.Drawing.Size(0, 0);
            this.lciCurrency.TextToControlDistance = 0;
            this.lciCurrency.TextVisible = false;
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
            this.rgType.Location = new System.Drawing.Point(688, 6);
            this.rgType.Name = "rgType";
            this.rgType.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgType.Properties.Appearance.Options.UseBackColor = true;
            this.rgType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rgType.Properties.Columns = 2;
            this.rgType.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Normal"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Balanced"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "GL/First Local"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "GL/Second Local")});
            this.rgType.Size = new System.Drawing.Size(200, 44);
            this.rgType.StyleController = this.lcReport;
            this.rgType.TabIndex = 5;
            this.rgType.SelectedIndexChanged += new System.EventHandler(this.rgType_SelectedIndexChanged);
            // 
            // lciType
            // 
            this.lciType.Control = this.rgType;
            this.lciType.CustomizationFormText = "lciType";
            this.lciType.IsRequired = null;
            this.lciType.Location = new System.Drawing.Point(682, 0);
            this.lciType.Name = "lciType";
            this.lciType.Size = new System.Drawing.Size(204, 48);
            this.lciType.TextSize = new System.Drawing.Size(0, 0);
            this.lciType.TextVisible = false;
            // 
            // lciFromDate
            // 
            this.lciFromDate.Control = this.deFrom;
            this.lciFromDate.CustomizationFormText = "From Date";
            this.lciFromDate.IsRequired = null;
            this.lciFromDate.Location = new System.Drawing.Point(0, 0);
            this.lciFromDate.MaxSize = new System.Drawing.Size(150, 24);
            this.lciFromDate.MinSize = new System.Drawing.Size(150, 24);
            this.lciFromDate.Name = "lciFromDate";
            this.lciFromDate.Size = new System.Drawing.Size(150, 24);
            this.lciFromDate.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciFromDate.Text = "From Date";
            this.lciFromDate.TextSize = new System.Drawing.Size(66, 13);
            // 
            // deTo
            // 
            this.deTo.AllowLeadingSpace = false;
            this.deTo.DefaultState = efControls.Enums.ControlState.AlwaysEnabled;
            this.deTo.DisplayType = efControls.Enums.DisplayType.Default;
            this.deTo.EditValue = null;
            this.deTo.EnterMoveNextControl = true;
            this.deTo.Information = null;
            this.deTo.Location = new System.Drawing.Point(76, 30);
            this.deTo.Name = "deTo";
            this.deTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deTo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.deTo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.deTo.Size = new System.Drawing.Size(76, 20);
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
            this.lciToDate.MaxSize = new System.Drawing.Size(150, 24);
            this.lciToDate.MinSize = new System.Drawing.Size(150, 24);
            this.lciToDate.Name = "lciToDate";
            this.lciToDate.Size = new System.Drawing.Size(150, 24);
            this.lciToDate.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciToDate.Text = "To Date";
            this.lciToDate.TextSize = new System.Drawing.Size(66, 13);
            // 
            // gcResult
            // 
            this.gcResult.DataSource = this.bsResult;
            this.gcResult.DefaultState = efControls.Enums.ControlState.AlwaysDisabled;
            this.gcResult.EmbeddedNavigatorHideButtons = true;
            this.gcResult.Location = new System.Drawing.Point(6, 54);
            this.gcResult.MainView = this.gvResult;
            this.gcResult.Name = "gcResult";
            this.gcResult.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.peScan});
            this.gcResult.Size = new System.Drawing.Size(882, 413);
            this.gcResult.TabIndex = 17;
            this.gcResult.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvResult});
            // 
            // bsResult
            // 
            this.bsResult.DataSource = typeof(Accounting.StatementOfAccount);
            // 
            // gvResult
            // 
            this.gvResult.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colScan,
            this.colSC,
            this.colAccount,
            this.coljvdate,
            this.coltype,
            this.colreference,
            this.coldescription1,
            this.colcur,
            this.colDebit,
            this.colCredit,
            this.colBalance,
            this.colDebit1st,
            this.colCredit1st,
            this.colBalance1st,
            this.colDebit2nd,
            this.colCredit2nd,
            this.colBalance2nd,
            this.colVouchertypeid});
            this.gvResult.GridControl = this.gcResult;
            this.gvResult.GroupCount = 1;
            this.gvResult.GroupFormat = "{1} {2}";
            this.gvResult.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Debit", this.colDebit, "{0:#,#0.00;;\"\"}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Credit", this.colCredit, "{0:#,#0.00;;\"\"}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Debit1st", this.colDebit1st, "{0:#,#0.00;;\"\"}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Credit1st", this.colCredit1st, "{0:#,#0.00;;\"\"}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Debit2nd", this.colDebit2nd, "{0:#,#0.00;;\"\"}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Credit2nd", this.colCredit2nd, "{0:#,#0.00;;\"\"}")});
            this.gvResult.HighLightFocusedRow = true;
            this.gvResult.Images = this.formImages;
            this.gvResult.Name = "gvResult";
            this.gvResult.OptionsBehavior.AutoExpandAllGroups = true;
            this.gvResult.OptionsBehavior.ReadOnly = true;
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
            this.gvResult.OptionsView.ShowGroupedColumns = true;
            this.gvResult.OptionsView.ShowGroupPanel = false;
            this.gvResult.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gvResult.OptionsView.ShowIndicator = false;
            this.gvResult.ParentForm = null;
            this.gvResult.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colAccount, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvResult.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gvResult.VisibleAutoFilterRow = true;
            this.gvResult.VisibleGroupPanel = false;
            this.gvResult.VisibleIndicator = false;
            this.gvResult.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gvResult_RowCellClick);
            this.gvResult.CustomSummaryExists += new DevExpress.Data.CustomSummaryExistEventHandler(this.gvResult_CustomSummaryExists);
            this.gvResult.ColumnFilterChanged += new System.EventHandler(this.gvResult_ColumnFilterChanged);
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
            this.colScan.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colScan.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.colScan.ImageIndex = 0;
            this.colScan.Name = "colScan";
            this.colScan.OptionsColumn.AllowEdit = false;
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
            this.colSC.CustomData = "";
            this.colSC.EditDisabled = false;
            this.colSC.FieldName = "sc";
            this.colSC.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colSC.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.colSC.ImageIndex = 1;
            this.colSC.Name = "colSC";
            this.colSC.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSC.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Equals;
            this.colSC.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colSC.Visible = true;
            this.colSC.VisibleIndex = 1;
            this.colSC.Width = 25;
            // 
            // colAccount
            // 
            this.colAccount.AlwaysDisabled = false;
            this.colAccount.AppearanceHeader.Options.UseTextOptions = true;
            this.colAccount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAccount.CustomData = "";
            this.colAccount.EditDisabled = false;
            this.colAccount.FieldName = "Account";
            this.colAccount.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colAccount.Name = "colAccount";
            this.colAccount.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colAccount.Visible = true;
            this.colAccount.VisibleIndex = 2;
            // 
            // coljvdate
            // 
            this.coljvdate.AlwaysDisabled = false;
            this.coljvdate.AppearanceHeader.Options.UseTextOptions = true;
            this.coljvdate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coljvdate.Caption = "Date";
            this.coljvdate.CustomData = "";
            this.coljvdate.EditDisabled = false;
            this.coljvdate.FieldName = "JvDate";
            this.coljvdate.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.coljvdate.Name = "coljvdate";
            this.coljvdate.Visible = true;
            this.coljvdate.VisibleIndex = 3;
            this.coljvdate.Width = 65;
            // 
            // coltype
            // 
            this.coltype.AlwaysDisabled = false;
            this.coltype.AppearanceHeader.Options.UseTextOptions = true;
            this.coltype.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltype.CustomData = "";
            this.coltype.EditDisabled = false;
            this.coltype.FieldName = "Type";
            this.coltype.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.coltype.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.coltype.ImageIndex = 3;
            this.coltype.Name = "coltype";
            this.coltype.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Equals;
            this.coltype.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.coltype.Visible = true;
            this.coltype.VisibleIndex = 4;
            this.coltype.Width = 30;
            // 
            // colreference
            // 
            this.colreference.AlwaysDisabled = false;
            this.colreference.AppearanceHeader.Options.UseTextOptions = true;
            this.colreference.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colreference.Caption = "Reference";
            this.colreference.CustomData = "";
            this.colreference.EditDisabled = false;
            this.colreference.FieldName = "Reference";
            this.colreference.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colreference.Name = "colreference";
            this.colreference.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colreference.OptionsColumn.AllowMove = false;
            this.colreference.Visible = true;
            this.colreference.VisibleIndex = 5;
            this.colreference.Width = 62;
            // 
            // coldescription1
            // 
            this.coldescription1.AlwaysDisabled = false;
            this.coldescription1.AppearanceHeader.Options.UseTextOptions = true;
            this.coldescription1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldescription1.Caption = "Description";
            this.coldescription1.CustomData = "";
            this.coldescription1.EditDisabled = false;
            this.coldescription1.FieldName = "Description";
            this.coldescription1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.coldescription1.Name = "coldescription1";
            this.coldescription1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.coldescription1.OptionsColumn.AllowMove = false;
            this.coldescription1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.coldescription1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.coldescription1.Visible = true;
            this.coldescription1.VisibleIndex = 6;
            this.coldescription1.Width = 247;
            // 
            // colcur
            // 
            this.colcur.AlwaysDisabled = false;
            this.colcur.AppearanceHeader.Options.UseTextOptions = true;
            this.colcur.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colcur.CustomData = "";
            this.colcur.EditDisabled = false;
            this.colcur.FieldName = "Currency";
            this.colcur.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colcur.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.colcur.ImageIndex = 2;
            this.colcur.Name = "colcur";
            this.colcur.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colcur.OptionsColumn.AllowMove = false;
            this.colcur.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colcur.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Equals;
            this.colcur.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colcur.Visible = true;
            this.colcur.VisibleIndex = 7;
            this.colcur.Width = 30;
            // 
            // colDebit
            // 
            this.colDebit.AlwaysDisabled = false;
            this.colDebit.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.colDebit.AppearanceCell.Options.UseBackColor = true;
            this.colDebit.AppearanceHeader.Options.UseTextOptions = true;
            this.colDebit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDebit.CustomData = "";
            this.colDebit.DisplayFormat.FormatString = "{0:#,#0.00;;\"\"}";
            this.colDebit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colDebit.EditDisabled = false;
            this.colDebit.FieldName = "Debit";
            this.colDebit.Name = "colDebit";
            this.colDebit.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colDebit.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDebit.Visible = true;
            this.colDebit.VisibleIndex = 8;
            this.colDebit.Width = 100;
            // 
            // colCredit
            // 
            this.colCredit.AlwaysDisabled = false;
            this.colCredit.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.colCredit.AppearanceCell.Options.UseBackColor = true;
            this.colCredit.AppearanceHeader.Options.UseTextOptions = true;
            this.colCredit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCredit.CustomData = "";
            this.colCredit.DisplayFormat.FormatString = "{0:#,#0.00;;\"\"}";
            this.colCredit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colCredit.EditDisabled = false;
            this.colCredit.FieldName = "Credit";
            this.colCredit.Name = "colCredit";
            this.colCredit.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colCredit.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCredit.Visible = true;
            this.colCredit.VisibleIndex = 9;
            this.colCredit.Width = 100;
            // 
            // colBalance
            // 
            this.colBalance.AlwaysDisabled = false;
            this.colBalance.AppearanceHeader.Options.UseTextOptions = true;
            this.colBalance.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBalance.Caption = "Balance";
            this.colBalance.CustomData = "";
            this.colBalance.DisplayFormat.FormatString = "{0:#,#0.00;;\"\"}";
            this.colBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBalance.EditDisabled = false;
            this.colBalance.FieldName = "Balance";
            this.colBalance.Name = "colBalance";
            this.colBalance.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colBalance.Visible = true;
            this.colBalance.VisibleIndex = 10;
            this.colBalance.Width = 100;
            // 
            // colDebit1st
            // 
            this.colDebit1st.AlwaysDisabled = false;
            this.colDebit1st.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.colDebit1st.AppearanceCell.Options.UseBackColor = true;
            this.colDebit1st.AppearanceHeader.Options.UseTextOptions = true;
            this.colDebit1st.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDebit1st.Caption = "Debit 1st";
            this.colDebit1st.CustomData = "";
            this.colDebit1st.DisplayFormat.FormatString = "{0:#,#0.00;;\"\"}";
            this.colDebit1st.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colDebit1st.EditDisabled = false;
            this.colDebit1st.FieldName = "Debit1st";
            this.colDebit1st.Name = "colDebit1st";
            this.colDebit1st.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colDebit1st.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDebit1st.Visible = true;
            this.colDebit1st.VisibleIndex = 11;
            this.colDebit1st.Width = 100;
            // 
            // colCredit1st
            // 
            this.colCredit1st.AlwaysDisabled = false;
            this.colCredit1st.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.colCredit1st.AppearanceCell.Options.UseBackColor = true;
            this.colCredit1st.AppearanceHeader.Options.UseTextOptions = true;
            this.colCredit1st.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCredit1st.Caption = "Credit 1st";
            this.colCredit1st.CustomData = "";
            this.colCredit1st.DisplayFormat.FormatString = "{0:#,#0.00;;\"\"}";
            this.colCredit1st.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colCredit1st.EditDisabled = false;
            this.colCredit1st.FieldName = "Credit1st";
            this.colCredit1st.Name = "colCredit1st";
            this.colCredit1st.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colCredit1st.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCredit1st.Visible = true;
            this.colCredit1st.VisibleIndex = 12;
            this.colCredit1st.Width = 100;
            // 
            // colBalance1st
            // 
            this.colBalance1st.AlwaysDisabled = false;
            this.colBalance1st.AppearanceHeader.Options.UseTextOptions = true;
            this.colBalance1st.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBalance1st.CustomData = "";
            this.colBalance1st.DisplayFormat.FormatString = "{0:#,#0.00;;\"\"}";
            this.colBalance1st.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBalance1st.EditDisabled = false;
            this.colBalance1st.FieldName = "Balance1st";
            this.colBalance1st.Name = "colBalance1st";
            this.colBalance1st.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colBalance1st.Visible = true;
            this.colBalance1st.VisibleIndex = 13;
            this.colBalance1st.Width = 100;
            // 
            // colDebit2nd
            // 
            this.colDebit2nd.AlwaysDisabled = false;
            this.colDebit2nd.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.colDebit2nd.AppearanceCell.Options.UseBackColor = true;
            this.colDebit2nd.AppearanceHeader.Options.UseTextOptions = true;
            this.colDebit2nd.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDebit2nd.Caption = "Debit 2nd";
            this.colDebit2nd.CustomData = "";
            this.colDebit2nd.DisplayFormat.FormatString = "{0:#,#0.00;;\"\"}";
            this.colDebit2nd.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colDebit2nd.EditDisabled = false;
            this.colDebit2nd.FieldName = "Debit2nd";
            this.colDebit2nd.Name = "colDebit2nd";
            this.colDebit2nd.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colDebit2nd.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDebit2nd.Visible = true;
            this.colDebit2nd.VisibleIndex = 14;
            this.colDebit2nd.Width = 100;
            // 
            // colCredit2nd
            // 
            this.colCredit2nd.AlwaysDisabled = false;
            this.colCredit2nd.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.colCredit2nd.AppearanceCell.Options.UseBackColor = true;
            this.colCredit2nd.AppearanceHeader.Options.UseTextOptions = true;
            this.colCredit2nd.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCredit2nd.Caption = "Credit 2nd";
            this.colCredit2nd.CustomData = "";
            this.colCredit2nd.DisplayFormat.FormatString = "{0:#,#0.00;;\"\"}";
            this.colCredit2nd.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colCredit2nd.EditDisabled = false;
            this.colCredit2nd.FieldName = "Credit2nd";
            this.colCredit2nd.Name = "colCredit2nd";
            this.colCredit2nd.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colCredit2nd.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCredit2nd.Visible = true;
            this.colCredit2nd.VisibleIndex = 15;
            this.colCredit2nd.Width = 100;
            // 
            // colBalance2nd
            // 
            this.colBalance2nd.AlwaysDisabled = false;
            this.colBalance2nd.AppearanceHeader.Options.UseTextOptions = true;
            this.colBalance2nd.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBalance2nd.CustomData = "";
            this.colBalance2nd.DisplayFormat.FormatString = "{0:#,#0.00;;\"\"}";
            this.colBalance2nd.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBalance2nd.EditDisabled = false;
            this.colBalance2nd.FieldName = "Balance2nd";
            this.colBalance2nd.Name = "colBalance2nd";
            this.colBalance2nd.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colBalance2nd.Visible = true;
            this.colBalance2nd.VisibleIndex = 16;
            this.colBalance2nd.Width = 100;
            // 
            // colVouchertypeid
            // 
            this.colVouchertypeid.AlwaysDisabled = false;
            this.colVouchertypeid.AppearanceHeader.Options.UseTextOptions = true;
            this.colVouchertypeid.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colVouchertypeid.CustomData = "";
            this.colVouchertypeid.EditDisabled = false;
            this.colVouchertypeid.FieldName = "Vouchertypeid";
            this.colVouchertypeid.Name = "colVouchertypeid";
            this.colVouchertypeid.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            // 
            // formImages
            // 
            this.formImages.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("formImages.ImageStream")));
            this.formImages.InsertGalleryImage("notes_16x16.png", "office2013/content/notes_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/content/notes_16x16.png"), 0);
            this.formImages.Images.SetKeyName(0, "notes_16x16.png");
            this.formImages.InsertGalleryImage("group_16x16.png", "office2013/actions/group_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/group_16x16.png"), 1);
            this.formImages.Images.SetKeyName(1, "group_16x16.png");
            this.formImages.InsertGalleryImage("currency_16x16.png", "office2013/miscellaneous/currency_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/miscellaneous/currency_16x16.png"), 2);
            this.formImages.Images.SetKeyName(2, "currency_16x16.png");
            this.formImages.InsertGalleryImage("tag_16x16.png", "office2013/programming/tag_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/programming/tag_16x16.png"), 3);
            this.formImages.Images.SetKeyName(3, "tag_16x16.png");
            // 
            // lciGridResult
            // 
            this.lciGridResult.Control = this.gcResult;
            this.lciGridResult.CustomizationFormText = "lciGridResult";
            this.lciGridResult.IsRequired = null;
            this.lciGridResult.Location = new System.Drawing.Point(0, 48);
            this.lciGridResult.Name = "lciGridResult";
            this.lciGridResult.Size = new System.Drawing.Size(886, 417);
            this.lciGridResult.TextSize = new System.Drawing.Size(0, 0);
            this.lciGridResult.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(558, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(124, 24);
            this.emptySpaceItem1.Text = "Currency";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(66, 0);
            this.emptySpaceItem1.TextVisible = true;
            // 
            // cboAccountFrom
            // 
            this.cboAccountFrom.AccountStatusFlag = null;
            this.cboAccountFrom.bs = this.bsAccounts;
            this.cboAccountFrom.DefaultState = efControls.Enums.ControlState.Default;
            this.cboAccountFrom.DropdownWidth = 0;
            this.cboAccountFrom.EnterMoveNextControl = true;
            this.cboAccountFrom.Location = new System.Drawing.Point(226, 6);
            this.cboAccountFrom.Name = "cboAccountFrom";
            this.cboAccountFrom.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboAccountFrom.Properties.ContextImage = ((System.Drawing.Image)(resources.GetObject("cboAccountFrom.Properties.ContextImage")));
            this.cboAccountFrom.Properties.ContextImageAlignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.cboAccountFrom.Properties.DataSource = this.bsAccounts;
            this.cboAccountFrom.Properties.DisplayMember = "CodeDescription";
            this.cboAccountFrom.Properties.NullText = "";
            this.cboAccountFrom.Properties.NullValuePrompt = "Select Account Or Leave Blank";
            this.cboAccountFrom.Properties.NullValuePromptShowForEmptyValue = true;
            this.cboAccountFrom.Properties.PopupFormMinSize = new System.Drawing.Size(350, 200);
            this.cboAccountFrom.Properties.ValidateOnEnterKey = true;
            this.cboAccountFrom.Properties.ValueMember = "ID";
            this.cboAccountFrom.Properties.View = this.cboAccountFromView;
            this.cboAccountFrom.ShowAccountNumber = true;
            this.cboAccountFrom.ShowContextImage = true;
            this.cboAccountFrom.Size = new System.Drawing.Size(334, 20);
            this.cboAccountFrom.StartWith = null;
            this.cboAccountFrom.StyleController = this.lcReport;
            this.cboAccountFrom.TabIndex = 2;
            this.cboAccountFrom.ToolTip = "...";
            this.cboAccountFrom.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.cboAccountFrom.ToolTipTitle = "Press [CTRL+DELETE] To Clear Value ...";
            // 
            // cboAccountFromView
            // 
            this.cboAccountFromView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.cboAccountFromView.Name = "cboAccountFromView";
            this.cboAccountFromView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.cboAccountFromView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.cboAccountFromView.OptionsCustomization.AllowColumnMoving = false;
            this.cboAccountFromView.OptionsCustomization.AllowColumnResizing = false;
            this.cboAccountFromView.OptionsCustomization.AllowFilter = false;
            this.cboAccountFromView.OptionsFilter.AllowFilterEditor = false;
            this.cboAccountFromView.OptionsFind.AllowFindPanel = false;
            this.cboAccountFromView.OptionsFind.ShowClearButton = false;
            this.cboAccountFromView.OptionsFind.ShowCloseButton = false;
            this.cboAccountFromView.OptionsFind.ShowFindButton = false;
            this.cboAccountFromView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.cboAccountFromView.OptionsView.EnableAppearanceEvenRow = true;
            this.cboAccountFromView.OptionsView.EnableAppearanceOddRow = true;
            this.cboAccountFromView.OptionsView.ShowAutoFilterRow = true;
            this.cboAccountFromView.OptionsView.ShowGroupPanel = false;
            this.cboAccountFromView.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.cboAccountFromView.OptionsView.ShowIndicator = false;
            this.cboAccountFromView.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            // 
            // lciAccountFrom
            // 
            this.lciAccountFrom.Control = this.cboAccountFrom;
            this.lciAccountFrom.IsRequired = null;
            this.lciAccountFrom.Location = new System.Drawing.Point(150, 0);
            this.lciAccountFrom.Name = "lciAccountFrom";
            this.lciAccountFrom.Size = new System.Drawing.Size(408, 24);
            this.lciAccountFrom.Text = "Account From";
            this.lciAccountFrom.TextSize = new System.Drawing.Size(66, 13);
            // 
            // cboAccountTo
            // 
            this.cboAccountTo.AccountStatusFlag = null;
            this.cboAccountTo.bs = this.bsAccounts;
            this.cboAccountTo.DefaultState = efControls.Enums.ControlState.Default;
            this.cboAccountTo.DropdownWidth = 0;
            this.cboAccountTo.EnterMoveNextControl = true;
            this.cboAccountTo.Location = new System.Drawing.Point(226, 30);
            this.cboAccountTo.Name = "cboAccountTo";
            this.cboAccountTo.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboAccountTo.Properties.ContextImage = ((System.Drawing.Image)(resources.GetObject("cboAccountTo.Properties.ContextImage")));
            this.cboAccountTo.Properties.ContextImageAlignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.cboAccountTo.Properties.DataSource = this.bsAccounts;
            this.cboAccountTo.Properties.DisplayMember = "Description";
            this.cboAccountTo.Properties.NullText = "";
            this.cboAccountTo.Properties.NullValuePrompt = "Select Account Or Leave Blank";
            this.cboAccountTo.Properties.NullValuePromptShowForEmptyValue = true;
            this.cboAccountTo.Properties.PopupFormMinSize = new System.Drawing.Size(350, 200);
            this.cboAccountTo.Properties.ValidateOnEnterKey = true;
            this.cboAccountTo.Properties.ValueMember = "ID";
            this.cboAccountTo.Properties.View = this.cboAccountToView;
            this.cboAccountTo.ShowAccountNumber = true;
            this.cboAccountTo.ShowContextImage = true;
            this.cboAccountTo.Size = new System.Drawing.Size(334, 20);
            this.cboAccountTo.StartWith = null;
            this.cboAccountTo.StyleController = this.lcReport;
            this.cboAccountTo.TabIndex = 3;
            this.cboAccountTo.ToolTip = "...";
            this.cboAccountTo.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.cboAccountTo.ToolTipTitle = "Press [CTRL+DELETE] To Clear Value ...";
            // 
            // cboAccountToView
            // 
            this.cboAccountToView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.cboAccountToView.Name = "cboAccountToView";
            this.cboAccountToView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.cboAccountToView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.cboAccountToView.OptionsCustomization.AllowColumnMoving = false;
            this.cboAccountToView.OptionsCustomization.AllowColumnResizing = false;
            this.cboAccountToView.OptionsCustomization.AllowFilter = false;
            this.cboAccountToView.OptionsFilter.AllowFilterEditor = false;
            this.cboAccountToView.OptionsFind.AllowFindPanel = false;
            this.cboAccountToView.OptionsFind.ShowClearButton = false;
            this.cboAccountToView.OptionsFind.ShowCloseButton = false;
            this.cboAccountToView.OptionsFind.ShowFindButton = false;
            this.cboAccountToView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.cboAccountToView.OptionsView.EnableAppearanceEvenRow = true;
            this.cboAccountToView.OptionsView.EnableAppearanceOddRow = true;
            this.cboAccountToView.OptionsView.ShowAutoFilterRow = true;
            this.cboAccountToView.OptionsView.ShowGroupPanel = false;
            this.cboAccountToView.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.cboAccountToView.OptionsView.ShowIndicator = false;
            this.cboAccountToView.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            // 
            // lciAccountTo
            // 
            this.lciAccountTo.Control = this.cboAccountTo;
            this.lciAccountTo.IsRequired = null;
            this.lciAccountTo.Location = new System.Drawing.Point(150, 24);
            this.lciAccountTo.Name = "lciAccountTo";
            this.lciAccountTo.Size = new System.Drawing.Size(408, 24);
            this.lciAccountTo.Text = "Account To";
            this.lciAccountTo.TextSize = new System.Drawing.Size(66, 13);
            // 
            // FormStatementOfAccount
            // 
            this.ClientSize = new System.Drawing.Size(902, 511);
            this.Name = "FormStatementOfAccount";
            this.Text = "Statement Of Account";
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
            ((System.ComponentModel.ISupportInitialize)(this.rgType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFromDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciToDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peScan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGridResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAccountFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAccountFromView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAccountFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAccountTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAccountToView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAccountTo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private cboCurrencies cboCurrencies;
        private efControls.lci lciCurrency;
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
        private System.Windows.Forms.BindingSource bsResult;
        private efControls.efGridColumn coljvdate;
        private efControls.efGridColumn coltype;
        private efControls.efGridColumn colreference;
        private efControls.efGridColumn coldescription1;
        private efControls.efGridColumn colcur;
        private efControls.efGridColumn colDebit;
        private efControls.efGridColumn colCredit;
        private efControls.efGridColumn colDebit1st;
        private efControls.efGridColumn colCredit1st;
        private efControls.efGridColumn colDebit2nd;
        private efControls.efGridColumn colCredit2nd;
        private efControls.efGridColumn colAccount;
        private efControls.efGridColumn colBalance;
        private efControls.efGridColumn colBalance1st;
        private efControls.efGridColumn colBalance2nd;
        private efControls.efGridColumn colScan;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit peScan;
        private efControls.efGridColumn colVouchertypeid;
        private DevExpress.Utils.ImageCollection formImages;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private cboAccounts cboAccountFrom;
        private efControls.lci lciAccountFrom;
        private cboAccounts cboAccountTo;
        private efControls.lci lciAccountTo;
        private DevExpress.XtraGrid.Views.Grid.GridView cboAccountToView;
        private DevExpress.XtraGrid.Views.Grid.GridView cboAccountFromView;
        private System.Windows.Forms.BindingSource bsAccounts;
        private efControls.efGridColumn colSC;
    }
}
