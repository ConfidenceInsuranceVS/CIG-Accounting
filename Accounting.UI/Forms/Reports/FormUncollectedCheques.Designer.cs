namespace Accounting
{
    partial class FormUncollectedCheques
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUncollectedCheques));
            this.deFrom = new efControls.efDateEdit();
            this.bsResult = new System.Windows.Forms.BindingSource(this.components);
            this.colCode = new efControls.efGridColumn();
            this.colDescription = new efControls.efGridColumn();
            this.lciDate = new efControls.lci();
            this.gcResult = new efControls.efGridControl();
            this.gvResult = new efControls.efGridView();
            this.colSC = new efControls.efGridColumn();
            this.colMaturity = new efControls.efGridColumn();
            this.colAccount = new efControls.efGridColumn();
            this.colDescription1 = new efControls.efGridColumn();
            this.colCurrency = new efControls.efGridColumn();
            this.colDebit = new efControls.efGridColumn();
            this.colDebit1st = new efControls.efGridColumn();
            this.colDebit2nd = new efControls.efGridColumn();
            this.lciGridResult = new efControls.lci();
            this.cboAccounts = new Accounting.cboAccounts();
            this.cboAccounts1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lciAccount = new efControls.lci();
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
            ((System.ComponentModel.ISupportInitialize)(this.lciDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGridResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAccounts.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAccounts1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // lcReport
            // 
            this.lcReport.Appearance.ControlReadOnly.BackColor = System.Drawing.Color.Transparent;
            this.lcReport.Appearance.ControlReadOnly.Options.UseBackColor = true;
            this.lcReport.Controls.Add(this.cboAccounts);
            this.lcReport.Controls.Add(this.gcResult);
            this.lcReport.Controls.Add(this.deFrom);
            this.lcReport.Size = new System.Drawing.Size(790, 430);
            // 
            // lcgReport
            // 
            this.lcgReport.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciGridResult,
            this.lciDate,
            this.lciAccount});
            this.lcgReport.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.lcgReport.Size = new System.Drawing.Size(790, 430);
            // 
            // lcMain
            // 
            this.lcMain.Size = new System.Drawing.Size(798, 468);
            this.lcMain.Controls.SetChildIndex(this.ucCtrlNavigator, 0);
            this.lcMain.Controls.SetChildIndex(this.lcReport, 0);
            // 
            // lcgMain
            // 
            this.lcgMain.Size = new System.Drawing.Size(798, 468);
            // 
            // ucCtrlNavigator
            // 
            this.ucCtrlNavigator.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.ucCtrlNavigator.Appearance.Options.UseBackColor = true;
            this.ucCtrlNavigator.Location = new System.Drawing.Point(4, 438);
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
            this.deFrom.Location = new System.Drawing.Point(47, 4);
            this.deFrom.Name = "deFrom";
            this.deFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deFrom.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.deFrom.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.deFrom.Size = new System.Drawing.Size(83, 20);
            this.deFrom.StyleController = this.lcReport;
            this.deFrom.TabIndex = 15;
            // 
            // bsResult
            // 
            this.bsResult.DataSource = typeof(Accounting.UncollectedCheques);
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
            // lciDate
            // 
            this.lciDate.Control = this.deFrom;
            this.lciDate.CustomizationFormText = "Date";
            this.lciDate.IsRequired = null;
            this.lciDate.Location = new System.Drawing.Point(0, 0);
            this.lciDate.Name = "lciDate";
            this.lciDate.Size = new System.Drawing.Size(130, 24);
            this.lciDate.Text = "Date";
            this.lciDate.TextSize = new System.Drawing.Size(39, 13);
            // 
            // gcResult
            // 
            this.gcResult.DataSource = this.bsResult;
            this.gcResult.DefaultState = efControls.Enums.ControlState.AlwaysDisabled;
            this.gcResult.EmbeddedNavigatorHideButtons = false;
            this.gcResult.Location = new System.Drawing.Point(4, 28);
            this.gcResult.MainView = this.gvResult;
            this.gcResult.Name = "gcResult";
            this.gcResult.Size = new System.Drawing.Size(782, 398);
            this.gcResult.TabIndex = 17;
            this.gcResult.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvResult});
            // 
            // gvResult
            // 
            this.gvResult.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSC,
            this.colMaturity,
            this.colAccount,
            this.colDescription1,
            this.colCurrency,
            this.colDebit,
            this.colDebit1st,
            this.colDebit2nd});
            this.gvResult.GridControl = this.gcResult;
            this.gvResult.HighLightFocusedRow = true;
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
            // 
            // colSC
            // 
            this.colSC.AlwaysDisabled = false;
            this.colSC.AppearanceHeader.Options.UseTextOptions = true;
            this.colSC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSC.CustomData = "";
            this.colSC.EditDisabled = false;
            this.colSC.FieldName = "SC";
            this.colSC.Image = ((System.Drawing.Image)(resources.GetObject("colSC.Image")));
            this.colSC.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.colSC.Name = "colSC";
            this.colSC.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSC.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colSC.Visible = true;
            this.colSC.VisibleIndex = 0;
            this.colSC.Width = 25;
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
            this.colMaturity.Visible = true;
            this.colMaturity.VisibleIndex = 1;
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
            this.colAccount.Visible = true;
            this.colAccount.VisibleIndex = 2;
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
            this.colDescription1.Visible = true;
            this.colDescription1.VisibleIndex = 3;
            this.colDescription1.Width = 280;
            // 
            // colCurrency
            // 
            this.colCurrency.AlwaysDisabled = false;
            this.colCurrency.AppearanceHeader.Options.UseTextOptions = true;
            this.colCurrency.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCurrency.CustomData = "";
            this.colCurrency.EditDisabled = false;
            this.colCurrency.FieldName = "Currency";
            this.colCurrency.Image = ((System.Drawing.Image)(resources.GetObject("colCurrency.Image")));
            this.colCurrency.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.colCurrency.Name = "colCurrency";
            this.colCurrency.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCurrency.Visible = true;
            this.colCurrency.VisibleIndex = 4;
            this.colCurrency.Width = 25;
            // 
            // colDebit
            // 
            this.colDebit.AlwaysDisabled = false;
            this.colDebit.AppearanceHeader.Options.UseTextOptions = true;
            this.colDebit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDebit.CustomData = "";
            this.colDebit.DisplayFormat.FormatString = "n2";
            this.colDebit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDebit.EditDisabled = false;
            this.colDebit.FieldName = "Debit";
            this.colDebit.Name = "colDebit";
            this.colDebit.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDebit.Visible = true;
            this.colDebit.VisibleIndex = 5;
            this.colDebit.Width = 85;
            // 
            // colDebit1st
            // 
            this.colDebit1st.AlwaysDisabled = false;
            this.colDebit1st.AppearanceHeader.Options.UseTextOptions = true;
            this.colDebit1st.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDebit1st.CustomData = "";
            this.colDebit1st.DisplayFormat.FormatString = "n2";
            this.colDebit1st.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDebit1st.EditDisabled = false;
            this.colDebit1st.FieldName = "Debit1st";
            this.colDebit1st.Name = "colDebit1st";
            this.colDebit1st.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDebit1st.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Debit1st", "{0:n2}")});
            this.colDebit1st.Visible = true;
            this.colDebit1st.VisibleIndex = 6;
            this.colDebit1st.Width = 110;
            // 
            // colDebit2nd
            // 
            this.colDebit2nd.AlwaysDisabled = false;
            this.colDebit2nd.AppearanceHeader.Options.UseTextOptions = true;
            this.colDebit2nd.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDebit2nd.CustomData = "";
            this.colDebit2nd.DisplayFormat.FormatString = "n2";
            this.colDebit2nd.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDebit2nd.EditDisabled = false;
            this.colDebit2nd.FieldName = "Debit2nd";
            this.colDebit2nd.Name = "colDebit2nd";
            this.colDebit2nd.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDebit2nd.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Debit2nd", "{0:n2}")});
            this.colDebit2nd.Visible = true;
            this.colDebit2nd.VisibleIndex = 7;
            this.colDebit2nd.Width = 85;
            // 
            // lciGridResult
            // 
            this.lciGridResult.Control = this.gcResult;
            this.lciGridResult.CustomizationFormText = "lciGridResult";
            this.lciGridResult.IsRequired = null;
            this.lciGridResult.Location = new System.Drawing.Point(0, 24);
            this.lciGridResult.Name = "lciGridResult";
            this.lciGridResult.Size = new System.Drawing.Size(786, 402);
            this.lciGridResult.TextSize = new System.Drawing.Size(0, 0);
            this.lciGridResult.TextVisible = false;
            // 
            // cboAccounts
            // 
            this.cboAccounts.AccountStatusFlag = "B";
            this.cboAccounts.bs = null;
            this.cboAccounts.DefaultState = efControls.Enums.ControlState.Default;
            this.cboAccounts.DropdownWidth = 0;
            this.cboAccounts.EnterMoveNextControl = true;
            this.cboAccounts.Location = new System.Drawing.Point(177, 4);
            this.cboAccounts.Name = "cboAccounts";
            this.cboAccounts.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboAccounts.Properties.ContextImage = ((System.Drawing.Image)(resources.GetObject("cboAccounts.Properties.ContextImage")));
            this.cboAccounts.Properties.ContextImageAlignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.cboAccounts.Properties.NullText = "";
            this.cboAccounts.Properties.NullValuePrompt = "Select Account Or Leave Blank";
            this.cboAccounts.Properties.NullValuePromptShowForEmptyValue = true;
            this.cboAccounts.Properties.PopupFormMinSize = new System.Drawing.Size(350, 200);
            this.cboAccounts.Properties.ValidateOnEnterKey = true;
            this.cboAccounts.Properties.View = this.cboAccounts1View;
            this.cboAccounts.ShowAccountNumber = true;
            this.cboAccounts.ShowContextImage = true;
            this.cboAccounts.Size = new System.Drawing.Size(609, 20);
            this.cboAccounts.StartWith = null;
            this.cboAccounts.StyleController = this.lcReport;
            this.cboAccounts.TabIndex = 20;
            this.cboAccounts.ToolTip = "...";
            this.cboAccounts.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.cboAccounts.ToolTipTitle = "Press [CTRL+DELETE] To Clear Value ...";
            // 
            // cboAccounts1View
            // 
            this.cboAccounts1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.cboAccounts1View.Name = "cboAccounts1View";
            this.cboAccounts1View.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.cboAccounts1View.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.cboAccounts1View.OptionsCustomization.AllowColumnMoving = false;
            this.cboAccounts1View.OptionsCustomization.AllowColumnResizing = false;
            this.cboAccounts1View.OptionsCustomization.AllowFilter = false;
            this.cboAccounts1View.OptionsFilter.AllowFilterEditor = false;
            this.cboAccounts1View.OptionsFind.AllowFindPanel = false;
            this.cboAccounts1View.OptionsFind.ShowClearButton = false;
            this.cboAccounts1View.OptionsFind.ShowCloseButton = false;
            this.cboAccounts1View.OptionsFind.ShowFindButton = false;
            this.cboAccounts1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.cboAccounts1View.OptionsView.EnableAppearanceEvenRow = true;
            this.cboAccounts1View.OptionsView.EnableAppearanceOddRow = true;
            this.cboAccounts1View.OptionsView.ShowAutoFilterRow = true;
            this.cboAccounts1View.OptionsView.ShowGroupPanel = false;
            this.cboAccounts1View.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.cboAccounts1View.OptionsView.ShowIndicator = false;
            this.cboAccounts1View.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            // 
            // lciAccount
            // 
            this.lciAccount.Control = this.cboAccounts;
            this.lciAccount.IsRequired = null;
            this.lciAccount.Location = new System.Drawing.Point(130, 0);
            this.lciAccount.Name = "lciAccount";
            this.lciAccount.Size = new System.Drawing.Size(656, 24);
            this.lciAccount.Text = "Account";
            this.lciAccount.TextSize = new System.Drawing.Size(39, 13);
            // 
            // FormUncollectedCheques
            // 
            this.ClientSize = new System.Drawing.Size(798, 468);
            this.Name = "FormUncollectedCheques";
            this.Text = "Uncollected Cheques";
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
            ((System.ComponentModel.ISupportInitialize)(this.lciDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGridResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAccounts.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAccounts1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAccount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsResult;
        private efControls.efGridColumn colCode;
        private efControls.efGridColumn colDescription;
        private efControls.efGridControl gcResult;
        private efControls.efGridView gvResult;
        private efControls.efDateEdit deFrom;
        private efControls.lci lciDate;
        private efControls.lci lciGridResult;
        private efControls.efGridColumn colMaturity;
        private efControls.efGridColumn colAccount;
        private efControls.efGridColumn colDescription1;
        private efControls.efGridColumn colCurrency;
        private efControls.efGridColumn colDebit;
        private efControls.efGridColumn colDebit1st;
        private efControls.efGridColumn colDebit2nd;
        private cboAccounts cboAccounts;
        private DevExpress.XtraGrid.Views.Grid.GridView cboAccounts1View;
        private efControls.lci lciAccount;
        private efControls.efGridColumn colSC;
    }
}
