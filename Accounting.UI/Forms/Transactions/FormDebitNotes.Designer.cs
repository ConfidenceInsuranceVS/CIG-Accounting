namespace Accounting
{
    partial class FormDebitNotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDebitNotes));
            this.riVoucherType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVoucherType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCurrencies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBanks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboVoucherTypes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReference.Properties)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riVoucherType)).BeginInit();
            this.SuspendLayout();
            // 
            // cboVoucherTypes
            // 
            this.cboVoucherTypes.Filter = Accounting.cboVoucherTypes.jvFilter.DN;
            // 
            // deDate
            // 
            this.deDate.EditValue = null;
            this.deDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.deDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            // 
            // txtReference
            // 
            this.txtReference.Properties.Appearance.Options.UseTextOptions = true;
            this.txtReference.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtReference.Properties.Mask.EditMask = "d";
            this.txtReference.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtReference.Properties.Mask.UseMaskAsDisplayFormat = true;
            // 
            // gcSearch
            // 
            this.gcSearch.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcSearch.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcSearch.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcSearch.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcSearch.EmbeddedNavigator.Buttons.First.Visible = false;
            this.gcSearch.EmbeddedNavigator.Buttons.Last.Visible = false;
            this.gcSearch.EmbeddedNavigator.Buttons.Next.Visible = false;
            this.gcSearch.EmbeddedNavigator.Buttons.NextPage.Visible = false;
            this.gcSearch.EmbeddedNavigator.Buttons.Prev.Visible = false;
            this.gcSearch.EmbeddedNavigator.Buttons.PrevPage.Visible = false;
            this.gcSearch.EmbeddedNavigator.Buttons.Remove.Visible = false;
            gridLevelNode1.RelationName = "Level1";
            this.gcSearch.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gcSearch.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riVoucherType});
            this.gcSearch.Size = new System.Drawing.Size(116, 385);
            // 
            // gvSearch
            // 
            this.gvSearch.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvSearch.OptionsBehavior.Editable = false;
            this.gvSearch.OptionsBehavior.ReadOnly = true;
            this.gvSearch.OptionsCustomization.AllowColumnMoving = false;
            this.gvSearch.OptionsDetail.EnableMasterViewMode = false;
            this.gvSearch.OptionsFilter.UseNewCustomFilterDialog = true;
            this.gvSearch.OptionsFind.AllowFindPanel = false;
            this.gvSearch.OptionsMenu.EnableColumnMenu = false;
            this.gvSearch.OptionsMenu.EnableFooterMenu = false;
            this.gvSearch.OptionsMenu.EnableGroupPanelMenu = false;
            this.gvSearch.OptionsNavigation.AutoFocusNewRow = true;
            this.gvSearch.OptionsNavigation.EnterMoveNextColumn = true;
            this.gvSearch.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvSearch.OptionsView.EnableAppearanceEvenRow = true;
            this.gvSearch.OptionsView.EnableAppearanceOddRow = true;
            this.gvSearch.OptionsView.ShowAutoFilterRow = true;
            this.gvSearch.OptionsView.ShowColumnHeaders = true;//samir  BU 7/12/2016-1
            this.gvSearch.OptionsView.ShowDetailButtons = false;
            this.gvSearch.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.gvSearch.OptionsView.ShowGroupPanel = false;
            this.gvSearch.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gvSearch.OptionsView.ShowIndicator = false;
            // 
            // colSearch
            // 
            this.colSearch.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
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
            this.barDockControlTop.Size = new System.Drawing.Size(904, 28);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 463);
            this.barDockControlBottom.Size = new System.Drawing.Size(904, 28);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 28);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 435);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.Location = new System.Drawing.Point(904, 28);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 435);
            // 
            // barManager
            // 
            this.barManager.OptionsLayout.AllowAddNewItems = false;
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
            this.sccMain.Size = new System.Drawing.Size(904, 435);
            // 
            // lcSearch
            // 
            this.lcSearch.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(678, 161, 250, 350);
            this.lcSearch.Size = new System.Drawing.Size(120, 435);
            this.lcSearch.Controls.SetChildIndex(this.gcSearch, 0);
            // 
            // lcgSearch
            // 
            this.lcgSearch.Size = new System.Drawing.Size(120, 435);
            // 
            // lcMain
            // 
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1111, 96, 250, 700);
            this.lcMain.Size = new System.Drawing.Size(772, 435);
            this.lcMain.Controls.SetChildIndex(this.cboVoucherTypes, 0);
            this.lcMain.Controls.SetChildIndex(this.txtReference, 0);
            this.lcMain.Controls.SetChildIndex(this.deDate, 0);
            // 
            // lcgMain
            // 
            this.lcgMain.Size = new System.Drawing.Size(772, 435);
            // 
            // riVoucherType
            // 
            this.riVoucherType.AutoHeight = false;
            this.riVoucherType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riVoucherType.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.riVoucherType.DataSource = this.bsVoucherType;
            this.riVoucherType.DisplayMember = "Code";
            this.riVoucherType.Name = "riVoucherType";
            this.riVoucherType.ValueMember = "Code";
            // 
            // FormDebitNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 491);
            this.Name = "FormDebitNotes";
            this.Text = "Debit Notes";
            ((System.ComponentModel.ISupportInitialize)(this.bsVoucherType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCurrencies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBanks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboVoucherTypes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReference.Properties)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riVoucherType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riVoucherType;
    }
}