namespace efControls
{
    partial class bfPDF
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bfPDF));
            this.fp = new DevExpress.Utils.FlyoutPanel();
            this.fpc = new DevExpress.Utils.FlyoutPanelControl();
            this.pdfViewer = new DevExpress.XtraPdfViewer.PdfViewer();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.pdfFileSaveAsBarItem1 = new DevExpress.XtraPdfViewer.Bars.PdfFileSaveAsBarItem();
            this.pdfFilePrintBarItem1 = new DevExpress.XtraPdfViewer.Bars.PdfFilePrintBarItem();
            this.pdfPreviousPageBarItem1 = new DevExpress.XtraPdfViewer.Bars.PdfPreviousPageBarItem();
            this.pdfNextPageBarItem1 = new DevExpress.XtraPdfViewer.Bars.PdfNextPageBarItem();
            this.pdfFindTextBarItem1 = new DevExpress.XtraPdfViewer.Bars.PdfFindTextBarItem();
            this.pdfZoomOutBarItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoomOutBarItem();
            this.pdfZoomInBarItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoomInBarItem();
            this.pdfExactZoomListBarSubItem1 = new DevExpress.XtraPdfViewer.Bars.PdfExactZoomListBarSubItem();
            this.pdfZoom10CheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoom10CheckItem();
            this.pdfZoom25CheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoom25CheckItem();
            this.pdfZoom50CheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoom50CheckItem();
            this.pdfZoom75CheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoom75CheckItem();
            this.pdfZoom100CheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoom100CheckItem();
            this.pdfZoom125CheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoom125CheckItem();
            this.pdfZoom150CheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoom150CheckItem();
            this.pdfZoom200CheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoom200CheckItem();
            this.pdfZoom400CheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoom400CheckItem();
            this.pdfZoom500CheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoom500CheckItem();
            this.pdfSetActualSizeZoomModeCheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfSetActualSizeZoomModeCheckItem();
            this.pdfSetPageLevelZoomModeCheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfSetPageLevelZoomModeCheckItem();
            this.pdfSetFitWidthZoomModeCheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfSetFitWidthZoomModeCheckItem();
            this.pdfSetFitVisibleZoomModeCheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfSetFitVisibleZoomModeCheckItem();
            this.pdfExportFormDataBarItem1 = new DevExpress.XtraPdfViewer.Bars.PdfExportFormDataBarItem();
            this.pdfImportFormDataBarItem1 = new DevExpress.XtraPdfViewer.Bars.PdfImportFormDataBarItem();
            this.bbiEmail = new DevExpress.XtraBars.BarButtonItem();
            this.pdfRibbonPage1 = new DevExpress.XtraPdfViewer.Bars.PdfRibbonPage();
            this.pdfFileRibbonPageGroup1 = new DevExpress.XtraPdfViewer.Bars.PdfFileRibbonPageGroup();
            this.pdfNavigationRibbonPageGroup1 = new DevExpress.XtraPdfViewer.Bars.PdfNavigationRibbonPageGroup();
            this.pdfZoomRibbonPageGroup1 = new DevExpress.XtraPdfViewer.Bars.PdfZoomRibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pdfBarController1 = new DevExpress.XtraPdfViewer.Bars.PdfBarController();
            ((System.ComponentModel.ISupportInitialize)(this.fp)).BeginInit();
            this.fp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fpc)).BeginInit();
            this.fpc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdfBarController1)).BeginInit();
            this.SuspendLayout();
            // 
            // fp
            // 
            this.fp.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.fp.Appearance.Options.UseBackColor = true;
            this.fp.Controls.Add(this.fpc);
            this.fp.Location = new System.Drawing.Point(6, 4);
            this.fp.Name = "fp";
            this.fp.Options.AnimationType = DevExpress.Utils.Win.PopupToolWindowAnimation.Fade;
            this.fp.OptionsBeakPanel.BackColor = System.Drawing.SystemColors.Control;
            this.fp.OptionsButtonPanel.AppearanceButton.Normal.BackColor = System.Drawing.Color.Transparent;
            this.fp.OptionsButtonPanel.AppearanceButton.Normal.Options.UseBackColor = true;
            this.fp.Size = new System.Drawing.Size(770, 480);
            this.fp.TabIndex = 3;
            // 
            // fpc
            // 
            this.fpc.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.fpc.Appearance.Options.UseBackColor = true;
            this.fpc.AutoSize = true;
            this.fpc.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.fpc.Controls.Add(this.pdfViewer);
            this.fpc.Controls.Add(this.ribbonControl1);
            this.fpc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpc.FlyoutPanel = this.fp;
            this.fpc.Location = new System.Drawing.Point(0, 0);
            this.fpc.Name = "fpc";
            this.fpc.Padding = new System.Windows.Forms.Padding(5);
            this.fpc.Size = new System.Drawing.Size(770, 480);
            this.fpc.TabIndex = 0;
            // 
            // pdfViewer
            // 
            this.pdfViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfViewer.HandTool = true;
            this.pdfViewer.Location = new System.Drawing.Point(5, 35);
            this.pdfViewer.Name = "pdfViewer";
            this.pdfViewer.NavigationPaneInitialVisibility = DevExpress.XtraPdfViewer.PdfNavigationPaneVisibility.Hidden;
            this.pdfViewer.Size = new System.Drawing.Size(760, 440);
            this.pdfViewer.TabIndex = 0;
            this.pdfViewer.ZoomMode = DevExpress.XtraPdfViewer.PdfZoomMode.FitToVisible;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.pdfFileSaveAsBarItem1,
            this.pdfFilePrintBarItem1,
            this.pdfPreviousPageBarItem1,
            this.pdfNextPageBarItem1,
            this.pdfFindTextBarItem1,
            this.pdfZoomOutBarItem1,
            this.pdfZoomInBarItem1,
            this.pdfExactZoomListBarSubItem1,
            this.pdfZoom10CheckItem1,
            this.pdfZoom25CheckItem1,
            this.pdfZoom50CheckItem1,
            this.pdfZoom75CheckItem1,
            this.pdfZoom100CheckItem1,
            this.pdfZoom125CheckItem1,
            this.pdfZoom150CheckItem1,
            this.pdfZoom200CheckItem1,
            this.pdfZoom400CheckItem1,
            this.pdfZoom500CheckItem1,
            this.pdfSetActualSizeZoomModeCheckItem1,
            this.pdfSetPageLevelZoomModeCheckItem1,
            this.pdfSetFitWidthZoomModeCheckItem1,
            this.pdfSetFitVisibleZoomModeCheckItem1,
            this.pdfExportFormDataBarItem1,
            this.pdfImportFormDataBarItem1,
            this.bbiEmail});
            this.ribbonControl1.Location = new System.Drawing.Point(5, 5);
            this.ribbonControl1.MaxItemId = 28;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.pdfRibbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(760, 30);
            // 
            // pdfFileSaveAsBarItem1
            // 
            this.pdfFileSaveAsBarItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("pdfFileSaveAsBarItem1.Glyph")));
            this.pdfFileSaveAsBarItem1.Id = 2;
            this.pdfFileSaveAsBarItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
            this.pdfFileSaveAsBarItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("pdfFileSaveAsBarItem1.LargeGlyph")));
            this.pdfFileSaveAsBarItem1.Name = "pdfFileSaveAsBarItem1";
            // 
            // pdfFilePrintBarItem1
            // 
            this.pdfFilePrintBarItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("pdfFilePrintBarItem1.Glyph")));
            this.pdfFilePrintBarItem1.Id = 3;
            this.pdfFilePrintBarItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P));
            this.pdfFilePrintBarItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("pdfFilePrintBarItem1.LargeGlyph")));
            this.pdfFilePrintBarItem1.Name = "pdfFilePrintBarItem1";
            // 
            // pdfPreviousPageBarItem1
            // 
            this.pdfPreviousPageBarItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("pdfPreviousPageBarItem1.Glyph")));
            this.pdfPreviousPageBarItem1.Id = 4;
            this.pdfPreviousPageBarItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("pdfPreviousPageBarItem1.LargeGlyph")));
            this.pdfPreviousPageBarItem1.Name = "pdfPreviousPageBarItem1";
            // 
            // pdfNextPageBarItem1
            // 
            this.pdfNextPageBarItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("pdfNextPageBarItem1.Glyph")));
            this.pdfNextPageBarItem1.Id = 5;
            this.pdfNextPageBarItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("pdfNextPageBarItem1.LargeGlyph")));
            this.pdfNextPageBarItem1.Name = "pdfNextPageBarItem1";
            // 
            // pdfFindTextBarItem1
            // 
            this.pdfFindTextBarItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("pdfFindTextBarItem1.Glyph")));
            this.pdfFindTextBarItem1.Id = 6;
            this.pdfFindTextBarItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F));
            this.pdfFindTextBarItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("pdfFindTextBarItem1.LargeGlyph")));
            this.pdfFindTextBarItem1.Name = "pdfFindTextBarItem1";
            // 
            // pdfZoomOutBarItem1
            // 
            this.pdfZoomOutBarItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("pdfZoomOutBarItem1.Glyph")));
            this.pdfZoomOutBarItem1.Id = 7;
            this.pdfZoomOutBarItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("pdfZoomOutBarItem1.LargeGlyph")));
            this.pdfZoomOutBarItem1.Name = "pdfZoomOutBarItem1";
            // 
            // pdfZoomInBarItem1
            // 
            this.pdfZoomInBarItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("pdfZoomInBarItem1.Glyph")));
            this.pdfZoomInBarItem1.Id = 8;
            this.pdfZoomInBarItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("pdfZoomInBarItem1.LargeGlyph")));
            this.pdfZoomInBarItem1.Name = "pdfZoomInBarItem1";
            // 
            // pdfExactZoomListBarSubItem1
            // 
            this.pdfExactZoomListBarSubItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("pdfExactZoomListBarSubItem1.Glyph")));
            this.pdfExactZoomListBarSubItem1.Id = 9;
            this.pdfExactZoomListBarSubItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("pdfExactZoomListBarSubItem1.LargeGlyph")));
            this.pdfExactZoomListBarSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom10CheckItem1, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom25CheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom50CheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom75CheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom100CheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom125CheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom150CheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom200CheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom400CheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom500CheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfSetActualSizeZoomModeCheckItem1, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfSetPageLevelZoomModeCheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfSetFitWidthZoomModeCheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfSetFitVisibleZoomModeCheckItem1)});
            this.pdfExactZoomListBarSubItem1.Name = "pdfExactZoomListBarSubItem1";
            this.pdfExactZoomListBarSubItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
            // 
            // pdfZoom10CheckItem1
            // 
            this.pdfZoom10CheckItem1.Id = 10;
            this.pdfZoom10CheckItem1.Name = "pdfZoom10CheckItem1";
            // 
            // pdfZoom25CheckItem1
            // 
            this.pdfZoom25CheckItem1.Id = 11;
            this.pdfZoom25CheckItem1.Name = "pdfZoom25CheckItem1";
            // 
            // pdfZoom50CheckItem1
            // 
            this.pdfZoom50CheckItem1.Id = 12;
            this.pdfZoom50CheckItem1.Name = "pdfZoom50CheckItem1";
            // 
            // pdfZoom75CheckItem1
            // 
            this.pdfZoom75CheckItem1.Id = 13;
            this.pdfZoom75CheckItem1.Name = "pdfZoom75CheckItem1";
            // 
            // pdfZoom100CheckItem1
            // 
            this.pdfZoom100CheckItem1.Id = 14;
            this.pdfZoom100CheckItem1.Name = "pdfZoom100CheckItem1";
            // 
            // pdfZoom125CheckItem1
            // 
            this.pdfZoom125CheckItem1.Id = 15;
            this.pdfZoom125CheckItem1.Name = "pdfZoom125CheckItem1";
            // 
            // pdfZoom150CheckItem1
            // 
            this.pdfZoom150CheckItem1.Id = 16;
            this.pdfZoom150CheckItem1.Name = "pdfZoom150CheckItem1";
            // 
            // pdfZoom200CheckItem1
            // 
            this.pdfZoom200CheckItem1.Id = 17;
            this.pdfZoom200CheckItem1.Name = "pdfZoom200CheckItem1";
            // 
            // pdfZoom400CheckItem1
            // 
            this.pdfZoom400CheckItem1.Id = 18;
            this.pdfZoom400CheckItem1.Name = "pdfZoom400CheckItem1";
            // 
            // pdfZoom500CheckItem1
            // 
            this.pdfZoom500CheckItem1.Id = 19;
            this.pdfZoom500CheckItem1.Name = "pdfZoom500CheckItem1";
            // 
            // pdfSetActualSizeZoomModeCheckItem1
            // 
            this.pdfSetActualSizeZoomModeCheckItem1.Id = 20;
            this.pdfSetActualSizeZoomModeCheckItem1.Name = "pdfSetActualSizeZoomModeCheckItem1";
            // 
            // pdfSetPageLevelZoomModeCheckItem1
            // 
            this.pdfSetPageLevelZoomModeCheckItem1.Id = 21;
            this.pdfSetPageLevelZoomModeCheckItem1.Name = "pdfSetPageLevelZoomModeCheckItem1";
            // 
            // pdfSetFitWidthZoomModeCheckItem1
            // 
            this.pdfSetFitWidthZoomModeCheckItem1.Id = 22;
            this.pdfSetFitWidthZoomModeCheckItem1.Name = "pdfSetFitWidthZoomModeCheckItem1";
            // 
            // pdfSetFitVisibleZoomModeCheckItem1
            // 
            this.pdfSetFitVisibleZoomModeCheckItem1.Id = 23;
            this.pdfSetFitVisibleZoomModeCheckItem1.Name = "pdfSetFitVisibleZoomModeCheckItem1";
            // 
            // pdfExportFormDataBarItem1
            // 
            this.pdfExportFormDataBarItem1.Id = 24;
            this.pdfExportFormDataBarItem1.Name = "pdfExportFormDataBarItem1";
            // 
            // pdfImportFormDataBarItem1
            // 
            this.pdfImportFormDataBarItem1.Id = 25;
            this.pdfImportFormDataBarItem1.Name = "pdfImportFormDataBarItem1";
            // 
            // bbiEmail
            // 
            this.bbiEmail.Caption = "Email";
            this.bbiEmail.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiEmail.Glyph")));
            this.bbiEmail.Id = 27;
            this.bbiEmail.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiEmail.LargeGlyph")));
            this.bbiEmail.Name = "bbiEmail";
            this.bbiEmail.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEmail_ItemClick);
            // 
            // pdfRibbonPage1
            // 
            this.pdfRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.pdfFileRibbonPageGroup1,
            this.pdfNavigationRibbonPageGroup1,
            this.pdfZoomRibbonPageGroup1,
            this.ribbonPageGroup1});
            this.pdfRibbonPage1.Name = "pdfRibbonPage1";
            // 
            // pdfFileRibbonPageGroup1
            // 
            this.pdfFileRibbonPageGroup1.ItemLinks.Add(this.pdfFileSaveAsBarItem1);
            this.pdfFileRibbonPageGroup1.ItemLinks.Add(this.pdfFilePrintBarItem1);
            this.pdfFileRibbonPageGroup1.Name = "pdfFileRibbonPageGroup1";
            // 
            // pdfNavigationRibbonPageGroup1
            // 
            this.pdfNavigationRibbonPageGroup1.ItemLinks.Add(this.pdfPreviousPageBarItem1);
            this.pdfNavigationRibbonPageGroup1.ItemLinks.Add(this.pdfNextPageBarItem1);
            this.pdfNavigationRibbonPageGroup1.ItemLinks.Add(this.pdfFindTextBarItem1);
            this.pdfNavigationRibbonPageGroup1.Name = "pdfNavigationRibbonPageGroup1";
            // 
            // pdfZoomRibbonPageGroup1
            // 
            this.pdfZoomRibbonPageGroup1.ItemLinks.Add(this.pdfZoomOutBarItem1);
            this.pdfZoomRibbonPageGroup1.ItemLinks.Add(this.pdfZoomInBarItem1);
            this.pdfZoomRibbonPageGroup1.ItemLinks.Add(this.pdfExactZoomListBarSubItem1);
            this.pdfZoomRibbonPageGroup1.Name = "pdfZoomRibbonPageGroup1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiEmail);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // pdfBarController1
            // 
            this.pdfBarController1.BarItems.Add(this.pdfFileSaveAsBarItem1);
            this.pdfBarController1.BarItems.Add(this.pdfFilePrintBarItem1);
            this.pdfBarController1.BarItems.Add(this.pdfPreviousPageBarItem1);
            this.pdfBarController1.BarItems.Add(this.pdfNextPageBarItem1);
            this.pdfBarController1.BarItems.Add(this.pdfFindTextBarItem1);
            this.pdfBarController1.BarItems.Add(this.pdfZoomOutBarItem1);
            this.pdfBarController1.BarItems.Add(this.pdfZoomInBarItem1);
            this.pdfBarController1.BarItems.Add(this.pdfExactZoomListBarSubItem1);
            this.pdfBarController1.BarItems.Add(this.pdfZoom10CheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfZoom25CheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfZoom50CheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfZoom75CheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfZoom100CheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfZoom125CheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfZoom150CheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfZoom200CheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfZoom400CheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfZoom500CheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfSetActualSizeZoomModeCheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfSetPageLevelZoomModeCheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfSetFitWidthZoomModeCheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfSetFitVisibleZoomModeCheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfExportFormDataBarItem1);
            this.pdfBarController1.BarItems.Add(this.pdfImportFormDataBarItem1);
            this.pdfBarController1.Control = this.pdfViewer;
            // 
            // bfPDF
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fp);
            this.Name = "bfPDF";
            this.Size = new System.Drawing.Size(779, 488);
            ((System.ComponentModel.ISupportInitialize)(this.fp)).EndInit();
            this.fp.ResumeLayout(false);
            this.fp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fpc)).EndInit();
            this.fpc.ResumeLayout(false);
            this.fpc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdfBarController1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.Utils.FlyoutPanel fp;
        public DevExpress.Utils.FlyoutPanelControl fpc;
        public DevExpress.XtraPdfViewer.PdfViewer pdfViewer;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraPdfViewer.Bars.PdfFileSaveAsBarItem pdfFileSaveAsBarItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfFilePrintBarItem pdfFilePrintBarItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfPreviousPageBarItem pdfPreviousPageBarItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfNextPageBarItem pdfNextPageBarItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfFindTextBarItem pdfFindTextBarItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfZoomOutBarItem pdfZoomOutBarItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfZoomInBarItem pdfZoomInBarItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfExactZoomListBarSubItem pdfExactZoomListBarSubItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfZoom10CheckItem pdfZoom10CheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfZoom25CheckItem pdfZoom25CheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfZoom50CheckItem pdfZoom50CheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfZoom75CheckItem pdfZoom75CheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfZoom100CheckItem pdfZoom100CheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfZoom125CheckItem pdfZoom125CheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfZoom150CheckItem pdfZoom150CheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfZoom200CheckItem pdfZoom200CheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfZoom400CheckItem pdfZoom400CheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfZoom500CheckItem pdfZoom500CheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfSetActualSizeZoomModeCheckItem pdfSetActualSizeZoomModeCheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfSetPageLevelZoomModeCheckItem pdfSetPageLevelZoomModeCheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfSetFitWidthZoomModeCheckItem pdfSetFitWidthZoomModeCheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfSetFitVisibleZoomModeCheckItem pdfSetFitVisibleZoomModeCheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfExportFormDataBarItem pdfExportFormDataBarItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfImportFormDataBarItem pdfImportFormDataBarItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfRibbonPage pdfRibbonPage1;
        private DevExpress.XtraPdfViewer.Bars.PdfFileRibbonPageGroup pdfFileRibbonPageGroup1;
        private DevExpress.XtraPdfViewer.Bars.PdfNavigationRibbonPageGroup pdfNavigationRibbonPageGroup1;
        private DevExpress.XtraPdfViewer.Bars.PdfZoomRibbonPageGroup pdfZoomRibbonPageGroup1;
        private DevExpress.XtraPdfViewer.Bars.PdfBarController pdfBarController1;
        private DevExpress.XtraBars.BarButtonItem bbiEmail;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
    }
}
