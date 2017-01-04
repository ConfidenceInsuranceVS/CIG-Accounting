namespace efControls
{
    partial class ucControlNavigator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucControlNavigator));
            this.imgList = new DevExpress.Utils.ImageCollection(this.components);
            this.chkLock = new DevExpress.XtraEditors.CheckButton();
            this.lcNavigator = new DevExpress.XtraLayout.LayoutControl();
            this.btnExcel = new efControls.efButton();
            this.controlNavigator = new efControls.efControlNavigator();
            this.lcgNavigator = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciButton = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciNavigator = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciExcel = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.imgList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcNavigator)).BeginInit();
            this.lcNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcgNavigator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNavigator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.Images.SetKeyName(0, "LockedGrid.png");
            this.imgList.Images.SetKeyName(1, "UnlockedGrid.png");
            // 
            // chkLock
            // 
            this.chkLock.ImageIndex = 0;
            this.chkLock.ImageList = this.imgList;
            this.chkLock.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.chkLock.Location = new System.Drawing.Point(160, 2);
            this.chkLock.Name = "chkLock";
            this.chkLock.Size = new System.Drawing.Size(23, 22);
            this.chkLock.StyleController = this.lcNavigator;
            this.chkLock.TabIndex = 1;
            this.chkLock.TabStop = false;
            this.chkLock.CheckedChanged += new System.EventHandler(this.chkLock_CheckedChanged);
            // 
            // lcNavigator
            // 
            this.lcNavigator.Controls.Add(this.btnExcel);
            this.lcNavigator.Controls.Add(this.controlNavigator);
            this.lcNavigator.Controls.Add(this.chkLock);
            this.lcNavigator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcNavigator.Location = new System.Drawing.Point(0, 0);
            this.lcNavigator.Margin = new System.Windows.Forms.Padding(0);
            this.lcNavigator.Name = "lcNavigator";
            this.lcNavigator.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(802, 108, 349, 350);
            this.lcNavigator.Padding = new System.Windows.Forms.Padding(2);
            this.lcNavigator.Root = this.lcgNavigator;
            this.lcNavigator.Size = new System.Drawing.Size(185, 26);
            this.lcNavigator.TabIndex = 2;
            // 
            // btnExcel
            // 
            this.btnExcel.DefaultState = efControls.Enums.ControlState.AlwaysEnabled;
            this.btnExcel.HighLighted = false;
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.Location = new System.Drawing.Point(133, 2);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(23, 22);
            this.btnExcel.StyleController = this.lcNavigator;
            this.btnExcel.TabIndex = 4;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // controlNavigator
            // 
            this.controlNavigator.Appearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.controlNavigator.Appearance.Options.UseBorderColor = true;
            this.controlNavigator.Buttons.Append.Enabled = false;
            this.controlNavigator.Buttons.Append.Visible = false;
            this.controlNavigator.Buttons.CancelEdit.Enabled = false;
            this.controlNavigator.Buttons.CancelEdit.Visible = false;
            this.controlNavigator.Buttons.Edit.Enabled = false;
            this.controlNavigator.Buttons.Edit.Visible = false;
            this.controlNavigator.Buttons.EndEdit.Enabled = false;
            this.controlNavigator.Buttons.EndEdit.Visible = false;
            this.controlNavigator.Buttons.NextPage.Visible = false;
            this.controlNavigator.Buttons.PrevPage.Visible = false;
            this.controlNavigator.Buttons.Remove.Enabled = false;
            this.controlNavigator.Buttons.Remove.Visible = false;
            this.controlNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.controlNavigator.Location = new System.Drawing.Point(2, 2);
            this.controlNavigator.Name = "controlNavigator";
            this.controlNavigator.showButtons = false;
            this.controlNavigator.showNavigator = true;
            this.controlNavigator.showPager = false;
            this.controlNavigator.showText = true;
            this.controlNavigator.Size = new System.Drawing.Size(127, 22);
            this.controlNavigator.StyleController = this.lcNavigator;
            this.controlNavigator.TabIndex = 0;
            this.controlNavigator.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center;
            this.controlNavigator.TextStringFormat = "{0} of {1}";
            // 
            // lcgNavigator
            // 
            this.lcgNavigator.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgNavigator.GroupBordersVisible = false;
            this.lcgNavigator.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciButton,
            this.lciNavigator,
            this.lciExcel});
            this.lcgNavigator.Location = new System.Drawing.Point(0, 0);
            this.lcgNavigator.Name = "Root";
            this.lcgNavigator.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcgNavigator.Size = new System.Drawing.Size(185, 26);
            this.lcgNavigator.TextVisible = false;
            // 
            // lciButton
            // 
            this.lciButton.Control = this.chkLock;
            this.lciButton.Location = new System.Drawing.Point(158, 0);
            this.lciButton.MaxSize = new System.Drawing.Size(27, 26);
            this.lciButton.MinSize = new System.Drawing.Size(27, 26);
            this.lciButton.Name = "lciButton";
            this.lciButton.Size = new System.Drawing.Size(27, 26);
            this.lciButton.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciButton.TextSize = new System.Drawing.Size(0, 0);
            this.lciButton.TextVisible = false;
            // 
            // lciNavigator
            // 
            this.lciNavigator.Control = this.controlNavigator;
            this.lciNavigator.Location = new System.Drawing.Point(0, 0);
            this.lciNavigator.MinSize = new System.Drawing.Size(98, 23);
            this.lciNavigator.Name = "lciNavigator";
            this.lciNavigator.Size = new System.Drawing.Size(131, 26);
            this.lciNavigator.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciNavigator.TextSize = new System.Drawing.Size(0, 0);
            this.lciNavigator.TextVisible = false;
            // 
            // lciExcel
            // 
            this.lciExcel.Control = this.btnExcel;
            this.lciExcel.Location = new System.Drawing.Point(131, 0);
            this.lciExcel.MaxSize = new System.Drawing.Size(27, 26);
            this.lciExcel.MinSize = new System.Drawing.Size(27, 26);
            this.lciExcel.Name = "lciExcel";
            this.lciExcel.Size = new System.Drawing.Size(27, 26);
            this.lciExcel.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciExcel.TextSize = new System.Drawing.Size(0, 0);
            this.lciExcel.TextVisible = false;
            // 
            // ucControlNavigator
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lcNavigator);
            this.MaximumSize = new System.Drawing.Size(0, 26);
            this.MinimumSize = new System.Drawing.Size(185, 26);
            this.Name = "ucControlNavigator";
            this.Size = new System.Drawing.Size(185, 26);
            ((System.ComponentModel.ISupportInitialize)(this.imgList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcNavigator)).EndInit();
            this.lcNavigator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcgNavigator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNavigator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciExcel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private efControlNavigator controlNavigator;
        private DevExpress.XtraEditors.CheckButton chkLock;
        private DevExpress.Utils.ImageCollection imgList;
        private DevExpress.XtraLayout.LayoutControl lcNavigator;
        private DevExpress.XtraLayout.LayoutControlGroup lcgNavigator;
        private DevExpress.XtraLayout.LayoutControlItem lciButton;
        private DevExpress.XtraLayout.LayoutControlItem lciNavigator;
        private efButton btnExcel;
        private DevExpress.XtraLayout.LayoutControlItem lciExcel;
    }
}
