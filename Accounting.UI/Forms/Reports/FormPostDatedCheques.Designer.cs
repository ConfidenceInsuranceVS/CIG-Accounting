namespace Accounting
{
    partial class FormPostDatedCheques
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
            DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule compareAgainstControlValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression1 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPostDatedCheques));
            this.deFrom = new efControls.efDateEdit();
            this.colMaturity = new efControls.efGridColumn();
            this.bsResult = new System.Windows.Forms.BindingSource();
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
            this.colDocument = new efControls.efGridColumn();
            this.colBank = new efControls.efGridColumn();
            this.colAccount = new efControls.efGridColumn();
            this.colDescription = new efControls.efGridColumn();
            this.colCur = new efControls.efGridColumn();
            this.colAmount = new efControls.efGridColumn();
            this.colDebit = new efControls.efGridColumn();
            this.colCredit = new efControls.efGridColumn();
            this.colType = new efControls.efGridColumn();
            this.colReference = new efControls.efGridColumn();
            this.colYdate = new efControls.efGridColumn();
            this.formImages = new DevExpress.Utils.ImageCollection();
            this.lciGridResult = new efControls.lci();
            this.deTill = new efControls.efDateEdit();
            this.lciTillDate = new efControls.lci();
            this.deCash = new efControls.efDateEdit();
            this.lciCashDate = new efControls.lci();
            this.gcSummary = new efControls.efGridControl();
            this.bsSummary = new System.Windows.Forms.BindingSource();
            this.gvSummary = new efControls.efGridView();
            this.colSC1 = new efControls.efGridColumn();
            this.colCheques = new efControls.efGridColumn();
            this.colCur1 = new efControls.efGridColumn();
            this.colDebit1 = new efControls.efGridColumn();
            this.colCredit1 = new efControls.efGridColumn();
            this.colDebitBalance = new efControls.efGridColumn();
            this.colCreditBalance = new efControls.efGridColumn();
            this.lciSummary = new efControls.lci();
            ((System.ComponentModel.ISupportInitialize)(this.lcReport)).BeginInit();
            this.lcReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcgReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFrom.Properties)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.formImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGridResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTill.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTill.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTillDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deCash.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deCash.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCashDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSummary)).BeginInit();
            this.SuspendLayout();
            // 
            // lcReport
            // 
            this.lcReport.Appearance.ControlReadOnly.BackColor = System.Drawing.Color.Transparent;
            this.lcReport.Appearance.ControlReadOnly.Options.UseBackColor = true;
            this.lcReport.Controls.Add(this.gcSummary);
            this.lcReport.Controls.Add(this.deCash);
            this.lcReport.Controls.Add(this.deTill);
            this.lcReport.Controls.Add(this.gcResult);
            this.lcReport.Controls.Add(this.deTo);
            this.lcReport.Controls.Add(this.deFrom);
            this.lcReport.Controls.Add(this.rgType);
            this.lcReport.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(967, 271, 250, 350);
            this.lcReport.Size = new System.Drawing.Size(920, 463);
            // 
            // lcgReport
            // 
            this.lcgReport.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciGridResult,
            this.lciFromDate,
            this.lciToDate,
            this.lciTillDate,
            this.lciType,
            this.lciCashDate,
            this.lciSummary});
            this.lcgReport.Name = "Root";
            this.lcgReport.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.lcgReport.Size = new System.Drawing.Size(920, 463);
            // 
            // lcMain
            // 
            this.lcMain.Size = new System.Drawing.Size(928, 501);
            this.lcMain.Controls.SetChildIndex(this.ucCtrlNavigator, 0);
            this.lcMain.Controls.SetChildIndex(this.lcReport, 0);
            // 
            // lcgMain
            // 
            this.lcgMain.Size = new System.Drawing.Size(928, 501);
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
            this.deFrom.Size = new System.Drawing.Size(72, 20);
            this.deFrom.StyleController = this.lcReport;
            this.deFrom.TabIndex = 0;
            // 
            // colMaturity
            // 
            this.colMaturity.AlwaysDisabled = false;
            this.colMaturity.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaturity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaturity.CustomData = "";
            this.colMaturity.EditDisabled = false;
            this.colMaturity.FieldName = "Maturity";
            this.colMaturity.Name = "colMaturity";
            this.colMaturity.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colMaturity.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colMaturity.Visible = true;
            this.colMaturity.VisibleIndex = 2;
            this.colMaturity.Width = 65;
            // 
            // bsResult
            // 
            this.bsResult.DataSource = typeof(Accounting.PostDatedChequesDetailed);
            // 
            // rgType
            // 
            this.rgType.Location = new System.Drawing.Point(622, 4);
            this.rgType.MaximumSize = new System.Drawing.Size(0, 20);
            this.rgType.MinimumSize = new System.Drawing.Size(100, 20);
            this.rgType.Name = "rgType";
            this.rgType.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgType.Properties.Appearance.Options.UseBackColor = true;
            this.rgType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rgType.Properties.Columns = 3;
            this.rgType.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Instant"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Detailed"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "In House")});
            this.rgType.Size = new System.Drawing.Size(294, 20);
            this.rgType.StyleController = this.lcReport;
            this.rgType.TabIndex = 4;
            this.rgType.SelectedIndexChanged += new System.EventHandler(this.rgType_SelectedIndexChanged);
            // 
            // lciType
            // 
            this.lciType.Control = this.rgType;
            this.lciType.CustomizationFormText = "lciType";
            this.lciType.IsRequired = null;
            this.lciType.Location = new System.Drawing.Point(520, 0);
            this.lciType.MaxSize = new System.Drawing.Size(0, 24);
            this.lciType.MinSize = new System.Drawing.Size(104, 24);
            this.lciType.Name = "lciType";
            this.lciType.Padding = new DevExpress.XtraLayout.Utils.Padding(100, 2, 2, 2);
            this.lciType.Size = new System.Drawing.Size(396, 24);
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
            this.deTo.DefaultState = efControls.Enums.ControlState.Default;
            this.deTo.DisplayType = efControls.Enums.DisplayType.Default;
            this.deTo.EditValue = null;
            this.deTo.EnterMoveNextControl = true;
            this.deTo.Information = null;
            this.deTo.Location = new System.Drawing.Point(188, 4);
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
            // gcResult
            // 
            this.gcResult.DataSource = this.bsResult;
            this.gcResult.DefaultState = efControls.Enums.ControlState.AlwaysDisabled;
            this.gcResult.EmbeddedNavigatorHideButtons = false;
            this.gcResult.Location = new System.Drawing.Point(4, 28);
            this.gcResult.MainView = this.gvResult;
            this.gcResult.Name = "gcResult";
            this.gcResult.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.peScan});
            this.gcResult.Size = new System.Drawing.Size(912, 346);
            this.gcResult.TabIndex = 17;
            this.gcResult.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvResult});
            // 
            // gvResult
            // 
            this.gvResult.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colScan,
            this.colSC,
            this.colMaturity,
            this.colDocument,
            this.colBank,
            this.colAccount,
            this.colDescription,
            this.colCur,
            this.colAmount,
            this.colDebit,
            this.colCredit,
            this.colType,
            this.colReference,
            this.colYdate});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Column = this.colMaturity;
            gridFormatRule1.Name = "FormatMaturity";
            formatConditionRuleExpression1.Expression = "[Maturity] < Today()";
            formatConditionRuleExpression1.PredefinedName = "Red Text";
            gridFormatRule1.Rule = formatConditionRuleExpression1;
            this.gvResult.FormatRules.Add(gridFormatRule1);
            this.gvResult.GridControl = this.gcResult;
            this.gvResult.HighLightFocusedRow = true;
            this.gvResult.Images = this.formImages;
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
            this.gvResult.OptionsView.ShowGroupPanel = false;
            this.gvResult.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gvResult.OptionsView.ShowIndicator = false;
            this.gvResult.ParentForm = null;
            this.gvResult.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gvResult.VisibleAutoFilterRow = true;
            this.gvResult.VisibleGroupPanel = false;
            this.gvResult.VisibleIndicator = false;
            this.gvResult.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gvResult_RowCellClick);
            this.gvResult.ColumnFilterChanged += new System.EventHandler(this.gvResult_ColumnFilterChanged);
            this.gvResult.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gvResult_CustomUnboundColumnData);
            // 
            // colScan
            // 
            this.colScan.AlwaysDisabled = false;
            this.colScan.AppearanceHeader.Options.UseTextOptions = true;
            this.colScan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colScan.ColumnEdit = this.peScan;
            this.colScan.CustomData = "";
            this.colScan.EditDisabled = false;
            this.colScan.FieldName = "colScan";
            this.colScan.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.colScan.ImageIndex = 0;
            this.colScan.Name = "colScan";
            this.colScan.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colScan.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colScan.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            this.colScan.Visible = true;
            this.colScan.VisibleIndex = 0;
            this.colScan.Width = 25;
            // 
            // peScan
            // 
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
            this.colSC.FieldName = "Sc";
            this.colSC.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.colSC.ImageIndex = 1;
            this.colSC.Name = "colSC";
            this.colSC.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSC.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colSC.Visible = true;
            this.colSC.VisibleIndex = 1;
            this.colSC.Width = 25;
            // 
            // colDocument
            // 
            this.colDocument.AlwaysDisabled = false;
            this.colDocument.AppearanceHeader.Options.UseTextOptions = true;
            this.colDocument.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDocument.Caption = "Check #";
            this.colDocument.CustomData = "";
            this.colDocument.EditDisabled = false;
            this.colDocument.FieldName = "Document";
            this.colDocument.Name = "colDocument";
            this.colDocument.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDocument.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDocument.Visible = true;
            this.colDocument.VisibleIndex = 3;
            this.colDocument.Width = 65;
            // 
            // colBank
            // 
            this.colBank.AlwaysDisabled = false;
            this.colBank.AppearanceHeader.Options.UseTextOptions = true;
            this.colBank.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBank.Caption = "Bank Name";
            this.colBank.CustomData = "";
            this.colBank.EditDisabled = false;
            this.colBank.FieldName = "Bank";
            this.colBank.Name = "colBank";
            this.colBank.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colBank.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colBank.Visible = true;
            this.colBank.VisibleIndex = 4;
            // 
            // colAccount
            // 
            this.colAccount.AlwaysDisabled = false;
            this.colAccount.AppearanceHeader.Options.UseTextOptions = true;
            this.colAccount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAccount.CustomData = "";
            this.colAccount.EditDisabled = false;
            this.colAccount.FieldName = "Account";
            this.colAccount.Name = "colAccount";
            this.colAccount.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colAccount.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colAccount.Visible = true;
            this.colAccount.VisibleIndex = 5;
            this.colAccount.Width = 65;
            // 
            // colDescription
            // 
            this.colDescription.AlwaysDisabled = false;
            this.colDescription.AppearanceHeader.Options.UseTextOptions = true;
            this.colDescription.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDescription.Caption = "Description";
            this.colDescription.CustomData = "";
            this.colDescription.EditDisabled = false;
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDescription.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 6;
            this.colDescription.Width = 137;
            // 
            // colCur
            // 
            this.colCur.AlwaysDisabled = false;
            this.colCur.AppearanceHeader.Options.UseTextOptions = true;
            this.colCur.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCur.CustomData = "";
            this.colCur.EditDisabled = false;
            this.colCur.FieldName = "Cur";
            this.colCur.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.colCur.ImageIndex = 2;
            this.colCur.Name = "colCur";
            this.colCur.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCur.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colCur.Visible = true;
            this.colCur.VisibleIndex = 7;
            this.colCur.Width = 25;
            // 
            // colAmount
            // 
            this.colAmount.AlwaysDisabled = false;
            this.colAmount.AppearanceHeader.Options.UseTextOptions = true;
            this.colAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAmount.Caption = "Amount";
            this.colAmount.CustomData = "";
            this.colAmount.DisplayFormat.FormatString = "{0:#,#0.00;;\"\"}";
            this.colAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colAmount.EditDisabled = false;
            this.colAmount.FieldName = "colAmount";
            this.colAmount.Name = "colAmount";
            this.colAmount.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colAmount.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Equals;
            this.colAmount.UnboundExpression = "[Debit] - [Credit]";
            this.colAmount.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 8;
            this.colAmount.Width = 100;
            // 
            // colDebit
            // 
            this.colDebit.AlwaysDisabled = false;
            this.colDebit.AppearanceHeader.Options.UseTextOptions = true;
            this.colDebit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDebit.Caption = "Debit";
            this.colDebit.CustomData = "";
            this.colDebit.DisplayFormat.FormatString = "{0:#,#0.00;;\"\"}";
            this.colDebit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colDebit.EditDisabled = false;
            this.colDebit.FieldName = "Debit";
            this.colDebit.Name = "colDebit";
            this.colDebit.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDebit.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Equals;
            this.colDebit.Visible = true;
            this.colDebit.VisibleIndex = 9;
            this.colDebit.Width = 100;
            // 
            // colCredit
            // 
            this.colCredit.AlwaysDisabled = false;
            this.colCredit.AppearanceHeader.Options.UseTextOptions = true;
            this.colCredit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCredit.Caption = "Credit";
            this.colCredit.CustomData = "";
            this.colCredit.DisplayFormat.FormatString = "{0:#,#0.00;;\"\"}";
            this.colCredit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colCredit.EditDisabled = false;
            this.colCredit.FieldName = "Credit";
            this.colCredit.Name = "colCredit";
            this.colCredit.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCredit.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Equals;
            this.colCredit.Visible = true;
            this.colCredit.VisibleIndex = 10;
            this.colCredit.Width = 100;
            // 
            // colType
            // 
            this.colType.AlwaysDisabled = false;
            this.colType.AppearanceHeader.Options.UseTextOptions = true;
            this.colType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colType.Caption = "T";
            this.colType.CustomData = "";
            this.colType.EditDisabled = false;
            this.colType.FieldName = "Type";
            this.colType.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.colType.ImageIndex = 3;
            this.colType.Name = "colType";
            this.colType.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colType.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colType.Visible = true;
            this.colType.VisibleIndex = 11;
            this.colType.Width = 25;
            // 
            // colReference
            // 
            this.colReference.AlwaysDisabled = false;
            this.colReference.AppearanceHeader.Options.UseTextOptions = true;
            this.colReference.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colReference.CustomData = "";
            this.colReference.EditDisabled = false;
            this.colReference.FieldName = "Reference";
            this.colReference.Name = "colReference";
            this.colReference.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colReference.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colReference.Visible = true;
            this.colReference.VisibleIndex = 12;
            this.colReference.Width = 45;
            // 
            // colYdate
            // 
            this.colYdate.AlwaysDisabled = false;
            this.colYdate.AppearanceHeader.Options.UseTextOptions = true;
            this.colYdate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colYdate.Caption = "Date";
            this.colYdate.CustomData = "";
            this.colYdate.EditDisabled = false;
            this.colYdate.FieldName = "YDate";
            this.colYdate.Name = "colYdate";
            this.colYdate.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colYdate.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colYdate.Visible = true;
            this.colYdate.VisibleIndex = 13;
            this.colYdate.Width = 40;
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
            this.lciGridResult.Location = new System.Drawing.Point(0, 24);
            this.lciGridResult.Name = "lciGridResult";
            this.lciGridResult.Size = new System.Drawing.Size(916, 350);
            this.lciGridResult.TextSize = new System.Drawing.Size(0, 0);
            this.lciGridResult.TextVisible = false;
            // 
            // deTill
            // 
            this.deTill.AllowLeadingSpace = false;
            this.deTill.DefaultState = efControls.Enums.ControlState.Default;
            this.deTill.DisplayType = efControls.Enums.DisplayType.Default;
            this.deTill.EditValue = null;
            this.deTill.EnterMoveNextControl = true;
            this.deTill.Information = null;
            this.deTill.Location = new System.Drawing.Point(318, 4);
            this.deTill.Name = "deTill";
            this.deTill.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deTill.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.deTill.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.deTill.Size = new System.Drawing.Size(72, 20);
            this.deTill.StyleController = this.lcReport;
            this.deTill.TabIndex = 2;
            // 
            // lciTillDate
            // 
            this.lciTillDate.Control = this.deTill;
            this.lciTillDate.CustomizationFormText = "Till Date";
            this.lciTillDate.IsRequired = null;
            this.lciTillDate.Location = new System.Drawing.Point(260, 0);
            this.lciTillDate.MaxSize = new System.Drawing.Size(130, 24);
            this.lciTillDate.MinSize = new System.Drawing.Size(130, 24);
            this.lciTillDate.Name = "lciTillDate";
            this.lciTillDate.Size = new System.Drawing.Size(130, 24);
            this.lciTillDate.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciTillDate.Text = "Till Date";
            this.lciTillDate.TextSize = new System.Drawing.Size(50, 13);
            // 
            // deCash
            // 
            this.deCash.AllowLeadingSpace = false;
            this.deCash.DefaultState = efControls.Enums.ControlState.Default;
            this.deCash.DisplayType = efControls.Enums.DisplayType.Default;
            this.deCash.EditValue = null;
            this.deCash.EnterMoveNextControl = true;
            this.deCash.Information = null;
            this.deCash.Location = new System.Drawing.Point(448, 4);
            this.deCash.Name = "deCash";
            this.deCash.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deCash.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.deCash.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.deCash.Size = new System.Drawing.Size(72, 20);
            this.deCash.StyleController = this.lcReport;
            this.deCash.TabIndex = 3;
            // 
            // lciCashDate
            // 
            this.lciCashDate.Control = this.deCash;
            this.lciCashDate.IsRequired = null;
            this.lciCashDate.Location = new System.Drawing.Point(390, 0);
            this.lciCashDate.MaxSize = new System.Drawing.Size(130, 24);
            this.lciCashDate.MinSize = new System.Drawing.Size(130, 24);
            this.lciCashDate.Name = "lciCashDate";
            this.lciCashDate.Size = new System.Drawing.Size(130, 24);
            this.lciCashDate.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciCashDate.Text = "Cash Date";
            this.lciCashDate.TextSize = new System.Drawing.Size(50, 13);
            // 
            // gcSummary
            // 
            this.gcSummary.DataSource = this.bsSummary;
            this.gcSummary.DefaultState = efControls.Enums.ControlState.AlwaysDisabled;
            this.gcSummary.EmbeddedNavigatorHideButtons = false;
            this.gcSummary.Location = new System.Drawing.Point(302, 378);
            this.gcSummary.MainView = this.gvSummary;
            this.gcSummary.Name = "gcSummary";
            this.gcSummary.Size = new System.Drawing.Size(614, 81);
            this.gcSummary.TabIndex = 19;
            this.gcSummary.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSummary});
            // 
            // bsSummary
            // 
            this.bsSummary.DataSource = typeof(Accounting.PostdatedChequesSummary);
            // 
            // gvSummary
            // 
            this.gvSummary.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSC1,
            this.colCheques,
            this.colCur1,
            this.colDebit1,
            this.colCredit1,
            this.colDebitBalance,
            this.colCreditBalance});
            this.gvSummary.GridControl = this.gcSummary;
            this.gvSummary.HighLightFocusedRow = false;
            this.gvSummary.Images = this.formImages;
            this.gvSummary.Name = "gvSummary";
            this.gvSummary.OptionsBehavior.ReadOnly = true;
            this.gvSummary.OptionsFilter.AllowFilterEditor = false;
            this.gvSummary.OptionsFilter.FilterEditorUseMenuForOperandsAndOperators = false;
            this.gvSummary.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gvSummary.OptionsView.ShowGroupPanel = false;
            this.gvSummary.OptionsView.ShowIndicator = false;
            this.gvSummary.ParentForm = null;
            this.gvSummary.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gvSummary.VisibleAutoFilterRow = false;
            this.gvSummary.VisibleGroupPanel = false;
            this.gvSummary.VisibleIndicator = false;
            // 
            // colSC1
            // 
            this.colSC1.AlwaysDisabled = false;
            this.colSC1.AppearanceHeader.Options.UseTextOptions = true;
            this.colSC1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSC1.CustomData = "";
            this.colSC1.EditDisabled = false;
            this.colSC1.FieldName = "Sc";
            this.colSC1.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.colSC1.ImageIndex = 1;
            this.colSC1.Name = "colSC1";
            this.colSC1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSC1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colSC1.Visible = true;
            this.colSC1.VisibleIndex = 0;
            this.colSC1.Width = 25;
            // 
            // colCheques
            // 
            this.colCheques.AlwaysDisabled = false;
            this.colCheques.AppearanceHeader.Options.UseTextOptions = true;
            this.colCheques.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCheques.Caption = "Ch. Counts";
            this.colCheques.CustomData = "";
            this.colCheques.EditDisabled = false;
            this.colCheques.FieldName = "Cheques";
            this.colCheques.Name = "colCheques";
            this.colCheques.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCheques.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colCheques.Visible = true;
            this.colCheques.VisibleIndex = 1;
            this.colCheques.Width = 73;
            // 
            // colCur1
            // 
            this.colCur1.AlwaysDisabled = false;
            this.colCur1.AppearanceHeader.Options.UseTextOptions = true;
            this.colCur1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCur1.CustomData = "";
            this.colCur1.EditDisabled = false;
            this.colCur1.FieldName = "Cur";
            this.colCur1.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.colCur1.ImageIndex = 2;
            this.colCur1.Name = "colCur1";
            this.colCur1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCur1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colCur1.Visible = true;
            this.colCur1.VisibleIndex = 2;
            this.colCur1.Width = 30;
            // 
            // colDebit1
            // 
            this.colDebit1.AlwaysDisabled = false;
            this.colDebit1.AppearanceHeader.Options.UseTextOptions = true;
            this.colDebit1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDebit1.CustomData = "";
            this.colDebit1.DisplayFormat.FormatString = "{0:#,#0.00;;\"\"}";
            this.colDebit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colDebit1.EditDisabled = false;
            this.colDebit1.FieldName = "Debit";
            this.colDebit1.Name = "colDebit1";
            this.colDebit1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDebit1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDebit1.Visible = true;
            this.colDebit1.VisibleIndex = 3;
            this.colDebit1.Width = 106;
            // 
            // colCredit1
            // 
            this.colCredit1.AlwaysDisabled = false;
            this.colCredit1.AppearanceHeader.Options.UseTextOptions = true;
            this.colCredit1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCredit1.CustomData = "";
            this.colCredit1.DisplayFormat.FormatString = "{0:#,#0.00;;\"\"}";
            this.colCredit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colCredit1.EditDisabled = false;
            this.colCredit1.FieldName = "Credit";
            this.colCredit1.Name = "colCredit1";
            this.colCredit1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCredit1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colCredit1.Visible = true;
            this.colCredit1.VisibleIndex = 4;
            this.colCredit1.Width = 106;
            // 
            // colDebitBalance
            // 
            this.colDebitBalance.AlwaysDisabled = false;
            this.colDebitBalance.AppearanceHeader.Options.UseTextOptions = true;
            this.colDebitBalance.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDebitBalance.CustomData = "";
            this.colDebitBalance.DisplayFormat.FormatString = "{0:#,#0.00;;\"\"}";
            this.colDebitBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colDebitBalance.EditDisabled = false;
            this.colDebitBalance.FieldName = "DebitBalance";
            this.colDebitBalance.Name = "colDebitBalance";
            this.colDebitBalance.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDebitBalance.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDebitBalance.Visible = true;
            this.colDebitBalance.VisibleIndex = 5;
            this.colDebitBalance.Width = 106;
            // 
            // colCreditBalance
            // 
            this.colCreditBalance.AlwaysDisabled = false;
            this.colCreditBalance.AppearanceHeader.Options.UseTextOptions = true;
            this.colCreditBalance.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCreditBalance.CustomData = "";
            this.colCreditBalance.DisplayFormat.FormatString = "{0:#,#0.00;;\"\"}";
            this.colCreditBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colCreditBalance.EditDisabled = false;
            this.colCreditBalance.FieldName = "CreditBalance";
            this.colCreditBalance.Name = "colCreditBalance";
            this.colCreditBalance.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCreditBalance.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colCreditBalance.Visible = true;
            this.colCreditBalance.VisibleIndex = 6;
            this.colCreditBalance.Width = 124;
            // 
            // lciSummary
            // 
            this.lciSummary.Control = this.gcSummary;
            this.lciSummary.IsRequired = null;
            this.lciSummary.Location = new System.Drawing.Point(0, 374);
            this.lciSummary.Name = "lciSummary";
            this.lciSummary.Padding = new DevExpress.XtraLayout.Utils.Padding(300, 2, 2, 2);
            this.lciSummary.Size = new System.Drawing.Size(916, 85);
            this.lciSummary.TextSize = new System.Drawing.Size(0, 0);
            this.lciSummary.TextVisible = false;
            // 
            // FormPostDatedCheques
            // 
            this.ClientSize = new System.Drawing.Size(928, 501);
            this.Name = "FormPostDatedCheques";
            this.Text = "Post Dated Cheques";
            ((System.ComponentModel.ISupportInitialize)(this.lcReport)).EndInit();
            this.lcReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcgReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFrom.Properties)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.formImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGridResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTill.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTill.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTillDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deCash.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deCash.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCashDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSummary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bsResult;
        private efControls.efGridControl gcResult;
        private efControls.efGridView gvResult;
        private efControls.efDateEdit deTo;
        private efControls.efDateEdit deFrom;
        private efControls.efRadioGroup rgType;
        private efControls.lci lciType;
        private efControls.lci lciFromDate;
        private efControls.lci lciToDate;
        private efControls.lci lciGridResult;
        private efControls.efDateEdit deTill;
        private efControls.lci lciTillDate;
        private efControls.efGridColumn colMaturity;
        private efControls.efGridColumn colDocument;
        private efControls.efGridColumn colBank;
        private efControls.efGridColumn colAccount;
        private efControls.efGridColumn colDescription;
        private efControls.efGridColumn colCur;
        private efControls.efGridColumn colAmount;
        private efControls.efGridColumn colDebit;
        private efControls.efGridColumn colCredit;
        private efControls.efGridColumn colType;
        private efControls.efGridColumn colReference;
        private efControls.efGridColumn colYdate;
        private efControls.efDateEdit deCash;
        private efControls.lci lciCashDate;
        private efControls.efGridControl gcSummary;
        private System.Windows.Forms.BindingSource bsSummary;
        private efControls.efGridView gvSummary;
        private efControls.efGridColumn colCheques;
        private efControls.efGridColumn colCur1;
        private efControls.efGridColumn colDebit1;
        private efControls.efGridColumn colCredit1;
        private efControls.lci lciSummary;
        private efControls.efGridColumn colDebitBalance;
        private efControls.efGridColumn colCreditBalance;
        private efControls.efGridColumn colSC1;
        private efControls.efGridColumn colSC;
        private efControls.efGridColumn colScan;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit peScan;
        private DevExpress.Utils.ImageCollection formImages;
    }
}
