namespace efControls
{
    partial class efMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(efMainForm));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.repositoryItemMarqueeProgressBar2 = new DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ApplicationMenu = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.bbiThemes = new DevExpress.XtraBars.BarButtonItem();
            this.btnPassword = new DevExpress.XtraBars.BarButtonItem();
            this.bbiLogout = new DevExpress.XtraBars.BarButtonItem();
            this.bbiExit = new DevExpress.XtraBars.BarButtonItem();
            this.barAndDockingController = new DevExpress.XtraBars.BarAndDockingController(this.components);
            this.ribbonImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.barLoggedInAs = new DevExpress.XtraBars.BarStaticItem();
            this.rgbiSkins = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.btnPreferencesSave = new DevExpress.XtraBars.BarButtonItem();
            this.barCompanyAndYear = new DevExpress.XtraBars.BarStaticItem();
            this.mdiFormList = new DevExpress.XtraBars.BarMdiChildrenListItem();
            this.bbiInfo = new DevExpress.XtraBars.BarButtonItem();
            this.imgMenuCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.riProgressBar = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            this.ribeInfo = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.AlertControl = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.imgAlert = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMarqueeProgressBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApplicationMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMenuCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riProgressBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribeInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAlert)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemMarqueeProgressBar2
            // 
            this.repositoryItemMarqueeProgressBar2.LookAndFeel.SkinName = "Blue";
            this.repositoryItemMarqueeProgressBar2.MarqueeAnimationSpeed = 80;
            this.repositoryItemMarqueeProgressBar2.Name = "repositoryItemMarqueeProgressBar2";
            this.repositoryItemMarqueeProgressBar2.ProgressAnimationMode = DevExpress.Utils.Drawing.ProgressAnimationMode.Cycle;
            // 
            // ribbon
            // 
            this.ribbon.ApplicationButtonDropDownControl = this.ApplicationMenu;
            this.ribbon.ApplicationButtonText = null;
            this.ribbon.AutoSizeItems = true;
            this.ribbon.Controller = this.barAndDockingController;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Images = this.ribbonImageCollection;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barLoggedInAs,
            this.rgbiSkins,
            this.btnPreferencesSave,
            this.barCompanyAndYear,
            this.mdiFormList,
            this.bbiThemes,
            this.bbiLogout,
            this.bbiExit,
            this.btnPassword,
            this.bbiInfo});
            this.ribbon.LargeImages = this.imgMenuCollection;
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 1;
            this.ribbon.Name = "ribbon";
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riProgressBar,
            this.ribeInfo});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbon.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(1014, 49);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // ApplicationMenu
            // 
            this.ApplicationMenu.ItemLinks.Add(this.bbiThemes);
            this.ApplicationMenu.ItemLinks.Add(this.btnPassword, true);
            this.ApplicationMenu.ItemLinks.Add(this.bbiLogout, true);
            this.ApplicationMenu.ItemLinks.Add(this.bbiExit);
            this.ApplicationMenu.Name = "ApplicationMenu";
            this.ApplicationMenu.Ribbon = this.ribbon;
            // 
            // bbiThemes
            // 
            this.bbiThemes.Caption = "Select Themes";
            this.bbiThemes.Id = 119;
            this.bbiThemes.LargeImageIndex = 4;
            this.bbiThemes.Name = "bbiThemes";
            this.bbiThemes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiThemes_ItemClick);
            // 
            // btnPassword
            // 
            this.btnPassword.Caption = "Change Password";
            this.btnPassword.Id = 122;
            this.btnPassword.LargeImageIndex = 3;
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPassword_ItemClick);
            // 
            // bbiLogout
            // 
            this.bbiLogout.Caption = "Logout";
            this.bbiLogout.Id = 120;
            this.bbiLogout.LargeImageIndex = 6;
            this.bbiLogout.Name = "bbiLogout";
            this.bbiLogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiLogout_ItemClick);
            // 
            // bbiExit
            // 
            this.bbiExit.Caption = "Exit";
            this.bbiExit.Id = 121;
            this.bbiExit.LargeImageIndex = 7;
            this.bbiExit.Name = "bbiExit";
            this.bbiExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiExit_ItemClick);
            // 
            // barAndDockingController
            // 
            this.barAndDockingController.PropertiesBar.AllowLinkLighting = false;
            this.barAndDockingController.PropertiesBar.DefaultGlyphSize = new System.Drawing.Size(16, 16);
            this.barAndDockingController.PropertiesBar.DefaultLargeGlyphSize = new System.Drawing.Size(32, 32);
            this.barAndDockingController.PropertiesBar.LargeIcons = true;
            // 
            // ribbonImageCollection
            // 
            this.ribbonImageCollection.ImageSize = new System.Drawing.Size(32, 32);
            this.ribbonImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ribbonImageCollection.ImageStream")));
            // 
            // barLoggedInAs
            // 
            this.barLoggedInAs.Id = 53;
            this.barLoggedInAs.Name = "barLoggedInAs";
            this.barLoggedInAs.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // rgbiSkins
            // 
            this.rgbiSkins.Caption = "ribbonGalleryBarItem";
            this.rgbiSkins.Id = 60;
            this.rgbiSkins.Name = "rgbiSkins";
            // 
            // btnPreferencesSave
            // 
            this.btnPreferencesSave.Caption = "Save Preferences";
            this.btnPreferencesSave.Id = 61;
            this.btnPreferencesSave.Name = "btnPreferencesSave";
            this.btnPreferencesSave.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barCompanyAndYear
            // 
            this.barCompanyAndYear.Id = 84;
            this.barCompanyAndYear.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.barCompanyAndYear.ItemAppearance.Normal.Options.UseFont = true;
            this.barCompanyAndYear.Name = "barCompanyAndYear";
            this.barCompanyAndYear.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // mdiFormList
            // 
            this.mdiFormList.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.mdiFormList.Caption = "Running Forms";
            this.mdiFormList.Id = 115;
            this.mdiFormList.Name = "mdiFormList";
            // 
            // bbiInfo
            // 
            this.bbiInfo.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bbiInfo.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiInfo.Glyph")));
            this.bbiInfo.Id = 124;
            this.bbiInfo.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiInfo.LargeGlyph")));
            this.bbiInfo.Name = "bbiInfo";
            // 
            // imgMenuCollection
            // 
            this.imgMenuCollection.ImageSize = new System.Drawing.Size(32, 32);
            this.imgMenuCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgMenuCollection.ImageStream")));
            this.imgMenuCollection.Images.SetKeyName(0, "Background.png");
            this.imgMenuCollection.Images.SetKeyName(1, "company.png");
            this.imgMenuCollection.Images.SetKeyName(2, "form.png");
            this.imgMenuCollection.Images.SetKeyName(3, "PasswordChange.png");
            this.imgMenuCollection.Images.SetKeyName(4, "Themes.png");
            this.imgMenuCollection.Images.SetKeyName(5, "Users.png");
            this.imgMenuCollection.Images.SetKeyName(6, "Logout.png");
            this.imgMenuCollection.Images.SetKeyName(7, "Exit.png");
            // 
            // riProgressBar
            // 
            this.riProgressBar.Name = "riProgressBar";
            this.riProgressBar.ShowTitle = true;
            this.riProgressBar.Step = 1;
            // 
            // ribeInfo
            // 
            this.ribeInfo.AutoHeight = false;
            this.ribeInfo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 20, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("ribeInfo.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.ribeInfo.Name = "ribeInfo";
            this.ribeInfo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.barCompanyAndYear);
            this.ribbonStatusBar.ItemLinks.Add(this.barLoggedInAs, true);
            this.ribbonStatusBar.ItemLinks.Add(this.mdiFormList);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 736);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1014, 31);
            // 
            // AlertControl
            // 
            this.AlertControl.AutoFormDelay = 10000;
            this.AlertControl.LookAndFeel.UseDefaultLookAndFeel = false;
            // 
            // imgAlert
            // 
            this.imgAlert.ImageSize = new System.Drawing.Size(32, 32);
            this.imgAlert.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgAlert.ImageStream")));
            this.imgAlert.Images.SetKeyName(0, "None");
            this.imgAlert.Images.SetKeyName(1, "Critical");
            this.imgAlert.Images.SetKeyName(2, "Warning");
            this.imgAlert.Images.SetKeyName(3, "Info");
            this.imgAlert.Images.SetKeyName(4, "Help");
            // 
            // efMainForm
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1014, 767);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "efMainForm";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Main Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.efMainForm_FormClosing);
            this.ResizeEnd += new System.EventHandler(this.efMainForm_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMarqueeProgressBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApplicationMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMenuCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riProgressBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribeInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAlert)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        public DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        public DevExpress.XtraBars.BarAndDockingController barAndDockingController;
        private DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar repositoryItemMarqueeProgressBar2;
        public DevExpress.XtraBars.Alerter.AlertControl AlertControl;
        public DevExpress.XtraBars.BarStaticItem barLoggedInAs;
        public DevExpress.XtraBars.RibbonGalleryBarItem rgbiSkins;
        public DevExpress.XtraBars.BarButtonItem btnPreferencesSave;
        public DevExpress.XtraBars.BarStaticItem barCompanyAndYear;
        private DevExpress.XtraBars.BarMdiChildrenListItem mdiFormList;
        private DevExpress.XtraBars.BarButtonItem bbiThemes;
        private DevExpress.XtraBars.BarButtonItem bbiLogout;
        private DevExpress.XtraBars.BarButtonItem bbiExit;
        public DevExpress.XtraBars.Ribbon.ApplicationMenu ApplicationMenu;
        private DevExpress.XtraBars.BarButtonItem btnPassword;
        protected DevExpress.Utils.ImageCollection ribbonImageCollection;
        public DevExpress.XtraEditors.Repository.RepositoryItemProgressBar riProgressBar;
        protected DevExpress.Utils.ImageCollection imgMenuCollection;
        public DevExpress.XtraBars.BarButtonItem bbiInfo;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ribeInfo;
        protected internal DevExpress.Utils.ImageCollection imgAlert;
    }
}