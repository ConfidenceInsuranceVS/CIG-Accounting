namespace Accounting
{
    partial class FormCopyingBalances
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCopyingBalances));
            this.lcMain = new efControls.efLayoutControl();
            this.lstResult = new efControls.efListBox();
            this.txtDescription = new efControls.efTextBox();
            this.btnExit = new efControls.efButton();
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.btn1to5 = new efControls.efButton();
            this.lcg = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lci1to5 = new efControls.lci();
            this.lciDescription = new efControls.lci();
            this.lciExit = new efControls.lci();
            this.lciResult = new efControls.lci();
            this.esInfo = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci1to5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.esInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.lstResult);
            this.lcMain.Controls.Add(this.txtDescription);
            this.lcMain.Controls.Add(this.btnExit);
            this.lcMain.Controls.Add(this.btn1to5);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 0);
            this.lcMain.Name = "lcMain";
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(957, 132, 524, 683);
            this.lcMain.Root = this.lcg;
            this.lcMain.Size = new System.Drawing.Size(442, 368);
            this.lcMain.TabIndex = 18;
            this.lcMain.Text = "efLayoutControl1";
            // 
            // lstResult
            // 
            this.lstResult.Location = new System.Drawing.Point(12, 115);
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(418, 241);
            this.lstResult.StyleController = this.lcMain;
            this.lstResult.TabIndex = 32;
            // 
            // txtDescription
            // 
            this.txtDescription.AllowLeadingSpace = false;
            this.txtDescription.DefaultState = efControls.Enums.ControlState.Default;
            this.txtDescription.DisplayType = efControls.Enums.DisplayType.Default;
            this.txtDescription.EnterMoveNextControl = true;
            this.txtDescription.Information = null;
            this.txtDescription.Location = new System.Drawing.Point(68, 65);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(362, 20);
            this.txtDescription.StyleController = this.lcMain;
            this.txtDescription.TabIndex = 31;
            // 
            // btnExit
            // 
            this.btnExit.DefaultState = efControls.Enums.ControlState.Default;
            this.btnExit.HighLighted = false;
            this.btnExit.ImageIndex = 0;
            this.btnExit.ImageList = this.imageCollection;
            this.btnExit.Location = new System.Drawing.Point(346, 89);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 22);
            this.btnExit.StyleController = this.lcMain;
            this.btnExit.TabIndex = 26;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.InsertGalleryImage("loadfrom_16x16.png", "office2013/actions/loadfrom_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/loadfrom_16x16.png"), 0);
            this.imageCollection.Images.SetKeyName(0, "loadfrom_16x16.png");
            this.imageCollection.InsertGalleryImage("replace_16x16.png", "office2013/format/replace_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/format/replace_16x16.png"), 1);
            this.imageCollection.Images.SetKeyName(1, "replace_16x16.png");
            // 
            // btn1to5
            // 
            this.btn1to5.DefaultState = efControls.Enums.ControlState.Default;
            this.btn1to5.HighLighted = false;
            this.btn1to5.ImageIndex = 1;
            this.btn1to5.ImageList = this.imageCollection;
            this.btn1to5.Location = new System.Drawing.Point(12, 89);
            this.btn1to5.Name = "btn1to5";
            this.btn1to5.Size = new System.Drawing.Size(330, 22);
            this.btn1to5.StyleController = this.lcMain;
            this.btn1to5.TabIndex = 24;
            this.btn1to5.Text = "Confirm";
            this.btn1to5.Click += new System.EventHandler(this.btn1to5_Click);
            // 
            // lcg
            // 
            this.lcg.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcg.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lci1to5,
            this.lciDescription,
            this.lciExit,
            this.lciResult,
            this.esInfo});
            this.lcg.Location = new System.Drawing.Point(0, 0);
            this.lcg.Name = "Root";
            this.lcg.Size = new System.Drawing.Size(442, 368);
            this.lcg.TextVisible = false;
            // 
            // lci1to5
            // 
            this.lci1to5.Control = this.btn1to5;
            this.lci1to5.IsRequired = null;
            this.lci1to5.Location = new System.Drawing.Point(0, 77);
            this.lci1to5.Name = "lci1to5";
            this.lci1to5.Size = new System.Drawing.Size(334, 26);
            this.lci1to5.TextSize = new System.Drawing.Size(0, 0);
            this.lci1to5.TextVisible = false;
            // 
            // lciDescription
            // 
            this.lciDescription.Control = this.txtDescription;
            this.lciDescription.IsRequired = null;
            this.lciDescription.Location = new System.Drawing.Point(0, 53);
            this.lciDescription.Name = "lciDescription";
            this.lciDescription.Size = new System.Drawing.Size(422, 24);
            this.lciDescription.Text = "Description";
            this.lciDescription.TextSize = new System.Drawing.Size(53, 13);
            // 
            // lciExit
            // 
            this.lciExit.Control = this.btnExit;
            this.lciExit.IsRequired = null;
            this.lciExit.Location = new System.Drawing.Point(334, 77);
            this.lciExit.Name = "lciExit";
            this.lciExit.Size = new System.Drawing.Size(88, 26);
            this.lciExit.TextSize = new System.Drawing.Size(0, 0);
            this.lciExit.TextVisible = false;
            // 
            // lciResult
            // 
            this.lciResult.Control = this.lstResult;
            this.lciResult.IsRequired = null;
            this.lciResult.Location = new System.Drawing.Point(0, 103);
            this.lciResult.Name = "lciResult";
            this.lciResult.Size = new System.Drawing.Size(422, 245);
            this.lciResult.TextSize = new System.Drawing.Size(0, 0);
            this.lciResult.TextVisible = false;
            // 
            // esInfo
            // 
            this.esInfo.AllowHotTrack = false;
            this.esInfo.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.esInfo.AppearanceItemCaption.ForeColor = System.Drawing.Color.Red;
            this.esInfo.AppearanceItemCaption.Options.UseFont = true;
            this.esInfo.AppearanceItemCaption.Options.UseForeColor = true;
            this.esInfo.AppearanceItemCaption.Options.UseTextOptions = true;
            this.esInfo.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.esInfo.AppearanceItemCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.esInfo.Location = new System.Drawing.Point(0, 0);
            this.esInfo.Name = "esInfo";
            this.esInfo.Size = new System.Drawing.Size(422, 53);
            this.esInfo.Text = "Attention - This will create/update the {0} opening voucher";
            this.esInfo.TextSize = new System.Drawing.Size(53, 0);
            this.esInfo.TextVisible = true;
            // 
            // FormCopyingBalances
            // 
            this.ClientSize = new System.Drawing.Size(442, 368);
            this.ControlBox = false;
            this.Controls.Add(this.lcMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormCopyingBalances";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Copying Balances From Previous Year";
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci1to5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.esInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private efControls.efLayoutControl lcMain;
        private DevExpress.XtraLayout.LayoutControlGroup lcg;
        private efControls.efButton btnExit;
        private efControls.efButton btn1to5;
        private efControls.lci lci1to5;
        private efControls.lci lciExit;
        private DevExpress.Utils.ImageCollection imageCollection;
        private efControls.efTextBox txtDescription;
        private efControls.lci lciDescription;
        private efControls.efListBox lstResult;
        private efControls.lci lciResult;
        private DevExpress.XtraLayout.EmptySpaceItem esInfo;
    }
}
