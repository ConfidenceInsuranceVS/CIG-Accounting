namespace efControls
{
    partial class FormGroups
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGroups));
            this.gcGroups = new efControls.efGridControl();
            this.gvGroups = new efControls.efGridView();
            this.colDescription = new efControls.efGridColumn();
            this.riDescription = new efControls.RepositoryItemefTextBox();
            this.lciGrid = new efControls.lci();
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
            ((System.ComponentModel.ISupportInitialize)(this.bsSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGrid)).BeginInit();
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
            this.barDockControlTop.Size = new System.Drawing.Size(455, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 313);
            this.barDockControlBottom.Size = new System.Drawing.Size(455, 27);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 282);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.Location = new System.Drawing.Point(455, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 282);
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
            this.sccMain.Location = new System.Drawing.Point(0, 31);
            this.sccMain.Size = new System.Drawing.Size(455, 282);
            // 
            // lcSearch
            // 
            this.lcSearch.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(945, 154, 250, 350);
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.gcGroups);
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(603, 144, 250, 350);
            this.lcMain.Size = new System.Drawing.Size(455, 282);
            // 
            // lcgMain
            // 
            this.lcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciGrid});
            this.lcgMain.Size = new System.Drawing.Size(455, 282);
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
            this.bsSearch.DataSource = typeof(efControls.Data.Group);
            // 
            // gcGroups
            // 
            this.gcGroups.DataSource = this.bsMaster;
            this.gcGroups.DefaultState = efControls.Enums.ControlState.Default;
            this.gcGroups.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcGroups.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcGroups.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcGroups.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcGroups.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcGroups.EmbeddedNavigatorHideButtons = true;
            this.gcGroups.Location = new System.Drawing.Point(2, 2);
            this.gcGroups.MainView = this.gvGroups;
            this.gcGroups.MenuManager = this.barManager;
            this.gcGroups.Name = "gcGroups";
            this.gcGroups.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riDescription});
            this.gcGroups.Size = new System.Drawing.Size(451, 278);
            this.gcGroups.TabIndex = 4;
            this.gcGroups.UseEmbeddedNavigator = true;
            this.gcGroups.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvGroups});
            // 
            // gvGroups
            // 
            this.gvGroups.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDescription});
            this.gvGroups.GridControl = this.gcGroups;
            this.gvGroups.HighLightFocusedRow = true;
            this.gvGroups.Name = "gvGroups";
            this.gvGroups.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvGroups.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplaceHideCurrentRow;
            this.gvGroups.OptionsBehavior.ReadOnly = true;
            this.gvGroups.OptionsCustomization.AllowColumnMoving = false;
            this.gvGroups.OptionsDetail.EnableMasterViewMode = false;
            this.gvGroups.OptionsEditForm.EditFormColumnCount = 5;
            this.gvGroups.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.False;
            this.gvGroups.OptionsEditForm.ShowOnEnterKey = DevExpress.Utils.DefaultBoolean.False;
            this.gvGroups.OptionsEditForm.ShowOnF2Key = DevExpress.Utils.DefaultBoolean.False;
            this.gvGroups.OptionsEditForm.ShowUpdateCancelPanel = DevExpress.Utils.DefaultBoolean.False;
            this.gvGroups.OptionsFind.AllowFindPanel = false;
            this.gvGroups.OptionsMenu.EnableColumnMenu = false;
            this.gvGroups.OptionsMenu.EnableFooterMenu = false;
            this.gvGroups.OptionsMenu.EnableGroupPanelMenu = false;
            this.gvGroups.OptionsNavigation.AutoFocusNewRow = true;
            this.gvGroups.OptionsNavigation.EnterMoveNextColumn = true;
            this.gvGroups.OptionsView.ColumnAutoWidth = false;
            this.gvGroups.OptionsView.EnableAppearanceEvenRow = true;
            this.gvGroups.OptionsView.ShowAutoFilterRow = true;
            this.gvGroups.OptionsView.ShowGroupPanel = false;
            this.gvGroups.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gvGroups.OptionsView.ShowIndicator = false;
            this.gvGroups.ParentForm = null;
            this.gvGroups.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gvGroups.VisibleAutoFilterRow = true;
            this.gvGroups.VisibleGroupPanel = false;
            this.gvGroups.VisibleIndicator = false;
            this.gvGroups.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gvGroups_ValidatingEditor);
            // 
            // colDescription
            // 
            this.colDescription.AlwaysDisabled = false;
            this.colDescription.ColumnEdit = this.riDescription;
            this.colDescription.CustomData = "";
            this.colDescription.EditDisabled = false;
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 0;
            this.colDescription.Width = 413;
            // 
            // riDescription
            // 
            this.riDescription.AutoHeight = false;
            this.riDescription.MaxLength = 50;
            this.riDescription.Name = "riDescription";
            // 
            // lciGrid
            // 
            this.lciGrid.Control = this.gcGroups;
            this.lciGrid.CustomizationFormText = "lciGrid";
            this.lciGrid.IsRequired = null;
            this.lciGrid.Location = new System.Drawing.Point(0, 0);
            this.lciGrid.Name = "lciGrid";
            this.lciGrid.Size = new System.Drawing.Size(455, 282);
            this.lciGrid.TextSize = new System.Drawing.Size(0, 0);
            this.lciGrid.TextVisible = false;
            // 
            // FormGroups
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 340);
            this.Name = "FormGroups";
            this.NavigationGrid = this.gvGroups;
            this.PrintableGrid = this.gvGroups;
            this.Text = "Groups Management";
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
            ((System.ComponentModel.ISupportInitialize)(this.bsSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private efControls.efGridControl gcGroups;
        private efControls.efGridView gvGroups;
        private efControls.lci lciGrid;
        private efControls.efGridColumn colDescription;
        private efControls.RepositoryItemefTextBox riDescription;

    }
}