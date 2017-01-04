namespace Accounting
{
    partial class FormReceiptVouchers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReceiptVouchers));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.riVoucherType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.beInstallments = new DevExpress.XtraBars.BarEditItem();
            this.riInstallments = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCurrencies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBanks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboVoucherTypes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReference.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVoucherType)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riVoucherType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riInstallments)).BeginInit();
            this.SuspendLayout();
            // 
            // lcgDetails
            // 
            this.lcgDetails.Expanded = true;
            this.lcgDetails.Size = new System.Drawing.Size(792, 101);
            // 
            // cboVoucherTypes
            // 
            this.cboVoucherTypes.Filter = Accounting.cboVoucherTypes.jvFilter.RV;
            // 
            // deDate
            // 
            this.deDate.EditValue = null;
            this.deDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.deDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            // 
            // colRef
            // 
            this.colRef.AppearanceHeader.Options.UseTextOptions = true;
            this.colRef.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRef.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colRef.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Equals;
            this.colRef.VisibleIndex = 1;
            // 
            // txtReference
            // 
            this.txtReference.Properties.Appearance.Options.UseTextOptions = true;
            this.txtReference.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtReference.Properties.Mask.EditMask = "d";
            this.txtReference.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtReference.Properties.Mask.UseMaskAsDisplayFormat = true;
            // 
            // colSC
            // 
            this.colSC.AppearanceHeader.Options.UseTextOptions = true;
            this.colSC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSC.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSC.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // GridBar
            // 
            this.GridBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, this.beInstallments, "", true, true, true, 73)});
            this.GridBar.OptionsBar.AllowQuickCustomization = false;
            this.GridBar.OptionsBar.DisableClose = true;
            this.GridBar.OptionsBar.DisableCustomization = true;
            this.GridBar.OptionsBar.DrawBorder = false;
            this.GridBar.OptionsBar.DrawDragBorder = false;
            this.GridBar.OptionsBar.UseWholeRow = true;
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
            this.gcSearch.Size = new System.Drawing.Size(116, 343);
            // 
            // gvSearch
            // 
            this.gvSearch.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvSearch.OptionsBehavior.AutoExpandAllGroups = true;
            this.gvSearch.OptionsBehavior.ReadOnly = true;
            this.gvSearch.OptionsCustomization.AllowColumnMoving = false;
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
            this.colSearch.AppearanceHeader.Options.UseTextOptions = true;
            this.colSearch.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSearch.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
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
            this.barDockControlTop.Size = new System.Drawing.Size(924, 28);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 487);
            this.barDockControlBottom.Size = new System.Drawing.Size(924, 24);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 28);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 459);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.Location = new System.Drawing.Point(924, 28);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 459);
            // 
            // barManager
            // 
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.beInstallments});
            this.barManager.MaxItemId = 47;
            this.barManager.OptionsLayout.AllowAddNewItems = false;
            this.barManager.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riInstallments});
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
            this.sccMain.Size = new System.Drawing.Size(924, 459);
            // 
            // lcSearch
            // 
            this.lcSearch.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(678, 161, 250, 350);
            this.lcSearch.Size = new System.Drawing.Size(120, 459);
            this.lcSearch.Controls.SetChildIndex(this.gcSearch, 0);
            // 
            // lcgSearch
            // 
            this.lcgSearch.Size = new System.Drawing.Size(120, 459);
            // 
            // lcMain
            // 
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1111, 96, 250, 700);
            this.lcMain.Size = new System.Drawing.Size(792, 459);
            this.lcMain.Controls.SetChildIndex(this.cboVoucherTypes, 0);
            this.lcMain.Controls.SetChildIndex(this.txtReference, 0);
            this.lcMain.Controls.SetChildIndex(this.deDate, 0);
            // 
            // lcgMain
            // 
            this.lcgMain.Size = new System.Drawing.Size(792, 459);
            // 
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.InsertGalleryImage("addfile_16x16.png", "office2013/actions/addfile_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/addfile_16x16.png"), 16);
            this.imageCollection.Images.SetKeyName(16, "addfile_16x16.png");
            this.imageCollection.InsertGalleryImage("deletelist_16x16.png", "office2013/actions/deletelist_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/deletelist_16x16.png"), 17);
            this.imageCollection.Images.SetKeyName(17, "deletelist_16x16.png");
            this.imageCollection.InsertGalleryImage("copy_16x16.png", "office2013/edit/copy_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/edit/copy_16x16.png"), 18);
            this.imageCollection.Images.SetKeyName(18, "copy_16x16.png");
            this.imageCollection.InsertGalleryImage("emptytablerowseparator_16x16.png", "office2013/reports/emptytablerowseparator_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/reports/emptytablerowseparator_16x16.png"), 19);
            this.imageCollection.Images.SetKeyName(19, "emptytablerowseparator_16x16.png");
            this.imageCollection.Images.SetKeyName(20, "scan-off.png");
            this.imageCollection.InsertGalleryImage("movedown_16x16.png", "office2013/arrows/movedown_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/arrows/movedown_16x16.png"), 21);
            this.imageCollection.Images.SetKeyName(21, "movedown_16x16.png");
            this.imageCollection.InsertGalleryImage("moveup_16x16.png", "office2013/arrows/moveup_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/arrows/moveup_16x16.png"), 22);
            this.imageCollection.Images.SetKeyName(22, "moveup_16x16.png");
            this.imageCollection.InsertGalleryImage("listmultilevel_16x16.png", "office2013/format/listmultilevel_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/format/listmultilevel_16x16.png"), 23);
            this.imageCollection.Images.SetKeyName(23, "listmultilevel_16x16.png");
            this.imageCollection.Images.SetKeyName(24, "Currency.png");
            this.imageCollection.Images.SetKeyName(25, "DebitCredit.png");
            this.imageCollection.InsertGalleryImage("currency_16x16.png", "office2013/miscellaneous/currency_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/miscellaneous/currency_16x16.png"), 26);
            this.imageCollection.Images.SetKeyName(26, "currency_16x16.png");
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
            // beInstallments
            // 
            this.beInstallments.Edit = this.riInstallments;
            this.beInstallments.Glyph = ((System.Drawing.Image)(resources.GetObject("beInstallments.Glyph")));
            this.beInstallments.Id = 46;
            this.beInstallments.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("beInstallments.LargeGlyph")));
            this.beInstallments.Name = "beInstallments";
            // 
            // riInstallments
            // 
            this.riInstallments.Appearance.Options.UseTextOptions = true;
            this.riInstallments.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.riInstallments.AutoHeight = false;
            this.riInstallments.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("riInstallments.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.riInstallments.Name = "riInstallments";
            this.riInstallments.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // FormReceiptVouchers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 511);
            this.Name = "FormReceiptVouchers";
            this.Text = "Receipt Vouchers";
            ((System.ComponentModel.ISupportInitialize)(this.bsAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCurrencies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBanks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboVoucherTypes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReference.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVoucherType)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riVoucherType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riInstallments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riVoucherType;
        private DevExpress.XtraBars.BarEditItem beInstallments;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit riInstallments;
    }
}