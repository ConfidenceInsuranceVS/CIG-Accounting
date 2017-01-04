namespace Accounting
{
    partial class FormProfitAndLoss
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProfitAndLoss));
            this.rgCurrencyType = new efControls.efRadioGroup();
            this.lciCurrencyType = new efControls.lci();
            this.bsResult = new System.Windows.Forms.BindingSource(this.components);
            this.spnLevel = new efControls.efSpinner();
            this.lciLevel = new efControls.lci();
            this.spnFromMonth = new efControls.efSpinner();
            this.lciFromMonth = new efControls.lci();
            this.spnToMonth = new efControls.efSpinner();
            this.lciToMonth = new efControls.lci();
            this.gcResult = new efControls.efGridControl();
            this.gvResult = new efControls.efGridView();
            this.colGroup = new efControls.efGridColumn();
            this.colCode = new efControls.efGridColumn();
            this.colSC = new efControls.efGridColumn();
            this.colCurrency = new efControls.efGridColumn();
            this.colDescription = new efControls.efGridColumn();
            this.colDebit = new efControls.efGridColumn();
            this.colCredit = new efControls.efGridColumn();
            this.colBalance = new efControls.efGridColumn();
            this.lciResult = new efControls.lci();
            this.chkBeforeClosing = new efControls.efCheckBox();
            this.lciBeforeClosing = new efControls.lci();
            ((System.ComponentModel.ISupportInitialize)(this.lcReport)).BeginInit();
            this.lcReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcgReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgCurrencyType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCurrencyType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnLevel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnFromMonth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFromMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnToMonth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciToMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBeforeClosing.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBeforeClosing)).BeginInit();
            this.SuspendLayout();
            // 
            // lcReport
            // 
            this.lcReport.Appearance.ControlReadOnly.BackColor = System.Drawing.Color.Transparent;
            this.lcReport.Appearance.ControlReadOnly.Options.UseBackColor = true;
            this.lcReport.Controls.Add(this.chkBeforeClosing);
            this.lcReport.Controls.Add(this.gcResult);
            this.lcReport.Controls.Add(this.spnToMonth);
            this.lcReport.Controls.Add(this.spnFromMonth);
            this.lcReport.Controls.Add(this.spnLevel);
            this.lcReport.Controls.Add(this.rgCurrencyType);
            this.lcReport.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(968, 158, 250, 350);
            this.lcReport.Size = new System.Drawing.Size(895, 485);
            // 
            // lcgReport
            // 
            this.lcgReport.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciLevel,
            this.lciResult,
            this.lciFromMonth,
            this.lciToMonth,
            this.lciCurrencyType,
            this.lciBeforeClosing});
            this.lcgReport.Name = "Root";
            this.lcgReport.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.lcgReport.Size = new System.Drawing.Size(895, 485);
            // 
            // lcMain
            // 
            this.lcMain.Size = new System.Drawing.Size(903, 523);
            this.lcMain.Controls.SetChildIndex(this.ucCtrlNavigator, 0);
            this.lcMain.Controls.SetChildIndex(this.lcReport, 0);
            // 
            // lcgMain
            // 
            this.lcgMain.Size = new System.Drawing.Size(903, 523);
            // 
            // ucCtrlNavigator
            // 
            this.ucCtrlNavigator.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.ucCtrlNavigator.Appearance.Options.UseBackColor = true;
            this.ucCtrlNavigator.Location = new System.Drawing.Point(4, 493);
            this.ucCtrlNavigator.NavigatableControl = this.gcResult;
            // 
            // rgCurrencyType
            // 
            this.rgCurrencyType.Location = new System.Drawing.Point(561, 4);
            this.rgCurrencyType.Name = "rgCurrencyType";
            this.rgCurrencyType.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgCurrencyType.Properties.Appearance.Options.UseBackColor = true;
            this.rgCurrencyType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rgCurrencyType.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "First Local"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Second Local")});
            this.rgCurrencyType.Size = new System.Drawing.Size(330, 21);
            this.rgCurrencyType.StyleController = this.lcReport;
            this.rgCurrencyType.TabIndex = 4;
            // 
            // lciCurrencyType
            // 
            this.lciCurrencyType.Control = this.rgCurrencyType;
            this.lciCurrencyType.ControlAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.lciCurrencyType.CustomizationFormText = "lci1";
            this.lciCurrencyType.IsRequired = null;
            this.lciCurrencyType.Location = new System.Drawing.Point(557, 0);
            this.lciCurrencyType.MaxSize = new System.Drawing.Size(0, 25);
            this.lciCurrencyType.MinSize = new System.Drawing.Size(104, 25);
            this.lciCurrencyType.Name = "lciCurrencyType";
            this.lciCurrencyType.Size = new System.Drawing.Size(334, 25);
            this.lciCurrencyType.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciCurrencyType.TextSize = new System.Drawing.Size(0, 0);
            this.lciCurrencyType.TextVisible = false;
            // 
            // bsResult
            // 
            this.bsResult.DataSource = typeof(Accounting.ProfitAndLoss);
            // 
            // spnLevel
            // 
            this.spnLevel.AllowLeadingSpace = false;
            this.spnLevel.DefaultState = efControls.Enums.ControlState.Default;
            this.spnLevel.DisplayType = efControls.Enums.DisplayType.Default;
            this.spnLevel.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnLevel.EnterMoveNextControl = true;
            this.spnLevel.Information = null;
            this.spnLevel.Location = new System.Drawing.Point(65, 4);
            this.spnLevel.Name = "spnLevel";
            this.spnLevel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spnLevel.Properties.Mask.EditMask = "f0";
            this.spnLevel.Size = new System.Drawing.Size(50, 20);
            this.spnLevel.StyleController = this.lcReport;
            this.spnLevel.TabIndex = 0;
            // 
            // lciLevel
            // 
            this.lciLevel.Control = this.spnLevel;
            this.lciLevel.IsRequired = null;
            this.lciLevel.Location = new System.Drawing.Point(0, 0);
            this.lciLevel.MaxSize = new System.Drawing.Size(115, 24);
            this.lciLevel.MinSize = new System.Drawing.Size(115, 24);
            this.lciLevel.Name = "lciLevel";
            this.lciLevel.Size = new System.Drawing.Size(115, 25);
            this.lciLevel.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciLevel.Text = "Level";
            this.lciLevel.TextSize = new System.Drawing.Size(57, 13);
            // 
            // spnFromMonth
            // 
            this.spnFromMonth.AllowLeadingSpace = false;
            this.spnFromMonth.DefaultState = efControls.Enums.ControlState.Default;
            this.spnFromMonth.DisplayType = efControls.Enums.DisplayType.Default;
            this.spnFromMonth.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnFromMonth.EnterMoveNextControl = true;
            this.spnFromMonth.Information = null;
            this.spnFromMonth.Location = new System.Drawing.Point(180, 4);
            this.spnFromMonth.Name = "spnFromMonth";
            this.spnFromMonth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spnFromMonth.Properties.Mask.EditMask = "f0";
            this.spnFromMonth.Size = new System.Drawing.Size(50, 20);
            this.spnFromMonth.StyleController = this.lcReport;
            this.spnFromMonth.TabIndex = 1;
            // 
            // lciFromMonth
            // 
            this.lciFromMonth.Control = this.spnFromMonth;
            this.lciFromMonth.IsRequired = null;
            this.lciFromMonth.Location = new System.Drawing.Point(115, 0);
            this.lciFromMonth.MaxSize = new System.Drawing.Size(115, 24);
            this.lciFromMonth.MinSize = new System.Drawing.Size(115, 24);
            this.lciFromMonth.Name = "lciFromMonth";
            this.lciFromMonth.Size = new System.Drawing.Size(115, 25);
            this.lciFromMonth.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciFromMonth.Text = "From Month";
            this.lciFromMonth.TextSize = new System.Drawing.Size(57, 13);
            // 
            // spnToMonth
            // 
            this.spnToMonth.AllowLeadingSpace = false;
            this.spnToMonth.DefaultState = efControls.Enums.ControlState.Default;
            this.spnToMonth.DisplayType = efControls.Enums.DisplayType.Default;
            this.spnToMonth.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnToMonth.EnterMoveNextControl = true;
            this.spnToMonth.Information = null;
            this.spnToMonth.Location = new System.Drawing.Point(295, 4);
            this.spnToMonth.Name = "spnToMonth";
            this.spnToMonth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spnToMonth.Properties.Mask.EditMask = "f0";
            this.spnToMonth.Size = new System.Drawing.Size(50, 20);
            this.spnToMonth.StyleController = this.lcReport;
            this.spnToMonth.TabIndex = 2;
            // 
            // lciToMonth
            // 
            this.lciToMonth.Control = this.spnToMonth;
            this.lciToMonth.IsRequired = null;
            this.lciToMonth.Location = new System.Drawing.Point(230, 0);
            this.lciToMonth.MaxSize = new System.Drawing.Size(115, 24);
            this.lciToMonth.MinSize = new System.Drawing.Size(115, 24);
            this.lciToMonth.Name = "lciToMonth";
            this.lciToMonth.Size = new System.Drawing.Size(115, 25);
            this.lciToMonth.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciToMonth.Text = "To Month";
            this.lciToMonth.TextSize = new System.Drawing.Size(57, 13);
            // 
            // gcResult
            // 
            this.gcResult.DataSource = this.bsResult;
            this.gcResult.DefaultState = efControls.Enums.ControlState.AlwaysDisabled;
            this.gcResult.EmbeddedNavigatorHideButtons = false;
            this.gcResult.Location = new System.Drawing.Point(4, 29);
            this.gcResult.MainView = this.gvResult;
            this.gcResult.Name = "gcResult";
            this.gcResult.Size = new System.Drawing.Size(887, 452);
            this.gcResult.TabIndex = 15;
            this.gcResult.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvResult});
            // 
            // gvResult
            // 
            this.gvResult.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGroup,
            this.colCode,
            this.colSC,
            this.colCurrency,
            this.colDescription,
            this.colDebit,
            this.colCredit,
            this.colBalance});
            this.gvResult.GridControl = this.gcResult;
            this.gvResult.GroupCount = 1;
            this.gvResult.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Debit", this.colDebit, "{0:#,#0.00;;\"\"}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Credit", this.colCredit, "{0:#,#0.00;;\"\"}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "colBalance", this.colBalance, "{0:#,#0.00;;\"\"}")});
            this.gvResult.HighLightFocusedRow = false;
            this.gvResult.Name = "gvResult";
            this.gvResult.OptionsBehavior.ReadOnly = true;
            this.gvResult.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gvResult.OptionsView.ColumnAutoWidth = false;
            this.gvResult.OptionsView.ShowAutoFilterRow = true;
            this.gvResult.OptionsView.ShowFooter = true;
            this.gvResult.OptionsView.ShowGroupPanel = false;
            this.gvResult.OptionsView.ShowIndicator = false;
            this.gvResult.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colGroup, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvResult.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gvResult.VisibleAutoFilterRow = true;
            this.gvResult.VisibleGroupPanel = false;
            this.gvResult.VisibleIndicator = false;
            // 
            // colGroup
            // 
            this.colGroup.AlwaysDisabled = false;
            this.colGroup.AppearanceHeader.Options.UseTextOptions = true;
            this.colGroup.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGroup.Caption = "Total Class";
            this.colGroup.CustomData = "";
            this.colGroup.FieldName = "colGroup";
            this.colGroup.Name = "colGroup";
            this.colGroup.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colGroup.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colGroup.UnboundExpression = "Substring([Code], 0, 1)";
            this.colGroup.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.colGroup.Visible = true;
            this.colGroup.VisibleIndex = 0;
            this.colGroup.Width = 20;
            // 
            // colCode
            // 
            this.colCode.AlwaysDisabled = false;
            this.colCode.AppearanceHeader.Options.UseTextOptions = true;
            this.colCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCode.CustomData = "";
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCode.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 0;
            this.colCode.Width = 95;
            // 
            // colSC
            // 
            this.colSC.AlwaysDisabled = false;
            this.colSC.AppearanceHeader.Options.UseTextOptions = true;
            this.colSC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSC.CustomData = "";
            this.colSC.FieldName = "SC";
            this.colSC.Image = ((System.Drawing.Image)(resources.GetObject("colSC.Image")));
            this.colSC.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.colSC.Name = "colSC";
            this.colSC.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSC.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Equals;
            this.colSC.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colSC.Visible = true;
            this.colSC.VisibleIndex = 1;
            this.colSC.Width = 25;
            // 
            // colCurrency
            // 
            this.colCurrency.AlwaysDisabled = false;
            this.colCurrency.AppearanceHeader.Options.UseTextOptions = true;
            this.colCurrency.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCurrency.CustomData = "";
            this.colCurrency.FieldName = "Currency";
            this.colCurrency.Image = ((System.Drawing.Image)(resources.GetObject("colCurrency.Image")));
            this.colCurrency.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.colCurrency.Name = "colCurrency";
            this.colCurrency.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCurrency.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Equals;
            this.colCurrency.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colCurrency.Visible = true;
            this.colCurrency.VisibleIndex = 2;
            this.colCurrency.Width = 35;
            // 
            // colDescription
            // 
            this.colDescription.AlwaysDisabled = false;
            this.colDescription.AppearanceHeader.Options.UseTextOptions = true;
            this.colDescription.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDescription.CustomData = "";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDescription.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 3;
            this.colDescription.Width = 322;
            // 
            // colDebit
            // 
            this.colDebit.AlwaysDisabled = false;
            this.colDebit.AppearanceHeader.Options.UseTextOptions = true;
            this.colDebit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDebit.CustomData = "";
            this.colDebit.DisplayFormat.FormatString = "{0:#,#0.00;;\"\"}";
            this.colDebit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colDebit.FieldName = "Debit";
            this.colDebit.Name = "colDebit";
            this.colDebit.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDebit.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDebit.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Debit", "{0:#,#0.00;;\"\"}")});
            this.colDebit.Visible = true;
            this.colDebit.VisibleIndex = 4;
            this.colDebit.Width = 130;
            // 
            // colCredit
            // 
            this.colCredit.AlwaysDisabled = false;
            this.colCredit.AppearanceHeader.Options.UseTextOptions = true;
            this.colCredit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCredit.CustomData = "";
            this.colCredit.DisplayFormat.FormatString = "{0:#,#0.00;;\"\"}";
            this.colCredit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colCredit.FieldName = "Credit";
            this.colCredit.Name = "colCredit";
            this.colCredit.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCredit.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colCredit.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Credit", "{0:#,#0.00;;\"\"}")});
            this.colCredit.Visible = true;
            this.colCredit.VisibleIndex = 5;
            this.colCredit.Width = 130;
            // 
            // colBalance
            // 
            this.colBalance.AlwaysDisabled = false;
            this.colBalance.AppearanceHeader.Options.UseTextOptions = true;
            this.colBalance.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBalance.Caption = "Balance";
            this.colBalance.CustomData = "";
            this.colBalance.DisplayFormat.FormatString = "{0:#,#0.00;;\"\"}";
            this.colBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colBalance.FieldName = "colBalance";
            this.colBalance.Name = "colBalance";
            this.colBalance.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colBalance.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colBalance.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "colBalance", "{0:#,#0.00;;\"\"}")});
            this.colBalance.UnboundExpression = "[Debit] - [Credit]";
            this.colBalance.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colBalance.Visible = true;
            this.colBalance.VisibleIndex = 6;
            this.colBalance.Width = 130;
            // 
            // lciResult
            // 
            this.lciResult.Control = this.gcResult;
            this.lciResult.IsRequired = null;
            this.lciResult.Location = new System.Drawing.Point(0, 25);
            this.lciResult.Name = "lciResult";
            this.lciResult.Size = new System.Drawing.Size(891, 456);
            this.lciResult.TextSize = new System.Drawing.Size(0, 0);
            this.lciResult.TextVisible = false;
            // 
            // chkBeforeClosing
            // 
            this.chkBeforeClosing.DefaultState = efControls.Enums.ControlState.Default;
            this.chkBeforeClosing.EnterMoveNextControl = true;
            this.chkBeforeClosing.HighLighted = false;
            this.chkBeforeClosing.Location = new System.Drawing.Point(349, 4);
            this.chkBeforeClosing.Name = "chkBeforeClosing";
            this.chkBeforeClosing.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.chkBeforeClosing.Properties.Appearance.Options.UseBackColor = true;
            this.chkBeforeClosing.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Transparent;
            this.chkBeforeClosing.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.chkBeforeClosing.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Transparent;
            this.chkBeforeClosing.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.chkBeforeClosing.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Transparent;
            this.chkBeforeClosing.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.chkBeforeClosing.Properties.Caption = "Before Closing";
            this.chkBeforeClosing.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.chkBeforeClosing.Size = new System.Drawing.Size(208, 19);
            this.chkBeforeClosing.StyleController = this.lcReport;
            this.chkBeforeClosing.TabIndex = 3;
            this.chkBeforeClosing.ValueType = efControls.Enums.ValueType.Boolean;
            // 
            // lciBeforeClosing
            // 
            this.lciBeforeClosing.Control = this.chkBeforeClosing;
            this.lciBeforeClosing.IsRequired = null;
            this.lciBeforeClosing.Location = new System.Drawing.Point(345, 0);
            this.lciBeforeClosing.MaxSize = new System.Drawing.Size(212, 23);
            this.lciBeforeClosing.MinSize = new System.Drawing.Size(212, 23);
            this.lciBeforeClosing.Name = "lciBeforeClosing";
            this.lciBeforeClosing.Size = new System.Drawing.Size(212, 25);
            this.lciBeforeClosing.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciBeforeClosing.TextSize = new System.Drawing.Size(0, 0);
            this.lciBeforeClosing.TextVisible = false;
            // 
            // FormProfitAndLoss
            // 
            this.ClientSize = new System.Drawing.Size(903, 523);
            this.Name = "FormProfitAndLoss";
            this.Text = "Profit And Loss Report";
            ((System.ComponentModel.ISupportInitialize)(this.lcReport)).EndInit();
            this.lcReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcgReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgCurrencyType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCurrencyType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnLevel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnFromMonth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFromMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnToMonth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciToMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBeforeClosing.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBeforeClosing)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private efControls.efRadioGroup rgCurrencyType;
        private efControls.lci lciCurrencyType;
        private System.Windows.Forms.BindingSource bsResult;
        private efControls.efGridControl gcResult;
        private efControls.efGridView gvResult;
        private efControls.efSpinner spnToMonth;
        private efControls.efSpinner spnFromMonth;
        private efControls.efSpinner spnLevel;
        private efControls.lci lciLevel;
        private efControls.lci lciResult;
        private efControls.lci lciFromMonth;
        private efControls.lci lciToMonth;
        private efControls.efGridColumn colCode;
        private efControls.efGridColumn colCurrency;
        private efControls.efGridColumn colDescription;
        private efControls.efGridColumn colDebit;
        private efControls.efGridColumn colCredit;
        private efControls.efCheckBox chkBeforeClosing;
        private efControls.lci lciBeforeClosing;
        private efControls.efGridColumn colBalance;
        private efControls.efGridColumn colGroup;
        private efControls.efGridColumn colSC;
    }
}
