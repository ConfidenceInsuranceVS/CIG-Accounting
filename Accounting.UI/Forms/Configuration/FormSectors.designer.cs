namespace Accounting
{
    partial class FormSectors
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSectors));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.txtCode = new efControls.efTextBox();
            this.lciCode = new efControls.lci();
            this.txtDescription = new efControls.efTextBox();
            this.lciDescription = new efControls.lci();
            this.colDescription = new efControls.efGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdController)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sccMain)).BeginInit();
            this.sccMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcSearch)).BeginInit();
            this.lcSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcgSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDescription)).BeginInit();
            this.SuspendLayout();
            // 
            // gcSearch
            // 
            this.gcSearch.EmbeddedNavigator.Buttons.First.Visible = false;
            this.gcSearch.EmbeddedNavigator.Buttons.Last.Visible = false;
            this.gcSearch.EmbeddedNavigator.Buttons.Next.Visible = false;
            this.gcSearch.EmbeddedNavigator.Buttons.NextPage.Visible = false;
            this.gcSearch.EmbeddedNavigator.Buttons.Prev.Visible = false;
            this.gcSearch.EmbeddedNavigator.Buttons.PrevPage.Visible = false;
            gridLevelNode1.RelationName = "Level1";
            this.gcSearch.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gcSearch.Size = new System.Drawing.Size(450, 172);
            // 
            // gvSearch
            // 
            this.gvSearch.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvSearch.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDescription});
            this.gvSearch.OptionsBehavior.AutoExpandAllGroups = true;
            this.gvSearch.OptionsBehavior.ReadOnly = true;
            this.gvSearch.OptionsCustomization.AllowColumnMoving = false;
            this.gvSearch.OptionsCustomization.AllowColumnResizing = false;
            this.gvSearch.OptionsDetail.EnableMasterViewMode = false;
            this.gvSearch.OptionsEditForm.ActionOnModifiedRowChange = DevExpress.XtraGrid.Views.Grid.EditFormModifiedAction.Nothing;
            this.gvSearch.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.False;
            this.gvSearch.OptionsEditForm.ShowOnEnterKey = DevExpress.Utils.DefaultBoolean.False;
            this.gvSearch.OptionsEditForm.ShowOnF2Key = DevExpress.Utils.DefaultBoolean.False;
            this.gvSearch.OptionsEditForm.ShowUpdateCancelPanel = DevExpress.Utils.DefaultBoolean.False;
            this.gvSearch.OptionsFilter.UseNewCustomFilterDialog = true;
            this.gvSearch.OptionsFind.AllowFindPanel = false;
            this.gvSearch.OptionsMenu.EnableColumnMenu = false;
            this.gvSearch.OptionsMenu.EnableFooterMenu = false;
            this.gvSearch.OptionsMenu.EnableGroupPanelMenu = false;
            this.gvSearch.OptionsNavigation.AutoFocusNewRow = true;
            this.gvSearch.OptionsNavigation.EnterMoveNextColumn = true;
            this.gvSearch.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvSearch.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.NeverAnimate;
            this.gvSearch.OptionsView.EnableAppearanceEvenRow = true;
            this.gvSearch.OptionsView.ShowDetailButtons = false;
            this.gvSearch.OptionsView.ShowGroupPanel = false;
            this.gvSearch.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gvSearch.OptionsView.ShowIndicator = false;
            // 
            // colSearch
            // 
            this.colSearch.AppearanceHeader.Options.UseTextOptions = true;
            this.colSearch.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSearch.Caption = "Code";
            this.colSearch.FieldName = "Code";
            this.colSearch.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSearch.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colSearch.Width = 34;
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
            this.barDockControlTop.Size = new System.Drawing.Size(454, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 300);
            this.barDockControlBottom.Size = new System.Drawing.Size(454, 27);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 269);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.Location = new System.Drawing.Point(454, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 269);
            // 
            // barManager
            // 
            this.barManager.OptionsLayout.AllowAddNewItems = false;
            // 
            // bsMaster
            // 
            this.bsMaster.DataSource = this.bsSearch;
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
            this.sccMain.Horizontal = false;
            this.sccMain.Location = new System.Drawing.Point(0, 31);
            this.sccMain.Size = new System.Drawing.Size(454, 269);
            this.sccMain.SplitterPosition = 222;
            // 
            // lcSearch
            // 
            this.lcSearch.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(945, 154, 250, 350);
            this.lcSearch.Size = new System.Drawing.Size(454, 222);
            this.lcSearch.Controls.SetChildIndex(this.gcSearch, 0);
            // 
            // lcgSearch
            // 
            this.lcgSearch.Size = new System.Drawing.Size(454, 222);
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.txtDescription);
            this.lcMain.Controls.Add(this.txtCode);
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1189, 49, 250, 700);
            this.lcMain.Size = new System.Drawing.Size(454, 42);
            // 
            // lcgMain
            // 
            this.lcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciCode,
            this.lciDescription});
            this.lcgMain.Size = new System.Drawing.Size(454, 42);
            // 
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            // 
            // bciPosted
            // 
            this.bciPosted.ItemAppearance.Pressed.BackColor = System.Drawing.Color.Transparent;
            this.bciPosted.ItemAppearance.Pressed.Options.UseBackColor = true;
            // 
            // bsSearch
            // 
            this.bsSearch.DataSource = typeof(Accounting.SectorSearchList);
            // 
            // txtCode
            // 
            this.txtCode.AllowLeadingSpace = false;
            this.txtCode.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsMaster, "Code", true));
            this.txtCode.DefaultState = efControls.Enums.ControlState.EditDisabled;
            this.txtCode.DisplayType = efControls.Enums.DisplayType.Default;
            this.txtCode.EnterMoveNextControl = true;
            this.txtCode.Information = null;
            this.txtCode.Location = new System.Drawing.Point(2, 18);
            this.txtCode.MenuManager = this.barManager;
            this.txtCode.Name = "txtCode";
            this.txtCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCode.Size = new System.Drawing.Size(27, 20);
            this.txtCode.StyleController = this.lcMain;
            this.txtCode.TabIndex = 4;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Required!";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.ValidationProvider.SetValidationRule(this.txtCode, conditionValidationRule1);
            this.txtCode.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCode_Validating);
            // 
            // lciCode
            // 
            this.lciCode.Control = this.txtCode;
            this.lciCode.IsRequired = null;
            this.lciCode.Location = new System.Drawing.Point(0, 0);
            this.lciCode.MaxSize = new System.Drawing.Size(31, 0);
            this.lciCode.MinSize = new System.Drawing.Size(31, 1);
            this.lciCode.Name = "lciCode";
            this.lciCode.Size = new System.Drawing.Size(31, 42);
            this.lciCode.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciCode.Text = "Code";
            this.lciCode.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciCode.TextSize = new System.Drawing.Size(53, 13);
            // 
            // txtDescription
            // 
            this.txtDescription.AllowLeadingSpace = false;
            this.txtDescription.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsMaster, "Description", true));
            this.txtDescription.DefaultState = efControls.Enums.ControlState.Default;
            this.txtDescription.DisplayType = efControls.Enums.DisplayType.Default;
            this.txtDescription.EnterMoveNextControl = true;
            this.txtDescription.Information = null;
            this.txtDescription.Location = new System.Drawing.Point(33, 18);
            this.txtDescription.MenuManager = this.barManager;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(419, 20);
            this.txtDescription.StyleController = this.lcMain;
            this.txtDescription.TabIndex = 5;
            // 
            // lciDescription
            // 
            this.lciDescription.Control = this.txtDescription;
            this.lciDescription.IsRequired = null;
            this.lciDescription.Location = new System.Drawing.Point(31, 0);
            this.lciDescription.Name = "lciDescription";
            this.lciDescription.Size = new System.Drawing.Size(423, 42);
            this.lciDescription.Text = "Description";
            this.lciDescription.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciDescription.TextSize = new System.Drawing.Size(53, 13);
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
            this.colDescription.VisibleIndex = 1;
            this.colDescription.Width = 403;
            // 
            // FormSectors
            // 
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(454, 327);
            this.MaximumSize = new System.Drawing.Size(994, 643);
            this.MinimumSize = new System.Drawing.Size(444, 293);
            this.Name = "FormSectors";
            this.Text = "Sectors Management";
            ((System.ComponentModel.ISupportInitialize)(this.gcSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdController)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sccMain)).EndInit();
            this.sccMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcSearch)).EndInit();
            this.lcSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcgSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDescription)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private efControls.efTextBox txtDescription;
        private efControls.efTextBox txtCode;
        private efControls.lci lciCode;
        private efControls.lci lciDescription;
        private efControls.efGridColumn colDescription;
    }
}
