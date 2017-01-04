namespace Accounting
{
    partial class FormPostUnpost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPostUnpost));
            this.lcMain = new efControls.efLayoutControl();
            this.btnClose = new efControls.efButton();
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.btnUnPost = new efControls.efButton();
            this.btnPost = new efControls.efButton();
            this.txtToReference = new efControls.efTextBox();
            this.txtFromReference = new efControls.efTextBox();
            this.deTo = new efControls.efDateEdit();
            this.deFrom = new efControls.efDateEdit();
            this.lcgMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciFromDate = new efControls.lci();
            this.lciToDate = new efControls.lci();
            this.lciFromRef = new efControls.lci();
            this.lciToReference = new efControls.lci();
            this.lciPost = new efControls.lci();
            this.lciUnpost = new efControls.lci();
            this.lciClose = new efControls.lci();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.simpleSeparator2 = new DevExpress.XtraLayout.SimpleSeparator();
            this.simpleSeparator3 = new DevExpress.XtraLayout.SimpleSeparator();
            this.cboSubCompanies = new Accounting.cboSubCompanies();
            this.cboVoucherTypes = new Accounting.cboVoucherTypes();
            this.lciVoucherTypes = new efControls.lci();
            this.lciSubCompany = new efControls.lci();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToReference.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFromReference.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFromDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciToDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFromRef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciToReference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUnpost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSubCompanies.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboVoucherTypes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciVoucherTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSubCompany)).BeginInit();
            this.SuspendLayout();
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.cboSubCompanies);
            this.lcMain.Controls.Add(this.btnClose);
            this.lcMain.Controls.Add(this.btnUnPost);
            this.lcMain.Controls.Add(this.btnPost);
            this.lcMain.Controls.Add(this.txtToReference);
            this.lcMain.Controls.Add(this.txtFromReference);
            this.lcMain.Controls.Add(this.deTo);
            this.lcMain.Controls.Add(this.deFrom);
            this.lcMain.Controls.Add(this.cboVoucherTypes);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 0);
            this.lcMain.Name = "lcMain";
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1083, 198, 250, 350);
            this.lcMain.Root = this.lcgMain;
            this.lcMain.Size = new System.Drawing.Size(380, 128);
            this.lcMain.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.DefaultState = efControls.Enums.ControlState.Default;
            this.btnClose.HighLighted = false;
            this.btnClose.ImageIndex = 3;
            this.btnClose.ImageList = this.imageCollection;
            this.btnClose.Location = new System.Drawing.Point(252, 87);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(116, 28);
            this.btnClose.StyleController = this.lcMain;
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.InsertGalleryImage("loadfrom_16x16.png", "office2013/actions/loadfrom_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/loadfrom_16x16.png"), 3);
            this.imageCollection.Images.SetKeyName(3, "loadfrom_16x16.png");
            // 
            // btnUnPost
            // 
            this.btnUnPost.DefaultState = efControls.Enums.ControlState.Default;
            this.btnUnPost.HighLighted = false;
            this.btnUnPost.ImageIndex = 2;
            this.btnUnPost.ImageList = this.imageCollection;
            this.btnUnPost.Location = new System.Drawing.Point(132, 87);
            this.btnUnPost.Name = "btnUnPost";
            this.btnUnPost.Size = new System.Drawing.Size(116, 28);
            this.btnUnPost.StyleController = this.lcMain;
            this.btnUnPost.TabIndex = 10;
            this.btnUnPost.Text = "&UnPost";
            this.btnUnPost.Click += new System.EventHandler(this.btnUnPost_Click);
            // 
            // btnPost
            // 
            this.btnPost.DefaultState = efControls.Enums.ControlState.Default;
            this.btnPost.HighLighted = false;
            this.btnPost.ImageIndex = 1;
            this.btnPost.ImageList = this.imageCollection;
            this.btnPost.Location = new System.Drawing.Point(12, 87);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(116, 28);
            this.btnPost.StyleController = this.lcMain;
            this.btnPost.TabIndex = 9;
            this.btnPost.Text = "&Post";
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // txtToReference
            // 
            this.txtToReference.AllowLeadingSpace = false;
            this.txtToReference.DefaultState = efControls.Enums.ControlState.Default;
            this.txtToReference.DisplayType = efControls.Enums.DisplayType.Integer;
            this.txtToReference.EnterMoveNextControl = true;
            this.txtToReference.Information = null;
            this.txtToReference.Location = new System.Drawing.Point(272, 62);
            this.txtToReference.Name = "txtToReference";
            this.txtToReference.Properties.Appearance.Options.UseTextOptions = true;
            this.txtToReference.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtToReference.Properties.Mask.EditMask = "f0";
            this.txtToReference.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtToReference.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtToReference.Size = new System.Drawing.Size(96, 20);
            this.txtToReference.StyleController = this.lcMain;
            this.txtToReference.TabIndex = 8;
            this.txtToReference.Validating += new System.ComponentModel.CancelEventHandler(this.txtToReference_Validating);
            // 
            // txtFromReference
            // 
            this.txtFromReference.AllowLeadingSpace = false;
            this.txtFromReference.DefaultState = efControls.Enums.ControlState.Default;
            this.txtFromReference.DisplayType = efControls.Enums.DisplayType.Integer;
            this.txtFromReference.EnterMoveNextControl = true;
            this.txtFromReference.Information = null;
            this.txtFromReference.Location = new System.Drawing.Point(92, 62);
            this.txtFromReference.Name = "txtFromReference";
            this.txtFromReference.Properties.Appearance.Options.UseTextOptions = true;
            this.txtFromReference.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtFromReference.Properties.Mask.EditMask = "f0";
            this.txtFromReference.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtFromReference.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtFromReference.Size = new System.Drawing.Size(96, 20);
            this.txtFromReference.StyleController = this.lcMain;
            this.txtFromReference.TabIndex = 7;
            this.txtFromReference.Validated += new System.EventHandler(this.txtFromReference_Validated);
            // 
            // deTo
            // 
            this.deTo.AllowLeadingSpace = false;
            this.deTo.DefaultState = efControls.Enums.ControlState.Default;
            this.deTo.DisplayType = efControls.Enums.DisplayType.Default;
            this.deTo.EditValue = null;
            this.deTo.EnterMoveNextControl = true;
            this.deTo.Information = null;
            this.deTo.Location = new System.Drawing.Point(272, 37);
            this.deTo.Name = "deTo";
            this.deTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deTo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.deTo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.deTo.Size = new System.Drawing.Size(96, 20);
            this.deTo.StyleController = this.lcMain;
            this.deTo.TabIndex = 6;
            this.deTo.Validating += new System.ComponentModel.CancelEventHandler(this.deTo_Validating);
            // 
            // deFrom
            // 
            this.deFrom.AllowLeadingSpace = false;
            this.deFrom.DefaultState = efControls.Enums.ControlState.Default;
            this.deFrom.DisplayType = efControls.Enums.DisplayType.Default;
            this.deFrom.EditValue = null;
            this.deFrom.EnterMoveNextControl = true;
            this.deFrom.Information = null;
            this.deFrom.Location = new System.Drawing.Point(92, 37);
            this.deFrom.Name = "deFrom";
            this.deFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFrom.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.deFrom.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.deFrom.Size = new System.Drawing.Size(96, 20);
            this.deFrom.StyleController = this.lcMain;
            this.deFrom.TabIndex = 5;
            this.deFrom.Validated += new System.EventHandler(this.deFrom_Validated);
            // 
            // lcgMain
            // 
            this.lcgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgMain.GroupBordersVisible = false;
            this.lcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciVoucherTypes,
            this.lciFromDate,
            this.lciToDate,
            this.lciFromRef,
            this.lciToReference,
            this.lciPost,
            this.lciUnpost,
            this.lciClose,
            this.simpleSeparator1,
            this.simpleSeparator2,
            this.simpleSeparator3,
            this.lciSubCompany});
            this.lcgMain.Location = new System.Drawing.Point(0, 0);
            this.lcgMain.Name = "Root";
            this.lcgMain.Size = new System.Drawing.Size(380, 128);
            this.lcgMain.TextVisible = false;
            // 
            // lciFromDate
            // 
            this.lciFromDate.Control = this.deFrom;
            this.lciFromDate.IsRequired = null;
            this.lciFromDate.Location = new System.Drawing.Point(0, 25);
            this.lciFromDate.Name = "lciFromDate";
            this.lciFromDate.Size = new System.Drawing.Size(180, 24);
            this.lciFromDate.Text = "From Date";
            this.lciFromDate.TextSize = new System.Drawing.Size(77, 13);
            // 
            // lciToDate
            // 
            this.lciToDate.Control = this.deTo;
            this.lciToDate.IsRequired = null;
            this.lciToDate.Location = new System.Drawing.Point(180, 25);
            this.lciToDate.Name = "lciToDate";
            this.lciToDate.Size = new System.Drawing.Size(180, 24);
            this.lciToDate.Text = "To Date";
            this.lciToDate.TextSize = new System.Drawing.Size(77, 13);
            // 
            // lciFromRef
            // 
            this.lciFromRef.Control = this.txtFromReference;
            this.lciFromRef.IsRequired = null;
            this.lciFromRef.Location = new System.Drawing.Point(0, 50);
            this.lciFromRef.Name = "lciFromRef";
            this.lciFromRef.Size = new System.Drawing.Size(180, 24);
            this.lciFromRef.Text = "From Reference";
            this.lciFromRef.TextSize = new System.Drawing.Size(77, 13);
            // 
            // lciToReference
            // 
            this.lciToReference.Control = this.txtToReference;
            this.lciToReference.IsRequired = null;
            this.lciToReference.Location = new System.Drawing.Point(180, 50);
            this.lciToReference.Name = "lciToReference";
            this.lciToReference.Size = new System.Drawing.Size(180, 24);
            this.lciToReference.Text = "To Reference";
            this.lciToReference.TextSize = new System.Drawing.Size(77, 13);
            // 
            // lciPost
            // 
            this.lciPost.Control = this.btnPost;
            this.lciPost.IsRequired = null;
            this.lciPost.Location = new System.Drawing.Point(0, 75);
            this.lciPost.MaxSize = new System.Drawing.Size(0, 32);
            this.lciPost.MinSize = new System.Drawing.Size(58, 32);
            this.lciPost.Name = "lciPost";
            this.lciPost.Size = new System.Drawing.Size(120, 33);
            this.lciPost.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciPost.TextSize = new System.Drawing.Size(0, 0);
            this.lciPost.TextVisible = false;
            // 
            // lciUnpost
            // 
            this.lciUnpost.Control = this.btnUnPost;
            this.lciUnpost.IsRequired = null;
            this.lciUnpost.Location = new System.Drawing.Point(120, 75);
            this.lciUnpost.MaxSize = new System.Drawing.Size(0, 32);
            this.lciUnpost.MinSize = new System.Drawing.Size(71, 32);
            this.lciUnpost.Name = "lciUnpost";
            this.lciUnpost.Size = new System.Drawing.Size(120, 33);
            this.lciUnpost.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciUnpost.TextSize = new System.Drawing.Size(0, 0);
            this.lciUnpost.TextVisible = false;
            // 
            // lciClose
            // 
            this.lciClose.Control = this.btnClose;
            this.lciClose.IsRequired = null;
            this.lciClose.Location = new System.Drawing.Point(240, 75);
            this.lciClose.MaxSize = new System.Drawing.Size(0, 32);
            this.lciClose.MinSize = new System.Drawing.Size(56, 32);
            this.lciClose.Name = "lciClose";
            this.lciClose.Size = new System.Drawing.Size(120, 33);
            this.lciClose.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciClose.TextSize = new System.Drawing.Size(0, 0);
            this.lciClose.TextVisible = false;
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.Location = new System.Drawing.Point(0, 24);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(360, 1);
            // 
            // simpleSeparator2
            // 
            this.simpleSeparator2.AllowHotTrack = false;
            this.simpleSeparator2.Location = new System.Drawing.Point(0, 49);
            this.simpleSeparator2.Name = "simpleSeparator2";
            this.simpleSeparator2.Size = new System.Drawing.Size(360, 1);
            // 
            // simpleSeparator3
            // 
            this.simpleSeparator3.AllowHotTrack = false;
            this.simpleSeparator3.Location = new System.Drawing.Point(0, 74);
            this.simpleSeparator3.Name = "simpleSeparator3";
            this.simpleSeparator3.Size = new System.Drawing.Size(360, 1);
            // 
            // cboSubCompanies
            // 
            this.cboSubCompanies.bs = null;
            this.cboSubCompanies.DefaultState = efControls.Enums.ControlState.AlwaysEnabled;
            this.cboSubCompanies.EnterMoveNextControl = true;
            this.cboSubCompanies.Location = new System.Drawing.Point(347, 12);
            this.cboSubCompanies.Name = "cboSubCompanies";
            this.cboSubCompanies.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboSubCompanies.Properties.Name = "efComboBox";
            this.cboSubCompanies.Size = new System.Drawing.Size(21, 20);
            this.cboSubCompanies.StyleController = this.lcMain;
            this.cboSubCompanies.TabIndex = 12;
            // 
            // cboVoucherTypes
            // 
            this.cboVoucherTypes.DefaultState = efControls.Enums.ControlState.AlwaysEnabled;
            this.cboVoucherTypes.EnterMoveNextControl = true;
            this.cboVoucherTypes.Filter = Accounting.cboVoucherTypes.jvFilter.JV;
            this.cboVoucherTypes.Location = new System.Drawing.Point(92, 12);
            this.cboVoucherTypes.Name = "cboVoucherTypes";
            this.cboVoucherTypes.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboVoucherTypes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboVoucherTypes.Properties.Name = "efComboBox";
            this.cboVoucherTypes.Size = new System.Drawing.Size(251, 20);
            this.cboVoucherTypes.StyleController = this.lcMain;
            this.cboVoucherTypes.TabIndex = 4;
            // 
            // lciVoucherTypes
            // 
            this.lciVoucherTypes.Control = this.cboVoucherTypes;
            this.lciVoucherTypes.IsRequired = null;
            this.lciVoucherTypes.Location = new System.Drawing.Point(0, 0);
            this.lciVoucherTypes.Name = "lciVoucherTypes";
            this.lciVoucherTypes.Size = new System.Drawing.Size(335, 24);
            this.lciVoucherTypes.Text = "Voucher Type";
            this.lciVoucherTypes.TextSize = new System.Drawing.Size(77, 13);
            // 
            // lciSubCompany
            // 
            this.lciSubCompany.Control = this.cboSubCompanies;
            this.lciSubCompany.IsRequired = null;
            this.lciSubCompany.Location = new System.Drawing.Point(335, 0);
            this.lciSubCompany.MaxSize = new System.Drawing.Size(0, 24);
            this.lciSubCompany.MinSize = new System.Drawing.Size(25, 24);
            this.lciSubCompany.Name = "lciSubCompany";
            this.lciSubCompany.Size = new System.Drawing.Size(25, 24);
            this.lciSubCompany.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciSubCompany.TextSize = new System.Drawing.Size(0, 0);
            this.lciSubCompany.TextVisible = false;
            // 
            // FormPostUnpost
            // 
            this.ClientSize = new System.Drawing.Size(380, 128);
            this.Controls.Add(this.lcMain);
            this.Name = "FormPostUnpost";
            this.Text = "Posting/UnPosting Vouchers";
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToReference.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFromReference.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFromDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciToDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFromRef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciToReference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUnpost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSubCompanies.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboVoucherTypes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciVoucherTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSubCompany)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private efControls.efLayoutControl lcMain;
        private efControls.efButton btnClose;
        private DevExpress.Utils.ImageCollection imageCollection;
        private efControls.efButton btnUnPost;
        private efControls.efButton btnPost;
        private efControls.efTextBox txtToReference;
        private efControls.efTextBox txtFromReference;
        private efControls.efDateEdit deTo;
        private efControls.efDateEdit deFrom;
        private cboVoucherTypes cboVoucherTypes;
        private DevExpress.XtraLayout.LayoutControlGroup lcgMain;
        private efControls.lci lciVoucherTypes;
        private efControls.lci lciFromDate;
        private efControls.lci lciToDate;
        private efControls.lci lciFromRef;
        private efControls.lci lciToReference;
        private efControls.lci lciPost;
        private efControls.lci lciUnpost;
        private efControls.lci lciClose;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator2;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator3;
        private cboSubCompanies cboSubCompanies;
        private efControls.lci lciSubCompany;
    }
}
