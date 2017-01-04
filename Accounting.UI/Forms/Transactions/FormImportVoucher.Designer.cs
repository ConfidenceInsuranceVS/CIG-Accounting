namespace Accounting
{
    partial class FormImportVoucher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImportVoucher));
            this.lc = new efControls.efLayoutControl();
            this.cboSubCompanies = new Accounting.cboSubCompanies();
            this.btnCancel = new efControls.efButton();
            this.btnImport = new efControls.efButton();
            this.txtReference = new efControls.efTextBox();
            this.cboCompanies = new Accounting.cboCompanies();
            this.cboVoucherTypes = new Accounting.cboVoucherTypes();
            this.spnYear = new efControls.efSpinner();
            this.lcg = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciCompany = new efControls.lci();
            this.lciType = new efControls.lci();
            this.lciImport = new efControls.lci();
            this.lciCancel = new efControls.lci();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.lciReference = new efControls.lci();
            this.lciYear = new efControls.lci();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciSC = new efControls.lci();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lc)).BeginInit();
            this.lc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboSubCompanies.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReference.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCompanies.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboVoucherTypes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciReference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSC)).BeginInit();
            this.SuspendLayout();
            // 
            // lc
            // 
            this.lc.Controls.Add(this.cboSubCompanies);
            this.lc.Controls.Add(this.btnCancel);
            this.lc.Controls.Add(this.btnImport);
            this.lc.Controls.Add(this.txtReference);
            this.lc.Controls.Add(this.cboCompanies);
            this.lc.Controls.Add(this.cboVoucherTypes);
            this.lc.Controls.Add(this.spnYear);
            this.lc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lc.Location = new System.Drawing.Point(0, 0);
            this.lc.Name = "lc";
            this.lc.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(697, 63, 250, 350);
            this.lc.Root = this.lcg;
            this.lc.Size = new System.Drawing.Size(308, 145);
            this.lc.TabIndex = 18;
            this.lc.Text = "efLayoutControl1";
            // 
            // cboSubCompanies
            // 
            this.cboSubCompanies.bs = null;
            this.cboSubCompanies.DefaultState = efControls.Enums.ControlState.AlwaysEnabled;
            this.cboSubCompanies.EnterMoveNextControl = true;
            this.cboSubCompanies.Location = new System.Drawing.Point(283, 53);
            this.cboSubCompanies.Name = "cboSubCompanies";
            this.cboSubCompanies.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboSubCompanies.Properties.Name = "efComboBox";
            this.cboSubCompanies.Size = new System.Drawing.Size(20, 20);
            this.cboSubCompanies.StyleController = this.lc;
            this.cboSubCompanies.TabIndex = 18;
            // 
            // btnCancel
            // 
            this.btnCancel.DefaultState = efControls.Enums.ControlState.AlwaysEnabled;
            this.btnCancel.HighLighted = false;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageIndex = 1;
            this.btnCancel.Location = new System.Drawing.Point(155, 112);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(148, 28);
            this.btnCancel.StyleController = this.lc;
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnImport
            // 
            this.btnImport.DefaultState = efControls.Enums.ControlState.AlwaysEnabled;
            this.btnImport.HighLighted = false;
            this.btnImport.Image = ((System.Drawing.Image)(resources.GetObject("btnImport.Image")));
            this.btnImport.ImageIndex = 0;
            this.btnImport.Location = new System.Drawing.Point(5, 112);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(146, 28);
            this.btnImport.StyleController = this.lc;
            this.btnImport.TabIndex = 16;
            this.btnImport.Text = "Import";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // txtReference
            // 
            this.txtReference.AllowLeadingSpace = false;
            this.txtReference.DefaultState = efControls.Enums.ControlState.AlwaysEnabled;
            this.txtReference.DisplayType = efControls.Enums.DisplayType.Default;
            this.txtReference.EnterMoveNextControl = true;
            this.txtReference.Information = null;
            this.txtReference.Location = new System.Drawing.Point(58, 77);
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(54, 20);
            this.txtReference.StyleController = this.lc;
            this.txtReference.TabIndex = 14;
            // 
            // cboCompanies
            // 
            this.cboCompanies.DefaultState = efControls.Enums.ControlState.AlwaysEnabled;
            this.cboCompanies.EnterMoveNextControl = true;
            this.cboCompanies.Location = new System.Drawing.Point(58, 5);
            this.cboCompanies.Name = "cboCompanies";
            this.cboCompanies.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboCompanies.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboCompanies.Properties.Name = "efComboBox";
            this.cboCompanies.Size = new System.Drawing.Size(245, 20);
            this.cboCompanies.StyleController = this.lc;
            this.cboCompanies.TabIndex = 11;
            // 
            // cboVoucherTypes
            // 
            this.cboVoucherTypes.DefaultState = efControls.Enums.ControlState.AlwaysEnabled;
            this.cboVoucherTypes.EnterMoveNextControl = true;
            this.cboVoucherTypes.Filter = Accounting.cboVoucherTypes.jvFilter.JV;
            this.cboVoucherTypes.Location = new System.Drawing.Point(58, 53);
            this.cboVoucherTypes.Name = "cboVoucherTypes";
            this.cboVoucherTypes.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboVoucherTypes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboVoucherTypes.Properties.Name = "efComboBox";
            this.cboVoucherTypes.Size = new System.Drawing.Size(221, 20);
            this.cboVoucherTypes.StyleController = this.lc;
            this.cboVoucherTypes.TabIndex = 13;
            // 
            // spnYear
            // 
            this.spnYear.AllowLeadingSpace = false;
            this.spnYear.DefaultState = efControls.Enums.ControlState.AlwaysEnabled;
            this.spnYear.DisplayType = efControls.Enums.DisplayType.Default;
            this.spnYear.EditValue = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.spnYear.EnterMoveNextControl = true;
            this.spnYear.Information = null;
            this.spnYear.Location = new System.Drawing.Point(58, 29);
            this.spnYear.Name = "spnYear";
            this.spnYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spnYear.Properties.Mask.EditMask = "f0";
            this.spnYear.Properties.MaxValue = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.spnYear.Properties.MinValue = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.spnYear.Size = new System.Drawing.Size(54, 20);
            this.spnYear.StyleController = this.lc;
            this.spnYear.TabIndex = 12;
            // 
            // lcg
            // 
            this.lcg.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcg.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciCompany,
            this.lciType,
            this.lciImport,
            this.lciCancel,
            this.simpleSeparator1,
            this.lciReference,
            this.lciYear,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.lciSC});
            this.lcg.Location = new System.Drawing.Point(0, 0);
            this.lcg.Name = "Root";
            this.lcg.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.lcg.Size = new System.Drawing.Size(308, 145);
            this.lcg.TextVisible = false;
            // 
            // lciCompany
            // 
            this.lciCompany.Control = this.cboCompanies;
            this.lciCompany.IsRequired = null;
            this.lciCompany.Location = new System.Drawing.Point(0, 0);
            this.lciCompany.Name = "lciCompany";
            this.lciCompany.Size = new System.Drawing.Size(302, 24);
            this.lciCompany.Text = "Company";
            this.lciCompany.TextSize = new System.Drawing.Size(50, 13);
            // 
            // lciType
            // 
            this.lciType.Control = this.cboVoucherTypes;
            this.lciType.IsRequired = null;
            this.lciType.Location = new System.Drawing.Point(0, 48);
            this.lciType.MaxSize = new System.Drawing.Size(0, 24);
            this.lciType.MinSize = new System.Drawing.Size(107, 24);
            this.lciType.Name = "lciType";
            this.lciType.Size = new System.Drawing.Size(278, 24);
            this.lciType.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciType.Text = "Type";
            this.lciType.TextSize = new System.Drawing.Size(50, 13);
            // 
            // lciImport
            // 
            this.lciImport.Control = this.btnImport;
            this.lciImport.IsRequired = null;
            this.lciImport.Location = new System.Drawing.Point(0, 107);
            this.lciImport.MinSize = new System.Drawing.Size(45, 26);
            this.lciImport.Name = "lciImport";
            this.lciImport.Size = new System.Drawing.Size(150, 32);
            this.lciImport.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciImport.TextSize = new System.Drawing.Size(0, 0);
            this.lciImport.TextVisible = false;
            // 
            // lciCancel
            // 
            this.lciCancel.Control = this.btnCancel;
            this.lciCancel.IsRequired = null;
            this.lciCancel.Location = new System.Drawing.Point(150, 107);
            this.lciCancel.MinSize = new System.Drawing.Size(45, 26);
            this.lciCancel.Name = "lciCancel";
            this.lciCancel.Size = new System.Drawing.Size(152, 32);
            this.lciCancel.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciCancel.TextSize = new System.Drawing.Size(0, 0);
            this.lciCancel.TextVisible = false;
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.Location = new System.Drawing.Point(0, 96);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(302, 11);
            this.simpleSeparator1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 5, 5);
            // 
            // lciReference
            // 
            this.lciReference.Control = this.txtReference;
            this.lciReference.IsRequired = null;
            this.lciReference.Location = new System.Drawing.Point(0, 72);
            this.lciReference.Name = "lciReference";
            this.lciReference.Size = new System.Drawing.Size(111, 24);
            this.lciReference.Text = "Reference";
            this.lciReference.TextSize = new System.Drawing.Size(50, 13);
            // 
            // lciYear
            // 
            this.lciYear.Control = this.spnYear;
            this.lciYear.IsRequired = null;
            this.lciYear.Location = new System.Drawing.Point(0, 24);
            this.lciYear.Name = "lciYear";
            this.lciYear.Size = new System.Drawing.Size(111, 24);
            this.lciYear.Text = "Year";
            this.lciYear.TextSize = new System.Drawing.Size(50, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(111, 24);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(191, 24);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(111, 72);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(191, 24);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciSC
            // 
            this.lciSC.Control = this.cboSubCompanies;
            this.lciSC.IsRequired = null;
            this.lciSC.Location = new System.Drawing.Point(278, 48);
            this.lciSC.MaxSize = new System.Drawing.Size(0, 20);
            this.lciSC.MinSize = new System.Drawing.Size(24, 20);
            this.lciSC.Name = "lciSC";
            this.lciSC.Size = new System.Drawing.Size(24, 24);
            this.lciSC.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciSC.TextSize = new System.Drawing.Size(0, 0);
            this.lciSC.TextVisible = false;
            // 
            // FormImportVoucher
            // 
            this.ClientSize = new System.Drawing.Size(308, 145);
            this.ControlBox = false;
            this.Controls.Add(this.lc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormImportVoucher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Import Vouchers";
            this.Controls.SetChildIndex(this.lc, 0);
            this.Controls.SetChildIndex(this.lblFocus, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lc)).EndInit();
            this.lc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboSubCompanies.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReference.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCompanies.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboVoucherTypes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciReference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private cboCompanies cboCompanies;
        private efControls.efTextBox txtReference;
        private efControls.efButton btnImport;
        private efControls.efButton btnCancel;
        private efControls.efSpinner spnYear;
        private efControls.efLayoutControl lc;
        private DevExpress.XtraLayout.LayoutControlGroup lcg;
        private efControls.lci lciCompany;
        private efControls.lci lciType;
        private efControls.lci lciReference;
        private efControls.lci lciImport;
        private efControls.lci lciCancel;
        private efControls.lci lciYear;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private cboVoucherTypes cboVoucherTypes;
        private cboSubCompanies cboSubCompanies;
        private efControls.lci lciSC;
    }
}
