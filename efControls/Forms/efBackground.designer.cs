namespace efControls
{
    partial class efBackground
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(efBackground));
            this.lcFonts = new efControls.efLayoutControl();
            this.btnClear = new efControls.efButton();
            this.rgStyle = new efControls.efRadioGroup();
            this.peBackground = new DevExpress.XtraEditors.PictureEdit();
            this.btnClose = new efControls.efButton();
            this.btnSave = new efControls.efButton();
            this.lcgPreferences = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciSave = new efControls.lci();
            this.lciClose = new efControls.lci();
            this.lciPicture = new efControls.lci();
            this.lciStyle = new efControls.lci();
            this.lciClear = new efControls.lci();
            this.rgbSkins = new DevExpress.XtraBars.RibbonGalleryBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcFonts)).BeginInit();
            this.lcFonts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgStyle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peBackground.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgPreferences)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciStyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciClear)).BeginInit();
            this.SuspendLayout();
            // 
            // lcFonts
            // 
            this.lcFonts.Controls.Add(this.btnClear);
            this.lcFonts.Controls.Add(this.rgStyle);
            this.lcFonts.Controls.Add(this.peBackground);
            this.lcFonts.Controls.Add(this.btnClose);
            this.lcFonts.Controls.Add(this.btnSave);
            this.lcFonts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcFonts.Location = new System.Drawing.Point(0, 0);
            this.lcFonts.Name = "lcFonts";
            this.lcFonts.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(561, 211, 250, 350);
            this.lcFonts.Root = this.lcgPreferences;
            this.lcFonts.Size = new System.Drawing.Size(334, 359);
            this.lcFonts.TabIndex = 0;
            this.lcFonts.Text = "efLayoutControl1";
            // 
            // btnClear
            // 
            this.btnClear.DefaultState = efControls.Enums.ControlState.Default;
            this.btnClear.HighLighted = false;
            this.btnClear.Location = new System.Drawing.Point(92, 280);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 22);
            this.btnClear.StyleController = this.lcFonts;
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear Image";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // rgStyle
            // 
            this.rgStyle.Location = new System.Drawing.Point(20, 306);
            this.rgStyle.Name = "rgStyle";
            this.rgStyle.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Tile"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Center"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Stretch"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Zoom")});
            this.rgStyle.Size = new System.Drawing.Size(294, 25);
            this.rgStyle.StyleController = this.lcFonts;
            this.rgStyle.TabIndex = 11;
            this.rgStyle.SelectedIndexChanged += new System.EventHandler(this.rgStyle_SelectedIndexChanged);
            // 
            // peBackground
            // 
            this.peBackground.Location = new System.Drawing.Point(75, 75);
            this.peBackground.Name = "peBackground";
            this.peBackground.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.peBackground.Size = new System.Drawing.Size(184, 128);
            this.peBackground.StyleController = this.lcFonts;
            this.peBackground.TabIndex = 10;
            this.peBackground.DoubleClick += new System.EventHandler(this.peBackground_DoubleClick);
            // 
            // btnClose
            // 
            this.btnClose.DefaultState = efControls.Enums.ControlState.Default;
            this.btnClose.HighLighted = false;
            this.btnClose.Location = new System.Drawing.Point(169, 335);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(73, 22);
            this.btnClose.StyleController = this.lcFonts;
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.DefaultState = efControls.Enums.ControlState.Default;
            this.btnSave.HighLighted = false;
            this.btnSave.Location = new System.Drawing.Point(92, 335);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(73, 22);
            this.btnSave.StyleController = this.lcFonts;
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lcgPreferences
            // 
            this.lcgPreferences.CustomizationFormText = "lcgPreferences";
            this.lcgPreferences.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgPreferences.GroupBordersVisible = false;
            this.lcgPreferences.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciSave,
            this.lciClose,
            this.lciPicture,
            this.lciStyle,
            this.lciClear});
            this.lcgPreferences.Location = new System.Drawing.Point(0, 0);
            this.lcgPreferences.Name = "Root";
            this.lcgPreferences.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcgPreferences.Size = new System.Drawing.Size(334, 359);
            this.lcgPreferences.Text = "Root";
            this.lcgPreferences.TextVisible = false;
            // 
            // lciSave
            // 
            this.lciSave.Control = this.btnSave;
            this.lciSave.CustomizationFormText = "lciSave";
            this.lciSave.IsRequired = null;
            this.lciSave.Location = new System.Drawing.Point(0, 333);
            this.lciSave.MaxSize = new System.Drawing.Size(167, 26);
            this.lciSave.MinSize = new System.Drawing.Size(167, 26);
            this.lciSave.Name = "lciSave";
            this.lciSave.Padding = new DevExpress.XtraLayout.Utils.Padding(92, 2, 2, 2);
            this.lciSave.Size = new System.Drawing.Size(167, 26);
            this.lciSave.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciSave.Text = "lciSave";
            this.lciSave.TextSize = new System.Drawing.Size(0, 0);
            this.lciSave.TextToControlDistance = 0;
            this.lciSave.TextVisible = false;
            // 
            // lciClose
            // 
            this.lciClose.Control = this.btnClose;
            this.lciClose.CustomizationFormText = "efLayoutControlItem2";
            this.lciClose.IsRequired = null;
            this.lciClose.Location = new System.Drawing.Point(167, 333);
            this.lciClose.MaxSize = new System.Drawing.Size(167, 26);
            this.lciClose.MinSize = new System.Drawing.Size(167, 26);
            this.lciClose.Name = "lciClose";
            this.lciClose.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 92, 2, 2);
            this.lciClose.Size = new System.Drawing.Size(167, 26);
            this.lciClose.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciClose.Text = "lciClose";
            this.lciClose.TextSize = new System.Drawing.Size(0, 0);
            this.lciClose.TextToControlDistance = 0;
            this.lciClose.TextVisible = false;
            // 
            // lciPicture
            // 
            this.lciPicture.Control = this.peBackground;
            this.lciPicture.CustomizationFormText = "lciPicture";
            this.lciPicture.IsRequired = null;
            this.lciPicture.Location = new System.Drawing.Point(0, 0);
            this.lciPicture.Name = "lciPicture";
            this.lciPicture.Padding = new DevExpress.XtraLayout.Utils.Padding(75, 75, 75, 75);
            this.lciPicture.Size = new System.Drawing.Size(334, 278);
            this.lciPicture.Text = "lciPicture";
            this.lciPicture.TextSize = new System.Drawing.Size(0, 0);
            this.lciPicture.TextToControlDistance = 0;
            this.lciPicture.TextVisible = false;
            // 
            // lciStyle
            // 
            this.lciStyle.Control = this.rgStyle;
            this.lciStyle.CustomizationFormText = "lciStyle";
            this.lciStyle.IsRequired = null;
            this.lciStyle.Location = new System.Drawing.Point(0, 304);
            this.lciStyle.Name = "lciStyle";
            this.lciStyle.Padding = new DevExpress.XtraLayout.Utils.Padding(20, 20, 2, 2);
            this.lciStyle.Size = new System.Drawing.Size(334, 29);
            this.lciStyle.Text = "lciStyle";
            this.lciStyle.TextSize = new System.Drawing.Size(0, 0);
            this.lciStyle.TextToControlDistance = 0;
            this.lciStyle.TextVisible = false;
            // 
            // lciClear
            // 
            this.lciClear.Control = this.btnClear;
            this.lciClear.CustomizationFormText = "lciClear";
            this.lciClear.IsRequired = null;
            this.lciClear.Location = new System.Drawing.Point(0, 278);
            this.lciClear.Name = "lciClear";
            this.lciClear.Padding = new DevExpress.XtraLayout.Utils.Padding(92, 92, 2, 2);
            this.lciClear.Size = new System.Drawing.Size(334, 26);
            this.lciClear.Text = "lciClear";
            this.lciClear.TextSize = new System.Drawing.Size(0, 0);
            this.lciClear.TextToControlDistance = 0;
            this.lciClear.TextVisible = false;
            // 
            // rgbSkins
            // 
            this.rgbSkins.Id = 143;
            this.rgbSkins.Name = "rgbSkins";
            // 
            // efBackground
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 359);
            this.Controls.Add(this.lcFonts);
            this.Name = "efBackground";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Background Settings";
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcFonts)).EndInit();
            this.lcFonts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgStyle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peBackground.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgPreferences)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciStyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciClear)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private efLayoutControl lcFonts;
        private DevExpress.XtraLayout.LayoutControlGroup lcgPreferences;
        private DevExpress.XtraBars.RibbonGalleryBarItem rgbSkins;
        private efButton btnClose;
        private efButton btnSave;
        private lci lciSave;
        private lci lciClose;
        private efRadioGroup rgStyle;
        private DevExpress.XtraEditors.PictureEdit peBackground;
        private lci lciPicture;
        private lci lciStyle;
        private efButton btnClear;
        private lci lciClear;

    }
}