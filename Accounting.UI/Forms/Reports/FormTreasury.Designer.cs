namespace Accounting
{
    partial class FormTreasury
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTreasury));
            this.deFrom = new efControls.efDateEdit();
            this.colCode = new efControls.efGridColumn();
            this.colDescription = new efControls.efGridColumn();
            this.lciFromDate = new efControls.lci();
            this.gcResult = new efControls.efGridControl();
            this.bsResult = new System.Windows.Forms.BindingSource(this.components);
            this.gvResult = new efControls.efGridView();
            this.colSC = new efControls.efGridColumn();
            this.colAccount = new efControls.efGridColumn();
            this.colCurrency = new efControls.efGridColumn();
            this.colDescription1 = new efControls.efGridColumn();
            this.colDebit = new efControls.efGridColumn();
            this.colCredit = new efControls.efGridColumn();
            this.colBalance = new efControls.efGridColumn();
            this.colBalance1st = new efControls.efGridColumn();
            this.colBalance2nd = new efControls.efGridColumn();
            this.lciGridResult = new efControls.lci();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.lciFromDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGridResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // lcReport
            // 
            this.lcReport.Appearance.ControlReadOnly.BackColor = System.Drawing.Color.Transparent;
            this.lcReport.Appearance.ControlReadOnly.Options.UseBackColor = true;
            this.lcReport.Controls.Add(this.gcResult);
            this.lcReport.Controls.Add(this.deFrom);
            this.lcReport.Size = new System.Drawing.Size(847, 465);
            // 
            // lcgReport
            // 
            this.lcgReport.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciFromDate,
            this.lciGridResult,
            this.emptySpaceItem1});
            this.lcgReport.Size = new System.Drawing.Size(847, 465);
            // 
            // lcMain
            // 
            this.lcMain.Size = new System.Drawing.Size(855, 503);
            this.lcMain.Controls.SetChildIndex(this.ucCtrlNavigator, 0);
            this.lcMain.Controls.SetChildIndex(this.lcReport, 0);
            // 
            // lcgMain
            // 
            this.lcgMain.Size = new System.Drawing.Size(855, 503);
            // 
            // ucCtrlNavigator
            // 
            this.ucCtrlNavigator.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.ucCtrlNavigator.Appearance.Options.UseBackColor = true;
            this.ucCtrlNavigator.Location = new System.Drawing.Point(4, 473);
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
            this.deFrom.Location = new System.Drawing.Point(66, 12);
            this.deFrom.Name = "deFrom";
            this.deFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deFrom.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.deFrom.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.deFrom.Size = new System.Drawing.Size(75, 20);
            this.deFrom.StyleController = this.lcReport;
            this.deFrom.TabIndex = 15;
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
            // lciFromDate
            // 
            this.lciFromDate.Control = this.deFrom;
            this.lciFromDate.CustomizationFormText = "From Date";
            this.lciFromDate.IsRequired = null;
            this.lciFromDate.Location = new System.Drawing.Point(0, 0);
            this.lciFromDate.MaxSize = new System.Drawing.Size(133, 24);
            this.lciFromDate.MinSize = new System.Drawing.Size(133, 24);
            this.lciFromDate.Name = "lciFromDate";
            this.lciFromDate.Size = new System.Drawing.Size(133, 24);
            this.lciFromDate.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciFromDate.Text = "From Date";
            this.lciFromDate.TextSize = new System.Drawing.Size(50, 13);
            // 
            // gcResult
            // 
            this.gcResult.DataSource = this.bsResult;
            this.gcResult.DefaultState = efControls.Enums.ControlState.AlwaysDisabled;
            this.gcResult.EmbeddedNavigatorHideButtons = false;
            this.gcResult.Location = new System.Drawing.Point(12, 36);
            this.gcResult.MainView = this.gvResult;
            this.gcResult.Name = "gcResult";
            this.gcResult.Size = new System.Drawing.Size(823, 417);
            this.gcResult.TabIndex = 17;
            this.gcResult.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvResult});
            // 
            // bsResult
            // 
            this.bsResult.DataSource = typeof(Accounting.Treasury);
            // 
            // gvResult
            // 
            this.gvResult.Appearance.GroupRow.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvResult.Appearance.GroupRow.Options.UseFont = true;
            this.gvResult.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSC,
            this.colAccount,
            this.colCurrency,
            this.colDescription1,
            this.colDebit,
            this.colCredit,
            this.colBalance,
            this.colBalance1st,
            this.colBalance2nd});
            this.gvResult.GridControl = this.gcResult;
            this.gvResult.GroupCount = 1;
            this.gvResult.GroupFormat = "{0}: [#image]{1}       {2}";
            this.gvResult.GroupRowHeight = 24;
            this.gvResult.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Balance1st", null, "1st Local : {0:#,#0.00;;\"\"}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Balance2nd", null, "2nd Local : {0:#,#0.00;;\"\"}")});
            this.gvResult.HighLightFocusedRow = true;
            this.gvResult.Name = "gvResult";
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
            this.gvResult.OptionsView.ShowFooter = true;
            this.gvResult.OptionsView.ShowGroupedColumns = true;
            this.gvResult.OptionsView.ShowGroupPanel = false;
            this.gvResult.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gvResult.OptionsView.ShowIndicator = false;
            this.gvResult.ParentForm = null;
            this.gvResult.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colCurrency, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colAccount, DevExpress.Data.ColumnSortOrder.Ascending)});
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
            this.colAccount.Name = "colAccount";
            this.colAccount.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colAccount.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colAccount.Visible = true;
            this.colAccount.VisibleIndex = 1;
            this.colAccount.Width = 97;
            // 
            // colCurrency
            // 
            this.colCurrency.AlwaysDisabled = false;
            this.colCurrency.CustomData = "";
            this.colCurrency.EditDisabled = false;
            this.colCurrency.FieldName = "Currency";
            this.colCurrency.Image = ((System.Drawing.Image)(resources.GetObject("colCurrency.Image")));
            this.colCurrency.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.colCurrency.Name = "colCurrency";
            this.colCurrency.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCurrency.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Equals;
            this.colCurrency.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colCurrency.Visible = true;
            this.colCurrency.VisibleIndex = 2;
            this.colCurrency.Width = 38;
            // 
            // colDescription1
            // 
            this.colDescription1.AlwaysDisabled = false;
            this.colDescription1.CustomData = "";
            this.colDescription1.EditDisabled = false;
            this.colDescription1.FieldName = "Description";
            this.colDescription1.Name = "colDescription1";
            this.colDescription1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colDescription1.OptionsColumn.AllowMove = false;
            this.colDescription1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDescription1.OptionsColumn.ReadOnly = true;
            this.colDescription1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDescription1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Balance1st", "1st Local : {0:#,#0.00;;\"\"}"),
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Balance2nd", "2nd Local : {0:#,#0.00;;\"\"}")});
            this.colDescription1.Visible = true;
            this.colDescription1.VisibleIndex = 3;
            this.colDescription1.Width = 342;
            // 
            // colDebit
            // 
            this.colDebit.AlwaysDisabled = false;
            this.colDebit.CustomData = "";
            this.colDebit.DisplayFormat.FormatString = "{0:#,#0.00;;\"\"}";
            this.colDebit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colDebit.EditDisabled = false;
            this.colDebit.FieldName = "Debit1";
            this.colDebit.Name = "colDebit";
            this.colDebit.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDebit.Visible = true;
            this.colDebit.VisibleIndex = 4;
            this.colDebit.Width = 100;
            // 
            // colCredit
            // 
            this.colCredit.AlwaysDisabled = false;
            this.colCredit.CustomData = "";
            this.colCredit.DisplayFormat.FormatString = "{0:#,#0.00;;\"\"}";
            this.colCredit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colCredit.EditDisabled = false;
            this.colCredit.FieldName = "Credit1";
            this.colCredit.Name = "colCredit";
            this.colCredit.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCredit.Visible = true;
            this.colCredit.VisibleIndex = 5;
            this.colCredit.Width = 100;
            // 
            // colBalance
            // 
            this.colBalance.AlwaysDisabled = false;
            this.colBalance.CustomData = "";
            this.colBalance.DisplayFormat.FormatString = "{0:#,#0.00;;\"\"}";
            this.colBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colBalance.EditDisabled = false;
            this.colBalance.FieldName = "Balance";
            this.colBalance.Name = "colBalance";
            this.colBalance.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colBalance.Visible = true;
            this.colBalance.VisibleIndex = 6;
            this.colBalance.Width = 100;
            // 
            // colBalance1st
            // 
            this.colBalance1st.AlwaysDisabled = false;
            this.colBalance1st.CustomData = "";
            this.colBalance1st.EditDisabled = false;
            this.colBalance1st.FieldName = "Balance1st";
            this.colBalance1st.Name = "colBalance1st";
            this.colBalance1st.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colBalance1st.Width = 120;
            // 
            // colBalance2nd
            // 
            this.colBalance2nd.AlwaysDisabled = false;
            this.colBalance2nd.CustomData = "";
            this.colBalance2nd.EditDisabled = false;
            this.colBalance2nd.FieldName = "Balance2nd";
            this.colBalance2nd.Name = "colBalance2nd";
            this.colBalance2nd.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colBalance2nd.Width = 85;
            // 
            // lciGridResult
            // 
            this.lciGridResult.Control = this.gcResult;
            this.lciGridResult.CustomizationFormText = "lciGridResult";
            this.lciGridResult.IsRequired = null;
            this.lciGridResult.Location = new System.Drawing.Point(0, 24);
            this.lciGridResult.Name = "lciGridResult";
            this.lciGridResult.Size = new System.Drawing.Size(827, 421);
            this.lciGridResult.TextSize = new System.Drawing.Size(0, 0);
            this.lciGridResult.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(133, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(694, 24);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // FormTreasury
            // 
            this.ClientSize = new System.Drawing.Size(855, 503);
            this.Name = "FormTreasury";
            this.Text = "Treasury";
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
            ((System.ComponentModel.ISupportInitialize)(this.lciFromDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGridResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private efControls.efGridColumn colCode;
        private efControls.efGridColumn colDescription;
        private efControls.efGridControl gcResult;
        private efControls.efGridView gvResult;
        private efControls.efDateEdit deFrom;
        private efControls.lci lciFromDate;
        private efControls.lci lciGridResult;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private System.Windows.Forms.BindingSource bsResult;
        private efControls.efGridColumn colAccount;
        private efControls.efGridColumn colCurrency;
        private efControls.efGridColumn colDescription1;
        private efControls.efGridColumn colDebit;
        private efControls.efGridColumn colCredit;
        private efControls.efGridColumn colBalance;
        private efControls.efGridColumn colBalance1st;
        private efControls.efGridColumn colBalance2nd;
        private efControls.efGridColumn colSC;
    }
}
