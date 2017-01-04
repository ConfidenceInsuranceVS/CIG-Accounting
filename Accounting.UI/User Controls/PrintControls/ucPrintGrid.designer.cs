namespace Accounting
{
    partial class ucPrintGrid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPrintGrid));
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.bsMaster = new System.Windows.Forms.BindingSource(this.components);
            this.rgSelection = new efControls.efRadioGroup();
            this.lciSelection = new efControls.lci();
            ((System.ComponentModel.ISupportInitialize)(this.icPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgSelection.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSelection)).BeginInit();
            this.SuspendLayout();
            // 
            // icPrint
            // 
            this.icPrint.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("icPrint.ImageStream")));
            this.icPrint.Images.SetKeyName(0, "close16.png");
            this.icPrint.Images.SetKeyName(1, "kappfinder.png");
            this.icPrint.Images.SetKeyName(2, "print.png");
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.rgSelection);
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(593, 251, 250, 350);
            this.lcMain.Size = new System.Drawing.Size(231, 119);
            // 
            // lcgMain
            // 
            this.lcgMain.AppearanceGroup.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lcgMain.AppearanceGroup.Options.UseFont = true;
            this.lcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciSelection});
            this.lcgMain.Name = "Root";
            this.lcgMain.Size = new System.Drawing.Size(231, 119);
            // 
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.Images.SetKeyName(0, "print.png");
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(2, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(294, 0);
            // 
            // rgSelection
            // 
            //this.rgSelection.DefaultState = efControls.Enums.ControlState.AlwaysEnabled;
            this.rgSelection.EnterMoveNextControl = true;
            this.rgSelection.Location = new System.Drawing.Point(3, 23);
            this.rgSelection.Name = "rgSelection";
            this.rgSelection.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Current Row"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "All Rows"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Selected Row[s]")});
            this.rgSelection.Size = new System.Drawing.Size(225, 93);
            this.rgSelection.StyleController = this.lcMain;
            this.rgSelection.TabIndex = 4;
            // 
            // lciSelection
            // 
            this.lciSelection.Control = this.rgSelection;
            this.lciSelection.CustomizationFormText = "lciSelection";
            this.lciSelection.IsRequired = null;
            this.lciSelection.Location = new System.Drawing.Point(0, 0);
            this.lciSelection.Name = "lciSelection";
            this.lciSelection.Size = new System.Drawing.Size(229, 97);
            this.lciSelection.Text = "lciSelection";
            this.lciSelection.TextSize = new System.Drawing.Size(0, 0);
            this.lciSelection.TextToControlDistance = 0;
            this.lciSelection.TextVisible = false;
            // 
            // ucPrintGrid
            // 
            this.Appearance.BackColor = System.Drawing.Color.Silver;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "ucPrintGrid";
            this.Size = new System.Drawing.Size(235, 150);
            ((System.ComponentModel.ISupportInitialize)(this.icPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgSelection.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSelection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.BindingSource bsMaster;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private efControls.efRadioGroup rgSelection;
        private efControls.lci lciSelection;




    }
}
