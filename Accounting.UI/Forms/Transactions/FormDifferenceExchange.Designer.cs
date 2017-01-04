using DevExpress.XtraEditors.Repository;

namespace Accounting
{
    partial class FormDifferenceExchange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDifferenceExchange));
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue2 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            this.colAmount1st = new efControls.efGridColumn();
            this.colAmount2nd = new efControls.efGridColumn();
            this.lcMain = new efControls.efLayoutControl();
            this.cboAccountCredit = new Accounting.cboAccounts();
            this.cboAccountCreditView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cboAccountDebit = new Accounting.cboAccounts();
            this.cboAccountDebitView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcGrid = new efControls.efGridControl();
            this.bsDifference = new System.Windows.Forms.BindingSource(this.components);
            this.gvGrid = new efControls.efGridView();
            this.colLine = new efControls.efGridColumn();
            this.colSC = new efControls.efGridColumn();
            this.colAccount = new efControls.efGridColumn();
            this.riAccounts = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bsAccounts = new System.Windows.Forms.BindingSource(this.components);
            this.colDocument = new efControls.efGridColumn();
            this.colMaturity = new efControls.efGridColumn();
            this.colCurrencyid = new efControls.efGridColumn();
            this.riCurrencies = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bsCurrencies = new System.Windows.Forms.BindingSource(this.components);
            this.colAmount = new efControls.efGridColumn();
            this.colDc = new efControls.efGridColumn();
            this.colDescription = new efControls.efGridColumn();
            this.colBankid = new efControls.efGridColumn();
            this.riBanks = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bsBanks = new System.Windows.Forms.BindingSource(this.components);
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.txtDescription = new efControls.efTextBox();
            this.deFrom = new efControls.efDateEdit();
            this.btnExit = new efControls.efButton();
            this.btnDifference = new efControls.efButton();
            this.btnProcess = new efControls.efButton();
            this.lcg = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciPrint = new efControls.lci();
            this.lciFromDate = new efControls.lci();
            this.lciDifference = new efControls.lci();
            this.lciExit = new efControls.lci();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciGrid = new efControls.lci();
            this.lciDescription = new efControls.lci();
            this.lci675 = new efControls.lci();
            this.lci775 = new efControls.lci();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboAccountCredit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAccountCreditView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAccountDebit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAccountDebitView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDifference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riCurrencies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCurrencies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riBanks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBanks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFromDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDifference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci675)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci775)).BeginInit();
            this.SuspendLayout();
            // 
            // colAmount1st
            // 
            this.colAmount1st.AlwaysDisabled = false;
            this.colAmount1st.AppearanceHeader.Options.UseTextOptions = true;
            this.colAmount1st.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAmount1st.CustomData = "";
            this.colAmount1st.FieldName = "Amount1st";
            this.colAmount1st.Name = "colAmount1st";
            this.colAmount1st.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colAmount1st.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colAmount1st.Visible = true;
            this.colAmount1st.VisibleIndex = 10;
            // 
            // colAmount2nd
            // 
            this.colAmount2nd.AlwaysDisabled = false;
            this.colAmount2nd.AppearanceHeader.Options.UseTextOptions = true;
            this.colAmount2nd.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAmount2nd.CustomData = "";
            this.colAmount2nd.FieldName = "Amount2nd";
            this.colAmount2nd.Name = "colAmount2nd";
            this.colAmount2nd.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colAmount2nd.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colAmount2nd.Visible = true;
            this.colAmount2nd.VisibleIndex = 11;
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.cboAccountCredit);
            this.lcMain.Controls.Add(this.cboAccountDebit);
            this.lcMain.Controls.Add(this.gcGrid);
            this.lcMain.Controls.Add(this.txtDescription);
            this.lcMain.Controls.Add(this.deFrom);
            this.lcMain.Controls.Add(this.btnExit);
            this.lcMain.Controls.Add(this.btnDifference);
            this.lcMain.Controls.Add(this.btnProcess);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 0);
            this.lcMain.Name = "lcMain";
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(957, 132, 524, 683);
            this.lcMain.Root = this.lcg;
            this.lcMain.Size = new System.Drawing.Size(835, 506);
            this.lcMain.TabIndex = 18;
            this.lcMain.Text = "efLayoutControl1";
            // 
            // cboAccountCredit
            // 
            this.cboAccountCredit.bs = null;
            this.cboAccountCredit.DefaultState = efControls.Enums.ControlState.Default;
            this.cboAccountCredit.DropdownWidth = 0;
            this.cboAccountCredit.EnterMoveNextControl = true;
            this.cboAccountCredit.Location = new System.Drawing.Point(111, 53);
            this.cboAccountCredit.Name = "cboAccountCredit";
            this.cboAccountCredit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboAccountCredit.Properties.ContextImage = ((System.Drawing.Image)(resources.GetObject("cboAccountCredit.Properties.ContextImage")));
            this.cboAccountCredit.Properties.ContextImageAlignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.cboAccountCredit.Properties.NullText = "";
            this.cboAccountCredit.Properties.NullValuePrompt = "Select Account Or Leave Blank";
            this.cboAccountCredit.Properties.NullValuePromptShowForEmptyValue = true;
            this.cboAccountCredit.Properties.PopupFormMinSize = new System.Drawing.Size(350, 200);
            this.cboAccountCredit.Properties.ValidateOnEnterKey = true;
            this.cboAccountCredit.Properties.View = this.cboAccountCreditView;
            this.cboAccountCredit.ShowAccountNumber = true;
            this.cboAccountCredit.ShowContextImage = true;
            this.cboAccountCredit.Size = new System.Drawing.Size(719, 20);
            this.cboAccountCredit.StartWith = null;
            this.cboAccountCredit.StyleController = this.lcMain;
            this.cboAccountCredit.TabIndex = 36;
            this.cboAccountCredit.ToolTip = "...";
            this.cboAccountCredit.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.cboAccountCredit.ToolTipTitle = "Press [CTRL+DELETE] To Clear Value ...";
            // 
            // cboAccountCreditView
            // 
            this.cboAccountCreditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.cboAccountCreditView.Name = "cboAccountCreditView";
            this.cboAccountCreditView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.cboAccountCreditView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.cboAccountCreditView.OptionsCustomization.AllowColumnMoving = false;
            this.cboAccountCreditView.OptionsCustomization.AllowColumnResizing = false;
            this.cboAccountCreditView.OptionsCustomization.AllowFilter = false;
            this.cboAccountCreditView.OptionsFilter.AllowFilterEditor = false;
            this.cboAccountCreditView.OptionsFind.AllowFindPanel = false;
            this.cboAccountCreditView.OptionsFind.ShowClearButton = false;
            this.cboAccountCreditView.OptionsFind.ShowCloseButton = false;
            this.cboAccountCreditView.OptionsFind.ShowFindButton = false;
            this.cboAccountCreditView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.cboAccountCreditView.OptionsView.EnableAppearanceEvenRow = true;
            this.cboAccountCreditView.OptionsView.EnableAppearanceOddRow = true;
            this.cboAccountCreditView.OptionsView.ShowAutoFilterRow = true;
            this.cboAccountCreditView.OptionsView.ShowGroupPanel = false;
            this.cboAccountCreditView.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.cboAccountCreditView.OptionsView.ShowIndicator = false;
            this.cboAccountCreditView.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            // 
            // cboAccountDebit
            // 
            this.cboAccountDebit.bs = null;
            this.cboAccountDebit.DefaultState = efControls.Enums.ControlState.Default;
            this.cboAccountDebit.DropdownWidth = 0;
            this.cboAccountDebit.EnterMoveNextControl = true;
            this.cboAccountDebit.Location = new System.Drawing.Point(111, 29);
            this.cboAccountDebit.Name = "cboAccountDebit";
            this.cboAccountDebit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboAccountDebit.Properties.ContextImage = ((System.Drawing.Image)(resources.GetObject("cboAccountDebit.Properties.ContextImage")));
            this.cboAccountDebit.Properties.ContextImageAlignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.cboAccountDebit.Properties.NullText = "";
            this.cboAccountDebit.Properties.NullValuePrompt = "Select Account Or Leave Blank";
            this.cboAccountDebit.Properties.NullValuePromptShowForEmptyValue = true;
            this.cboAccountDebit.Properties.PopupFormMinSize = new System.Drawing.Size(350, 200);
            this.cboAccountDebit.Properties.ValidateOnEnterKey = true;
            this.cboAccountDebit.Properties.View = this.cboAccountDebitView;
            this.cboAccountDebit.ShowAccountNumber = true;
            this.cboAccountDebit.ShowContextImage = true;
            this.cboAccountDebit.Size = new System.Drawing.Size(719, 20);
            this.cboAccountDebit.StartWith = null;
            this.cboAccountDebit.StyleController = this.lcMain;
            this.cboAccountDebit.TabIndex = 35;
            this.cboAccountDebit.ToolTip = "...";
            this.cboAccountDebit.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.cboAccountDebit.ToolTipTitle = "Press [CTRL+DELETE] To Clear Value ...";
            // 
            // cboAccountDebitView
            // 
            this.cboAccountDebitView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.cboAccountDebitView.Name = "cboAccountDebitView";
            this.cboAccountDebitView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.cboAccountDebitView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.cboAccountDebitView.OptionsCustomization.AllowColumnMoving = false;
            this.cboAccountDebitView.OptionsCustomization.AllowColumnResizing = false;
            this.cboAccountDebitView.OptionsCustomization.AllowFilter = false;
            this.cboAccountDebitView.OptionsFilter.AllowFilterEditor = false;
            this.cboAccountDebitView.OptionsFind.AllowFindPanel = false;
            this.cboAccountDebitView.OptionsFind.ShowClearButton = false;
            this.cboAccountDebitView.OptionsFind.ShowCloseButton = false;
            this.cboAccountDebitView.OptionsFind.ShowFindButton = false;
            this.cboAccountDebitView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.cboAccountDebitView.OptionsView.EnableAppearanceEvenRow = true;
            this.cboAccountDebitView.OptionsView.EnableAppearanceOddRow = true;
            this.cboAccountDebitView.OptionsView.ShowAutoFilterRow = true;
            this.cboAccountDebitView.OptionsView.ShowGroupPanel = false;
            this.cboAccountDebitView.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.cboAccountDebitView.OptionsView.ShowIndicator = false;
            this.cboAccountDebitView.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            // 
            // gcGrid
            // 
            this.gcGrid.DataSource = this.bsDifference;
            this.gcGrid.DefaultState = efControls.Enums.ControlState.AlwaysDisabled;
            this.gcGrid.EmbeddedNavigatorHideButtons = false;
            this.gcGrid.Location = new System.Drawing.Point(5, 77);
            this.gcGrid.MainView = this.gvGrid;
            this.gcGrid.Name = "gcGrid";
            this.gcGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riAccounts,
            this.riCurrencies,
            this.riBanks});
            this.gcGrid.Size = new System.Drawing.Size(825, 398);
            this.gcGrid.TabIndex = 34;
            this.gcGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvGrid});
            // 
            // bsDifference
            // 
            this.bsDifference.DataSource = typeof(Accounting.Journalchild);
            // 
            // gvGrid
            // 
            this.gvGrid.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLine,
            this.colSC,
            this.colAccount,
            this.colDocument,
            this.colMaturity,
            this.colCurrencyid,
            this.colAmount,
            this.colDc,
            this.colDescription,
            this.colBankid,
            this.colAmount1st,
            this.colAmount2nd});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Column = this.colAmount1st;
            gridFormatRule1.Name = "1stLocal";
            formatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            formatConditionRuleValue1.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Expression;
            formatConditionRuleValue1.Expression = "[Amount1st] > 0 And [Amount2nd] = 0";
            gridFormatRule1.Rule = formatConditionRuleValue1;
            gridFormatRule2.ApplyToRow = true;
            gridFormatRule2.Column = this.colAmount2nd;
            gridFormatRule2.Name = "2ndLocal";
            formatConditionRuleValue2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            formatConditionRuleValue2.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Expression;
            formatConditionRuleValue2.Expression = "[Amount1st] = 0 And [Amount2nd] > 0";
            gridFormatRule2.Rule = formatConditionRuleValue2;
            this.gvGrid.FormatRules.Add(gridFormatRule1);
            this.gvGrid.FormatRules.Add(gridFormatRule2);
            this.gvGrid.GridControl = this.gcGrid;
            this.gvGrid.HighLightFocusedRow = true;
            this.gvGrid.Images = this.imageCollection;
            this.gvGrid.Name = "gvGrid";
            this.gvGrid.OptionsBehavior.ReadOnly = true;
            this.gvGrid.OptionsView.ColumnAutoWidth = false;
            this.gvGrid.OptionsView.ShowGroupPanel = false;
            this.gvGrid.OptionsView.ShowIndicator = false;
            this.gvGrid.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gvGrid.VisibleAutoFilterRow = false;
            this.gvGrid.VisibleGroupPanel = false;
            this.gvGrid.VisibleIndicator = false;
            // 
            // colLine
            // 
            this.colLine.AlwaysDisabled = false;
            this.colLine.AppearanceHeader.Options.UseTextOptions = true;
            this.colLine.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLine.CustomData = "";
            this.colLine.FieldName = "Line";
            this.colLine.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.colLine.ImageIndex = 5;
            this.colLine.Name = "colLine";
            this.colLine.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colLine.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colLine.Visible = true;
            this.colLine.VisibleIndex = 0;
            this.colLine.Width = 30;
            // 
            // colSC
            // 
            this.colSC.AlwaysDisabled = false;
            this.colSC.AppearanceHeader.Options.UseTextOptions = true;
            this.colSC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSC.CustomData = "";
            this.colSC.FieldName = "Recstamp";
            this.colSC.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.colSC.ImageIndex = 4;
            this.colSC.Name = "colSC";
            this.colSC.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSC.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colSC.Visible = true;
            this.colSC.VisibleIndex = 1;
            this.colSC.Width = 25;
            // 
            // colAccount
            // 
            this.colAccount.AlwaysDisabled = false;
            this.colAccount.AppearanceHeader.Options.UseTextOptions = true;
            this.colAccount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAccount.Caption = "Account";
            this.colAccount.ColumnEdit = this.riAccounts;
            this.colAccount.CustomData = "";
            this.colAccount.FieldName = "Accountid";
            this.colAccount.Name = "colAccount";
            this.colAccount.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colAccount.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colAccount.Visible = true;
            this.colAccount.VisibleIndex = 2;
            this.colAccount.Width = 65;
            // 
            // riAccounts
            // 
            this.riAccounts.AutoHeight = false;
            this.riAccounts.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riAccounts.DataSource = this.bsAccounts;
            this.riAccounts.DisplayMember = "Code";
            this.riAccounts.Name = "riAccounts";
            this.riAccounts.NullText = "";
            this.riAccounts.ValueMember = "ID";
            // 
            // bsAccounts
            // 
            this.bsAccounts.DataSource = typeof(Accounting.ucAccounts);
            // 
            // colDocument
            // 
            this.colDocument.AlwaysDisabled = false;
            this.colDocument.AppearanceHeader.Options.UseTextOptions = true;
            this.colDocument.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDocument.CustomData = "";
            this.colDocument.FieldName = "Document";
            this.colDocument.Name = "colDocument";
            this.colDocument.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDocument.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDocument.Visible = true;
            this.colDocument.VisibleIndex = 3;
            this.colDocument.Width = 65;
            // 
            // colMaturity
            // 
            this.colMaturity.AlwaysDisabled = false;
            this.colMaturity.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaturity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaturity.CustomData = "";
            this.colMaturity.FieldName = "Maturity";
            this.colMaturity.Name = "colMaturity";
            this.colMaturity.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colMaturity.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colMaturity.Visible = true;
            this.colMaturity.VisibleIndex = 4;
            this.colMaturity.Width = 65;
            // 
            // colCurrencyid
            // 
            this.colCurrencyid.AlwaysDisabled = false;
            this.colCurrencyid.AppearanceHeader.Options.UseTextOptions = true;
            this.colCurrencyid.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCurrencyid.Caption = "Cur";
            this.colCurrencyid.ColumnEdit = this.riCurrencies;
            this.colCurrencyid.CustomData = "";
            this.colCurrencyid.FieldName = "Currencyid";
            this.colCurrencyid.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.colCurrencyid.ImageIndex = 1;
            this.colCurrencyid.Name = "colCurrencyid";
            this.colCurrencyid.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCurrencyid.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colCurrencyid.Visible = true;
            this.colCurrencyid.VisibleIndex = 5;
            this.colCurrencyid.Width = 40;
            // 
            // riCurrencies
            // 
            this.riCurrencies.AutoHeight = false;
            this.riCurrencies.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riCurrencies.DataSource = this.bsCurrencies;
            this.riCurrencies.DisplayMember = "Code";
            this.riCurrencies.Name = "riCurrencies";
            this.riCurrencies.NullText = "";
            this.riCurrencies.ValueMember = "ID";
            // 
            // bsCurrencies
            // 
            this.bsCurrencies.DataSource = typeof(Accounting.Currency);
            // 
            // colAmount
            // 
            this.colAmount.AlwaysDisabled = false;
            this.colAmount.AppearanceHeader.Options.UseTextOptions = true;
            this.colAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAmount.CustomData = "";
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colAmount.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 6;
            // 
            // colDc
            // 
            this.colDc.AlwaysDisabled = false;
            this.colDc.AppearanceHeader.Options.UseTextOptions = true;
            this.colDc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDc.Caption = "DC";
            this.colDc.CustomData = "";
            this.colDc.FieldName = "Dc";
            this.colDc.Name = "colDc";
            this.colDc.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDc.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDc.Visible = true;
            this.colDc.VisibleIndex = 7;
            this.colDc.Width = 25;
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
            this.colDescription.VisibleIndex = 8;
            this.colDescription.Width = 205;
            // 
            // colBankid
            // 
            this.colBankid.AlwaysDisabled = false;
            this.colBankid.AppearanceHeader.Options.UseTextOptions = true;
            this.colBankid.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBankid.Caption = "Bank";
            this.colBankid.ColumnEdit = this.riBanks;
            this.colBankid.CustomData = "";
            this.colBankid.FieldName = "Bankid";
            this.colBankid.Name = "colBankid";
            this.colBankid.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colBankid.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colBankid.Visible = true;
            this.colBankid.VisibleIndex = 9;
            this.colBankid.Width = 60;
            // 
            // riBanks
            // 
            this.riBanks.AutoHeight = false;
            this.riBanks.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riBanks.DataSource = this.bsBanks;
            this.riBanks.DisplayMember = "Code";
            this.riBanks.Name = "riBanks";
            this.riBanks.NullText = "";
            this.riBanks.ValueMember = "ID";
            // 
            // bsBanks
            // 
            this.bsBanks.DataSource = typeof(Accounting.ucBanks);
            // 
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.InsertGalleryImage("loadfrom_16x16.png", "office2013/actions/loadfrom_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/loadfrom_16x16.png"), 0);
            this.imageCollection.Images.SetKeyName(0, "loadfrom_16x16.png");
            this.imageCollection.InsertGalleryImage("currency_16x16.png", "office2013/miscellaneous/currency_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/miscellaneous/currency_16x16.png"), 1);
            this.imageCollection.Images.SetKeyName(1, "currency_16x16.png");
            this.imageCollection.InsertGalleryImage("print_16x16.png", "office2013/print/print_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/print/print_16x16.png"), 2);
            this.imageCollection.Images.SetKeyName(2, "print_16x16.png");
            this.imageCollection.InsertGalleryImage("technology_16x16.png", "office2013/programming/technology_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/programming/technology_16x16.png"), 3);
            this.imageCollection.Images.SetKeyName(3, "technology_16x16.png");
            this.imageCollection.InsertGalleryImage("group_16x16.png", "office2013/actions/group_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/group_16x16.png"), 4);
            this.imageCollection.Images.SetKeyName(4, "group_16x16.png");
            this.imageCollection.InsertGalleryImage("listnumbers_16x16.png", "office2013/format/listnumbers_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/format/listnumbers_16x16.png"), 5);
            this.imageCollection.Images.SetKeyName(5, "listnumbers_16x16.png");
            // 
            // txtDescription
            // 
            this.txtDescription.AllowLeadingSpace = false;
            this.txtDescription.DefaultState = efControls.Enums.ControlState.Default;
            this.txtDescription.DisplayType = efControls.Enums.DisplayType.Default;
            this.txtDescription.EnterMoveNextControl = true;
            this.txtDescription.Information = null;
            this.txtDescription.Location = new System.Drawing.Point(297, 5);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(533, 20);
            this.txtDescription.StyleController = this.lcMain;
            this.txtDescription.TabIndex = 31;
            // 
            // deFrom
            // 
            this.deFrom.AllowLeadingSpace = false;
            this.deFrom.DefaultState = efControls.Enums.ControlState.Default;
            this.deFrom.DisplayType = efControls.Enums.DisplayType.Default;
            this.deFrom.EditValue = null;
            this.deFrom.EnterMoveNextControl = true;
            this.deFrom.Information = null;
            this.deFrom.Location = new System.Drawing.Point(111, 5);
            this.deFrom.Name = "deFrom";
            this.deFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFrom.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.deFrom.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.deFrom.Size = new System.Drawing.Size(76, 20);
            this.deFrom.StyleController = this.lcMain;
            this.deFrom.TabIndex = 30;
            // 
            // btnExit
            // 
            this.btnExit.DefaultState = efControls.Enums.ControlState.Default;
            this.btnExit.HighLighted = false;
            this.btnExit.ImageIndex = 0;
            this.btnExit.ImageList = this.imageCollection;
            this.btnExit.Location = new System.Drawing.Point(734, 479);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 22);
            this.btnExit.StyleController = this.lcMain;
            this.btnExit.TabIndex = 26;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDifference
            // 
            this.btnDifference.DefaultState = efControls.Enums.ControlState.Default;
            this.btnDifference.HighLighted = false;
            this.btnDifference.ImageIndex = 1;
            this.btnDifference.ImageList = this.imageCollection;
            this.btnDifference.Location = new System.Drawing.Point(633, 479);
            this.btnDifference.Name = "btnDifference";
            this.btnDifference.Size = new System.Drawing.Size(97, 22);
            this.btnDifference.StyleController = this.lcMain;
            this.btnDifference.TabIndex = 25;
            this.btnDifference.Text = "Diff. Exchange";
            this.btnDifference.Click += new System.EventHandler(this.btnDifference_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.DefaultState = efControls.Enums.ControlState.Default;
            this.btnProcess.HighLighted = false;
            this.btnProcess.ImageIndex = 3;
            this.btnProcess.ImageList = this.imageCollection;
            this.btnProcess.Location = new System.Drawing.Point(533, 479);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(96, 22);
            this.btnProcess.StyleController = this.lcMain;
            this.btnProcess.TabIndex = 24;
            this.btnProcess.Text = "Process";
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // lcg
            // 
            this.lcg.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcg.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciPrint,
            this.lciFromDate,
            this.lciDifference,
            this.lciExit,
            this.emptySpaceItem1,
            this.lciGrid,
            this.lciDescription,
            this.lci675,
            this.lci775});
            this.lcg.Location = new System.Drawing.Point(0, 0);
            this.lcg.Name = "Root";
            this.lcg.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.lcg.Size = new System.Drawing.Size(835, 506);
            this.lcg.TextVisible = false;
            // 
            // lciPrint
            // 
            this.lciPrint.Control = this.btnProcess;
            this.lciPrint.IsRequired = null;
            this.lciPrint.Location = new System.Drawing.Point(528, 474);
            this.lciPrint.MaxSize = new System.Drawing.Size(100, 26);
            this.lciPrint.MinSize = new System.Drawing.Size(100, 26);
            this.lciPrint.Name = "lciPrint";
            this.lciPrint.Size = new System.Drawing.Size(100, 26);
            this.lciPrint.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciPrint.TextSize = new System.Drawing.Size(0, 0);
            this.lciPrint.TextVisible = false;
            // 
            // lciFromDate
            // 
            this.lciFromDate.Control = this.deFrom;
            this.lciFromDate.IsRequired = null;
            this.lciFromDate.Location = new System.Drawing.Point(0, 0);
            this.lciFromDate.Name = "lciFromDate";
            this.lciFromDate.Size = new System.Drawing.Size(186, 24);
            this.lciFromDate.Text = "Date From";
            this.lciFromDate.TextSize = new System.Drawing.Size(103, 13);
            // 
            // lciDifference
            // 
            this.lciDifference.Control = this.btnDifference;
            this.lciDifference.IsRequired = null;
            this.lciDifference.Location = new System.Drawing.Point(628, 474);
            this.lciDifference.MaxSize = new System.Drawing.Size(101, 26);
            this.lciDifference.MinSize = new System.Drawing.Size(101, 26);
            this.lciDifference.Name = "lciDifference";
            this.lciDifference.Size = new System.Drawing.Size(101, 26);
            this.lciDifference.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciDifference.TextSize = new System.Drawing.Size(0, 0);
            this.lciDifference.TextVisible = false;
            // 
            // lciExit
            // 
            this.lciExit.Control = this.btnExit;
            this.lciExit.IsRequired = null;
            this.lciExit.Location = new System.Drawing.Point(729, 474);
            this.lciExit.MaxSize = new System.Drawing.Size(100, 26);
            this.lciExit.MinSize = new System.Drawing.Size(100, 26);
            this.lciExit.Name = "lciExit";
            this.lciExit.Size = new System.Drawing.Size(100, 26);
            this.lciExit.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciExit.TextSize = new System.Drawing.Size(0, 0);
            this.lciExit.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 474);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(528, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciGrid
            // 
            this.lciGrid.Control = this.gcGrid;
            this.lciGrid.IsRequired = null;
            this.lciGrid.Location = new System.Drawing.Point(0, 72);
            this.lciGrid.Name = "lciGrid";
            this.lciGrid.Size = new System.Drawing.Size(829, 402);
            this.lciGrid.TextSize = new System.Drawing.Size(0, 0);
            this.lciGrid.TextVisible = false;
            // 
            // lciDescription
            // 
            this.lciDescription.Control = this.txtDescription;
            this.lciDescription.IsRequired = null;
            this.lciDescription.Location = new System.Drawing.Point(186, 0);
            this.lciDescription.Name = "lciDescription";
            this.lciDescription.Size = new System.Drawing.Size(643, 24);
            this.lciDescription.Text = "Description";
            this.lciDescription.TextSize = new System.Drawing.Size(103, 13);
            // 
            // lci675
            // 
            this.lci675.Control = this.cboAccountDebit;
            this.lci675.IsRequired = null;
            this.lci675.Location = new System.Drawing.Point(0, 24);
            this.lci675.Name = "lci675";
            this.lci675.Size = new System.Drawing.Size(829, 24);
            this.lci675.Text = "- Difference Account";
            this.lci675.TextSize = new System.Drawing.Size(103, 13);
            // 
            // lci775
            // 
            this.lci775.Control = this.cboAccountCredit;
            this.lci775.IsRequired = null;
            this.lci775.Location = new System.Drawing.Point(0, 48);
            this.lci775.Name = "lci775";
            this.lci775.Size = new System.Drawing.Size(829, 24);
            this.lci775.Text = "+ Difference Account";
            this.lci775.TextSize = new System.Drawing.Size(103, 13);
            // 
            // FormDifferenceExchange
            // 
            this.ClientSize = new System.Drawing.Size(835, 506);
            this.ControlBox = false;
            this.Controls.Add(this.lcMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormDifferenceExchange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Difference Of Exchange";
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboAccountCredit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAccountCreditView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAccountDebit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAccountDebitView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDifference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riCurrencies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCurrencies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riBanks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBanks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFromDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDifference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci675)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci775)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private efControls.efLayoutControl lcMain;
        private DevExpress.XtraLayout.LayoutControlGroup lcg;
        private efControls.efButton btnExit;
        private efControls.efButton btnDifference;
        private efControls.efButton btnProcess;
        private efControls.lci lciPrint;
        private efControls.lci lciDifference;
        private efControls.lci lciExit;
        private DevExpress.Utils.ImageCollection imageCollection;
        private efControls.efTextBox txtDescription;
        private efControls.efDateEdit deFrom;
        private efControls.lci lciFromDate;
        private efControls.lci lciDescription;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private efControls.efGridControl gcGrid;
        private efControls.efGridView gvGrid;
        private efControls.lci lciGrid;
        private System.Windows.Forms.BindingSource bsDifference;
        private cboAccounts cboAccountCredit;
        private cboAccounts cboAccountDebit;
        private efControls.lci lci675;
        private efControls.lci lci775;
        private DevExpress.XtraGrid.Views.Grid.GridView cboAccountCreditView;
        private DevExpress.XtraGrid.Views.Grid.GridView cboAccountDebitView;
        private efControls.efGridColumn colMaturity;
        private efControls.efGridColumn colDocument;
        private efControls.efGridColumn colAmount;
        private efControls.efGridColumn colAmount1st;
        private efControls.efGridColumn colAmount2nd;
        private efControls.efGridColumn colDc;
        private efControls.efGridColumn colDescription;
        private efControls.efGridColumn colLine;
        private efControls.efGridColumn colAccount;
        private efControls.efGridColumn colCurrencyid;
        private efControls.efGridColumn colBankid;
        private System.Windows.Forms.BindingSource bsAccounts;
        private RepositoryItemLookUpEdit riAccounts;
        private System.Windows.Forms.BindingSource bsBanks;
        private System.Windows.Forms.BindingSource bsCurrencies;
        private RepositoryItemLookUpEdit riCurrencies;
        private RepositoryItemLookUpEdit riBanks;
        private efControls.efGridColumn colSC;
    }
}
