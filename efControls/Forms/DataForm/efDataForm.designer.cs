namespace efControls
{
    partial class efDataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(efDataForm));
            this.imageCollection = new DevExpress.Utils.ImageCollection();
            this.barManager = new DevExpress.XtraBars.BarManager();
            this.statusBar = new DevExpress.XtraBars.Bar();
            this.bsiCreatedBy = new DevExpress.XtraBars.BarStaticItem();
            this.bsiModifiedBy = new DevExpress.XtraBars.BarStaticItem();
            this.bciPosted = new DevExpress.XtraBars.BarCheckItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.toolBar = new DevExpress.XtraBars.Bar();
            this.btnNew = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnCancel = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrint = new DevExpress.XtraBars.BarButtonItem();
            this.pmPrint = new DevExpress.XtraBars.PopupMenu();
            this.btnPreview = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.bdController = new DevExpress.XtraBars.BarAndDockingController();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnPosted = new DevExpress.XtraBars.BarButtonItem();
            this.barToggleSwitchItem1 = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.bsMaster = new System.Windows.Forms.BindingSource();
            this.sccMain = new DevExpress.XtraEditors.SplitContainerControl();
            this.lcSearch = new efControls.efLayoutControl();
            this.lcgSearch = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcMain = new efControls.efLayoutControl();
            this.lcgMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.bsSearch = new System.Windows.Forms.BindingSource();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pmPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdController)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sccMain)).BeginInit();
            this.sccMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            // 
            // barManager
            // 
            this.barManager.AllowCustomization = false;
            this.barManager.AllowMoveBarOnToolbar = false;
            this.barManager.AllowQuickCustomization = false;
            this.barManager.AllowShowToolbarsPopup = false;
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.statusBar,
            this.toolBar});
            this.barManager.Controller = this.bdController;
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.DockWindowTabFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barManager.Form = this;
            this.barManager.Images = this.imageCollection;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnNew,
            this.btnEdit,
            this.btnDelete,
            this.btnSave,
            this.btnCancel,
            this.btnPrint,
            this.btnExit,
            this.btnPosted,
            this.bsiCreatedBy,
            this.bsiModifiedBy,
            this.btnRefresh,
            this.btnPreview,
            this.bciPosted,
            this.barToggleSwitchItem1});
            this.barManager.MaxItemId = 35;
            this.barManager.OptionsLayout.AllowAddNewItems = false;
            this.barManager.StatusBar = this.statusBar;
            // 
            // statusBar
            // 
            this.statusBar.BarName = "StatusBar";
            this.statusBar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.statusBar.DockCol = 0;
            this.statusBar.DockRow = 0;
            this.statusBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.statusBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bsiCreatedBy),
            new DevExpress.XtraBars.LinkPersistInfo(this.bsiModifiedBy),
            new DevExpress.XtraBars.LinkPersistInfo(this.bciPosted),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefresh, true)});
            this.statusBar.OptionsBar.AllowQuickCustomization = false;
            this.statusBar.OptionsBar.DisableClose = true;
            this.statusBar.OptionsBar.DisableCustomization = true;
            this.statusBar.OptionsBar.DrawDragBorder = false;
            this.statusBar.OptionsBar.DrawSizeGrip = true;
            this.statusBar.OptionsBar.MultiLine = true;
            this.statusBar.OptionsBar.UseWholeRow = true;
            this.statusBar.Text = "Statusbar";
            // 
            // bsiCreatedBy
            // 
            this.bsiCreatedBy.Id = 26;
            this.bsiCreatedBy.ImageIndex = 14;
            this.bsiCreatedBy.Name = "bsiCreatedBy";
            this.bsiCreatedBy.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bsiCreatedBy.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // bsiModifiedBy
            // 
            this.bsiModifiedBy.Id = 27;
            this.bsiModifiedBy.ImageIndex = 15;
            this.bsiModifiedBy.Name = "bsiModifiedBy";
            this.bsiModifiedBy.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bsiModifiedBy.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // bciPosted
            // 
            this.bciPosted.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bciPosted.Id = 33;
            this.bciPosted.ImageIndex = 9;
            this.bciPosted.ItemAppearance.Pressed.BackColor = System.Drawing.Color.Transparent;
            this.bciPosted.ItemAppearance.Pressed.Options.UseBackColor = true;
            this.bciPosted.Name = "bciPosted";
            this.bciPosted.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bciPosted.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.bciPosted_CheckedChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnRefresh.Caption = "Refresh";
            this.btnRefresh.Id = 28;
            this.btnRefresh.ImageIndex = 12;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // toolBar
            // 
            this.toolBar.BarName = "ToolBar";
            this.toolBar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
            this.toolBar.DockCol = 0;
            this.toolBar.DockRow = 0;
            this.toolBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.toolBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnNew, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSave, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCancel),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPrint, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExit, true)});
            this.toolBar.OptionsBar.AllowQuickCustomization = false;
            this.toolBar.OptionsBar.DisableClose = true;
            this.toolBar.OptionsBar.DisableCustomization = true;
            this.toolBar.OptionsBar.DrawDragBorder = false;
            this.toolBar.OptionsBar.RotateWhenVertical = false;
            this.toolBar.OptionsBar.UseWholeRow = true;
            this.toolBar.Text = "Toolbar";
            // 
            // btnNew
            // 
            this.btnNew.Caption = "&New";
            this.btnNew.Id = 5;
            this.btnNew.ImageIndex = 1;
            this.btnNew.Name = "btnNew";
            this.btnNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNew_ItemClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Caption = "&Edit";
            this.btnEdit.Id = 6;
            this.btnEdit.ImageIndex = 2;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEdit_ItemClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "&Delete";
            this.btnDelete.Id = 7;
            this.btnDelete.ImageIndex = 3;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
            // 
            // btnSave
            // 
            this.btnSave.Caption = "&Save";
            this.btnSave.Id = 8;
            this.btnSave.ImageIndex = 4;
            this.btnSave.Name = "btnSave";
            this.btnSave.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Caption = "&Cancel";
            this.btnCancel.Id = 9;
            this.btnCancel.ImageIndex = 5;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnCancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCancel_ItemClick);
            // 
            // btnPrint
            // 
            this.btnPrint.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.btnPrint.Caption = "&Print";
            this.btnPrint.DropDownControl = this.pmPrint;
            this.btnPrint.Id = 11;
            this.btnPrint.ImageIndex = 6;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnPrint.Tag = true;
            this.btnPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrint_ItemClick);
            // 
            // pmPrint
            // 
            this.pmPrint.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPreview)});
            this.pmPrint.Manager = this.barManager;
            this.pmPrint.Name = "pmPrint";
            // 
            // btnPreview
            // 
            this.btnPreview.Caption = "Preview";
            this.btnPreview.Id = 32;
            this.btnPreview.ImageIndex = 7;
            this.btnPreview.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.V));
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.True;
            this.btnPreview.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPreview_ItemClick);
            // 
            // btnExit
            // 
            this.btnExit.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnExit.Caption = "E&xit";
            this.btnExit.Id = 12;
            this.btnExit.ImageIndex = 0;
            this.btnExit.Name = "btnExit";
            this.btnExit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExit_ItemClick);
            // 
            // bdController
            // 
            this.bdController.LookAndFeel.SkinName = "Office 2010 Blue";
            this.bdController.PropertiesBar.AllowLinkLighting = false;
            this.bdController.PropertiesBar.DefaultGlyphSize = new System.Drawing.Size(16, 16);
            this.bdController.PropertiesBar.DefaultLargeGlyphSize = new System.Drawing.Size(32, 32);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(461, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 323);
            this.barDockControlBottom.Size = new System.Drawing.Size(461, 27);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 292);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(461, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 292);
            // 
            // btnPosted
            // 
            this.btnPosted.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnPosted.Caption = "Posted";
            this.btnPosted.Id = 15;
            this.btnPosted.ImageIndex = 9;
            this.btnPosted.Name = "btnPosted";
            this.btnPosted.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // barToggleSwitchItem1
            // 
            this.barToggleSwitchItem1.Caption = "barToggleSwitchItem1";
            this.barToggleSwitchItem1.Id = 34;
            this.barToggleSwitchItem1.Name = "barToggleSwitchItem1";
            // 
            // sccMain
            // 
            this.sccMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sccMain.Location = new System.Drawing.Point(0, 31);
            this.sccMain.Name = "sccMain";
            this.sccMain.Panel1.Controls.Add(this.lcSearch);
            this.sccMain.Panel1.MinSize = 120;
            this.sccMain.Panel1.Text = "Panel1";
            this.sccMain.Panel2.Controls.Add(this.lcMain);
            this.sccMain.Panel2.Text = "Panel2";
            this.sccMain.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2;
            this.sccMain.Size = new System.Drawing.Size(461, 292);
            this.sccMain.SplitterPosition = 120;
            this.sccMain.TabIndex = 69;
            // 
            // lcSearch
            // 
            this.lcSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcSearch.Images = this.imageCollection;
            this.lcSearch.Location = new System.Drawing.Point(0, 0);
            this.lcSearch.Name = "lcSearch";
            this.lcSearch.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(945, 154, 250, 350);
            this.lcSearch.Root = this.lcgSearch;
            this.lcSearch.Size = new System.Drawing.Size(0, 0);
            this.lcSearch.TabIndex = 54;
            // 
            // lcgSearch
            // 
            this.lcgSearch.CustomizationFormText = "lcgSearch";
            this.lcgSearch.GroupBordersVisible = false;
            this.lcgSearch.Location = new System.Drawing.Point(0, 0);
            this.lcgSearch.Name = "Root";
            this.lcgSearch.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcgSearch.Size = new System.Drawing.Size(1, 1);
            this.lcgSearch.TextVisible = false;
            // 
            // lcMain
            // 
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 0);
            this.lcMain.Name = "lcMain";
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1227, 170, 250, 350);
            this.lcMain.Root = this.lcgMain;
            this.lcMain.Size = new System.Drawing.Size(461, 292);
            this.lcMain.TabIndex = 0;
            // 
            // lcgMain
            // 
            this.lcgMain.CustomizationFormText = "lcgMain";
            this.lcgMain.GroupBordersVisible = false;
            this.lcgMain.Location = new System.Drawing.Point(0, 0);
            this.lcgMain.Name = "Root";
            this.lcgMain.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcgMain.Size = new System.Drawing.Size(461, 292);
            this.lcgMain.Text = "lcgMain";
            this.lcgMain.TextVisible = false;
            // 
            // efDataForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(461, 350);
            this.Controls.Add(this.sccMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.MaximumSize = new System.Drawing.Size(1000, 650);
            this.MinimumSize = new System.Drawing.Size(450, 300);
            this.Name = "efDataForm";
            this.Controls.SetChildIndex(this.barDockControlTop, 0);
            this.Controls.SetChildIndex(this.barDockControlBottom, 0);
            this.Controls.SetChildIndex(this.barDockControlRight, 0);
            this.Controls.SetChildIndex(this.barDockControlLeft, 0);
            this.Controls.SetChildIndex(this.sccMain, 0);
            this.Controls.SetChildIndex(this.lblFocus, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pmPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdController)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sccMain)).EndInit();
            this.sccMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraBars.Bar toolBar;
        public DevExpress.XtraBars.BarButtonItem btnNew;
        public DevExpress.XtraBars.BarButtonItem btnEdit;
        public DevExpress.XtraBars.BarButtonItem btnDelete;
        public DevExpress.XtraBars.BarButtonItem btnSave;
        public DevExpress.XtraBars.BarButtonItem btnCancel;
        public DevExpress.XtraBars.BarButtonItem btnPrint;
        public DevExpress.XtraBars.BarButtonItem btnExit;
        public DevExpress.XtraBars.Bar statusBar;
        public DevExpress.XtraBars.BarDockControl barDockControlTop;
        public DevExpress.XtraBars.BarDockControl barDockControlBottom;
        public DevExpress.XtraBars.BarDockControl barDockControlLeft;
        public DevExpress.XtraBars.BarDockControl barDockControlRight;
        public DevExpress.XtraBars.BarManager barManager;
        public System.Windows.Forms.BindingSource bsMaster;
        public DevExpress.XtraBars.BarAndDockingController bdController;
        public DevExpress.XtraEditors.SplitContainerControl sccMain;
        public efLayoutControl lcSearch;
        public DevExpress.XtraLayout.LayoutControlGroup lcgSearch;
        public efLayoutControl lcMain;
        public DevExpress.XtraLayout.LayoutControlGroup lcgMain;
        private DevExpress.XtraBars.PopupMenu pmPrint;
        private DevExpress.XtraBars.BarButtonItem btnPreview;
        protected DevExpress.Utils.ImageCollection imageCollection;
        public DevExpress.XtraBars.BarStaticItem bsiCreatedBy;
        public DevExpress.XtraBars.BarButtonItem btnPosted;
        public DevExpress.XtraBars.BarStaticItem bsiModifiedBy;
        public DevExpress.XtraBars.BarButtonItem btnRefresh;
        public DevExpress.XtraBars.BarCheckItem bciPosted;
        private DevExpress.XtraBars.BarToggleSwitchItem barToggleSwitchItem1;
        protected internal System.Windows.Forms.BindingSource bsSearch;
    }
}