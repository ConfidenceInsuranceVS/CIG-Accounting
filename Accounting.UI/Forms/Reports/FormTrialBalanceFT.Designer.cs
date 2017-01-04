namespace Accounting
{
    partial class FormTrialBalanceFT
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTrialBalanceFT));
            this.deFrom = new efControls.efDateEdit();
            this.cboCurrencies = new Accounting.cboCurrencies();
            this.lciCurrency = new efControls.lci();
            this.colCode = new efControls.efGridColumn();
            this.rgType = new efControls.efRadioGroup();
            this.lciFromDate = new efControls.lci();
            this.deTo = new efControls.efDateEdit();
            this.lciToDate = new efControls.lci();
            this.gcResult = new efControls.efGridControl();
            this.bsResult = new System.Windows.Forms.BindingSource(this.components);
            this.gvResult = new efControls.efGridView();
            this.colSC = new efControls.efGridColumn();
            this.colAccount = new efControls.efGridColumn();
            this.colDescription = new efControls.efGridColumn();
            this.colCurrency = new efControls.efGridColumn();
            this.colDebit = new efControls.efGridColumn();
            this.colCredit = new efControls.efGridColumn();
            this.colBalance = new efControls.efGridColumn();
            this.colDebit1st = new efControls.efGridColumn();
            this.colCredit1st = new efControls.efGridColumn();
            this.colBalance1st = new efControls.efGridColumn();
            this.colDebit2nd = new efControls.efGridColumn();
            this.colCredit2nd = new efControls.efGridColumn();
            this.colBalance2nd = new efControls.efGridColumn();
            this.colLevel = new efControls.efGridColumn();
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.lciGridResult = new efControls.lci();
            this.lciType = new efControls.lci();
            this.lcgCriteria = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciBeforeClosing = new efControls.lci();
            this.chkBeforeClosing = new efControls.efCheckBox();
            this.lciLevel = new efControls.lci();
            this.spnLevel = new efControls.efSpinner();
            this.spnToClass = new efControls.efSpinner();
            this.lciToClass = new efControls.lci();
            this.spnFromClass = new efControls.efSpinner();
            this.lciFromClass = new efControls.lci();
            this.chkSkipBalanceZero = new efControls.efCheckBox();
            this.lciSkipBalanceZero = new efControls.lci();
            this.chkSkipOverZeros = new efControls.efCheckBox();
            this.lciSkipOverZeros = new efControls.lci();
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
            ((System.ComponentModel.ISupportInitialize)(this.lciFromDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciToDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGridResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgCriteria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBeforeClosing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBeforeClosing.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnLevel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnToClass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciToClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnFromClass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFromClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSkipBalanceZero.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSkipBalanceZero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSkipOverZeros.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSkipOverZeros)).BeginInit();
            this.SuspendLayout();
            // 
            // lcReport
            // 
            this.lcReport.Appearance.ControlReadOnly.BackColor = System.Drawing.Color.Transparent;
            this.lcReport.Appearance.ControlReadOnly.Options.UseBackColor = true;
            this.lcReport.Controls.Add(this.chkSkipOverZeros);
            this.lcReport.Controls.Add(this.chkSkipBalanceZero);
            this.lcReport.Controls.Add(this.chkBeforeClosing);
            this.lcReport.Controls.Add(this.spnFromClass);
            this.lcReport.Controls.Add(this.spnToClass);
            this.lcReport.Controls.Add(this.spnLevel);
            this.lcReport.Controls.Add(this.rgType);
            this.lcReport.Controls.Add(this.gcResult);
            this.lcReport.Controls.Add(this.deTo);
            this.lcReport.Controls.Add(this.deFrom);
            this.lcReport.Controls.Add(this.cboCurrencies);
            this.lcReport.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(140, 160, 250, 350);
            this.lcReport.OptionsFocus.EnableAutoTabOrder = false;
            this.lcReport.Size = new System.Drawing.Size(847, 463);
            // 
            // lcgReport
            // 
            this.lcgReport.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciGridResult,
            this.lcgCriteria,
            this.lciType,
            this.lciFromClass,
            this.lciToClass,
            this.lciSkipOverZeros,
            this.lciSkipBalanceZero});
            this.lcgReport.Name = "Root";
            this.lcgReport.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.lcgReport.Size = new System.Drawing.Size(847, 463);
            // 
            // lcMain
            // 
            this.lcMain.Size = new System.Drawing.Size(855, 501);
            this.lcMain.Controls.SetChildIndex(this.ucCtrlNavigator, 0);
            this.lcMain.Controls.SetChildIndex(this.lcReport, 0);
            // 
            // lcgMain
            // 
            this.lcgMain.Size = new System.Drawing.Size(855, 501);
            // 
            // ucCtrlNavigator
            // 
            this.ucCtrlNavigator.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.ucCtrlNavigator.Appearance.Options.UseBackColor = true;
            this.ucCtrlNavigator.Location = new System.Drawing.Point(4, 471);
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
            this.deFrom.Location = new System.Drawing.Point(63, 26);
            this.deFrom.Name = "deFrom";
            this.deFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deFrom.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.deFrom.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.deFrom.Size = new System.Drawing.Size(75, 20);
            this.deFrom.StyleController = this.lcReport;
            this.deFrom.TabIndex = 0;
            // 
            // cboCurrencies
            // 
            this.cboCurrencies.bs = null;
            this.cboCurrencies.DefaultState = efControls.Enums.ControlState.AlwaysEnabled;
            this.cboCurrencies.EnterMoveNextControl = true;
            this.cboCurrencies.Location = new System.Drawing.Point(332, 26);
            this.cboCurrencies.Name = "cboCurrencies";
            this.cboCurrencies.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboCurrencies.Properties.Name = "efComboBox";
            this.cboCurrencies.Size = new System.Drawing.Size(265, 20);
            this.cboCurrencies.StyleController = this.lcReport;
            this.cboCurrencies.TabIndex = 2;
            this.cboCurrencies.ValueToDisplay = Accounting.cboCurrencies.DisplayValue.Description;
            // 
            // lciCurrency
            // 
            this.lciCurrency.Control = this.cboCurrencies;
            this.lciCurrency.CustomizationFormText = "Currency";
            this.lciCurrency.IsRequired = null;
            this.lciCurrency.Location = new System.Drawing.Point(270, 0);
            this.lciCurrency.Name = "lciCurrency";
            this.lciCurrency.OptionsTableLayoutItem.RowIndex = 2;
            this.lciCurrency.Size = new System.Drawing.Size(324, 24);
            this.lciCurrency.Text = "Currency";
            this.lciCurrency.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.lciCurrency.TextLocation = DevExpress.Utils.Locations.Left;
            this.lciCurrency.TextSize = new System.Drawing.Size(44, 13);
            this.lciCurrency.TextToControlDistance = 11;
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
            // rgType
            // 
            this.rgType.AutoSizeInLayoutControl = true;
            this.rgType.EditValue = 0;
            this.rgType.Location = new System.Drawing.Point(492, 438);
            this.rgType.MaximumSize = new System.Drawing.Size(0, 22);
            this.rgType.MinimumSize = new System.Drawing.Size(100, 22);
            this.rgType.Name = "rgType";
            this.rgType.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgType.Properties.Appearance.Options.UseBackColor = true;
            this.rgType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rgType.Properties.Columns = 4;
            this.rgType.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.rgType.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "First Local"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Second Local"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(3, "All")});
            this.rgType.Properties.ItemsLayout = DevExpress.XtraEditors.RadioGroupItemsLayout.Flow;
            this.rgType.Size = new System.Drawing.Size(351, 22);
            this.rgType.StyleController = this.lcReport;
            this.rgType.TabIndex = 6;
            this.rgType.EditValueChanged += new System.EventHandler(this.rgType_EditValueChanged);
            // 
            // lciFromDate
            // 
            this.lciFromDate.Control = this.deFrom;
            this.lciFromDate.CustomizationFormText = "From Date";
            this.lciFromDate.IsRequired = null;
            this.lciFromDate.Location = new System.Drawing.Point(0, 0);
            this.lciFromDate.Name = "lciFromDate";
            this.lciFromDate.Size = new System.Drawing.Size(135, 24);
            this.lciFromDate.Text = "From Date";
            this.lciFromDate.TextSize = new System.Drawing.Size(52, 13);
            // 
            // deTo
            // 
            this.deTo.AllowLeadingSpace = false;
            this.deTo.DefaultState = efControls.Enums.ControlState.AlwaysEnabled;
            this.deTo.DisplayType = efControls.Enums.DisplayType.Default;
            this.deTo.EditValue = null;
            this.deTo.EnterMoveNextControl = true;
            this.deTo.Information = null;
            this.deTo.Location = new System.Drawing.Point(198, 26);
            this.deTo.Name = "deTo";
            this.deTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deTo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.deTo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.deTo.Size = new System.Drawing.Size(75, 20);
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
            this.lciToDate.Location = new System.Drawing.Point(135, 0);
            this.lciToDate.Name = "lciToDate";
            this.lciToDate.OptionsTableLayoutItem.RowIndex = 1;
            this.lciToDate.Size = new System.Drawing.Size(135, 24);
            this.lciToDate.Text = "To Date";
            this.lciToDate.TextSize = new System.Drawing.Size(52, 13);
            // 
            // gcResult
            // 
            this.gcResult.DataSource = this.bsResult;
            this.gcResult.DefaultState = efControls.Enums.ControlState.AlwaysDisabled;
            this.gcResult.EmbeddedNavigatorHideButtons = false;
            gridLevelNode1.RelationName = "Level1";
            this.gcResult.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gcResult.Location = new System.Drawing.Point(4, 53);
            this.gcResult.MainView = this.gvResult;
            this.gcResult.Name = "gcResult";
            this.gcResult.Size = new System.Drawing.Size(839, 381);
            this.gcResult.TabIndex = 13;
            this.gcResult.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvResult});
            // 
            // bsResult
            // 
            this.bsResult.DataSource = typeof(Accounting.TrialBalance);
            // 
            // gvResult
            // 
            this.gvResult.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvResult.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvResult.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.gvResult.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSC,
            this.colAccount,
            this.colDescription,
            this.colCurrency,
            this.colDebit,
            this.colCredit,
            this.colBalance,
            this.colDebit1st,
            this.colCredit1st,
            this.colBalance1st,
            this.colDebit2nd,
            this.colCredit2nd,
            this.colBalance2nd,
            this.colLevel});
            this.gvResult.GridControl = this.gcResult;
            this.gvResult.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Debit", this.colDebit, "{0:0.##}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Credit", this.colCredit, "{0:0.##}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Debit1st", this.colDebit1st, "{0:0.##}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Credit1st", this.colCredit1st, "{0:0.##}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Debit2nd", this.colDebit2nd, "{0:0.##}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Credit2nd", this.colCredit2nd, "{0:0.##}")});
            this.gvResult.HighLightFocusedRow = true;
            this.gvResult.Images = this.imageCollection;
            this.gvResult.Name = "gvResult";
            this.gvResult.OptionsBehavior.ReadOnly = true;
            this.gvResult.OptionsView.ColumnAutoWidth = false;
            this.gvResult.OptionsView.ShowAutoFilterRow = true;
            this.gvResult.OptionsView.ShowFooter = true;
            this.gvResult.OptionsView.ShowIndicator = false;
            this.gvResult.ParentForm = null;
            this.gvResult.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gvResult.VisibleAutoFilterRow = true;
            this.gvResult.VisibleGroupPanel = true;
            this.gvResult.VisibleIndicator = false;
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
            this.colSC.VisibleIndex = 0;
            this.colSC.Width = 25;
            // 
            // colAccount
            // 
            this.colAccount.AlwaysDisabled = false;
            this.colAccount.CustomData = "";
            this.colAccount.EditDisabled = false;
            this.colAccount.FieldName = "Account";
            this.colAccount.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colAccount.Name = "colAccount";
            this.colAccount.Visible = true;
            this.colAccount.VisibleIndex = 1;
            this.colAccount.Width = 70;
            // 
            // colDescription
            // 
            this.colDescription.AlwaysDisabled = false;
            this.colDescription.CustomData = "";
            this.colDescription.EditDisabled = false;
            this.colDescription.FieldName = "Description";
            this.colDescription.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 2;
            this.colDescription.Width = 315;
            // 
            // colCurrency
            // 
            this.colCurrency.AlwaysDisabled = false;
            this.colCurrency.CustomData = "";
            this.colCurrency.EditDisabled = false;
            this.colCurrency.FieldName = "Currency";
            this.colCurrency.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colCurrency.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.colCurrency.ImageIndex = 0;
            this.colCurrency.Name = "colCurrency";
            this.colCurrency.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colCurrency.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Equals;
            this.colCurrency.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colCurrency.Visible = true;
            this.colCurrency.VisibleIndex = 3;
            this.colCurrency.Width = 30;
            // 
            // colDebit
            // 
            this.colDebit.AlwaysDisabled = false;
            this.colDebit.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.colDebit.AppearanceCell.Options.UseBackColor = true;
            this.colDebit.CustomData = "";
            this.colDebit.DisplayFormat.FormatString = "{0:#,#0.00;;\"\"}";
            this.colDebit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colDebit.EditDisabled = false;
            this.colDebit.FieldName = "Debit";
            this.colDebit.Name = "colDebit";
            this.colDebit.Visible = true;
            this.colDebit.VisibleIndex = 4;
            this.colDebit.Width = 125;
            // 
            // colCredit
            // 
            this.colCredit.AlwaysDisabled = false;
            this.colCredit.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.colCredit.AppearanceCell.Options.UseBackColor = true;
            this.colCredit.CustomData = "";
            this.colCredit.DisplayFormat.FormatString = "{0:#,#0.00;;\"\"}";
            this.colCredit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colCredit.EditDisabled = false;
            this.colCredit.FieldName = "Credit";
            this.colCredit.Name = "colCredit";
            this.colCredit.Visible = true;
            this.colCredit.VisibleIndex = 5;
            this.colCredit.Width = 125;
            // 
            // colBalance
            // 
            this.colBalance.AlwaysDisabled = false;
            this.colBalance.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.colBalance.AppearanceCell.Options.UseBackColor = true;
            this.colBalance.Caption = "Balance";
            this.colBalance.CustomData = "";
            this.colBalance.DisplayFormat.FormatString = "{0:#,#0.00;;\"\"}";
            this.colBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colBalance.EditDisabled = false;
            this.colBalance.FieldName = "colBalance";
            this.colBalance.Name = "colBalance";
            this.colBalance.UnboundExpression = "[Debit] - [Credit]";
            this.colBalance.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colBalance.Visible = true;
            this.colBalance.VisibleIndex = 6;
            this.colBalance.Width = 125;
            // 
            // colDebit1st
            // 
            this.colDebit1st.AlwaysDisabled = false;
            this.colDebit1st.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.colDebit1st.AppearanceCell.Options.UseBackColor = true;
            this.colDebit1st.Caption = "Debit 1st";
            this.colDebit1st.CustomData = "";
            this.colDebit1st.DisplayFormat.FormatString = "{0:#,#0.00;;\"\"}";
            this.colDebit1st.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colDebit1st.EditDisabled = false;
            this.colDebit1st.FieldName = "Debit1st";
            this.colDebit1st.Name = "colDebit1st";
            this.colDebit1st.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Debit1st", "{0:#,#0.00;;\"\"}")});
            this.colDebit1st.Width = 125;
            // 
            // colCredit1st
            // 
            this.colCredit1st.AlwaysDisabled = false;
            this.colCredit1st.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.colCredit1st.AppearanceCell.Options.UseBackColor = true;
            this.colCredit1st.Caption = "Credit 1st";
            this.colCredit1st.CustomData = "";
            this.colCredit1st.DisplayFormat.FormatString = "{0:#,#0.00;;\"\"}";
            this.colCredit1st.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colCredit1st.EditDisabled = false;
            this.colCredit1st.FieldName = "Credit1st";
            this.colCredit1st.Name = "colCredit1st";
            this.colCredit1st.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Credit1st", "{0:#,#0.00;;\"\"}")});
            this.colCredit1st.Width = 125;
            // 
            // colBalance1st
            // 
            this.colBalance1st.AlwaysDisabled = false;
            this.colBalance1st.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.colBalance1st.AppearanceCell.Options.UseBackColor = true;
            this.colBalance1st.Caption = "Balance 1st";
            this.colBalance1st.CustomData = "";
            this.colBalance1st.DisplayFormat.FormatString = "{0:#,#0.00;;\"\"}";
            this.colBalance1st.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colBalance1st.EditDisabled = false;
            this.colBalance1st.FieldName = "colBalance1st";
            this.colBalance1st.Name = "colBalance1st";
            this.colBalance1st.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "colBalance1st", "{0:#,#0.00;;\"\"}")});
            this.colBalance1st.UnboundExpression = "[Debit1st] - [Credit1st]";
            this.colBalance1st.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colBalance1st.Width = 125;
            // 
            // colDebit2nd
            // 
            this.colDebit2nd.AlwaysDisabled = false;
            this.colDebit2nd.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.colDebit2nd.AppearanceCell.Options.UseBackColor = true;
            this.colDebit2nd.Caption = "Debit 2nd";
            this.colDebit2nd.CustomData = "";
            this.colDebit2nd.DisplayFormat.FormatString = "{0:#,#0.00;;\"\"}";
            this.colDebit2nd.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colDebit2nd.EditDisabled = false;
            this.colDebit2nd.FieldName = "Debit2nd";
            this.colDebit2nd.Name = "colDebit2nd";
            this.colDebit2nd.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Debit2nd", "{0:#,#0.00;;\"\"}")});
            this.colDebit2nd.Width = 125;
            // 
            // colCredit2nd
            // 
            this.colCredit2nd.AlwaysDisabled = false;
            this.colCredit2nd.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.colCredit2nd.AppearanceCell.Options.UseBackColor = true;
            this.colCredit2nd.Caption = "Credit 2nd";
            this.colCredit2nd.CustomData = "";
            this.colCredit2nd.DisplayFormat.FormatString = "{0:#,#0.00;;\"\"}";
            this.colCredit2nd.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colCredit2nd.EditDisabled = false;
            this.colCredit2nd.FieldName = "Credit2nd";
            this.colCredit2nd.Name = "colCredit2nd";
            this.colCredit2nd.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Credit2nd", "{0:#,#0.00;;\"\"}")});
            this.colCredit2nd.Width = 125;
            // 
            // colBalance2nd
            // 
            this.colBalance2nd.AlwaysDisabled = false;
            this.colBalance2nd.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.colBalance2nd.AppearanceCell.Options.UseBackColor = true;
            this.colBalance2nd.Caption = "Balance 2nd";
            this.colBalance2nd.CustomData = "";
            this.colBalance2nd.DisplayFormat.FormatString = "{0:#,#0.00;;\"\"}";
            this.colBalance2nd.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colBalance2nd.EditDisabled = false;
            this.colBalance2nd.FieldName = "colBalance2nd";
            this.colBalance2nd.Name = "colBalance2nd";
            this.colBalance2nd.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "colBalance2nd", "{0:#,#0.00;;\"\"}")});
            this.colBalance2nd.UnboundExpression = "[Debit2nd] - [Credit2nd]";
            this.colBalance2nd.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colBalance2nd.Width = 125;
            // 
            // colLevel
            // 
            this.colLevel.AlwaysDisabled = false;
            this.colLevel.AppearanceHeader.Options.UseTextOptions = true;
            this.colLevel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLevel.Caption = "Level";
            this.colLevel.CustomData = "";
            this.colLevel.EditDisabled = false;
            this.colLevel.FieldName = "colLevel";
            this.colLevel.Name = "colLevel";
            this.colLevel.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colLevel.UnboundExpression = "Len([Account])";
            this.colLevel.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            // 
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.InsertGalleryImage("currency_16x16.png", "office2013/miscellaneous/currency_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/miscellaneous/currency_16x16.png"), 0);
            this.imageCollection.Images.SetKeyName(0, "currency_16x16.png");
            this.imageCollection.InsertGalleryImage("group_16x16.png", "office2013/actions/group_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/group_16x16.png"), 1);
            this.imageCollection.Images.SetKeyName(1, "group_16x16.png");
            // 
            // lciGridResult
            // 
            this.lciGridResult.Control = this.gcResult;
            this.lciGridResult.CustomizationFormText = "lciGridResult";
            this.lciGridResult.IsRequired = null;
            this.lciGridResult.Location = new System.Drawing.Point(0, 49);
            this.lciGridResult.Name = "lciGridResult";
            this.lciGridResult.Size = new System.Drawing.Size(843, 385);
            this.lciGridResult.TextSize = new System.Drawing.Size(0, 0);
            this.lciGridResult.TextVisible = false;
            // 
            // lciType
            // 
            this.lciType.Control = this.rgType;
            this.lciType.IsRequired = null;
            this.lciType.Location = new System.Drawing.Point(488, 434);
            this.lciType.MaxSize = new System.Drawing.Size(0, 25);
            this.lciType.MinSize = new System.Drawing.Size(281, 25);
            this.lciType.Name = "lciType";
            this.lciType.Size = new System.Drawing.Size(355, 25);
            this.lciType.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciType.TextSize = new System.Drawing.Size(0, 0);
            this.lciType.TextVisible = false;
            // 
            // lcgCriteria
            // 
            this.lcgCriteria.AppearanceGroup.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lcgCriteria.AppearanceGroup.Options.UseFont = true;
            this.lcgCriteria.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Clear", ((System.Drawing.Image)(resources.GetObject("lcgCriteria.CustomHeaderButtons"))), -1, DevExpress.XtraEditors.ButtonPanel.ImageLocation.Default, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", true, -1, true, null, true, false, true, null, "CF", -1)});
            this.lcgCriteria.ExpandButtonVisible = true;
            this.lcgCriteria.ExpandOnDoubleClick = true;
            this.lcgCriteria.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.lcgCriteria.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciFromDate,
            this.lciToDate,
            this.lciCurrency,
            this.lciBeforeClosing,
            this.lciLevel});
            this.lcgCriteria.Location = new System.Drawing.Point(0, 0);
            this.lcgCriteria.Name = "lcgCriteria";
            this.lcgCriteria.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcgCriteria.Size = new System.Drawing.Size(843, 49);
            this.lcgCriteria.Text = "Expand To Select Different Criteria";
            this.lcgCriteria.CustomButtonClick += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.lcgCriteria_CustomButtonClick);
            // 
            // lciBeforeClosing
            // 
            this.lciBeforeClosing.Control = this.chkBeforeClosing;
            this.lciBeforeClosing.IsRequired = null;
            this.lciBeforeClosing.Location = new System.Drawing.Point(704, 0);
            this.lciBeforeClosing.Name = "lciBeforeClosing";
            this.lciBeforeClosing.Size = new System.Drawing.Size(133, 24);
            this.lciBeforeClosing.TextSize = new System.Drawing.Size(0, 0);
            this.lciBeforeClosing.TextVisible = false;
            // 
            // chkBeforeClosing
            // 
            this.chkBeforeClosing.DefaultState = efControls.Enums.ControlState.Default;
            this.chkBeforeClosing.EnterMoveNextControl = true;
            this.chkBeforeClosing.HighLighted = false;
            this.chkBeforeClosing.Location = new System.Drawing.Point(711, 26);
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
            this.chkBeforeClosing.Properties.Name = "efCheckBox";
            this.chkBeforeClosing.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.chkBeforeClosing.Size = new System.Drawing.Size(129, 19);
            this.chkBeforeClosing.StyleController = this.lcReport;
            this.chkBeforeClosing.TabIndex = 7;
            this.chkBeforeClosing.ValueType = efControls.Enums.ValueType.Boolean;
            // 
            // lciLevel
            // 
            this.lciLevel.Control = this.spnLevel;
            this.lciLevel.IsRequired = null;
            this.lciLevel.Location = new System.Drawing.Point(594, 0);
            this.lciLevel.MaxSize = new System.Drawing.Size(110, 24);
            this.lciLevel.MinSize = new System.Drawing.Size(110, 24);
            this.lciLevel.Name = "lciLevel";
            this.lciLevel.Size = new System.Drawing.Size(110, 24);
            this.lciLevel.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciLevel.Text = "Level";
            this.lciLevel.TextSize = new System.Drawing.Size(52, 13);
            // 
            // spnLevel
            // 
            this.spnLevel.AllowLeadingSpace = false;
            this.spnLevel.DefaultState = efControls.Enums.ControlState.Default;
            this.spnLevel.DisplayType = efControls.Enums.DisplayType.Default;
            this.spnLevel.EditValue = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.spnLevel.EnterMoveNextControl = true;
            this.spnLevel.Information = null;
            this.spnLevel.Location = new System.Drawing.Point(657, 26);
            this.spnLevel.Name = "spnLevel";
            this.spnLevel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spnLevel.Properties.DisplayFormat.FormatString = "n0";
            this.spnLevel.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spnLevel.Properties.MaxValue = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.spnLevel.Size = new System.Drawing.Size(50, 20);
            this.spnLevel.StyleController = this.lcReport;
            this.spnLevel.TabIndex = 5;
            // 
            // spnToClass
            // 
            this.spnToClass.AllowLeadingSpace = false;
            this.spnToClass.DefaultState = efControls.Enums.ControlState.Default;
            this.spnToClass.DisplayType = efControls.Enums.DisplayType.Default;
            this.spnToClass.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnToClass.EnterMoveNextControl = true;
            this.spnToClass.Information = null;
            this.spnToClass.Location = new System.Drawing.Point(170, 438);
            this.spnToClass.Name = "spnToClass";
            this.spnToClass.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spnToClass.Properties.Mask.EditMask = "f0";
            this.spnToClass.Size = new System.Drawing.Size(50, 20);
            this.spnToClass.StyleController = this.lcReport;
            this.spnToClass.TabIndex = 4;
            this.spnToClass.EditValueChanged += new System.EventHandler(this.spnToClass_EditValueChanged);
            // 
            // lciToClass
            // 
            this.lciToClass.Control = this.spnToClass;
            this.lciToClass.IsRequired = null;
            this.lciToClass.Location = new System.Drawing.Point(110, 434);
            this.lciToClass.MaxSize = new System.Drawing.Size(110, 24);
            this.lciToClass.MinSize = new System.Drawing.Size(110, 24);
            this.lciToClass.Name = "lciToClass";
            this.lciToClass.Size = new System.Drawing.Size(110, 25);
            this.lciToClass.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciToClass.Text = "To Class";
            this.lciToClass.TextSize = new System.Drawing.Size(52, 13);
            // 
            // spnFromClass
            // 
            this.spnFromClass.AllowLeadingSpace = false;
            this.spnFromClass.DefaultState = efControls.Enums.ControlState.Default;
            this.spnFromClass.DisplayType = efControls.Enums.DisplayType.Default;
            this.spnFromClass.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnFromClass.EnterMoveNextControl = true;
            this.spnFromClass.Information = null;
            this.spnFromClass.Location = new System.Drawing.Point(60, 438);
            this.spnFromClass.Name = "spnFromClass";
            this.spnFromClass.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spnFromClass.Properties.Mask.EditMask = "f0";
            this.spnFromClass.Size = new System.Drawing.Size(50, 20);
            this.spnFromClass.StyleController = this.lcReport;
            this.spnFromClass.TabIndex = 3;
            this.spnFromClass.EditValueChanged += new System.EventHandler(this.spnFromClass_EditValueChanged);
            // 
            // lciFromClass
            // 
            this.lciFromClass.Control = this.spnFromClass;
            this.lciFromClass.IsRequired = null;
            this.lciFromClass.Location = new System.Drawing.Point(0, 434);
            this.lciFromClass.MaxSize = new System.Drawing.Size(110, 24);
            this.lciFromClass.MinSize = new System.Drawing.Size(110, 24);
            this.lciFromClass.Name = "lciFromClass";
            this.lciFromClass.Size = new System.Drawing.Size(110, 25);
            this.lciFromClass.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciFromClass.Text = "From Class";
            this.lciFromClass.TextSize = new System.Drawing.Size(52, 13);
            // 
            // chkSkipBalanceZero
            // 
            this.chkSkipBalanceZero.DefaultState = efControls.Enums.ControlState.Default;
            this.chkSkipBalanceZero.EnterMoveNextControl = true;
            this.chkSkipBalanceZero.HighLighted = false;
            this.chkSkipBalanceZero.Location = new System.Drawing.Point(353, 438);
            this.chkSkipBalanceZero.Name = "chkSkipBalanceZero";
            this.chkSkipBalanceZero.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.chkSkipBalanceZero.Properties.Appearance.Options.UseBackColor = true;
            this.chkSkipBalanceZero.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Transparent;
            this.chkSkipBalanceZero.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.chkSkipBalanceZero.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Transparent;
            this.chkSkipBalanceZero.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.chkSkipBalanceZero.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Transparent;
            this.chkSkipBalanceZero.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.chkSkipBalanceZero.Properties.Caption = "Skip Balance Zero";
            this.chkSkipBalanceZero.Properties.Name = "efCheckBox";
            this.chkSkipBalanceZero.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.chkSkipBalanceZero.Size = new System.Drawing.Size(135, 19);
            this.chkSkipBalanceZero.StyleController = this.lcReport;
            this.chkSkipBalanceZero.TabIndex = 9;
            this.chkSkipBalanceZero.ValueType = efControls.Enums.ValueType.Boolean;
            this.chkSkipBalanceZero.EditValueChanged += new System.EventHandler(this.chkSkipBalanceZero_EditValueChanged);
            // 
            // lciSkipBalanceZero
            // 
            this.lciSkipBalanceZero.Control = this.chkSkipBalanceZero;
            this.lciSkipBalanceZero.IsRequired = null;
            this.lciSkipBalanceZero.Location = new System.Drawing.Point(349, 434);
            this.lciSkipBalanceZero.Name = "lciSkipBalanceZero";
            this.lciSkipBalanceZero.Size = new System.Drawing.Size(139, 25);
            this.lciSkipBalanceZero.TextSize = new System.Drawing.Size(0, 0);
            this.lciSkipBalanceZero.TextVisible = false;
            // 
            // chkSkipOverZeros
            // 
            this.chkSkipOverZeros.DefaultState = efControls.Enums.ControlState.Default;
            this.chkSkipOverZeros.EnterMoveNextControl = true;
            this.chkSkipOverZeros.HighLighted = false;
            this.chkSkipOverZeros.Location = new System.Drawing.Point(224, 438);
            this.chkSkipOverZeros.Name = "chkSkipOverZeros";
            this.chkSkipOverZeros.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.chkSkipOverZeros.Properties.Appearance.Options.UseBackColor = true;
            this.chkSkipOverZeros.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Transparent;
            this.chkSkipOverZeros.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.chkSkipOverZeros.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Transparent;
            this.chkSkipOverZeros.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.chkSkipOverZeros.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Transparent;
            this.chkSkipOverZeros.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.chkSkipOverZeros.Properties.Caption = "Skip Over Zeros";
            this.chkSkipOverZeros.Properties.Name = "efCheckBox";
            this.chkSkipOverZeros.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.chkSkipOverZeros.Size = new System.Drawing.Size(125, 19);
            this.chkSkipOverZeros.StyleController = this.lcReport;
            this.chkSkipOverZeros.TabIndex = 8;
            this.chkSkipOverZeros.ValueType = efControls.Enums.ValueType.Boolean;
            // 
            // lciSkipOverZeros
            // 
            this.lciSkipOverZeros.Control = this.chkSkipOverZeros;
            this.lciSkipOverZeros.IsRequired = null;
            this.lciSkipOverZeros.Location = new System.Drawing.Point(220, 434);
            this.lciSkipOverZeros.Name = "lciSkipOverZeros";
            this.lciSkipOverZeros.Size = new System.Drawing.Size(129, 25);
            this.lciSkipOverZeros.TextSize = new System.Drawing.Size(0, 0);
            this.lciSkipOverZeros.TextVisible = false;
            // 
            // FormTrialBalanceFT
            // 
            this.ClientSize = new System.Drawing.Size(855, 501);
            this.Name = "FormTrialBalanceFT";
            this.Text = "Trial Balance";
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
            ((System.ComponentModel.ISupportInitialize)(this.lciFromDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciToDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGridResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgCriteria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBeforeClosing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBeforeClosing.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnLevel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnToClass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciToClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnFromClass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFromClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSkipBalanceZero.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSkipBalanceZero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSkipOverZeros.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSkipOverZeros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private cboCurrencies cboCurrencies;
        private efControls.lci lciCurrency;
        private efControls.efGridColumn colCode;
        private efControls.efGridControl gcResult;
        private efControls.efGridView gvResult;
        private efControls.efDateEdit deTo;
        private efControls.efDateEdit deFrom;
        private efControls.efRadioGroup rgType;
        private efControls.lci lciFromDate;
        private efControls.lci lciToDate;
        private efControls.lci lciGridResult;
        private System.Windows.Forms.BindingSource bsResult;
        private efControls.efGridColumn colAccount;
        private efControls.efGridColumn colDescription;
        private efControls.efGridColumn colCurrency;
        private efControls.efGridColumn colDebit;
        private efControls.efGridColumn colCredit;
        private efControls.efGridColumn colBalance;
        private efControls.efGridColumn colDebit1st;
        private efControls.efGridColumn colCredit1st;
        private efControls.efGridColumn colBalance1st;
        private efControls.efGridColumn colDebit2nd;
        private efControls.efGridColumn colCredit2nd;
        private efControls.efGridColumn colBalance2nd;
        private efControls.lci lciType;
        private DevExpress.XtraLayout.LayoutControlGroup lcgCriteria;
        private efControls.efSpinner spnLevel;
        private efControls.efGridColumn colLevel;
        private efControls.lci lciLevel;
        private efControls.efCheckBox chkSkipOverZeros;
        private efControls.efCheckBox chkSkipBalanceZero;
        private efControls.efCheckBox chkBeforeClosing;
        private efControls.efSpinner spnFromClass;
        private efControls.efSpinner spnToClass;
        private efControls.lci lciToClass;
        private efControls.lci lciFromClass;
        private efControls.lci lciBeforeClosing;
        private efControls.lci lciSkipBalanceZero;
        private efControls.lci lciSkipOverZeros;
        private DevExpress.Utils.ImageCollection imageCollection;
        private efControls.efGridColumn colSC;
    }
}
