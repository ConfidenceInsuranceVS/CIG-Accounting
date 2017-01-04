﻿namespace Accounting
{
    partial class FormCostCenter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCostCenter));
            this.gcForm = new efControls.efGridControl();
            this.gvForm = new efControls.efGridView();
            this.colCode = new efControls.efGridColumn();
            this.riCode = new efControls.RepositoryItemefTextBox();
            this.colDescription = new efControls.efGridColumn();
            this.riDescription = new efControls.RepositoryItemefTextBox();
            this.colOpendate = new efControls.efGridColumn();
            this.colReason = new efControls.efGridColumn();
            this.colReasondate = new efControls.efGridColumn();
            this.colIsparent = new efControls.efGridColumn();
            this.colIscancelled = new efControls.efGridColumn();
            this.riPhonecode = new efControls.RepositoryItemefTextBox();
            this.lcg = new efControls.lci();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdController)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sccMain)).BeginInit();
            this.sccMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riPhonecode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcg)).BeginInit();
            this.SuspendLayout();
            // 
            // toolBar
            // 
            this.toolBar.OptionsBar.AllowQuickCustomization = false;
            this.toolBar.OptionsBar.DisableClose = true;
            this.toolBar.OptionsBar.DisableCustomization = true;
            this.toolBar.OptionsBar.DrawDragBorder = false;
            this.toolBar.OptionsBar.RotateWhenVertical = false;
            this.toolBar.OptionsBar.UseWholeRow = true;
            // 
            // statusBar
            // 
            this.statusBar.OptionsBar.AllowQuickCustomization = false;
            this.statusBar.OptionsBar.DisableClose = true;
            this.statusBar.OptionsBar.DisableCustomization = true;
            this.statusBar.OptionsBar.DrawDragBorder = false;
            this.statusBar.OptionsBar.DrawSizeGrip = true;
            this.statusBar.OptionsBar.MultiLine = true;
            this.statusBar.OptionsBar.UseWholeRow = true;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.Size = new System.Drawing.Size(860, 28);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 475);
            this.barDockControlBottom.Size = new System.Drawing.Size(860, 28);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 28);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 447);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.Location = new System.Drawing.Point(860, 28);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 447);
            // 
            // barManager
            // 
            this.barManager.OptionsLayout.AllowAddNewItems = false;
            // 
            // bsMaster
            // 
            this.bsMaster.DataSource = typeof(Accounting.Costcenter);
            // 
            // bdController
            // 
            this.bdController.LookAndFeel.SkinName = "Office 2010 Blue";
            this.bdController.PropertiesBar.AllowLinkLighting = false;
            this.bdController.PropertiesBar.DefaultGlyphSize = new System.Drawing.Size(16, 16);
            this.bdController.PropertiesBar.DefaultLargeGlyphSize = new System.Drawing.Size(32, 32);
            // 
            // sccMain
            // 
            this.sccMain.Location = new System.Drawing.Point(0, 28);
            this.sccMain.Size = new System.Drawing.Size(860, 447);
            // 
            // lcSearch
            // 
            this.lcSearch.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(945, 154, 250, 350);
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.gcForm);
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1189, 49, 250, 700);
            this.lcMain.Size = new System.Drawing.Size(860, 447);
            // 
            // lcgMain
            // 
            this.lcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcg});
            this.lcgMain.Size = new System.Drawing.Size(860, 447);
            // 
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            // 
            // gcForm
            // 
            this.gcForm.DataSource = this.bsMaster;
            this.gcForm.DefaultState = efControls.Enums.ControlState.Default;
            this.gcForm.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcForm.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcForm.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcForm.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcForm.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcForm.EmbeddedNavigatorHideButtons = true;
            this.gcForm.Location = new System.Drawing.Point(2, 2);
            this.gcForm.MainView = this.gvForm;
            this.gcForm.MenuManager = this.barManager;
            this.gcForm.Name = "gcForm";
            this.gcForm.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riCode,
            this.riDescription,
            this.riPhonecode});
            this.gcForm.Size = new System.Drawing.Size(856, 443);
            this.gcForm.TabIndex = 4;
            this.gcForm.UseEmbeddedNavigator = true;
            this.gcForm.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvForm});
            // 
            // gvForm
            // 
            this.gvForm.Columns.AddRange(new efControls.efGridColumn[] {
            this.colCode,
            this.colDescription,
            this.colOpendate,
            this.colReason,
            this.colReasondate,
            this.colIsparent,
            this.colIscancelled});
            this.gvForm.GridControl = this.gcForm;
            this.gvForm.Name = "gvForm";
            this.gvForm.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplaceHideCurrentRow;
            this.gvForm.OptionsBehavior.ReadOnly = true;
            this.gvForm.OptionsCustomization.AllowColumnMoving = false;
            this.gvForm.OptionsDetail.EnableMasterViewMode = false;
            this.gvForm.OptionsEditForm.ActionOnModifiedRowChange = DevExpress.XtraGrid.Views.Grid.EditFormModifiedAction.Nothing;
            this.gvForm.OptionsEditForm.EditFormColumnCount = 6;
            this.gvForm.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.False;
            this.gvForm.OptionsEditForm.ShowOnEnterKey = DevExpress.Utils.DefaultBoolean.False;
            this.gvForm.OptionsEditForm.ShowOnF2Key = DevExpress.Utils.DefaultBoolean.False;
            this.gvForm.OptionsEditForm.ShowUpdateCancelPanel = DevExpress.Utils.DefaultBoolean.False;
            this.gvForm.OptionsFind.AllowFindPanel = false;
            this.gvForm.OptionsMenu.EnableColumnMenu = false;
            this.gvForm.OptionsMenu.EnableFooterMenu = false;
            this.gvForm.OptionsMenu.EnableGroupPanelMenu = false;
            this.gvForm.OptionsNavigation.AutoFocusNewRow = true;
            this.gvForm.OptionsNavigation.EnterMoveNextColumn = true;
            this.gvForm.OptionsView.ColumnAutoWidth = false;
            this.gvForm.OptionsView.EnableAppearanceEvenRow = true;
            this.gvForm.OptionsView.ShowAutoFilterRow = true;
            this.gvForm.OptionsView.ShowGroupPanel = false;
            this.gvForm.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gvForm.OptionsView.ShowIndicator = false;
            this.gvForm.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gvForm.VisibleAutoFilterRow = true;
            this.gvForm.VisibleGroupPanel = false;
            this.gvForm.VisibleIndicator = false;
            this.gvForm.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gvForm_ValidatingEditor);
            // 
            // colCode
            // 
            this.colCode.ColumnEdit = this.riCode;
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.OptionsEditForm.Caption = "Code";
            this.colCode.OptionsEditForm.UseEditorColRowSpan = false;
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 0;
            // 
            // riCode
            // 
            this.riCode.AutoHeight = false;
            this.riCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.riCode.MaxLength = 3;
            this.riCode.Name = "riCode";
            // 
            // colDescription
            // 
            this.colDescription.ColumnEdit = this.riDescription;
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.OptionsEditForm.Caption = "Description";
            this.colDescription.OptionsEditForm.ColumnSpan = 5;
            this.colDescription.OptionsEditForm.UseEditorColRowSpan = false;
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            this.colDescription.Width = 234;
            // 
            // riDescription
            // 
            this.riDescription.AutoHeight = false;
            this.riDescription.MaxLength = 30;
            this.riDescription.Name = "riDescription";
            // 
            // colOpendate
            // 
            this.colOpendate.AppearanceHeader.Options.UseTextOptions = true;
            this.colOpendate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOpendate.Caption = "Open Date";
            this.colOpendate.CustomData = "";
            this.colOpendate.FieldName = "Opendate";
            this.colOpendate.Name = "colOpendate";
            this.colOpendate.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colOpendate.OptionsEditForm.Caption = "Open Date";
            this.colOpendate.OptionsEditForm.UseEditorColRowSpan = false;
            this.colOpendate.Visible = true;
            this.colOpendate.VisibleIndex = 2;
            // 
            // colReason
            // 
            this.colReason.AppearanceHeader.Options.UseTextOptions = true;
            this.colReason.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colReason.CustomData = "";
            this.colReason.FieldName = "Reason";
            this.colReason.Name = "colReason";
            this.colReason.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colReason.OptionsEditForm.Caption = "Reason";
            this.colReason.OptionsEditForm.ColumnSpan = 5;
            this.colReason.OptionsEditForm.UseEditorColRowSpan = false;
            this.colReason.Visible = true;
            this.colReason.VisibleIndex = 3;
            this.colReason.Width = 226;
            // 
            // colReasondate
            // 
            this.colReasondate.AppearanceHeader.Options.UseTextOptions = true;
            this.colReasondate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colReasondate.Caption = "Date";
            this.colReasondate.CustomData = "";
            this.colReasondate.FieldName = "Reasondate";
            this.colReasondate.Name = "colReasondate";
            this.colReasondate.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colReasondate.OptionsEditForm.Caption = "Date";
            this.colReasondate.OptionsEditForm.UseEditorColRowSpan = false;
            this.colReasondate.Visible = true;
            this.colReasondate.VisibleIndex = 4;
            // 
            // colIsparent
            // 
            this.colIsparent.AppearanceHeader.Options.UseTextOptions = true;
            this.colIsparent.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIsparent.Caption = "Parent";
            this.colIsparent.CustomData = "";
            this.colIsparent.FieldName = "Isparent";
            this.colIsparent.Name = "colIsparent";
            this.colIsparent.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIsparent.OptionsEditForm.Caption = "Parent";
            this.colIsparent.OptionsEditForm.StartNewRow = true;
            this.colIsparent.OptionsEditForm.UseEditorColRowSpan = false;
            this.colIsparent.Visible = true;
            this.colIsparent.VisibleIndex = 5;
            // 
            // colIscancelled
            // 
            this.colIscancelled.AppearanceHeader.Options.UseTextOptions = true;
            this.colIscancelled.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIscancelled.Caption = "Cancelled";
            this.colIscancelled.CustomData = "";
            this.colIscancelled.FieldName = "Iscancelled";
            this.colIscancelled.Name = "colIscancelled";
            this.colIscancelled.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIscancelled.OptionsEditForm.Caption = "Cancelled";
            this.colIscancelled.OptionsEditForm.StartNewRow = true;
            this.colIscancelled.OptionsEditForm.UseEditorColRowSpan = false;
            this.colIscancelled.Visible = true;
            this.colIscancelled.VisibleIndex = 6;
            // 
            // riPhonecode
            // 
            this.riPhonecode.AutoHeight = false;
            this.riPhonecode.MaxLength = 5;
            this.riPhonecode.Name = "riPhonecode";
            // 
            // lcg
            // 
            this.lcg.Control = this.gcForm;
            this.lcg.CustomizationFormText = "lcg";
            this.lcg.IsRequired = null;
            this.lcg.Location = new System.Drawing.Point(0, 0);
            this.lcg.Name = "lcg";
            this.lcg.Size = new System.Drawing.Size(860, 447);
            this.lcg.TextSize = new System.Drawing.Size(0, 0);
            this.lcg.TextVisible = false;
            // 
            // FormCostCenter
            // 
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(860, 503);
            this.MaximumSize = new System.Drawing.Size(994, 643);
            this.MinimumSize = new System.Drawing.Size(444, 293);
            this.Name = "FormCostCenter";
            this.NavigationGrid = this.gvForm;
            this.PrintableGrid = this.gvForm;
            this.Text = "Cost Center";
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdController)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sccMain)).EndInit();
            this.sccMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riPhonecode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private efControls.efGridControl gcForm;
        private efControls.efGridView gvForm;
        private efControls.lci lcg;
        private efControls.efGridColumn colCode;
        private efControls.efGridColumn colDescription;
        private efControls.RepositoryItemefTextBox riCode;
        private efControls.RepositoryItemefTextBox riDescription;
        private efControls.RepositoryItemefTextBox riPhonecode;
        private efControls.efGridColumn colOpendate;
        private efControls.efGridColumn colReason;
        private efControls.efGridColumn colReasondate;
        private efControls.efGridColumn colIscancelled;
        private efControls.efGridColumn colIsparent;
    }
}