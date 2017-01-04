namespace efControls
{
    partial class ucPrintControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPrintControl));
            this.bmPrint = new DevExpress.XtraBars.BarManager(this.components);
            this.statusBar = new DevExpress.XtraBars.Bar();
            this.ucBtnPrint = new DevExpress.XtraBars.BarButtonItem();
            this.ucBtnPreview = new DevExpress.XtraBars.BarButtonItem();
            this.ucBtnClose = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.icPrint = new DevExpress.Utils.ImageCollection(this.components);
            this.pPrint = new efControls.efPanel();
            this.lcPrint = new efControls.efLayoutControl();
            this.pePrinter = new DevExpress.XtraEditors.PictureEdit();
            this.lcgPrint = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciImage = new efControls.lci();
            ((System.ComponentModel.ISupportInitialize)(this.bmPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPrint)).BeginInit();
            this.pPrint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcPrint)).BeginInit();
            this.lcPrint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pePrinter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciImage)).BeginInit();
            this.SuspendLayout();
            // 
            // bmPrint
            // 
            this.bmPrint.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.statusBar});
            this.bmPrint.DockControls.Add(this.barDockControlTop);
            this.bmPrint.DockControls.Add(this.barDockControlBottom);
            this.bmPrint.DockControls.Add(this.barDockControlLeft);
            this.bmPrint.DockControls.Add(this.barDockControlRight);
            this.bmPrint.Form = this;
            this.bmPrint.Images = this.icPrint;
            this.bmPrint.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ucBtnPrint,
            this.ucBtnPreview,
            this.ucBtnClose});
            this.bmPrint.LargeImages = this.icPrint;
            this.bmPrint.MaxItemId = 6;
            this.bmPrint.StatusBar = this.statusBar;
            // 
            // statusBar
            // 
            this.statusBar.BarName = "Status bar";
            this.statusBar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.statusBar.DockCol = 0;
            this.statusBar.DockRow = 0;
            this.statusBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.statusBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.ucBtnPrint),
            new DevExpress.XtraBars.LinkPersistInfo(this.ucBtnPreview, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.ucBtnClose, true)});
            this.statusBar.OptionsBar.AllowQuickCustomization = false;
            this.statusBar.OptionsBar.DisableClose = true;
            this.statusBar.OptionsBar.DisableCustomization = true;
            this.statusBar.OptionsBar.DrawDragBorder = false;
            this.statusBar.OptionsBar.UseWholeRow = true;
            this.statusBar.Text = "Status bar";
            // 
            // ucBtnPrint
            // 
            this.ucBtnPrint.Caption = "Print";
            this.ucBtnPrint.Id = 3;
            this.ucBtnPrint.ImageIndex = 2;
            this.ucBtnPrint.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.ucBtnPrint.ItemAppearance.Normal.Options.UseFont = true;
            this.ucBtnPrint.Name = "ucBtnPrint";
            this.ucBtnPrint.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.ucBtnPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ucBtnPrint_ItemClick);
            // 
            // ucBtnPreview
            // 
            this.ucBtnPreview.Caption = "Preview";
            this.ucBtnPreview.Id = 4;
            this.ucBtnPreview.ImageIndex = 1;
            this.ucBtnPreview.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.ucBtnPreview.ItemAppearance.Normal.Options.UseFont = true;
            this.ucBtnPreview.Name = "ucBtnPreview";
            this.ucBtnPreview.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.ucBtnPreview.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ucBtnPreview_ItemClick);
            // 
            // ucBtnClose
            // 
            this.ucBtnClose.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.ucBtnClose.Caption = "Close";
            this.ucBtnClose.Id = 5;
            this.ucBtnClose.ImageIndex = 0;
            this.ucBtnClose.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.ucBtnClose.ItemAppearance.Normal.Options.UseFont = true;
            this.ucBtnClose.Name = "ucBtnClose";
            this.ucBtnClose.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.ucBtnClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ucBtnClose_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(2, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(244, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(2, 66);
            this.barDockControlBottom.Size = new System.Drawing.Size(244, 27);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(2, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 64);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(246, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 64);
            // 
            // icPrint
            // 
            this.icPrint.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("icPrint.ImageStream")));
            this.icPrint.Images.SetKeyName(0, "close16.png");
            this.icPrint.Images.SetKeyName(1, "kappfinder.png");
            this.icPrint.Images.SetKeyName(2, "print.png");
            // 
            // pPrint
            // 
            this.pPrint.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pPrint.Appearance.Options.UseBackColor = true;
            this.pPrint.Controls.Add(this.lcPrint);
            this.pPrint.DefaultState = efControls.Enums.ControlState.AlwaysDisabled;
            this.pPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPrint.HighLighted = false;
            this.pPrint.Location = new System.Drawing.Point(2, 2);
            this.pPrint.Name = "pPrint";
            this.pPrint.Size = new System.Drawing.Size(244, 64);
            this.pPrint.TabIndex = 11;
            // 
            // lcPrint
            // 
            this.lcPrint.Controls.Add(this.pePrinter);
            this.lcPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcPrint.Location = new System.Drawing.Point(2, 2);
            this.lcPrint.Name = "lcPrint";
            this.lcPrint.Root = this.lcgPrint;
            this.lcPrint.Size = new System.Drawing.Size(240, 60);
            this.lcPrint.TabIndex = 13;
            this.lcPrint.Text = "efLayoutControl1";
            // 
            // pePrinter
            // 
            this.pePrinter.EditValue = ((object)(resources.GetObject("pePrinter.EditValue")));
            this.pePrinter.Location = new System.Drawing.Point(4, 4);
            this.pePrinter.MenuManager = this.bmPrint;
            this.pePrinter.Name = "pePrinter";
            this.pePrinter.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pePrinter.Properties.Appearance.Options.UseBackColor = true;
            this.pePrinter.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pePrinter.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pePrinter.Size = new System.Drawing.Size(232, 52);
            this.pePrinter.StyleController = this.lcPrint;
            this.pePrinter.TabIndex = 21;
            // 
            // lcgPrint
            // 
            this.lcgPrint.CustomizationFormText = "lcgPrint";
            this.lcgPrint.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgPrint.GroupBordersVisible = false;
            this.lcgPrint.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciImage});
            this.lcgPrint.Location = new System.Drawing.Point(0, 0);
            this.lcgPrint.Name = "lcgPrint";
            this.lcgPrint.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.lcgPrint.Size = new System.Drawing.Size(240, 60);
            this.lcgPrint.Text = "lcgPrint";
            // 
            // lciImage
            // 
            this.lciImage.Control = this.pePrinter;
            this.lciImage.CustomizationFormText = "lciImage";
            this.lciImage.IsRequired = null;
            this.lciImage.Location = new System.Drawing.Point(0, 0);
            this.lciImage.Name = "lciImage";
            this.lciImage.Size = new System.Drawing.Size(236, 56);
            this.lciImage.Text = "lciImage";
            this.lciImage.TextSize = new System.Drawing.Size(0, 0);
            this.lciImage.TextToControlDistance = 0;
            this.lciImage.TextVisible = false;
            // 
            // ucPrintControl
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pPrint);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ucPrintControl";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(248, 95);
            this.Load += new System.EventHandler(this.ucPrintControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bmPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPrint)).EndInit();
            this.pPrint.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcPrint)).EndInit();
            this.lcPrint.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pePrinter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager bmPrint;
        private DevExpress.XtraBars.Bar statusBar;
        private DevExpress.XtraBars.BarButtonItem ucBtnPrint;
        private DevExpress.XtraBars.BarButtonItem ucBtnPreview;
        private DevExpress.XtraBars.BarButtonItem ucBtnClose;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.Utils.ImageCollection icPrint;
        protected efControls.efLayoutControl lcPrint;
        protected DevExpress.XtraLayout.LayoutControlGroup lcgPrint;
        protected efPanel pPrint;
        protected DevExpress.XtraEditors.PictureEdit pePrinter;
        protected lci lciImage;
    }
}
