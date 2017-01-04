namespace Accounting
{
    partial class ucVoucherTypesEditForm
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
            this.txtType = new efControls.efTextBox();
            this.lciType = new efControls.lci();
            this.lciOrder = new efControls.lci();
            this.spnOrder = new efControls.efSpinner();
            this.chkJV = new efControls.efCheckBox();
            this.lciJV = new efControls.lci();
            this.chkPV = new efControls.efCheckBox();
            this.lciPV = new efControls.lci();
            this.chkCN = new efControls.efCheckBox();
            this.lciCN = new efControls.lci();
            this.chkRV = new efControls.efCheckBox();
            this.lciRV = new efControls.lci();
            this.chkDN = new efControls.efCheckBox();
            this.lciDN = new efControls.lci();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.lci1 = new efControls.lci();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcEditForm)).BeginInit();
            this.lcEditForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcgEditform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnOrder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkJV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciJV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkRV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescription
            // 
            // 
            // txtCode
            // 
            // 
            // lcEditForm
            // 
            this.lcEditForm.Controls.Add(this.separatorControl1);
            this.lcEditForm.Controls.Add(this.chkDN);
            this.lcEditForm.Controls.Add(this.chkRV);
            this.lcEditForm.Controls.Add(this.chkCN);
            this.lcEditForm.Controls.Add(this.chkPV);
            this.lcEditForm.Controls.Add(this.chkJV);
            this.lcEditForm.Controls.Add(this.txtType);
            this.lcEditForm.Controls.Add(this.spnOrder);
            this.lcEditForm.Size = new System.Drawing.Size(391, 123);
            this.lcEditForm.Controls.SetChildIndex(this.spnOrder, 0);
            this.lcEditForm.Controls.SetChildIndex(this.txtCode, 0);
            this.lcEditForm.Controls.SetChildIndex(this.txtDescription, 0);
            this.lcEditForm.Controls.SetChildIndex(this.txtType, 0);
            this.lcEditForm.Controls.SetChildIndex(this.chkJV, 0);
            this.lcEditForm.Controls.SetChildIndex(this.chkPV, 0);
            this.lcEditForm.Controls.SetChildIndex(this.chkCN, 0);
            this.lcEditForm.Controls.SetChildIndex(this.chkRV, 0);
            this.lcEditForm.Controls.SetChildIndex(this.chkDN, 0);
            this.lcEditForm.Controls.SetChildIndex(this.separatorControl1, 0);
            // 
            // lcgEditform
            // 
            this.lcgEditform.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciType,
            this.lciOrder,
            this.lciJV,
            this.lciPV,
            this.lciCN,
            this.lciRV,
            this.lciDN,
            this.lci1,
            this.emptySpaceItem1});
            this.lcgEditform.Size = new System.Drawing.Size(391, 123);
            // 
            // txtType
            // 
            this.txtType.AllowLeadingSpace = false;
            this.SetBoundFieldName(this.txtType, "Type");
            this.SetBoundPropertyName(this.txtType, "EditValue");
            this.txtType.DefaultState = efControls.Enums.ControlState.Default;
            this.txtType.DisplayType = efControls.Enums.DisplayType.Default;
            this.txtType.EnterMoveNextControl = true;
            this.txtType.Information = null;
            this.txtType.Location = new System.Drawing.Point(69, 60);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(50, 20);
            this.txtType.StyleController = this.lcEditForm;
            this.txtType.TabIndex = 6;
            // 
            // lciType
            // 
            this.lciType.Control = this.txtType;
            this.lciType.IsRequired = null;
            this.lciType.Location = new System.Drawing.Point(0, 48);
            this.lciType.MaxSize = new System.Drawing.Size(111, 24);
            this.lciType.MinSize = new System.Drawing.Size(111, 24);
            this.lciType.Name = "lciType";
            this.lciType.Size = new System.Drawing.Size(111, 24);
            this.lciType.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciType.Text = "Type";
            this.lciType.TextSize = new System.Drawing.Size(53, 13);
            // 
            // lciOrder
            // 
            this.lciOrder.Control = this.spnOrder;
            this.lciOrder.IsRequired = null;
            this.lciOrder.Location = new System.Drawing.Point(260, 48);
            this.lciOrder.MaxSize = new System.Drawing.Size(111, 24);
            this.lciOrder.MinSize = new System.Drawing.Size(111, 24);
            this.lciOrder.Name = "lciOrder";
            this.lciOrder.Size = new System.Drawing.Size(111, 24);
            this.lciOrder.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciOrder.Text = "Order";
            this.lciOrder.TextSize = new System.Drawing.Size(53, 13);
            // 
            // spnOrder
            // 
            this.spnOrder.AllowLeadingSpace = false;
            this.SetBoundFieldName(this.spnOrder, "OrderID");
            this.SetBoundPropertyName(this.spnOrder, "EditValue");
            this.spnOrder.DefaultState = efControls.Enums.ControlState.Default;
            this.spnOrder.DisplayType = efControls.Enums.DisplayType.Default;
            this.spnOrder.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnOrder.EnterMoveNextControl = true;
            this.spnOrder.Information = null;
            this.spnOrder.Location = new System.Drawing.Point(329, 60);
            this.spnOrder.Name = "spnOrder";
            this.spnOrder.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spnOrder.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.spnOrder.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.spnOrder.Size = new System.Drawing.Size(50, 20);
            this.spnOrder.StyleController = this.lcEditForm;
            this.spnOrder.TabIndex = 7;
            // 
            // chkJV
            // 
            this.SetBoundFieldName(this.chkJV, "JV");
            this.SetBoundPropertyName(this.chkJV, "EditValue");
            this.chkJV.DefaultState = efControls.Enums.ControlState.Default;
            this.chkJV.EnterMoveNextControl = true;
            this.chkJV.HighLighted = false;
            this.chkJV.Location = new System.Drawing.Point(12, 92);
            this.chkJV.Name = "chkJV";
            this.chkJV.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.chkJV.Properties.Appearance.Options.UseBackColor = true;
            this.chkJV.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Transparent;
            this.chkJV.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.chkJV.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Transparent;
            this.chkJV.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.chkJV.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Transparent;
            this.chkJV.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.chkJV.Properties.Caption = "JV";
            this.chkJV.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.chkJV.Size = new System.Drawing.Size(70, 19);
            this.chkJV.StyleController = this.lcEditForm;
            this.chkJV.TabIndex = 8;
            this.chkJV.ValueType = efControls.Enums.ValueType.Boolean;
            // 
            // lciJV
            // 
            this.lciJV.Control = this.chkJV;
            this.lciJV.IsRequired = null;
            this.lciJV.Location = new System.Drawing.Point(0, 80);
            this.lciJV.Name = "lciJV";
            this.lciJV.Size = new System.Drawing.Size(74, 23);
            this.lciJV.TextSize = new System.Drawing.Size(0, 0);
            this.lciJV.TextVisible = false;
            // 
            // chkPV
            // 
            this.SetBoundFieldName(this.chkPV, "PV");
            this.SetBoundPropertyName(this.chkPV, "EditValue");
            this.chkPV.DefaultState = efControls.Enums.ControlState.Default;
            this.chkPV.EnterMoveNextControl = true;
            this.chkPV.HighLighted = false;
            this.chkPV.Location = new System.Drawing.Point(161, 92);
            this.chkPV.Name = "chkPV";
            this.chkPV.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.chkPV.Properties.Appearance.Options.UseBackColor = true;
            this.chkPV.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Transparent;
            this.chkPV.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.chkPV.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Transparent;
            this.chkPV.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.chkPV.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Transparent;
            this.chkPV.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.chkPV.Properties.Caption = "PV";
            this.chkPV.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.chkPV.Size = new System.Drawing.Size(69, 19);
            this.chkPV.StyleController = this.lcEditForm;
            this.chkPV.TabIndex = 9;
            this.chkPV.ValueType = efControls.Enums.ValueType.Boolean;
            // 
            // lciPV
            // 
            this.lciPV.Control = this.chkPV;
            this.lciPV.IsRequired = null;
            this.lciPV.Location = new System.Drawing.Point(149, 80);
            this.lciPV.Name = "lciPV";
            this.lciPV.Size = new System.Drawing.Size(73, 23);
            this.lciPV.TextSize = new System.Drawing.Size(0, 0);
            this.lciPV.TextVisible = false;
            // 
            // chkCN
            // 
            this.SetBoundFieldName(this.chkCN, "CN");
            this.SetBoundPropertyName(this.chkCN, "EditValue");
            this.chkCN.DefaultState = efControls.Enums.ControlState.Default;
            this.chkCN.EnterMoveNextControl = true;
            this.chkCN.HighLighted = false;
            this.chkCN.Location = new System.Drawing.Point(234, 92);
            this.chkCN.Name = "chkCN";
            this.chkCN.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.chkCN.Properties.Appearance.Options.UseBackColor = true;
            this.chkCN.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Transparent;
            this.chkCN.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.chkCN.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Transparent;
            this.chkCN.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.chkCN.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Transparent;
            this.chkCN.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.chkCN.Properties.Caption = "CN";
            this.chkCN.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.chkCN.Size = new System.Drawing.Size(70, 19);
            this.chkCN.StyleController = this.lcEditForm;
            this.chkCN.TabIndex = 10;
            this.chkCN.ValueType = efControls.Enums.ValueType.Boolean;
            // 
            // lciCN
            // 
            this.lciCN.Control = this.chkCN;
            this.lciCN.IsRequired = null;
            this.lciCN.Location = new System.Drawing.Point(222, 80);
            this.lciCN.Name = "lciCN";
            this.lciCN.Size = new System.Drawing.Size(74, 23);
            this.lciCN.TextSize = new System.Drawing.Size(0, 0);
            this.lciCN.TextVisible = false;
            // 
            // chkRV
            // 
            this.SetBoundFieldName(this.chkRV, "RV");
            this.SetBoundPropertyName(this.chkRV, "EditValue");
            this.chkRV.DefaultState = efControls.Enums.ControlState.Default;
            this.chkRV.EnterMoveNextControl = true;
            this.chkRV.HighLighted = false;
            this.chkRV.Location = new System.Drawing.Point(86, 92);
            this.chkRV.Name = "chkRV";
            this.chkRV.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.chkRV.Properties.Appearance.Options.UseBackColor = true;
            this.chkRV.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Transparent;
            this.chkRV.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.chkRV.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Transparent;
            this.chkRV.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.chkRV.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Transparent;
            this.chkRV.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.chkRV.Properties.Caption = "RV";
            this.chkRV.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.chkRV.Size = new System.Drawing.Size(71, 19);
            this.chkRV.StyleController = this.lcEditForm;
            this.chkRV.TabIndex = 11;
            this.chkRV.ValueType = efControls.Enums.ValueType.Boolean;
            // 
            // lciRV
            // 
            this.lciRV.Control = this.chkRV;
            this.lciRV.IsRequired = null;
            this.lciRV.Location = new System.Drawing.Point(74, 80);
            this.lciRV.Name = "lciRV";
            this.lciRV.Size = new System.Drawing.Size(75, 23);
            this.lciRV.TextSize = new System.Drawing.Size(0, 0);
            this.lciRV.TextVisible = false;
            // 
            // chkDN
            // 
            this.SetBoundFieldName(this.chkDN, "DN");
            this.SetBoundPropertyName(this.chkDN, "EditValue");
            this.chkDN.DefaultState = efControls.Enums.ControlState.Default;
            this.chkDN.EnterMoveNextControl = true;
            this.chkDN.HighLighted = false;
            this.chkDN.Location = new System.Drawing.Point(308, 92);
            this.chkDN.Name = "chkDN";
            this.chkDN.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.chkDN.Properties.Appearance.Options.UseBackColor = true;
            this.chkDN.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Transparent;
            this.chkDN.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.chkDN.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Transparent;
            this.chkDN.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.chkDN.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Transparent;
            this.chkDN.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.chkDN.Properties.Caption = "DN";
            this.chkDN.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.chkDN.Size = new System.Drawing.Size(71, 19);
            this.chkDN.StyleController = this.lcEditForm;
            this.chkDN.TabIndex = 12;
            this.chkDN.ValueType = efControls.Enums.ValueType.Boolean;
            // 
            // lciDN
            // 
            this.lciDN.Control = this.chkDN;
            this.lciDN.IsRequired = null;
            this.lciDN.Location = new System.Drawing.Point(296, 80);
            this.lciDN.Name = "lciDN";
            this.lciDN.Size = new System.Drawing.Size(75, 23);
            this.lciDN.TextSize = new System.Drawing.Size(0, 0);
            this.lciDN.TextVisible = false;
            // 
            // separatorControl1
            // 
            this.SetBoundPropertyName(this.separatorControl1, "");
            this.separatorControl1.Location = new System.Drawing.Point(12, 84);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(367, 4);
            this.separatorControl1.TabIndex = 13;
            // 
            // lci1
            // 
            this.lci1.Control = this.separatorControl1;
            this.lci1.IsRequired = null;
            this.lci1.Location = new System.Drawing.Point(0, 72);
            this.lci1.MinSize = new System.Drawing.Size(104, 8);
            this.lci1.Name = "lci1";
            this.lci1.Size = new System.Drawing.Size(371, 8);
            this.lci1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lci1.TextSize = new System.Drawing.Size(0, 0);
            this.lci1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(111, 48);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(149, 24);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ucVoucherTypesEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "ucVoucherTypesEditForm";
            this.Size = new System.Drawing.Size(391, 123);
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcEditForm)).EndInit();
            this.lcEditForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcgEditform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnOrder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkJV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciJV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkRV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private efControls.efTextBox txtType;
        private efControls.lci lciType;
        private efControls.lci lciOrder;
        private efControls.efCheckBox chkDN;
        private efControls.efCheckBox chkRV;
        private efControls.efCheckBox chkCN;
        private efControls.efCheckBox chkPV;
        private efControls.efCheckBox chkJV;
        private efControls.lci lciJV;
        private efControls.lci lciPV;
        private efControls.lci lciCN;
        private efControls.lci lciRV;
        private efControls.lci lciDN;
        private efControls.efSpinner spnOrder;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private efControls.lci lci1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}
