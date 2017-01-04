namespace Accounting
{
    partial class efActivityLogger
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.coldateout = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bsLogger = new System.Windows.Forms.BindingSource(this.components);
            this.gcLogger = new efControls.efGridControl();
            this.gvLogger = new efControls.efGridView();
            this.colguid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusers = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riUsers = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bsUsers = new System.Windows.Forms.BindingSource(this.components);
            this.colmachine = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colformname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldatein = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemarks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.chkAutoRefresh = new efControls.efCheckBox();
            this.ucControlNavigator = new efControls.ucControlNavigator();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLogger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLogger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLogger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAutoRefresh.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // coldateout
            // 
            this.coldateout.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.coldateout.AppearanceHeader.Options.UseFont = true;
            this.coldateout.AppearanceHeader.Options.UseTextOptions = true;
            this.coldateout.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldateout.Caption = "Date Out";
            this.coldateout.DisplayFormat.FormatString = "dd-MM-yyyy HH:mm";
            this.coldateout.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.coldateout.FieldName = "DateOut";
            this.coldateout.GroupFormat.FormatString = "dd-MM-yyyy HH:mm";
            this.coldateout.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.coldateout.Name = "coldateout";
            this.coldateout.Visible = true;
            this.coldateout.VisibleIndex = 4;
            this.coldateout.Width = 120;
            // 
            // bsLogger
            // 
            this.bsLogger.DataSource = typeof(Accounting.ActivityLogger);
            // 
            // gcLogger
            // 
            this.gcLogger.DataSource = this.bsLogger;
            this.gcLogger.DefaultState = efControls.Enums.ControlState.AlwaysDisabled;
            this.gcLogger.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcLogger.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcLogger.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcLogger.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcLogger.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcLogger.EmbeddedNavigator.Buttons.First.ImageIndex = 6;
            this.gcLogger.EmbeddedNavigator.Buttons.Last.ImageIndex = 0;
            this.gcLogger.EmbeddedNavigator.Buttons.Next.ImageIndex = 1;
            this.gcLogger.EmbeddedNavigator.Buttons.NextPage.ImageIndex = 2;
            this.gcLogger.EmbeddedNavigator.Buttons.Prev.ImageIndex = 3;
            this.gcLogger.EmbeddedNavigator.Buttons.PrevPage.ImageIndex = 4;
            this.gcLogger.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcLogger.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.gcLogger.EmbeddedNavigator.CustomButtons.AddRange(new DevExpress.XtraEditors.NavigatorCustomButton[] {
            new DevExpress.XtraEditors.NavigatorCustomButton(5, "REFRESH")});
            this.gcLogger.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.gcLogger_EmbeddedNavigator_ButtonClick);
            this.gcLogger.EmbeddedNavigatorHideButtons = false;
            this.gcLogger.Location = new System.Drawing.Point(0, 0);
            this.gcLogger.MainView = this.gvLogger;
            this.gcLogger.Name = "gcLogger";
            this.gcLogger.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riUsers});
            this.gcLogger.Size = new System.Drawing.Size(874, 427);
            this.gcLogger.TabIndex = 0;
            this.gcLogger.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLogger});
            // 
            // gvLogger
            // 
            this.gvLogger.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gvLogger.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colguid,
            this.colusers,
            this.colmachine,
            this.colformname,
            this.coldatein,
            this.coldateout,
            this.colRemarks});
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.coldateout;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Expression = "null";
            this.gvLogger.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gvLogger.GridControl = this.gcLogger;
            this.gvLogger.HighLightFocusedRow = true;
            this.gvLogger.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.gvLogger.Name = "gvLogger";
            this.gvLogger.OptionsBehavior.ReadOnly = true;
            this.gvLogger.OptionsNavigation.EnterMoveNextColumn = true;
            this.gvLogger.OptionsView.EnableAppearanceEvenRow = true;
            this.gvLogger.OptionsView.ShowGroupPanel = false;
            this.gvLogger.OptionsView.ShowIndicator = false;
            this.gvLogger.ParentForm = null;
            this.gvLogger.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gvLogger.VisibleAutoFilterRow = false;
            this.gvLogger.VisibleGroupPanel = false;
            this.gvLogger.VisibleIndicator = false;
            // 
            // colguid
            // 
            this.colguid.FieldName = "Guid";
            this.colguid.Name = "colguid";
            this.colguid.Width = 60;
            // 
            // colusers
            // 
            this.colusers.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colusers.AppearanceHeader.Options.UseFont = true;
            this.colusers.AppearanceHeader.Options.UseTextOptions = true;
            this.colusers.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colusers.Caption = "User Name";
            this.colusers.ColumnEdit = this.riUsers;
            this.colusers.FieldName = "UserID";
            this.colusers.Name = "colusers";
            this.colusers.Visible = true;
            this.colusers.VisibleIndex = 0;
            this.colusers.Width = 150;
            // 
            // riUsers
            // 
            this.riUsers.AutoHeight = false;
            this.riUsers.DataSource = this.bsUsers;
            this.riUsers.DisplayMember = "Name";
            this.riUsers.Name = "riUsers";
            this.riUsers.ValueMember = "ID";
            // 
            // bsUsers
            // 
            this.bsUsers.DataSource = typeof(efControls.Data.User);
            // 
            // colmachine
            // 
            this.colmachine.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colmachine.AppearanceHeader.Options.UseFont = true;
            this.colmachine.AppearanceHeader.Options.UseTextOptions = true;
            this.colmachine.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmachine.Caption = "Machine";
            this.colmachine.FieldName = "Machine";
            this.colmachine.Name = "colmachine";
            this.colmachine.Visible = true;
            this.colmachine.VisibleIndex = 1;
            this.colmachine.Width = 105;
            // 
            // colformname
            // 
            this.colformname.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colformname.AppearanceHeader.Options.UseFont = true;
            this.colformname.AppearanceHeader.Options.UseTextOptions = true;
            this.colformname.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colformname.Caption = "Form Name";
            this.colformname.FieldName = "FormName";
            this.colformname.Name = "colformname";
            this.colformname.Visible = true;
            this.colformname.VisibleIndex = 2;
            this.colformname.Width = 125;
            // 
            // coldatein
            // 
            this.coldatein.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.coldatein.AppearanceHeader.Options.UseFont = true;
            this.coldatein.AppearanceHeader.Options.UseTextOptions = true;
            this.coldatein.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldatein.Caption = "Date In";
            this.coldatein.DisplayFormat.FormatString = "dd-MM-yyyy HH:mm";
            this.coldatein.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.coldatein.FieldName = "DateIn";
            this.coldatein.GroupFormat.FormatString = "dd-MM-yyyy HH:mm";
            this.coldatein.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.coldatein.Name = "coldatein";
            this.coldatein.Visible = true;
            this.coldatein.VisibleIndex = 3;
            this.coldatein.Width = 120;
            // 
            // colRemarks
            // 
            this.colRemarks.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colRemarks.AppearanceHeader.Options.UseFont = true;
            this.colRemarks.AppearanceHeader.Options.UseTextOptions = true;
            this.colRemarks.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRemarks.Caption = "Remarks";
            this.colRemarks.FieldName = "Remarks";
            this.colRemarks.Name = "colRemarks";
            this.colRemarks.Visible = true;
            this.colRemarks.VisibleIndex = 5;
            this.colRemarks.Width = 237;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 5000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // chkAutoRefresh
            // 
            this.chkAutoRefresh.DefaultState = efControls.Enums.ControlState.Default;
            this.chkAutoRefresh.EnterMoveNextControl = true;
            this.chkAutoRefresh.HighLighted = false;
            this.chkAutoRefresh.Location = new System.Drawing.Point(715, 433);
            this.chkAutoRefresh.Name = "chkAutoRefresh";
            this.chkAutoRefresh.Properties.Caption = "Auto Refresh (5 seconds)";
            this.chkAutoRefresh.Properties.Name = "efCheckBox";
            this.chkAutoRefresh.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.chkAutoRefresh.Size = new System.Drawing.Size(155, 19);
            this.chkAutoRefresh.TabIndex = 1;
            this.chkAutoRefresh.ValueType = efControls.Enums.ValueType.Boolean;
            this.chkAutoRefresh.CheckedChanged += new System.EventHandler(this.chkAutoRefresh_CheckedChanged);
            // 
            // ucControlNavigator
            // 
            this.ucControlNavigator.AlwaysEnabled = false;
            this.ucControlNavigator.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.ucControlNavigator.Appearance.Options.UseBackColor = true;
            this.ucControlNavigator.Location = new System.Drawing.Point(1, 430);
            this.ucControlNavigator.MaximumSize = new System.Drawing.Size(0, 26);
            this.ucControlNavigator.MinimumSize = new System.Drawing.Size(185, 26);
            this.ucControlNavigator.Name = "ucControlNavigator";
            this.ucControlNavigator.NavigatableControl = this.gcLogger;
            this.ucControlNavigator.Size = new System.Drawing.Size(185, 26);
            this.ucControlNavigator.TabIndex = 2;
            // 
            // efActivityLogger
            // 
            this.ClientSize = new System.Drawing.Size(874, 457);
            this.Controls.Add(this.ucControlNavigator);
            this.Controls.Add(this.chkAutoRefresh);
            this.Controls.Add(this.gcLogger);
            this.Name = "efActivityLogger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Logger";
            this.Controls.SetChildIndex(this.gcLogger, 0);
            this.Controls.SetChildIndex(this.chkAutoRefresh, 0);
            this.Controls.SetChildIndex(this.ucControlNavigator, 0);
            this.Controls.SetChildIndex(this.lblFocus, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLogger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLogger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLogger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAutoRefresh.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsLogger;
        private efControls.efGridControl gcLogger;
        private efControls.efGridView gvLogger;
        private DevExpress.XtraGrid.Columns.GridColumn colguid;
        private DevExpress.XtraGrid.Columns.GridColumn colusers;
        private DevExpress.XtraGrid.Columns.GridColumn colmachine;
        private DevExpress.XtraGrid.Columns.GridColumn colformname;
        private DevExpress.XtraGrid.Columns.GridColumn coldatein;
        private DevExpress.XtraGrid.Columns.GridColumn coldateout;
        private DevExpress.XtraGrid.Columns.GridColumn colRemarks;
        private System.Windows.Forms.Timer timer;
        private efControls.efCheckBox chkAutoRefresh;
        private System.Windows.Forms.BindingSource bsUsers;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riUsers;
        private efControls.ucControlNavigator ucControlNavigator;
    }
}
