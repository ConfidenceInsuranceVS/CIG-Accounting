namespace efControls
{
    partial class efPreferences
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
            this.gcSkins = new DevExpress.XtraBars.Ribbon.GalleryControl();
            this.galleryControlClient1 = new DevExpress.XtraBars.Ribbon.GalleryControlClient();
            this.lcFonts = new efControls.efLayoutControl();
            this.btnClose = new efControls.efButton();
            this.btnSave = new efControls.efButton();
            this.cpBordercolor = new DevExpress.XtraEditors.ColorPickEdit();
            this.cpForecolor = new DevExpress.XtraEditors.ColorPickEdit();
            this.cpBackcolor = new DevExpress.XtraEditors.ColorPickEdit();
            this.spnSize = new efControls.efSpinner();
            this.chkBold = new efControls.efCheckBox();
            this.cmbFonts = new DevExpress.XtraEditors.FontEdit();
            this.lcgPreferences = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciFontName = new efControls.lci();
            this.lciFontSize = new efControls.lci();
            this.lciFontStyle = new efControls.lci();
            this.lcgeditBackcolor = new efControls.lci();
            this.lciForecolor = new efControls.lci();
            this.lciBorderColor = new efControls.lci();
            this.lciSave = new efControls.lci();
            this.lciClose = new efControls.lci();
            this.rgbSkins = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.lciGallery = new efControls.lci();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSkins)).BeginInit();
            this.gcSkins.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcFonts)).BeginInit();
            this.lcFonts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpBordercolor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpForecolor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpBackcolor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBold.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFonts.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgPreferences)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFontName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFontSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFontStyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgeditBackcolor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciForecolor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBorderColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGallery)).BeginInit();
            this.SuspendLayout();
            // 
            // gcSkins
            // 
            this.gcSkins.Controls.Add(this.galleryControlClient1);
            this.gcSkins.DesignGalleryGroupIndex = 0;
            this.gcSkins.DesignGalleryItemIndex = 0;
            this.gcSkins.Location = new System.Drawing.Point(2, 2);
            this.gcSkins.Name = "gcSkins";
            this.gcSkins.Size = new System.Drawing.Size(730, 426);
            this.gcSkins.StyleController = this.lcFonts;
            this.gcSkins.TabIndex = 1;
            // 
            // galleryControlClient1
            // 
            this.galleryControlClient1.GalleryControl = this.gcSkins;
            this.galleryControlClient1.Location = new System.Drawing.Point(2, 2);
            this.galleryControlClient1.Size = new System.Drawing.Size(709, 422);
            // 
            // lcFonts
            // 
            this.lcFonts.Controls.Add(this.gcSkins);
            this.lcFonts.Controls.Add(this.btnClose);
            this.lcFonts.Controls.Add(this.btnSave);
            this.lcFonts.Controls.Add(this.cpBordercolor);
            this.lcFonts.Controls.Add(this.cpForecolor);
            this.lcFonts.Controls.Add(this.cpBackcolor);
            this.lcFonts.Controls.Add(this.spnSize);
            this.lcFonts.Controls.Add(this.chkBold);
            this.lcFonts.Controls.Add(this.cmbFonts);
            this.lcFonts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcFonts.Location = new System.Drawing.Point(0, 0);
            this.lcFonts.Name = "lcFonts";
            this.lcFonts.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1242, 199, 392, 696);
            this.lcFonts.Root = this.lcgPreferences;
            this.lcFonts.Size = new System.Drawing.Size(734, 482);
            this.lcFonts.TabIndex = 0;
            this.lcFonts.Text = "efLayoutControl1";
            // 
            // btnClose
            // 
            this.btnClose.DefaultState = efControls.Enums.ControlState.Default;
            this.btnClose.HighLighted = false;
            this.btnClose.Location = new System.Drawing.Point(662, 458);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(70, 22);
            this.btnClose.StyleController = this.lcFonts;
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.DefaultState = efControls.Enums.ControlState.Default;
            this.btnSave.HighLighted = false;
            this.btnSave.Location = new System.Drawing.Point(662, 432);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 22);
            this.btnSave.StyleController = this.lcFonts;
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cpBordercolor
            // 
            this.cpBordercolor.EditValue = System.Drawing.Color.Empty;
            this.cpBordercolor.Location = new System.Drawing.Point(508, 458);
            this.cpBordercolor.Name = "cpBordercolor";
            this.cpBordercolor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cpBordercolor.Size = new System.Drawing.Size(150, 20);
            this.cpBordercolor.StyleController = this.lcFonts;
            this.cpBordercolor.TabIndex = 7;
            // 
            // cpForecolor
            // 
            this.cpForecolor.EditValue = System.Drawing.Color.Empty;
            this.cpForecolor.Location = new System.Drawing.Point(288, 458);
            this.cpForecolor.Name = "cpForecolor";
            this.cpForecolor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cpForecolor.Size = new System.Drawing.Size(150, 20);
            this.cpForecolor.StyleController = this.lcFonts;
            this.cpForecolor.TabIndex = 6;
            // 
            // cpBackcolor
            // 
            this.cpBackcolor.EditValue = System.Drawing.Color.Empty;
            this.cpBackcolor.Location = new System.Drawing.Point(68, 458);
            this.cpBackcolor.Name = "cpBackcolor";
            this.cpBackcolor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cpBackcolor.Size = new System.Drawing.Size(150, 20);
            this.cpBackcolor.StyleController = this.lcFonts;
            this.cpBackcolor.TabIndex = 5;
            // 
            // spnSize
            // 
            this.spnSize.AllowLeadingSpace = false;
            this.spnSize.DefaultState = efControls.Enums.ControlState.Default;
            this.spnSize.DisplayType = efControls.Enums.DisplayType.Default;
            this.spnSize.EditValue = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.spnSize.EnterMoveNextControl = true;
            this.spnSize.Information = null;
            this.spnSize.Location = new System.Drawing.Point(508, 432);
            this.spnSize.Name = "spnSize";
            this.spnSize.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spnSize.Properties.MaxValue = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.spnSize.Properties.MinValue = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.spnSize.Size = new System.Drawing.Size(50, 20);
            this.spnSize.StyleController = this.lcFonts;
            this.spnSize.TabIndex = 2;
            // 
            // chkBold
            // 
            this.chkBold.DefaultState = efControls.Enums.ControlState.Default;
            this.chkBold.EnterMoveNextControl = true;
            this.chkBold.HighLighted = false;
            this.chkBold.Location = new System.Drawing.Point(565, 432);
            this.chkBold.Name = "chkBold";
            this.chkBold.Properties.Appearance.Options.UseTextOptions = true;
            this.chkBold.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.chkBold.Properties.Caption = "Bold";
            this.chkBold.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.chkBold.Properties.Name = "efCheckBox";
            this.chkBold.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.chkBold.Size = new System.Drawing.Size(93, 19);
            this.chkBold.StyleController = this.lcFonts;
            this.chkBold.TabIndex = 4;
            this.chkBold.ValueType = efControls.Enums.ValueType.Boolean;
            // 
            // cmbFonts
            // 
            this.cmbFonts.Location = new System.Drawing.Point(68, 432);
            this.cmbFonts.Name = "cmbFonts";
            this.cmbFonts.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbFonts.Size = new System.Drawing.Size(370, 20);
            this.cmbFonts.StyleController = this.lcFonts;
            this.cmbFonts.TabIndex = 0;
            // 
            // lcgPreferences
            // 
            this.lcgPreferences.CustomizationFormText = "lcgPreferences";
            this.lcgPreferences.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgPreferences.GroupBordersVisible = false;
            this.lcgPreferences.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciGallery,
            this.lciFontName,
            this.lciFontSize,
            this.lcgeditBackcolor,
            this.lciForecolor,
            this.lciFontStyle,
            this.lciBorderColor,
            this.lciSave,
            this.lciClose});
            this.lcgPreferences.Location = new System.Drawing.Point(0, 0);
            this.lcgPreferences.Name = "Root";
            this.lcgPreferences.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcgPreferences.Size = new System.Drawing.Size(734, 482);
            this.lcgPreferences.TextVisible = false;
            // 
            // lciFontName
            // 
            this.lciFontName.Control = this.cmbFonts;
            this.lciFontName.CustomizationFormText = "Font Name";
            this.lciFontName.IsRequired = null;
            this.lciFontName.Location = new System.Drawing.Point(0, 430);
            this.lciFontName.Name = "lciFontName";
            this.lciFontName.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 2, 2, 2);
            this.lciFontName.Size = new System.Drawing.Size(440, 26);
            this.lciFontName.Text = "Font Name";
            this.lciFontName.TextLocation = DevExpress.Utils.Locations.Left;
            this.lciFontName.TextSize = new System.Drawing.Size(60, 13);
            // 
            // lciFontSize
            // 
            this.lciFontSize.Control = this.spnSize;
            this.lciFontSize.CustomizationFormText = "Font Size";
            this.lciFontSize.IsRequired = null;
            this.lciFontSize.Location = new System.Drawing.Point(440, 430);
            this.lciFontSize.Name = "lciFontSize";
            this.lciFontSize.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 2, 2, 2);
            this.lciFontSize.Size = new System.Drawing.Size(120, 26);
            this.lciFontSize.Text = "Font Size";
            this.lciFontSize.TextLocation = DevExpress.Utils.Locations.Left;
            this.lciFontSize.TextSize = new System.Drawing.Size(60, 13);
            // 
            // lciFontStyle
            // 
            this.lciFontStyle.Control = this.chkBold;
            this.lciFontStyle.CustomizationFormText = "lciFontStyle";
            this.lciFontStyle.IsRequired = null;
            this.lciFontStyle.Location = new System.Drawing.Point(560, 430);
            this.lciFontStyle.Name = "lciFontStyle";
            this.lciFontStyle.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 2, 2, 2);
            this.lciFontStyle.Size = new System.Drawing.Size(100, 26);
            this.lciFontStyle.TextSize = new System.Drawing.Size(0, 0);
            this.lciFontStyle.TextVisible = false;
            // 
            // lcgeditBackcolor
            // 
            this.lcgeditBackcolor.Control = this.cpBackcolor;
            this.lcgeditBackcolor.CustomizationFormText = "Control Backcolor";
            this.lcgeditBackcolor.IsRequired = null;
            this.lcgeditBackcolor.Location = new System.Drawing.Point(0, 456);
            this.lcgeditBackcolor.Name = "lcgeditBackcolor";
            this.lcgeditBackcolor.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 2, 2, 2);
            this.lcgeditBackcolor.Size = new System.Drawing.Size(220, 26);
            this.lcgeditBackcolor.Text = "Backcolor";
            this.lcgeditBackcolor.TextLocation = DevExpress.Utils.Locations.Left;
            this.lcgeditBackcolor.TextSize = new System.Drawing.Size(60, 13);
            // 
            // lciForecolor
            // 
            this.lciForecolor.Control = this.cpForecolor;
            this.lciForecolor.CustomizationFormText = "Forecolor";
            this.lciForecolor.IsRequired = null;
            this.lciForecolor.Location = new System.Drawing.Point(220, 456);
            this.lciForecolor.Name = "lciForecolor";
            this.lciForecolor.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 2, 2, 2);
            this.lciForecolor.Size = new System.Drawing.Size(220, 26);
            this.lciForecolor.Text = "Forecolor";
            this.lciForecolor.TextLocation = DevExpress.Utils.Locations.Left;
            this.lciForecolor.TextSize = new System.Drawing.Size(60, 13);
            // 
            // lciBorderColor
            // 
            this.lciBorderColor.Control = this.cpBordercolor;
            this.lciBorderColor.CustomizationFormText = "Border Color";
            this.lciBorderColor.IsRequired = null;
            this.lciBorderColor.Location = new System.Drawing.Point(440, 456);
            this.lciBorderColor.Name = "lciBorderColor";
            this.lciBorderColor.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 2, 2, 2);
            this.lciBorderColor.Size = new System.Drawing.Size(220, 26);
            this.lciBorderColor.Text = "Border Color";
            this.lciBorderColor.TextLocation = DevExpress.Utils.Locations.Left;
            this.lciBorderColor.TextSize = new System.Drawing.Size(60, 13);
            // 
            // lciSave
            // 
            this.lciSave.Control = this.btnSave;
            this.lciSave.CustomizationFormText = "efLayoutControlItem1";
            this.lciSave.IsRequired = null;
            this.lciSave.Location = new System.Drawing.Point(660, 430);
            this.lciSave.Name = "lciSave";
            this.lciSave.Size = new System.Drawing.Size(74, 26);
            this.lciSave.TextSize = new System.Drawing.Size(0, 0);
            this.lciSave.TextVisible = false;
            // 
            // lciClose
            // 
            this.lciClose.Control = this.btnClose;
            this.lciClose.CustomizationFormText = "efLayoutControlItem2";
            this.lciClose.IsRequired = null;
            this.lciClose.Location = new System.Drawing.Point(660, 456);
            this.lciClose.Name = "lciClose";
            this.lciClose.Size = new System.Drawing.Size(74, 26);
            this.lciClose.TextSize = new System.Drawing.Size(0, 0);
            this.lciClose.TextVisible = false;
            // 
            // rgbSkins
            // 
            this.rgbSkins.Id = 143;
            this.rgbSkins.Name = "rgbSkins";
            // 
            // lciGallery
            // 
            this.lciGallery.Control = this.gcSkins;
            this.lciGallery.IsRequired = null;
            this.lciGallery.Location = new System.Drawing.Point(0, 0);
            this.lciGallery.Name = "lciGallery";
            this.lciGallery.Size = new System.Drawing.Size(734, 430);
            this.lciGallery.TextSize = new System.Drawing.Size(0, 0);
            this.lciGallery.TextVisible = false;
            // 
            // efPreferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 482);
            this.Controls.Add(this.lcFonts);
            this.MinimumSize = new System.Drawing.Size(611, 391);
            this.Name = "efPreferences";
            this.Text = "Preferences";
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSkins)).EndInit();
            this.gcSkins.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcFonts)).EndInit();
            this.lcFonts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cpBordercolor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpForecolor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpBackcolor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBold.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFonts.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgPreferences)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFontName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFontSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFontStyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgeditBackcolor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciForecolor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBorderColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGallery)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.FontEdit cmbFonts;
        private efSpinner spnSize;
        private efCheckBox chkBold;
        private efLayoutControl lcFonts;
        private DevExpress.XtraEditors.ColorPickEdit cpBackcolor;
        private DevExpress.XtraLayout.LayoutControlGroup lcgPreferences;
        private lci lciFontStyle;
        private lci lciFontSize;
        private lci lciFontName;
        private lci lcgeditBackcolor;
        private DevExpress.XtraEditors.ColorPickEdit cpBordercolor;
        private DevExpress.XtraEditors.ColorPickEdit cpForecolor;
        private lci lciForecolor;
        private lci lciBorderColor;
        private DevExpress.XtraBars.RibbonGalleryBarItem rgbSkins;
        private DevExpress.XtraBars.Ribbon.GalleryControl gcSkins;
        private efButton btnClose;
        private efButton btnSave;
        private lci lciSave;
        private lci lciClose;
        private DevExpress.XtraBars.Ribbon.GalleryControlClient galleryControlClient1;
        private lci lciGallery;
    }
}