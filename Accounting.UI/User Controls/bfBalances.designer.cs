namespace Accounting
{
    partial class bfBalances
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
            this.fp = new DevExpress.Utils.FlyoutPanel();
            this.fpc = new DevExpress.Utils.FlyoutPanelControl();
            this.lbl2nd = new efControls.efLabel();
            this.txtBalanceCurrency = new efControls.efTextBox();
            this.txtBalance2ndLocal = new efControls.efTextBox();
            this.lbl1st = new efControls.efLabel();
            this.txtBalance1stLocal = new efControls.efTextBox();
            this.lblCurrency = new efControls.efLabel();
            ((System.ComponentModel.ISupportInitialize)(this.fp)).BeginInit();
            this.fp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fpc)).BeginInit();
            this.fpc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBalanceCurrency.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBalance2ndLocal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBalance1stLocal.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fp
            // 
            this.fp.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.fp.Appearance.Options.UseBackColor = true;
            this.fp.Controls.Add(this.fpc);
            this.fp.Location = new System.Drawing.Point(3, 3);
            this.fp.Name = "fp";
            this.fp.Options.AnimationType = DevExpress.Utils.Win.PopupToolWindowAnimation.Fade;
            this.fp.OptionsBeakPanel.BackColor = System.Drawing.SystemColors.Control;
            this.fp.OptionsButtonPanel.AppearanceButton.Normal.BackColor = System.Drawing.Color.Transparent;
            this.fp.OptionsButtonPanel.AppearanceButton.Normal.Options.UseBackColor = true;
            this.fp.OwnerControl = this;
            this.fp.Size = new System.Drawing.Size(180, 78);
            this.fp.TabIndex = 3;
            // 
            // fpc
            // 
            this.fpc.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.fpc.Appearance.Options.UseBackColor = true;
            this.fpc.AutoSize = true;
            this.fpc.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.fpc.Controls.Add(this.lbl2nd);
            this.fpc.Controls.Add(this.txtBalanceCurrency);
            this.fpc.Controls.Add(this.txtBalance2ndLocal);
            this.fpc.Controls.Add(this.lbl1st);
            this.fpc.Controls.Add(this.txtBalance1stLocal);
            this.fpc.Controls.Add(this.lblCurrency);
            this.fpc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpc.FlyoutPanel = this.fp;
            this.fpc.Location = new System.Drawing.Point(0, 0);
            this.fpc.Name = "fpc";
            this.fpc.Padding = new System.Windows.Forms.Padding(5);
            this.fpc.Size = new System.Drawing.Size(180, 78);
            this.fpc.TabIndex = 0;
            // 
            // lbl2nd
            // 
            this.lbl2nd.DefaultState = efControls.Enums.ControlState.Default;
            this.lbl2nd.HtmlLook = false;
            this.lbl2nd.Location = new System.Drawing.Point(11, 54);
            this.lbl2nd.Name = "lbl2nd";
            this.lbl2nd.Size = new System.Drawing.Size(45, 13);
            this.lbl2nd.TabIndex = 57;
            this.lbl2nd.Text = "2nd Local";
            // 
            // txtBalanceCurrency
            // 
            this.txtBalanceCurrency.AllowLeadingSpace = false;
            this.txtBalanceCurrency.DefaultState = efControls.Enums.ControlState.AlwaysDisabled;
            this.txtBalanceCurrency.DisplayType = efControls.Enums.DisplayType.Numeric;
            this.txtBalanceCurrency.EnterMoveNextControl = true;
            this.txtBalanceCurrency.Information = null;
            this.txtBalanceCurrency.Location = new System.Drawing.Point(64, 8);
            this.txtBalanceCurrency.Name = "txtBalanceCurrency";
            this.txtBalanceCurrency.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7F);
            this.txtBalanceCurrency.Properties.Appearance.Options.UseFont = true;
            this.txtBalanceCurrency.Properties.Appearance.Options.UseTextOptions = true;
            this.txtBalanceCurrency.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtBalanceCurrency.Properties.DisplayFormat.FormatString = "{0:#,#0.00;;\"\"}";
            this.txtBalanceCurrency.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtBalanceCurrency.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtBalanceCurrency.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtBalanceCurrency.Size = new System.Drawing.Size(106, 18);
            this.txtBalanceCurrency.TabIndex = 52;
            // 
            // txtBalance2ndLocal
            // 
            this.txtBalance2ndLocal.AllowLeadingSpace = false;
            this.txtBalance2ndLocal.DefaultState = efControls.Enums.ControlState.AlwaysDisabled;
            this.txtBalance2ndLocal.DisplayType = efControls.Enums.DisplayType.Numeric;
            this.txtBalance2ndLocal.EnterMoveNextControl = true;
            this.txtBalance2ndLocal.Information = null;
            this.txtBalance2ndLocal.Location = new System.Drawing.Point(64, 52);
            this.txtBalance2ndLocal.Name = "txtBalance2ndLocal";
            this.txtBalance2ndLocal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7F);
            this.txtBalance2ndLocal.Properties.Appearance.Options.UseFont = true;
            this.txtBalance2ndLocal.Properties.Appearance.Options.UseTextOptions = true;
            this.txtBalance2ndLocal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtBalance2ndLocal.Properties.DisplayFormat.FormatString = "{0:#,#0.00;;\"\"}";
            this.txtBalance2ndLocal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtBalance2ndLocal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtBalance2ndLocal.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtBalance2ndLocal.Size = new System.Drawing.Size(106, 18);
            this.txtBalance2ndLocal.TabIndex = 54;
            // 
            // lbl1st
            // 
            this.lbl1st.DefaultState = efControls.Enums.ControlState.Default;
            this.lbl1st.HtmlLook = false;
            this.lbl1st.Location = new System.Drawing.Point(11, 32);
            this.lbl1st.Name = "lbl1st";
            this.lbl1st.Size = new System.Drawing.Size(42, 13);
            this.lbl1st.TabIndex = 56;
            this.lbl1st.Text = "1st Local";
            // 
            // txtBalance1stLocal
            // 
            this.txtBalance1stLocal.AllowLeadingSpace = false;
            this.txtBalance1stLocal.DefaultState = efControls.Enums.ControlState.AlwaysDisabled;
            this.txtBalance1stLocal.DisplayType = efControls.Enums.DisplayType.Numeric;
            this.txtBalance1stLocal.EnterMoveNextControl = true;
            this.txtBalance1stLocal.Information = null;
            this.txtBalance1stLocal.Location = new System.Drawing.Point(64, 30);
            this.txtBalance1stLocal.Name = "txtBalance1stLocal";
            this.txtBalance1stLocal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7F);
            this.txtBalance1stLocal.Properties.Appearance.Options.UseFont = true;
            this.txtBalance1stLocal.Properties.Appearance.Options.UseTextOptions = true;
            this.txtBalance1stLocal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtBalance1stLocal.Properties.DisplayFormat.FormatString = "{0:#,#0.00;;\"\"}";
            this.txtBalance1stLocal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtBalance1stLocal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtBalance1stLocal.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtBalance1stLocal.Size = new System.Drawing.Size(106, 18);
            this.txtBalance1stLocal.TabIndex = 53;
            // 
            // lblCurrency
            // 
            this.lblCurrency.DefaultState = efControls.Enums.ControlState.Default;
            this.lblCurrency.HtmlLook = false;
            this.lblCurrency.Location = new System.Drawing.Point(11, 10);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(44, 13);
            this.lblCurrency.TabIndex = 55;
            this.lblCurrency.Text = "Currency";
            // 
            // bfBalances
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fp);
            this.Name = "bfBalances";
            this.Size = new System.Drawing.Size(186, 85);
            ((System.ComponentModel.ISupportInitialize)(this.fp)).EndInit();
            this.fp.ResumeLayout(false);
            this.fp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fpc)).EndInit();
            this.fpc.ResumeLayout(false);
            this.fpc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBalanceCurrency.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBalance2ndLocal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBalance1stLocal.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.Utils.FlyoutPanel fp;
        public DevExpress.Utils.FlyoutPanelControl fpc;
        private efControls.efLabel lbl2nd;
        private efControls.efLabel lbl1st;
        private efControls.efLabel lblCurrency;
        public efControls.efTextBox txtBalance2ndLocal;
        public efControls.efTextBox txtBalance1stLocal;
        public efControls.efTextBox txtBalanceCurrency;


    }
}
