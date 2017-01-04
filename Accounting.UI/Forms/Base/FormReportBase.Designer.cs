namespace Accounting
{
    partial class FormReportBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReportBase));
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.lcReport = new efControls.efLayoutControl();
            this.lcgReport = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcMain = new efControls.efLayoutControl();
            this.ucCtrlNavigator = new efControls.ucControlNavigator();
            this.cmdBrowse = new efControls.efButton();
            this.cmdPrint = new efControls.efButton();
            this.cmdPreview = new efControls.efButton();
            this.cmdExit = new efControls.efButton();
            this.lcgMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciExit = new efControls.lci();
            this.lci2 = new efControls.lci();
            this.lciPreview = new efControls.lci();
            this.lciPrint = new efControls.lci();
            this.lciBrowse = new efControls.lci();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciControlNavigator = new efControls.lci();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBrowse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciControlNavigator)).BeginInit();
            this.SuspendLayout();
            // 
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.Images.SetKeyName(0, "close.png");
            this.imageCollection.Images.SetKeyName(1, "document_flat-find.png");
            this.imageCollection.Images.SetKeyName(2, "document_flat-print.png");
            this.imageCollection.Images.SetKeyName(3, "view_details.png");
            // 
            // lcReport
            // 
            this.lcReport.Location = new System.Drawing.Point(4, 4);
            this.lcReport.Name = "lcReport";
            this.lcReport.Root = this.lcgReport;
            this.lcReport.Size = new System.Drawing.Size(589, 281);
            this.lcReport.TabIndex = 0;
            this.lcReport.Text = "efLayoutControl1";
            // 
            // lcgReport
            // 
            this.lcgReport.CustomizationFormText = "lcgReport";
            this.lcgReport.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgReport.GroupBordersVisible = false;
            this.lcgReport.Location = new System.Drawing.Point(0, 0);
            this.lcgReport.Name = "lcgReport";
            this.lcgReport.Size = new System.Drawing.Size(589, 281);
            this.lcgReport.TextVisible = false;
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.ucCtrlNavigator);
            this.lcMain.Controls.Add(this.cmdBrowse);
            this.lcMain.Controls.Add(this.cmdPrint);
            this.lcMain.Controls.Add(this.cmdPreview);
            this.lcMain.Controls.Add(this.lcReport);
            this.lcMain.Controls.Add(this.cmdExit);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 0);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.lcgMain;
            this.lcMain.Size = new System.Drawing.Size(597, 319);
            this.lcMain.TabIndex = 9;
            // 
            // ucCtrlNavigator
            // 
            this.ucCtrlNavigator.AlwaysEnabled = false;
            this.ucCtrlNavigator.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.ucCtrlNavigator.Appearance.Options.UseBackColor = true;
            this.ucCtrlNavigator.Location = new System.Drawing.Point(4, 289);
            this.ucCtrlNavigator.MaximumSize = new System.Drawing.Size(0, 26);
            this.ucCtrlNavigator.MinimumSize = new System.Drawing.Size(185, 26);
            this.ucCtrlNavigator.Name = "ucCtrlNavigator";
            this.ucCtrlNavigator.NavigatableControl = null;
            this.ucCtrlNavigator.Size = new System.Drawing.Size(240, 26);
            this.ucCtrlNavigator.TabIndex = 6;
            // 
            // cmdBrowse
            // 
            this.cmdBrowse.DefaultState = efControls.Enums.ControlState.AlwaysEnabled;
            this.cmdBrowse.HighLighted = false;
            this.cmdBrowse.ImageIndex = 3;
            this.cmdBrowse.ImageList = this.imageCollection;
            this.cmdBrowse.Location = new System.Drawing.Point(279, 291);
            this.cmdBrowse.Name = "cmdBrowse";
            this.cmdBrowse.Size = new System.Drawing.Size(72, 22);
            this.cmdBrowse.StyleController = this.lcMain;
            this.cmdBrowse.TabIndex = 2;
            this.cmdBrowse.Text = "&Browse";
            this.cmdBrowse.Click += new System.EventHandler(this.cmdBrowse_Click);
            // 
            // cmdPrint
            // 
            this.cmdPrint.DefaultState = efControls.Enums.ControlState.AlwaysEnabled;
            this.cmdPrint.HighLighted = false;
            this.cmdPrint.ImageIndex = 2;
            this.cmdPrint.ImageList = this.imageCollection;
            this.cmdPrint.Location = new System.Drawing.Point(439, 291);
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.Size = new System.Drawing.Size(72, 22);
            this.cmdPrint.StyleController = this.lcMain;
            this.cmdPrint.TabIndex = 4;
            this.cmdPrint.Text = "&Print";
            this.cmdPrint.Click += new System.EventHandler(this.cmdPrint_Click);
            // 
            // cmdPreview
            // 
            this.cmdPreview.DefaultState = efControls.Enums.ControlState.AlwaysEnabled;
            this.cmdPreview.HighLighted = false;
            this.cmdPreview.ImageIndex = 1;
            this.cmdPreview.ImageList = this.imageCollection;
            this.cmdPreview.Location = new System.Drawing.Point(359, 291);
            this.cmdPreview.Name = "cmdPreview";
            this.cmdPreview.Size = new System.Drawing.Size(72, 22);
            this.cmdPreview.StyleController = this.lcMain;
            this.cmdPreview.TabIndex = 3;
            this.cmdPreview.Text = "Pre&view";
            this.cmdPreview.Click += new System.EventHandler(this.cmdPreview_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.DefaultState = efControls.Enums.ControlState.AlwaysEnabled;
            this.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdExit.HighLighted = true;
            this.cmdExit.ImageIndex = 0;
            this.cmdExit.ImageList = this.imageCollection;
            this.cmdExit.Location = new System.Drawing.Point(519, 291);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(72, 22);
            this.cmdExit.StyleController = this.lcMain;
            this.cmdExit.TabIndex = 5;
            this.cmdExit.Text = "E&xit";
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // lcgMain
            // 
            this.lcgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgMain.GroupBordersVisible = false;
            this.lcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciExit,
            this.lci2,
            this.lciPreview,
            this.lciPrint,
            this.lciBrowse,
            this.emptySpaceItem1,
            this.lciControlNavigator});
            this.lcgMain.Location = new System.Drawing.Point(0, 0);
            this.lcgMain.Name = "lcgMain";
            this.lcgMain.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.lcgMain.Size = new System.Drawing.Size(597, 319);
            this.lcgMain.TextVisible = false;
            // 
            // lciExit
            // 
            this.lciExit.Control = this.cmdExit;
            this.lciExit.IsRequired = null;
            this.lciExit.Location = new System.Drawing.Point(513, 285);
            this.lciExit.MaxSize = new System.Drawing.Size(80, 30);
            this.lciExit.MinSize = new System.Drawing.Size(80, 30);
            this.lciExit.Name = "lciExit";
            this.lciExit.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.lciExit.Size = new System.Drawing.Size(80, 30);
            this.lciExit.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciExit.TextSize = new System.Drawing.Size(0, 0);
            this.lciExit.TextVisible = false;
            // 
            // lci2
            // 
            this.lci2.Control = this.lcReport;
            this.lci2.IsRequired = null;
            this.lci2.Location = new System.Drawing.Point(0, 0);
            this.lci2.Name = "lci2";
            this.lci2.Size = new System.Drawing.Size(593, 285);
            this.lci2.TextSize = new System.Drawing.Size(0, 0);
            this.lci2.TextVisible = false;
            // 
            // lciPreview
            // 
            this.lciPreview.Control = this.cmdPreview;
            this.lciPreview.IsRequired = null;
            this.lciPreview.Location = new System.Drawing.Point(353, 285);
            this.lciPreview.MaxSize = new System.Drawing.Size(80, 30);
            this.lciPreview.MinSize = new System.Drawing.Size(80, 30);
            this.lciPreview.Name = "lciPreview";
            this.lciPreview.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.lciPreview.Size = new System.Drawing.Size(80, 30);
            this.lciPreview.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciPreview.TextSize = new System.Drawing.Size(0, 0);
            this.lciPreview.TextVisible = false;
            // 
            // lciPrint
            // 
            this.lciPrint.Control = this.cmdPrint;
            this.lciPrint.IsRequired = null;
            this.lciPrint.Location = new System.Drawing.Point(433, 285);
            this.lciPrint.MaxSize = new System.Drawing.Size(80, 30);
            this.lciPrint.MinSize = new System.Drawing.Size(80, 30);
            this.lciPrint.Name = "lciPrint";
            this.lciPrint.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.lciPrint.Size = new System.Drawing.Size(80, 30);
            this.lciPrint.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciPrint.TextSize = new System.Drawing.Size(0, 0);
            this.lciPrint.TextVisible = false;
            // 
            // lciBrowse
            // 
            this.lciBrowse.Control = this.cmdBrowse;
            this.lciBrowse.IsRequired = null;
            this.lciBrowse.Location = new System.Drawing.Point(273, 285);
            this.lciBrowse.MaxSize = new System.Drawing.Size(80, 30);
            this.lciBrowse.MinSize = new System.Drawing.Size(80, 30);
            this.lciBrowse.Name = "lciBrowse";
            this.lciBrowse.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.lciBrowse.Size = new System.Drawing.Size(80, 30);
            this.lciBrowse.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciBrowse.TextSize = new System.Drawing.Size(0, 0);
            this.lciBrowse.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(244, 285);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(29, 30);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciControlNavigator
            // 
            this.lciControlNavigator.Control = this.ucCtrlNavigator;
            this.lciControlNavigator.IsRequired = null;
            this.lciControlNavigator.Location = new System.Drawing.Point(0, 285);
            this.lciControlNavigator.MaxSize = new System.Drawing.Size(244, 30);
            this.lciControlNavigator.MinSize = new System.Drawing.Size(244, 30);
            this.lciControlNavigator.Name = "lciControlNavigator";
            this.lciControlNavigator.Size = new System.Drawing.Size(244, 30);
            this.lciControlNavigator.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciControlNavigator.TextSize = new System.Drawing.Size(0, 0);
            this.lciControlNavigator.TextVisible = false;
            // 
            // FormReportBase
            // 
            this.AcceptButton = this.cmdBrowse;
            this.CancelButton = this.cmdExit;
            this.ClientSize = new System.Drawing.Size(597, 319);
            this.Controls.Add(this.lcMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormReportBase";
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBrowse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciControlNavigator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public efControls.efLayoutControl lcReport;
        public DevExpress.XtraLayout.LayoutControlGroup lcgReport;
        private DevExpress.Utils.ImageCollection imageCollection;
        private efControls.efButton cmdBrowse;
        private efControls.efButton cmdPrint;
        private efControls.efButton cmdPreview;
        private efControls.efButton cmdExit;
        private efControls.lci lciExit;
        private efControls.lci lci2;
        private efControls.lci lciPreview;
        private efControls.lci lciPrint;
        private efControls.lci lciBrowse;
        public efControls.efLayoutControl lcMain;
        public DevExpress.XtraLayout.LayoutControlGroup lcgMain;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        protected efControls.ucControlNavigator ucCtrlNavigator;
        private efControls.lci lciControlNavigator;
    }
}
