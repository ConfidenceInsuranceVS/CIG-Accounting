namespace efControls
{
    partial class ucEditForm
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
            this.lcEditForm = new efControls.efLayoutControl();
            this.txtDescription = new efControls.efTextBox();
            this.txtCode = new efControls.efTextBox();
            this.lcgEditform = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciCode = new efControls.lci();
            this.lciDescription = new efControls.lci();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.lcEditForm)).BeginInit();
            this.lcEditForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgEditform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // lcEditForm
            // 
            this.SetBoundPropertyName(this.lcEditForm, "");
            this.lcEditForm.Controls.Add(this.txtDescription);
            this.lcEditForm.Controls.Add(this.txtCode);
            this.lcEditForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcEditForm.Location = new System.Drawing.Point(0, 0);
            this.lcEditForm.Name = "lcEditForm";
            this.lcEditForm.Root = this.lcgEditform;
            this.lcEditForm.Size = new System.Drawing.Size(391, 69);
            this.lcEditForm.TabIndex = 0;
            this.lcEditForm.Text = "lcEditForm";
            // 
            // txtDescription
            // 
            this.txtDescription.AllowLeadingSpace = false;
            this.SetBoundFieldName(this.txtDescription, "Description");
            this.SetBoundPropertyName(this.txtDescription, "EditValue");
            this.txtDescription.DefaultState = efControls.Enums.ControlState.Default;
            this.txtDescription.DisplayType = efControls.Enums.DisplayType.Default;
            this.txtDescription.EnterMoveNextControl = true;
            this.txtDescription.Information = null;
            this.txtDescription.Location = new System.Drawing.Point(68, 36);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(311, 20);
            this.txtDescription.StyleController = this.lcEditForm;
            this.txtDescription.TabIndex = 5;
            // 
            // txtCode
            // 
            this.txtCode.AllowLeadingSpace = false;
            this.SetBoundFieldName(this.txtCode, "Code");
            this.SetBoundPropertyName(this.txtCode, "EditValue");
            this.txtCode.DefaultState = efControls.Enums.ControlState.Default;
            this.txtCode.DisplayType = efControls.Enums.DisplayType.Default;
            this.txtCode.EnterMoveNextControl = true;
            this.txtCode.Information = null;
            this.txtCode.Location = new System.Drawing.Point(68, 12);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(51, 20);
            this.txtCode.StyleController = this.lcEditForm;
            this.txtCode.TabIndex = 4;
            // 
            // lcgEditform
            // 
            this.lcgEditform.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgEditform.GroupBordersVisible = false;
            this.lcgEditform.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciCode,
            this.lciDescription,
            this.emptySpaceItem1});
            this.lcgEditform.Location = new System.Drawing.Point(0, 0);
            this.lcgEditform.Name = "lcgEditform";
            this.lcgEditform.Size = new System.Drawing.Size(391, 69);
            this.lcgEditform.TextVisible = false;
            // 
            // lciCode
            // 
            this.lciCode.Control = this.txtCode;
            this.lciCode.IsRequired = null;
            this.lciCode.Location = new System.Drawing.Point(0, 0);
            this.lciCode.Name = "lciCode";
            this.lciCode.Size = new System.Drawing.Size(111, 24);
            this.lciCode.Text = "Code";
            this.lciCode.TextSize = new System.Drawing.Size(53, 13);
            // 
            // lciDescription
            // 
            this.lciDescription.Control = this.txtDescription;
            this.lciDescription.IsRequired = null;
            this.lciDescription.Location = new System.Drawing.Point(0, 24);
            this.lciDescription.Name = "lciDescription";
            this.lciDescription.Size = new System.Drawing.Size(371, 25);
            this.lciDescription.Text = "Description";
            this.lciDescription.TextSize = new System.Drawing.Size(53, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(111, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(260, 24);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ucEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lcEditForm);
            this.Name = "ucEditForm";
            this.Size = new System.Drawing.Size(391, 69);
            ((System.ComponentModel.ISupportInitialize)(this.lcEditForm)).EndInit();
            this.lcEditForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgEditform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public efTextBox txtDescription;
        public efTextBox txtCode;
        private lci lciCode;
        private lci lciDescription;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        public efLayoutControl lcEditForm;
        public DevExpress.XtraLayout.LayoutControlGroup lcgEditform;
    }
}
