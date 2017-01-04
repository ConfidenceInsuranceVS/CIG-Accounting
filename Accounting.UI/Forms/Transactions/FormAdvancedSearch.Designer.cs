namespace Accounting
{
    partial class FormAdvancedSearch
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression1 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression2 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdvancedSearch));
            this.colDc = new efControls.efGridColumn();
            this.lcAdvancedSearch = new efControls.efLayoutControl();
            this.formImages = new DevExpress.Utils.ImageCollection();
            this.spnYear = new efControls.efSpinner();
            this.txtDetails = new efControls.efMultilineTextbox();
            this.bsResult = new System.Windows.Forms.BindingSource();
            this.txtBank = new efControls.efTextBox();
            this.txtRate = new efControls.efTextBox();
            this.txtCurrency = new efControls.efTextBox();
            this.txtAccount = new efControls.efTextBox();
            this.txtDescription = new efControls.efTextBox();
            this.ucControlNavigator = new efControls.ucControlNavigator();
            this.gcResult = new efControls.efGridControl();
            this.gvResult = new efControls.efGridView();
            this.colScan = new efControls.efGridColumn();
            this.peScan = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.colIsposted = new efControls.efGridColumn();
            this.coljvdate = new efControls.efGridColumn();
            this.colSC = new efControls.efGridColumn();
            this.coltype = new efControls.efGridColumn();
            this.colreference = new efControls.efGridColumn();
            this.colAccount = new efControls.efGridColumn();
            this.colDocument = new efControls.efGridColumn();
            this.colMaturity = new efControls.efGridColumn();
            this.colBank = new efControls.efGridColumn();
            this.colCurrency = new efControls.efGridColumn();
            this.colAmount = new efControls.efGridColumn();
            this.colDescription = new efControls.efGridColumn();
            this.colAmount1st = new efControls.efGridColumn();
            this.colAmount2nd = new efControls.efGridColumn();
            this.colDetails = new efControls.efGridColumn();
            this.lcgAdvancedSearch = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciResult = new efControls.lci();
            this.lciDescription = new efControls.lci();
            this.lciAccount = new efControls.lci();
            this.lciCurrency = new efControls.lci();
            this.lciRate = new efControls.lci();
            this.lciBank = new efControls.lci();
            this.lciDetails = new efControls.lci();
            this.lci3 = new efControls.lci();
            this.lciYear = new efControls.lci();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcAdvancedSearch)).BeginInit();
            this.lcAdvancedSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDetails.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBank.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrency.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peScan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgAdvancedSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCurrency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciYear)).BeginInit();
            this.SuspendLayout();
            // 
            // colDc
            // 
            this.colDc.AlwaysDisabled = false;
            this.colDc.AppearanceHeader.Options.UseTextOptions = true;
            this.colDc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDc.Caption = "DC";
            this.colDc.CustomData = "";
            this.colDc.EditDisabled = false;
            this.colDc.FieldName = "Dc";
            this.colDc.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colDc.Name = "colDc";
            this.colDc.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colDc.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDc.Visible = true;
            this.colDc.VisibleIndex = 12;
            this.colDc.Width = 20;
            // 
            // lcAdvancedSearch
            // 
            this.lcAdvancedSearch.Controls.Add(this.spnYear);
            this.lcAdvancedSearch.Controls.Add(this.txtDetails);
            this.lcAdvancedSearch.Controls.Add(this.txtBank);
            this.lcAdvancedSearch.Controls.Add(this.txtRate);
            this.lcAdvancedSearch.Controls.Add(this.txtCurrency);
            this.lcAdvancedSearch.Controls.Add(this.txtAccount);
            this.lcAdvancedSearch.Controls.Add(this.txtDescription);
            this.lcAdvancedSearch.Controls.Add(this.ucControlNavigator);
            this.lcAdvancedSearch.Controls.Add(this.gcResult);
            this.lcAdvancedSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcAdvancedSearch.Location = new System.Drawing.Point(0, 0);
            this.lcAdvancedSearch.Name = "lcAdvancedSearch";
            this.lcAdvancedSearch.Root = this.lcgAdvancedSearch;
            this.lcAdvancedSearch.Size = new System.Drawing.Size(904, 482);
            this.lcAdvancedSearch.TabIndex = 0;
            this.lcAdvancedSearch.Text = "efLayoutControl1";
            // 
            // formImages
            // 
            this.formImages.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("formImages.ImageStream")));
            this.formImages.InsertGalleryImage("notes_16x16.png", "office2013/content/notes_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/content/notes_16x16.png"), 0);
            this.formImages.Images.SetKeyName(0, "notes_16x16.png");
            this.formImages.InsertGalleryImage("exporttoxls_16x16.png", "office2013/export/exporttoxls_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/export/exporttoxls_16x16.png"), 1);
            this.formImages.Images.SetKeyName(1, "exporttoxls_16x16.png");
            this.formImages.InsertGalleryImage("group_16x16.png", "office2013/actions/group_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/group_16x16.png"), 2);
            this.formImages.Images.SetKeyName(2, "group_16x16.png");
            this.formImages.Images.SetKeyName(3, "database-lock.png");
            // 
            // spnYear
            // 
            this.spnYear.AllowLeadingSpace = false;
            this.spnYear.DefaultState = efControls.Enums.ControlState.AlwaysEnabled;
            this.spnYear.DisplayType = efControls.Enums.DisplayType.Integer;
            this.spnYear.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnYear.EnterMoveNextControl = true;
            this.spnYear.Information = null;
            this.spnYear.Location = new System.Drawing.Point(60, 380);
            this.spnYear.Name = "spnYear";
            this.spnYear.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.spnYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spnYear.Properties.Mask.EditMask = "f0";
            this.spnYear.Size = new System.Drawing.Size(64, 20);
            this.spnYear.StyleController = this.lcAdvancedSearch;
            this.spnYear.TabIndex = 14;
            this.spnYear.EditValueChanged += new System.EventHandler(this.spnYear_EditValueChanged);
            // 
            // txtDetails
            // 
            this.txtDetails.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsResult, "Details", true));
            this.txtDetails.DefaultState = efControls.Enums.ControlState.AlwaysDisabled;
            this.txtDetails.EditValue = "";
            this.txtDetails.EnterMoveNextControl = true;
            this.txtDetails.Location = new System.Drawing.Point(513, 380);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Properties.Appearance.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.txtDetails.Properties.Appearance.Options.UseFont = true;
            this.txtDetails.Properties.ReadOnly = true;
            this.txtDetails.Size = new System.Drawing.Size(387, 98);
            this.txtDetails.StyleController = this.lcAdvancedSearch;
            this.txtDetails.TabIndex = 13;
            // 
            // bsResult
            // 
            this.bsResult.DataSource = typeof(Accounting.AdvancedSearch);
            // 
            // txtBank
            // 
            this.txtBank.AllowLeadingSpace = false;
            this.txtBank.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsResult, "Bank", true));
            this.txtBank.DefaultState = efControls.Enums.ControlState.AlwaysDisabled;
            this.txtBank.DisplayType = efControls.Enums.DisplayType.Default;
            this.txtBank.EnterMoveNextControl = true;
            this.txtBank.Information = null;
            this.txtBank.Location = new System.Drawing.Point(380, 458);
            this.txtBank.Name = "txtBank";
            this.txtBank.Properties.ReadOnly = true;
            this.txtBank.Size = new System.Drawing.Size(129, 20);
            this.txtBank.StyleController = this.lcAdvancedSearch;
            this.txtBank.TabIndex = 12;
            // 
            // txtRate
            // 
            this.txtRate.AllowLeadingSpace = false;
            this.txtRate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsResult, "Ratecurrency", true));
            this.txtRate.DefaultState = efControls.Enums.ControlState.AlwaysDisabled;
            this.txtRate.DisplayType = efControls.Enums.DisplayType.Default;
            this.txtRate.EnterMoveNextControl = true;
            this.txtRate.Information = null;
            this.txtRate.Location = new System.Drawing.Point(236, 458);
            this.txtRate.Name = "txtRate";
            this.txtRate.Properties.ReadOnly = true;
            this.txtRate.Size = new System.Drawing.Size(84, 20);
            this.txtRate.StyleController = this.lcAdvancedSearch;
            this.txtRate.TabIndex = 11;
            // 
            // txtCurrency
            // 
            this.txtCurrency.AllowLeadingSpace = false;
            this.txtCurrency.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsResult, "Currency", true));
            this.txtCurrency.DefaultState = efControls.Enums.ControlState.AlwaysDisabled;
            this.txtCurrency.DisplayType = efControls.Enums.DisplayType.Default;
            this.txtCurrency.EnterMoveNextControl = true;
            this.txtCurrency.Information = null;
            this.txtCurrency.Location = new System.Drawing.Point(60, 458);
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.Properties.ReadOnly = true;
            this.txtCurrency.Size = new System.Drawing.Size(116, 20);
            this.txtCurrency.StyleController = this.lcAdvancedSearch;
            this.txtCurrency.TabIndex = 10;
            // 
            // txtAccount
            // 
            this.txtAccount.AllowLeadingSpace = false;
            this.txtAccount.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsResult, "AccountDescription", true));
            this.txtAccount.DefaultState = efControls.Enums.ControlState.AlwaysDisabled;
            this.txtAccount.DisplayType = efControls.Enums.DisplayType.Default;
            this.txtAccount.EnterMoveNextControl = true;
            this.txtAccount.Information = null;
            this.txtAccount.Location = new System.Drawing.Point(60, 434);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Properties.ReadOnly = true;
            this.txtAccount.Size = new System.Drawing.Size(449, 20);
            this.txtAccount.StyleController = this.lcAdvancedSearch;
            this.txtAccount.TabIndex = 9;
            // 
            // txtDescription
            // 
            this.txtDescription.AllowLeadingSpace = false;
            this.txtDescription.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsResult, "Description", true));
            this.txtDescription.DefaultState = efControls.Enums.ControlState.AlwaysDisabled;
            this.txtDescription.DisplayType = efControls.Enums.DisplayType.Default;
            this.txtDescription.EnterMoveNextControl = true;
            this.txtDescription.Information = null;
            this.txtDescription.Location = new System.Drawing.Point(60, 410);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Properties.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(449, 20);
            this.txtDescription.StyleController = this.lcAdvancedSearch;
            this.txtDescription.TabIndex = 8;
            // 
            // ucControlNavigator
            // 
            this.ucControlNavigator.AlwaysEnabled = false;
            this.ucControlNavigator.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.ucControlNavigator.Appearance.Options.UseBackColor = true;
            this.ucControlNavigator.Location = new System.Drawing.Point(128, 380);
            this.ucControlNavigator.MaximumSize = new System.Drawing.Size(0, 26);
            this.ucControlNavigator.MinimumSize = new System.Drawing.Size(185, 26);
            this.ucControlNavigator.Name = "ucControlNavigator";
            this.ucControlNavigator.NavigatableControl = this.gcResult;
            this.ucControlNavigator.Size = new System.Drawing.Size(381, 26);
            this.ucControlNavigator.TabIndex = 7;
            // 
            // gcResult
            // 
            this.gcResult.DataSource = this.bsResult;
            this.gcResult.DefaultState = efControls.Enums.ControlState.AlwaysDisabled;
            this.gcResult.EmbeddedNavigatorHideButtons = false;
            this.gcResult.Location = new System.Drawing.Point(4, 4);
            this.gcResult.MainView = this.gvResult;
            this.gcResult.Name = "gcResult";
            this.gcResult.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.peScan});
            this.gcResult.Size = new System.Drawing.Size(896, 372);
            this.gcResult.TabIndex = 5;
            this.gcResult.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvResult});
            // 
            // gvResult
            // 
            this.gvResult.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colScan,
            this.colIsposted,
            this.coljvdate,
            this.colSC,
            this.coltype,
            this.colreference,
            this.colAccount,
            this.colDocument,
            this.colMaturity,
            this.colBank,
            this.colCurrency,
            this.colAmount,
            this.colDc,
            this.colDescription,
            this.colAmount1st,
            this.colAmount2nd,
            this.colDetails});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Column = this.colDc;
            gridFormatRule1.Name = "Debit";
            formatConditionRuleExpression1.Appearance.BackColor = System.Drawing.Color.LavenderBlush;
            formatConditionRuleExpression1.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression1.Expression = "[Dc] = \'C\'";
            gridFormatRule1.Rule = formatConditionRuleExpression1;
            gridFormatRule2.ApplyToRow = true;
            gridFormatRule2.Column = this.colDc;
            gridFormatRule2.Name = "Credit";
            formatConditionRuleExpression2.Appearance.BackColor = System.Drawing.Color.Azure;
            formatConditionRuleExpression2.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression2.Expression = "[Dc] = \'D\'";
            gridFormatRule2.Rule = formatConditionRuleExpression2;
            this.gvResult.FormatRules.Add(gridFormatRule1);
            this.gvResult.FormatRules.Add(gridFormatRule2);
            this.gvResult.GridControl = this.gcResult;
            this.gvResult.HighLightFocusedRow = true;
            this.gvResult.Images = this.formImages;
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
            this.colScan.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colScan.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.colScan.ImageIndex = 0;
            this.colScan.Name = "colScan";
            this.colScan.OptionsColumn.AllowEdit = false;
            this.colScan.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colScan.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
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
            // colIsposted
            // 
            this.colIsposted.AlwaysDisabled = false;
            this.colIsposted.AppearanceHeader.Options.UseTextOptions = true;
            this.colIsposted.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIsposted.CustomData = "";
            this.colIsposted.EditDisabled = false;
            this.colIsposted.FieldName = "Isposted";
            this.colIsposted.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colIsposted.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.colIsposted.ImageIndex = 3;
            this.colIsposted.Name = "colIsposted";
            this.colIsposted.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colIsposted.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colIsposted.Visible = true;
            this.colIsposted.VisibleIndex = 1;
            this.colIsposted.Width = 25;
            // 
            // coljvdate
            // 
            this.coljvdate.AlwaysDisabled = false;
            this.coljvdate.AppearanceHeader.Options.UseTextOptions = true;
            this.coljvdate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coljvdate.Caption = "Date";
            this.coljvdate.CustomData = "";
            this.coljvdate.EditDisabled = false;
            this.coljvdate.FieldName = "jvdate";
            this.coljvdate.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.coljvdate.Name = "coljvdate";
            this.coljvdate.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.coljvdate.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.coljvdate.Visible = true;
            this.coljvdate.VisibleIndex = 2;
            this.coljvdate.Width = 65;
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
            this.colSC.ImageIndex = 2;
            this.colSC.Name = "colSC";
            this.colSC.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSC.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colSC.Visible = true;
            this.colSC.VisibleIndex = 3;
            this.colSC.Width = 25;
            // 
            // coltype
            // 
            this.coltype.AlwaysDisabled = false;
            this.coltype.AppearanceHeader.Options.UseTextOptions = true;
            this.coltype.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltype.Caption = "TP";
            this.coltype.CustomData = "";
            this.coltype.EditDisabled = false;
            this.coltype.FieldName = "type";
            this.coltype.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.coltype.Name = "coltype";
            this.coltype.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.coltype.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.coltype.Visible = true;
            this.coltype.VisibleIndex = 4;
            this.coltype.Width = 30;
            // 
            // colreference
            // 
            this.colreference.AlwaysDisabled = false;
            this.colreference.AppearanceHeader.Options.UseTextOptions = true;
            this.colreference.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colreference.Caption = "Ref.";
            this.colreference.CustomData = "";
            this.colreference.EditDisabled = false;
            this.colreference.FieldName = "reference";
            this.colreference.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colreference.Name = "colreference";
            this.colreference.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colreference.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colreference.Visible = true;
            this.colreference.VisibleIndex = 5;
            this.colreference.Width = 50;
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
            this.colAccount.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colAccount.Visible = true;
            this.colAccount.VisibleIndex = 6;
            this.colAccount.Width = 65;
            // 
            // colDocument
            // 
            this.colDocument.AlwaysDisabled = false;
            this.colDocument.AppearanceHeader.Options.UseTextOptions = true;
            this.colDocument.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDocument.CustomData = "";
            this.colDocument.EditDisabled = false;
            this.colDocument.FieldName = "Document";
            this.colDocument.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colDocument.Name = "colDocument";
            this.colDocument.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colDocument.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDocument.Visible = true;
            this.colDocument.VisibleIndex = 7;
            this.colDocument.Width = 65;
            // 
            // colMaturity
            // 
            this.colMaturity.AlwaysDisabled = false;
            this.colMaturity.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaturity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaturity.CustomData = "";
            this.colMaturity.EditDisabled = false;
            this.colMaturity.FieldName = "Maturity";
            this.colMaturity.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colMaturity.Name = "colMaturity";
            this.colMaturity.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colMaturity.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colMaturity.Visible = true;
            this.colMaturity.VisibleIndex = 8;
            this.colMaturity.Width = 65;
            // 
            // colBank
            // 
            this.colBank.AlwaysDisabled = false;
            this.colBank.AppearanceHeader.Options.UseTextOptions = true;
            this.colBank.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBank.CustomData = "";
            this.colBank.EditDisabled = false;
            this.colBank.FieldName = "Bank";
            this.colBank.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colBank.Name = "colBank";
            this.colBank.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colBank.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colBank.Visible = true;
            this.colBank.VisibleIndex = 9;
            // 
            // colCurrency
            // 
            this.colCurrency.AlwaysDisabled = false;
            this.colCurrency.AppearanceHeader.Options.UseTextOptions = true;
            this.colCurrency.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCurrency.Caption = "Cur.";
            this.colCurrency.CustomData = "";
            this.colCurrency.EditDisabled = false;
            this.colCurrency.FieldName = "Currency";
            this.colCurrency.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colCurrency.Name = "colCurrency";
            this.colCurrency.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colCurrency.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colCurrency.Visible = true;
            this.colCurrency.VisibleIndex = 10;
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
            this.colAmount.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colAmount.Name = "colAmount";
            this.colAmount.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colAmount.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 11;
            this.colAmount.Width = 110;
            // 
            // colDescription
            // 
            this.colDescription.AlwaysDisabled = false;
            this.colDescription.AppearanceHeader.Options.UseTextOptions = true;
            this.colDescription.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDescription.CustomData = "";
            this.colDescription.EditDisabled = false;
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colDescription.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 13;
            this.colDescription.Width = 354;
            // 
            // colAmount1st
            // 
            this.colAmount1st.AlwaysDisabled = false;
            this.colAmount1st.AppearanceHeader.Options.UseTextOptions = true;
            this.colAmount1st.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAmount1st.Caption = "Amount 1st Local";
            this.colAmount1st.CustomData = "";
            this.colAmount1st.EditDisabled = false;
            this.colAmount1st.FieldName = "Amount1st";
            this.colAmount1st.Name = "colAmount1st";
            this.colAmount1st.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colAmount1st.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colAmount1st.Visible = true;
            this.colAmount1st.VisibleIndex = 14;
            this.colAmount1st.Width = 110;
            // 
            // colAmount2nd
            // 
            this.colAmount2nd.AlwaysDisabled = false;
            this.colAmount2nd.AppearanceHeader.Options.UseTextOptions = true;
            this.colAmount2nd.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAmount2nd.Caption = "Amount 2nd Local";
            this.colAmount2nd.CustomData = "";
            this.colAmount2nd.EditDisabled = false;
            this.colAmount2nd.FieldName = "Amount2nd";
            this.colAmount2nd.Name = "colAmount2nd";
            this.colAmount2nd.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colAmount2nd.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colAmount2nd.Visible = true;
            this.colAmount2nd.VisibleIndex = 15;
            this.colAmount2nd.Width = 110;
            // 
            // colDetails
            // 
            this.colDetails.AlwaysDisabled = false;
            this.colDetails.AppearanceHeader.Options.UseTextOptions = true;
            this.colDetails.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDetails.CustomData = "";
            this.colDetails.EditDisabled = false;
            this.colDetails.FieldName = "Details";
            this.colDetails.Name = "colDetails";
            this.colDetails.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colDetails.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDetails.Visible = true;
            this.colDetails.VisibleIndex = 16;
            this.colDetails.Width = 200;
            // 
            // lcgAdvancedSearch
            // 
            this.lcgAdvancedSearch.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgAdvancedSearch.GroupBordersVisible = false;
            this.lcgAdvancedSearch.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciResult,
            this.lciDescription,
            this.lciAccount,
            this.lciCurrency,
            this.lciRate,
            this.lciBank,
            this.lciDetails,
            this.lci3,
            this.lciYear});
            this.lcgAdvancedSearch.Location = new System.Drawing.Point(0, 0);
            this.lcgAdvancedSearch.Name = "lcgAdvancedSearch";
            this.lcgAdvancedSearch.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.lcgAdvancedSearch.Size = new System.Drawing.Size(904, 482);
            this.lcgAdvancedSearch.TextVisible = false;
            // 
            // lciResult
            // 
            this.lciResult.Control = this.gcResult;
            this.lciResult.IsRequired = null;
            this.lciResult.Location = new System.Drawing.Point(0, 0);
            this.lciResult.Name = "lciResult";
            this.lciResult.Size = new System.Drawing.Size(900, 376);
            this.lciResult.TextSize = new System.Drawing.Size(0, 0);
            this.lciResult.TextVisible = false;
            // 
            // lciDescription
            // 
            this.lciDescription.Control = this.txtDescription;
            this.lciDescription.IsRequired = null;
            this.lciDescription.Location = new System.Drawing.Point(0, 406);
            this.lciDescription.Name = "lciDescription";
            this.lciDescription.Size = new System.Drawing.Size(509, 24);
            this.lciDescription.Text = "Description";
            this.lciDescription.TextSize = new System.Drawing.Size(53, 13);
            // 
            // lciAccount
            // 
            this.lciAccount.Control = this.txtAccount;
            this.lciAccount.IsRequired = null;
            this.lciAccount.Location = new System.Drawing.Point(0, 430);
            this.lciAccount.Name = "lciAccount";
            this.lciAccount.Size = new System.Drawing.Size(509, 24);
            this.lciAccount.Text = "Account";
            this.lciAccount.TextSize = new System.Drawing.Size(53, 13);
            // 
            // lciCurrency
            // 
            this.lciCurrency.Control = this.txtCurrency;
            this.lciCurrency.IsRequired = null;
            this.lciCurrency.Location = new System.Drawing.Point(0, 454);
            this.lciCurrency.Name = "lciCurrency";
            this.lciCurrency.Size = new System.Drawing.Size(176, 24);
            this.lciCurrency.Text = "Currency";
            this.lciCurrency.TextSize = new System.Drawing.Size(53, 13);
            // 
            // lciRate
            // 
            this.lciRate.Control = this.txtRate;
            this.lciRate.IsRequired = null;
            this.lciRate.Location = new System.Drawing.Point(176, 454);
            this.lciRate.Name = "lciRate";
            this.lciRate.Size = new System.Drawing.Size(144, 24);
            this.lciRate.Text = "Rate";
            this.lciRate.TextSize = new System.Drawing.Size(53, 13);
            // 
            // lciBank
            // 
            this.lciBank.Control = this.txtBank;
            this.lciBank.IsRequired = null;
            this.lciBank.Location = new System.Drawing.Point(320, 454);
            this.lciBank.Name = "lciBank";
            this.lciBank.Size = new System.Drawing.Size(189, 24);
            this.lciBank.Text = "Bank";
            this.lciBank.TextSize = new System.Drawing.Size(53, 13);
            // 
            // lciDetails
            // 
            this.lciDetails.Control = this.txtDetails;
            this.lciDetails.IsRequired = null;
            this.lciDetails.Location = new System.Drawing.Point(509, 376);
            this.lciDetails.Name = "lciDetails";
            this.lciDetails.Size = new System.Drawing.Size(391, 102);
            this.lciDetails.Text = "Details";
            this.lciDetails.TextLocation = DevExpress.Utils.Locations.Left;
            this.lciDetails.TextSize = new System.Drawing.Size(0, 0);
            this.lciDetails.TextVisible = false;
            // 
            // lci3
            // 
            this.lci3.Control = this.ucControlNavigator;
            this.lci3.IsRequired = null;
            this.lci3.Location = new System.Drawing.Point(124, 376);
            this.lci3.Name = "lci3";
            this.lci3.Size = new System.Drawing.Size(385, 30);
            this.lci3.TextSize = new System.Drawing.Size(0, 0);
            this.lci3.TextVisible = false;
            // 
            // lciYear
            // 
            this.lciYear.Control = this.spnYear;
            this.lciYear.ControlAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.lciYear.IsRequired = null;
            this.lciYear.Location = new System.Drawing.Point(0, 376);
            this.lciYear.MinSize = new System.Drawing.Size(110, 24);
            this.lciYear.Name = "lciYear";
            this.lciYear.Size = new System.Drawing.Size(124, 30);
            this.lciYear.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciYear.Text = "Year";
            this.lciYear.TextSize = new System.Drawing.Size(53, 13);
            // 
            // FormAdvancedSearch
            // 
            this.ClientSize = new System.Drawing.Size(904, 482);
            this.Controls.Add(this.lcAdvancedSearch);
            this.Name = "FormAdvancedSearch";
            this.Text = "Advanced Search";
            this.Controls.SetChildIndex(this.lcAdvancedSearch, 0);
            this.Controls.SetChildIndex(this.lblFocus, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcAdvancedSearch)).EndInit();
            this.lcAdvancedSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.formImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDetails.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBank.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrency.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peScan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgAdvancedSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCurrency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private efControls.efLayoutControl lcAdvancedSearch;
        private efControls.ucControlNavigator ucControlNavigator;
        private efControls.efGridControl gcResult;
        private System.Windows.Forms.BindingSource bsResult;
        private efControls.efGridView gvResult;
        private efControls.efGridColumn coltype;
        private efControls.efGridColumn colreference;
        private efControls.efGridColumn coljvdate;
        private efControls.efGridColumn colAccount;
        private efControls.efGridColumn colCurrency;
        private efControls.efGridColumn colMaturity;
        private efControls.efGridColumn colDocument;
        private efControls.efGridColumn colAmount;
        private efControls.efGridColumn colAmount1st;
        private efControls.efGridColumn colAmount2nd;
        private efControls.efGridColumn colDc;
        private efControls.efGridColumn colDescription;
        private efControls.efGridColumn colBank;
        private efControls.efGridColumn colDetails;
        private efControls.efGridColumn colIsposted;
        private DevExpress.XtraLayout.LayoutControlGroup lcgAdvancedSearch;
        private efControls.lci lciResult;
        private efControls.lci lci3;
        private efControls.efMultilineTextbox txtDetails;
        private efControls.efTextBox txtBank;
        private efControls.efTextBox txtRate;
        private efControls.efTextBox txtCurrency;
        private efControls.efTextBox txtAccount;
        private efControls.efTextBox txtDescription;
        private efControls.lci lciDescription;
        private efControls.lci lciAccount;
        private efControls.lci lciCurrency;
        private efControls.lci lciRate;
        private efControls.lci lciBank;
        private efControls.lci lciDetails;
        private efControls.efSpinner spnYear;
        private efControls.lci lciYear;
        private efControls.efGridColumn colScan;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit peScan;
        private DevExpress.Utils.ImageCollection formImages;
        private efControls.efGridColumn colSC;
    }
}
