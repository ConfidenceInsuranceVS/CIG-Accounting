namespace Accounting
{
    partial class FormPrintJournal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrintJournal));
            this.deFrom = new efControls.efDateEdit();
            this.colCode = new efControls.efGridColumn();
            this.colDescription = new efControls.efGridColumn();
            this.rgType = new efControls.efRadioGroup();
            this.lciType = new efControls.lci();
            this.lciFromDate = new efControls.lci();
            this.deTo = new efControls.efDateEdit();
            this.lciToDate = new efControls.lci();
            this.cboVoucherTypes = new Accounting.cboVoucherTypes();
            this.lciVoucherTypes = new efControls.lci();
            this.lciFrom = new efControls.lci();
            this.txtFromReference = new efControls.efTextBox();
            this.lciTo = new efControls.lci();
            this.txtToReference = new efControls.efTextBox();
            this.bsResult = new System.Windows.Forms.BindingSource(this.components);
            this.cboAccounts = new Accounting.cboAccounts();
            this.cboAccountsView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lciAccount = new efControls.lci();
            this.gcResult = new efControls.efGridControl();
            this.gvResult = new efControls.efGridView();
            this.colSC = new efControls.efGridColumn();
            this.coljvdate = new efControls.efGridColumn();
            this.colType = new efControls.efGridColumn();
            this.colreference = new efControls.efGridColumn();
            this.colaccount = new efControls.efGridColumn();
            this.colAccountDescription = new efControls.efGridColumn();
            this.colDescription1 = new efControls.efGridColumn();
            this.colCurrency = new efControls.efGridColumn();
            this.colAmount = new efControls.efGridColumn();
            this.coldc = new efControls.efGridColumn();
            this.colcvAmount = new efControls.efGridColumn();
            this.colcvCur = new efControls.efGridColumn();
            this.coldetails = new efControls.efGridColumn();
            this.colfromTo = new efControls.efGridColumn();
            this.colTypeDescription = new efControls.efGridColumn();
            this.colAccount1 = new efControls.efGridColumn();
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.lciResult = new efControls.lci();
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
            ((System.ComponentModel.ISupportInitialize)(this.rgType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFromDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciToDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboVoucherTypes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciVoucherTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFromReference.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToReference.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAccounts.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAccountsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciResult)).BeginInit();
            this.SuspendLayout();
            // 
            // lcReport
            // 
            this.lcReport.Appearance.ControlReadOnly.BackColor = System.Drawing.Color.Transparent;
            this.lcReport.Appearance.ControlReadOnly.Options.UseBackColor = true;
            this.lcReport.Controls.Add(this.gcResult);
            this.lcReport.Controls.Add(this.cboAccounts);
            this.lcReport.Controls.Add(this.cboVoucherTypes);
            this.lcReport.Controls.Add(this.deTo);
            this.lcReport.Controls.Add(this.deFrom);
            this.lcReport.Controls.Add(this.rgType);
            this.lcReport.Controls.Add(this.txtFromReference);
            this.lcReport.Controls.Add(this.txtToReference);
            this.lcReport.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1031, 181, 250, 350);
            this.lcReport.OptionsFocus.EnableAutoTabOrder = false;
            this.lcReport.Size = new System.Drawing.Size(825, 450);
            // 
            // lcgReport
            // 
            this.lcgReport.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciResult,
            this.lciFromDate,
            this.lciToDate,
            this.lciAccount,
            this.lciVoucherTypes,
            this.lciFrom,
            this.lciTo,
            this.lciType});
            this.lcgReport.Name = "Root";
            this.lcgReport.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.lcgReport.Size = new System.Drawing.Size(825, 450);
            // 
            // lcMain
            // 
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(872, 84, 250, 876);
            this.lcMain.Size = new System.Drawing.Size(833, 488);
            this.lcMain.Controls.SetChildIndex(this.ucCtrlNavigator, 0);
            this.lcMain.Controls.SetChildIndex(this.lcReport, 0);
            // 
            // lcgMain
            // 
            this.lcgMain.Name = "Root";
            this.lcgMain.Size = new System.Drawing.Size(833, 488);
            // 
            // ucCtrlNavigator
            // 
            this.ucCtrlNavigator.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.ucCtrlNavigator.Appearance.Options.UseBackColor = true;
            this.ucCtrlNavigator.Location = new System.Drawing.Point(4, 458);
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
            this.deFrom.Location = new System.Drawing.Point(60, 6);
            this.deFrom.Name = "deFrom";
            this.deFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deFrom.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.deFrom.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.deFrom.Size = new System.Drawing.Size(72, 20);
            this.deFrom.StyleController = this.lcReport;
            this.deFrom.TabIndex = 0;
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
            this.rgType.Location = new System.Drawing.Point(589, 30);
            this.rgType.Name = "rgType";
            this.rgType.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgType.Properties.Appearance.Options.UseBackColor = true;
            this.rgType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rgType.Properties.Columns = 3;
            this.rgType.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Normal"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Official"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Vouchers")});
            this.rgType.Size = new System.Drawing.Size(230, 21);
            this.rgType.StyleController = this.lcReport;
            this.rgType.TabIndex = 6;
            this.rgType.SelectedIndexChanged += new System.EventHandler(this.rgType_SelectedIndexChanged);
            // 
            // lciType
            // 
            this.lciType.Control = this.rgType;
            this.lciType.CustomizationFormText = "lciType";
            this.lciType.IsRequired = null;
            this.lciType.Location = new System.Drawing.Point(583, 24);
            this.lciType.MaxSize = new System.Drawing.Size(0, 25);
            this.lciType.MinSize = new System.Drawing.Size(104, 25);
            this.lciType.Name = "lciType";
            this.lciType.Size = new System.Drawing.Size(234, 25);
            this.lciType.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciType.TextSize = new System.Drawing.Size(0, 0);
            this.lciType.TextVisible = false;
            // 
            // lciFromDate
            // 
            this.lciFromDate.Control = this.deFrom;
            this.lciFromDate.CustomizationFormText = "From Date";
            this.lciFromDate.IsRequired = null;
            this.lciFromDate.Location = new System.Drawing.Point(0, 0);
            this.lciFromDate.MaxSize = new System.Drawing.Size(130, 24);
            this.lciFromDate.MinSize = new System.Drawing.Size(130, 24);
            this.lciFromDate.Name = "lciFromDate";
            this.lciFromDate.Size = new System.Drawing.Size(130, 24);
            this.lciFromDate.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciFromDate.Text = "From Date";
            this.lciFromDate.TextSize = new System.Drawing.Size(50, 13);
            // 
            // deTo
            // 
            this.deTo.AllowLeadingSpace = false;
            this.deTo.DefaultState = efControls.Enums.ControlState.AlwaysEnabled;
            this.deTo.DisplayType = efControls.Enums.DisplayType.Default;
            this.deTo.EditValue = null;
            this.deTo.EnterMoveNextControl = true;
            this.deTo.Information = null;
            this.deTo.Location = new System.Drawing.Point(190, 6);
            this.deTo.Name = "deTo";
            this.deTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deTo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.deTo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.deTo.Size = new System.Drawing.Size(72, 20);
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
            this.lciToDate.Location = new System.Drawing.Point(130, 0);
            this.lciToDate.MaxSize = new System.Drawing.Size(130, 24);
            this.lciToDate.MinSize = new System.Drawing.Size(130, 24);
            this.lciToDate.Name = "lciToDate";
            this.lciToDate.Size = new System.Drawing.Size(130, 24);
            this.lciToDate.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciToDate.Text = "To Date";
            this.lciToDate.TextSize = new System.Drawing.Size(50, 13);
            // 
            // cboVoucherTypes
            // 
            this.cboVoucherTypes.DefaultState = efControls.Enums.ControlState.AlwaysEnabled;
            this.cboVoucherTypes.EnterMoveNextControl = true;
            this.cboVoucherTypes.Filter = Accounting.cboVoucherTypes.jvFilter.JV;
            this.cboVoucherTypes.Location = new System.Drawing.Point(320, 6);
            this.cboVoucherTypes.Name = "cboVoucherTypes";
            this.cboVoucherTypes.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboVoucherTypes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboVoucherTypes.Properties.Name = "efComboBox";
            this.cboVoucherTypes.Size = new System.Drawing.Size(265, 20);
            this.cboVoucherTypes.StyleController = this.lcReport;
            this.cboVoucherTypes.TabIndex = 2;
            // 
            // lciVoucherTypes
            // 
            this.lciVoucherTypes.Control = this.cboVoucherTypes;
            this.lciVoucherTypes.CustomizationFormText = "Type";
            this.lciVoucherTypes.IsRequired = null;
            this.lciVoucherTypes.Location = new System.Drawing.Point(260, 0);
            this.lciVoucherTypes.Name = "lciVoucherTypes";
            this.lciVoucherTypes.Size = new System.Drawing.Size(323, 24);
            this.lciVoucherTypes.Text = "Type";
            this.lciVoucherTypes.TextSize = new System.Drawing.Size(50, 13);
            // 
            // lciFrom
            // 
            this.lciFrom.Control = this.txtFromReference;
            this.lciFrom.CustomizationFormText = "From";
            this.lciFrom.IsRequired = null;
            this.lciFrom.Location = new System.Drawing.Point(583, 0);
            this.lciFrom.Name = "lciFrom";
            this.lciFrom.Size = new System.Drawing.Size(117, 24);
            this.lciFrom.Text = "From";
            this.lciFrom.TextSize = new System.Drawing.Size(50, 13);
            // 
            // txtFromReference
            // 
            this.txtFromReference.AllowLeadingSpace = false;
            this.txtFromReference.DefaultState = efControls.Enums.ControlState.Default;
            this.txtFromReference.DisplayType = efControls.Enums.DisplayType.Integer;
            this.txtFromReference.EnterMoveNextControl = true;
            this.txtFromReference.Information = null;
            this.txtFromReference.Location = new System.Drawing.Point(643, 6);
            this.txtFromReference.Name = "txtFromReference";
            this.txtFromReference.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.txtFromReference.Properties.Appearance.Options.UseTextOptions = true;
            this.txtFromReference.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtFromReference.Properties.Mask.EditMask = "f0";
            this.txtFromReference.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtFromReference.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtFromReference.Size = new System.Drawing.Size(59, 20);
            this.txtFromReference.StyleController = this.lcReport;
            this.txtFromReference.TabIndex = 3;
            // 
            // lciTo
            // 
            this.lciTo.Control = this.txtToReference;
            this.lciTo.CustomizationFormText = "To";
            this.lciTo.IsRequired = null;
            this.lciTo.Location = new System.Drawing.Point(700, 0);
            this.lciTo.Name = "lciTo";
            this.lciTo.Size = new System.Drawing.Size(117, 24);
            this.lciTo.Text = "To";
            this.lciTo.TextSize = new System.Drawing.Size(50, 13);
            // 
            // txtToReference
            // 
            this.txtToReference.AllowLeadingSpace = false;
            this.txtToReference.DefaultState = efControls.Enums.ControlState.Default;
            this.txtToReference.DisplayType = efControls.Enums.DisplayType.Integer;
            this.txtToReference.EnterMoveNextControl = true;
            this.txtToReference.Information = null;
            this.txtToReference.Location = new System.Drawing.Point(760, 6);
            this.txtToReference.Name = "txtToReference";
            this.txtToReference.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.txtToReference.Properties.Appearance.Options.UseTextOptions = true;
            this.txtToReference.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtToReference.Properties.Mask.EditMask = "f0";
            this.txtToReference.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtToReference.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtToReference.Size = new System.Drawing.Size(59, 20);
            this.txtToReference.StyleController = this.lcReport;
            this.txtToReference.TabIndex = 4;
            // 
            // bsResult
            // 
            this.bsResult.DataSource = typeof(Accounting.PrintVouchers);
            // 
            // cboAccounts
            // 
            this.cboAccounts.AccountStatusFlag = null;
            this.cboAccounts.bs = null;
            this.cboAccounts.DefaultState = efControls.Enums.ControlState.AlwaysEnabled;
            this.cboAccounts.DropdownWidth = 0;
            this.cboAccounts.EnterMoveNextControl = true;
            this.cboAccounts.Location = new System.Drawing.Point(60, 30);
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
            this.cboAccounts.Size = new System.Drawing.Size(525, 20);
            this.cboAccounts.StartWith = null;
            this.cboAccounts.StyleController = this.lcReport;
            this.cboAccounts.TabIndex = 5;
            this.cboAccounts.ToolTip = "...";
            this.cboAccounts.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.cboAccounts.ToolTipTitle = "Press [CTRL+DELETE] To Clear Value ...";
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
            this.lciAccount.ControlAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.lciAccount.IsRequired = null;
            this.lciAccount.Location = new System.Drawing.Point(0, 24);
            this.lciAccount.Name = "lciAccount";
            this.lciAccount.Size = new System.Drawing.Size(583, 25);
            this.lciAccount.Text = "Account";
            this.lciAccount.TextSize = new System.Drawing.Size(50, 13);
            // 
            // gcResult
            // 
            this.gcResult.DataSource = this.bsResult;
            this.gcResult.DefaultState = efControls.Enums.ControlState.AlwaysDisabled;
            this.gcResult.EmbeddedNavigatorHideButtons = false;
            this.gcResult.Location = new System.Drawing.Point(6, 55);
            this.gcResult.MainView = this.gvResult;
            this.gcResult.Name = "gcResult";
            this.gcResult.Size = new System.Drawing.Size(813, 389);
            this.gcResult.TabIndex = 10;
            this.gcResult.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvResult});
            // 
            // gvResult
            // 
            this.gvResult.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSC,
            this.coljvdate,
            this.colType,
            this.colreference,
            this.colaccount,
            this.colAccountDescription,
            this.colDescription1,
            this.colCurrency,
            this.colAmount,
            this.coldc,
            this.colcvAmount,
            this.colcvCur,
            this.coldetails,
            this.colfromTo,
            this.colTypeDescription,
            this.colAccount1});
            this.gvResult.GridControl = this.gcResult;
            this.gvResult.HighLightFocusedRow = true;
            this.gvResult.Images = this.imageCollection;
            this.gvResult.Name = "gvResult";
            this.gvResult.OptionsBehavior.ReadOnly = true;
            this.gvResult.OptionsView.ColumnAutoWidth = false;
            this.gvResult.OptionsView.ShowAutoFilterRow = true;
            this.gvResult.OptionsView.ShowGroupPanel = false;
            this.gvResult.OptionsView.ShowIndicator = false;
            this.gvResult.ParentForm = null;
            this.gvResult.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gvResult.VisibleAutoFilterRow = true;
            this.gvResult.VisibleGroupPanel = false;
            this.gvResult.VisibleIndicator = false;
            this.gvResult.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gvResult_RowCellClick);
            // 
            // colSC
            // 
            this.colSC.AlwaysDisabled = false;
            this.colSC.AppearanceHeader.Options.UseTextOptions = true;
            this.colSC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSC.CustomData = "";
            this.colSC.EditDisabled = false;
            this.colSC.FieldName = "SC";
            this.colSC.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.colSC.ImageIndex = 0;
            this.colSC.Name = "colSC";
            this.colSC.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSC.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colSC.Visible = true;
            this.colSC.VisibleIndex = 0;
            this.colSC.Width = 25;
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
            this.coljvdate.Name = "coljvdate";
            this.coljvdate.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.coljvdate.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.coljvdate.Visible = true;
            this.coljvdate.VisibleIndex = 1;
            this.coljvdate.Width = 65;
            // 
            // colType
            // 
            this.colType.AlwaysDisabled = false;
            this.colType.AppearanceHeader.Options.UseTextOptions = true;
            this.colType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colType.CustomData = "";
            this.colType.EditDisabled = false;
            this.colType.FieldName = "Type";
            this.colType.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.colType.ImageIndex = 2;
            this.colType.Name = "colType";
            this.colType.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colType.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colType.Width = 30;
            // 
            // colreference
            // 
            this.colreference.AlwaysDisabled = false;
            this.colreference.AppearanceHeader.Options.UseTextOptions = true;
            this.colreference.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colreference.Caption = "Ref.";
            this.colreference.CustomData = "";
            this.colreference.EditDisabled = false;
            this.colreference.FieldName = "Reference";
            this.colreference.Name = "colreference";
            this.colreference.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colreference.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colreference.Visible = true;
            this.colreference.VisibleIndex = 2;
            this.colreference.Width = 55;
            // 
            // colaccount
            // 
            this.colaccount.AlwaysDisabled = false;
            this.colaccount.AppearanceHeader.Options.UseTextOptions = true;
            this.colaccount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colaccount.Caption = "Account";
            this.colaccount.CustomData = "";
            this.colaccount.EditDisabled = false;
            this.colaccount.FieldName = "Account";
            this.colaccount.Name = "colaccount";
            this.colaccount.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colaccount.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colaccount.Width = 70;
            // 
            // colAccountDescription
            // 
            this.colAccountDescription.AlwaysDisabled = false;
            this.colAccountDescription.AppearanceHeader.Options.UseTextOptions = true;
            this.colAccountDescription.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAccountDescription.CustomData = "";
            this.colAccountDescription.EditDisabled = false;
            this.colAccountDescription.FieldName = "AccountDescription";
            this.colAccountDescription.Name = "colAccountDescription";
            this.colAccountDescription.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colAccountDescription.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colAccountDescription.Visible = true;
            this.colAccountDescription.VisibleIndex = 3;
            this.colAccountDescription.Width = 150;
            // 
            // colDescription1
            // 
            this.colDescription1.AlwaysDisabled = false;
            this.colDescription1.AppearanceHeader.Options.UseTextOptions = true;
            this.colDescription1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDescription1.CustomData = "";
            this.colDescription1.EditDisabled = false;
            this.colDescription1.FieldName = "Description";
            this.colDescription1.Name = "colDescription1";
            this.colDescription1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDescription1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDescription1.Visible = true;
            this.colDescription1.VisibleIndex = 4;
            this.colDescription1.Width = 242;
            // 
            // colCurrency
            // 
            this.colCurrency.AlwaysDisabled = false;
            this.colCurrency.AppearanceHeader.Options.UseTextOptions = true;
            this.colCurrency.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCurrency.CustomData = "";
            this.colCurrency.EditDisabled = false;
            this.colCurrency.FieldName = "Currency";
            this.colCurrency.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.colCurrency.ImageIndex = 1;
            this.colCurrency.Name = "colCurrency";
            this.colCurrency.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCurrency.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colCurrency.Visible = true;
            this.colCurrency.VisibleIndex = 5;
            this.colCurrency.Width = 30;
            // 
            // colAmount
            // 
            this.colAmount.AlwaysDisabled = false;
            this.colAmount.AppearanceHeader.Options.UseTextOptions = true;
            this.colAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAmount.Caption = "Amount";
            this.colAmount.CustomData = "";
            this.colAmount.EditDisabled = false;
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colAmount.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 6;
            this.colAmount.Width = 100;
            // 
            // coldc
            // 
            this.coldc.AlwaysDisabled = false;
            this.coldc.AppearanceHeader.Options.UseTextOptions = true;
            this.coldc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldc.Caption = "DC";
            this.coldc.CustomData = "";
            this.coldc.EditDisabled = false;
            this.coldc.FieldName = "DC";
            this.coldc.Name = "coldc";
            this.coldc.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.coldc.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.coldc.Visible = true;
            this.coldc.VisibleIndex = 7;
            this.coldc.Width = 25;
            // 
            // colcvAmount
            // 
            this.colcvAmount.AlwaysDisabled = false;
            this.colcvAmount.AppearanceHeader.Options.UseTextOptions = true;
            this.colcvAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colcvAmount.CustomData = "";
            this.colcvAmount.EditDisabled = false;
            this.colcvAmount.FieldName = "cvAmount";
            this.colcvAmount.Name = "colcvAmount";
            this.colcvAmount.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colcvAmount.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // colcvCur
            // 
            this.colcvCur.AlwaysDisabled = false;
            this.colcvCur.AppearanceHeader.Options.UseTextOptions = true;
            this.colcvCur.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colcvCur.CustomData = "";
            this.colcvCur.EditDisabled = false;
            this.colcvCur.FieldName = "cvCur";
            this.colcvCur.Name = "colcvCur";
            this.colcvCur.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colcvCur.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // coldetails
            // 
            this.coldetails.AlwaysDisabled = false;
            this.coldetails.AppearanceHeader.Options.UseTextOptions = true;
            this.coldetails.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldetails.CustomData = "";
            this.coldetails.EditDisabled = false;
            this.coldetails.FieldName = "details";
            this.coldetails.Name = "coldetails";
            this.coldetails.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.coldetails.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // colfromTo
            // 
            this.colfromTo.AlwaysDisabled = false;
            this.colfromTo.AppearanceHeader.Options.UseTextOptions = true;
            this.colfromTo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colfromTo.CustomData = "";
            this.colfromTo.EditDisabled = false;
            this.colfromTo.FieldName = "fromTo";
            this.colfromTo.Name = "colfromTo";
            this.colfromTo.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colfromTo.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // colTypeDescription
            // 
            this.colTypeDescription.AlwaysDisabled = false;
            this.colTypeDescription.AppearanceHeader.Options.UseTextOptions = true;
            this.colTypeDescription.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTypeDescription.CustomData = "";
            this.colTypeDescription.EditDisabled = false;
            this.colTypeDescription.FieldName = "TypeDescription";
            this.colTypeDescription.Name = "colTypeDescription";
            this.colTypeDescription.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colTypeDescription.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // colAccount1
            // 
            this.colAccount1.AlwaysDisabled = false;
            this.colAccount1.AppearanceHeader.Options.UseTextOptions = true;
            this.colAccount1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAccount1.CustomData = "";
            this.colAccount1.EditDisabled = false;
            this.colAccount1.FieldName = "Account";
            this.colAccount1.Name = "colAccount1";
            this.colAccount1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colAccount1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.InsertGalleryImage("group_16x16.png", "office2013/actions/group_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/group_16x16.png"), 0);
            this.imageCollection.Images.SetKeyName(0, "group_16x16.png");
            this.imageCollection.InsertGalleryImage("currency_16x16.png", "office2013/miscellaneous/currency_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/miscellaneous/currency_16x16.png"), 1);
            this.imageCollection.Images.SetKeyName(1, "currency_16x16.png");
            this.imageCollection.InsertGalleryImage("tag_16x16.png", "office2013/programming/tag_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/programming/tag_16x16.png"), 2);
            this.imageCollection.Images.SetKeyName(2, "tag_16x16.png");
            // 
            // lciResult
            // 
            this.lciResult.Control = this.gcResult;
            this.lciResult.IsRequired = null;
            this.lciResult.Location = new System.Drawing.Point(0, 49);
            this.lciResult.Name = "lciResult";
            this.lciResult.Size = new System.Drawing.Size(817, 393);
            this.lciResult.TextSize = new System.Drawing.Size(0, 0);
            this.lciResult.TextVisible = false;
            // 
            // FormPrintJournal
            // 
            this.ClientSize = new System.Drawing.Size(833, 488);
            this.Name = "FormPrintJournal";
            this.Text = "Print Journal";
            this.xState = efControls.Enums.State.None;
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
            ((System.ComponentModel.ISupportInitialize)(this.rgType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFromDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciToDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboVoucherTypes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciVoucherTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFromReference.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToReference.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAccounts.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAccountsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsResult;
        private efControls.efGridColumn colCode;
        private efControls.efGridColumn colDescription;
        private efControls.efDateEdit deTo;
        private efControls.efDateEdit deFrom;
        private efControls.efRadioGroup rgType;
        private efControls.lci lciType;
        private efControls.lci lciFromDate;
        private efControls.lci lciToDate;
        private cboVoucherTypes cboVoucherTypes;
        private efControls.lci lciVoucherTypes;
        private efControls.lci lciFrom;
        private efControls.lci lciTo;
        private efControls.efTextBox txtFromReference;
        private efControls.efTextBox txtToReference;
        private cboAccounts cboAccounts;
        private efControls.lci lciAccount;
        private DevExpress.XtraGrid.Views.Grid.GridView cboAccountsView;
        private efControls.efGridControl gcResult;
        private efControls.efGridView gvResult;
        private efControls.lci lciResult;
        private efControls.efGridColumn coljvdate;
        private efControls.efGridColumn colType;
        private efControls.efGridColumn colreference;
        private efControls.efGridColumn colaccount;
        private efControls.efGridColumn colAccountDescription;
        private efControls.efGridColumn colDescription1;
        private efControls.efGridColumn colCurrency;
        private efControls.efGridColumn colAmount;
        private efControls.efGridColumn coldc;
        private DevExpress.Utils.ImageCollection imageCollection;
        private efControls.efGridColumn colSC;
        private efControls.efGridColumn colcvAmount;
        private efControls.efGridColumn colcvCur;
        private efControls.efGridColumn coldetails;
        private efControls.efGridColumn colfromTo;
        private efControls.efGridColumn colTypeDescription;
        private efControls.efGridColumn colAccount1;
    }
}
