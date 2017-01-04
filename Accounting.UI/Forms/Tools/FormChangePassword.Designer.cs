namespace Accounting
{
    partial class FormChangePassword
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
            this.txtOldPassword = new efControls.efTextBox();
            this.lcMain = new efControls.efLayoutControl();
            this.btnClose = new efControls.efButton();
            this.txtConfirmPassword = new efControls.efTextBox();
            this.btnSave = new efControls.efButton();
            this.txtNewPassword = new efControls.efTextBox();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciOld = new efControls.lci();
            this.lciNew = new efControls.lci();
            this.lciConfirm = new efControls.lci();
            this.efLayoutControlItem4 = new efControls.lci();
            this.efLayoutControlItem5 = new efControls.lci();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirmPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciOld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciConfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.efLayoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.efLayoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.AllowLeadingSpace = false;
            this.txtOldPassword.DefaultState = efControls.Enums.ControlState.Default;
            this.txtOldPassword.DisplayType = efControls.Enums.DisplayType.Default;
            this.txtOldPassword.EnterMoveNextControl = true;
            this.txtOldPassword.Information = null;
            this.txtOldPassword.Location = new System.Drawing.Point(101, 12);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Properties.NullValuePrompt = "Enter Old Password";
            this.txtOldPassword.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtOldPassword.Properties.UseSystemPasswordChar = true;
            this.txtOldPassword.Size = new System.Drawing.Size(133, 20);
            this.txtOldPassword.StyleController = this.lcMain;
            this.txtOldPassword.TabIndex = 0;
            this.txtOldPassword.ToolTip = "Enter Old Password";
            this.txtOldPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtOldPassword_Validating);
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.btnClose);
            this.lcMain.Controls.Add(this.txtConfirmPassword);
            this.lcMain.Controls.Add(this.btnSave);
            this.lcMain.Controls.Add(this.txtNewPassword);
            this.lcMain.Controls.Add(this.txtOldPassword);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 0);
            this.lcMain.Name = "lcMain";
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(501, 316, 250, 350);
            this.lcMain.Root = this.layoutControlGroup1;
            this.lcMain.Size = new System.Drawing.Size(246, 124);
            this.lcMain.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.DefaultState = efControls.Enums.ControlState.Default;
            this.btnClose.HighLighted = false;
            this.btnClose.Location = new System.Drawing.Point(125, 84);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(109, 28);
            this.btnClose.StyleController = this.lcMain;
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.efButton2_Click);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.AllowLeadingSpace = false;
            this.txtConfirmPassword.DefaultState = efControls.Enums.ControlState.Default;
            this.txtConfirmPassword.DisplayType = efControls.Enums.DisplayType.Default;
            this.txtConfirmPassword.Enabled = false;
            this.txtConfirmPassword.EnterMoveNextControl = true;
            this.txtConfirmPassword.Information = null;
            this.txtConfirmPassword.Location = new System.Drawing.Point(101, 60);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Properties.NullValuePrompt = "Confirm Password";
            this.txtConfirmPassword.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtConfirmPassword.Properties.UseSystemPasswordChar = true;
            this.txtConfirmPassword.Size = new System.Drawing.Size(133, 20);
            this.txtConfirmPassword.StyleController = this.lcMain;
            this.txtConfirmPassword.TabIndex = 2;
            this.txtConfirmPassword.ToolTip = "Confirm Password";
            this.txtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmPassword_Validating);
            // 
            // btnSave
            // 
            this.btnSave.DefaultState = efControls.Enums.ControlState.Default;
            this.btnSave.HighLighted = false;
            this.btnSave.Location = new System.Drawing.Point(12, 84);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 28);
            this.btnSave.StyleController = this.lcMain;
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.efButton1_Click);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.AllowLeadingSpace = false;
            this.txtNewPassword.DefaultState = efControls.Enums.ControlState.Default;
            this.txtNewPassword.DisplayType = efControls.Enums.DisplayType.Default;
            this.txtNewPassword.Enabled = false;
            this.txtNewPassword.EnterMoveNextControl = true;
            this.txtNewPassword.Information = null;
            this.txtNewPassword.Location = new System.Drawing.Point(101, 36);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Properties.NullValuePrompt = "Enter New Password";
            this.txtNewPassword.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtNewPassword.Properties.UseSystemPasswordChar = true;
            this.txtNewPassword.Size = new System.Drawing.Size(133, 20);
            this.txtNewPassword.StyleController = this.lcMain;
            this.txtNewPassword.TabIndex = 1;
            this.txtNewPassword.ToolTip = "Enter New Password";
            this.txtNewPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtNewPassword_Validating);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciOld,
            this.lciNew,
            this.lciConfirm,
            this.efLayoutControlItem4,
            this.efLayoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(246, 124);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lciOld
            // 
            this.lciOld.Control = this.txtOldPassword;
            this.lciOld.CustomizationFormText = "Old Password";
            this.lciOld.IsRequired = null;
            this.lciOld.Location = new System.Drawing.Point(0, 0);
            this.lciOld.Name = "lciOld";
            this.lciOld.Size = new System.Drawing.Size(226, 24);
            this.lciOld.Text = "Old Password";
            this.lciOld.TextSize = new System.Drawing.Size(86, 13);
            // 
            // lciNew
            // 
            this.lciNew.Control = this.txtNewPassword;
            this.lciNew.CustomizationFormText = "New Password";
            this.lciNew.IsRequired = null;
            this.lciNew.Location = new System.Drawing.Point(0, 24);
            this.lciNew.Name = "lciNew";
            this.lciNew.Size = new System.Drawing.Size(226, 24);
            this.lciNew.Text = "New Password";
            this.lciNew.TextSize = new System.Drawing.Size(86, 13);
            // 
            // lciConfirm
            // 
            this.lciConfirm.Control = this.txtConfirmPassword;
            this.lciConfirm.CustomizationFormText = "Confirm Password";
            this.lciConfirm.IsRequired = null;
            this.lciConfirm.Location = new System.Drawing.Point(0, 48);
            this.lciConfirm.Name = "lciConfirm";
            this.lciConfirm.Size = new System.Drawing.Size(226, 24);
            this.lciConfirm.Text = "Confirm Password";
            this.lciConfirm.TextSize = new System.Drawing.Size(86, 13);
            // 
            // efLayoutControlItem4
            // 
            this.efLayoutControlItem4.Control = this.btnSave;
            this.efLayoutControlItem4.CustomizationFormText = "efLayoutControlItem4";
            this.efLayoutControlItem4.IsRequired = null;
            this.efLayoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.efLayoutControlItem4.MinSize = new System.Drawing.Size(35, 26);
            this.efLayoutControlItem4.Name = "efLayoutControlItem4";
            this.efLayoutControlItem4.Size = new System.Drawing.Size(113, 32);
            this.efLayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.efLayoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.efLayoutControlItem4.TextVisible = false;
            // 
            // efLayoutControlItem5
            // 
            this.efLayoutControlItem5.Control = this.btnClose;
            this.efLayoutControlItem5.CustomizationFormText = "efLayoutControlItem5";
            this.efLayoutControlItem5.IsRequired = null;
            this.efLayoutControlItem5.Location = new System.Drawing.Point(113, 72);
            this.efLayoutControlItem5.MinSize = new System.Drawing.Size(37, 26);
            this.efLayoutControlItem5.Name = "efLayoutControlItem5";
            this.efLayoutControlItem5.Size = new System.Drawing.Size(113, 32);
            this.efLayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.efLayoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.efLayoutControlItem5.TextVisible = false;
            // 
            // FormChangePassword
            // 
            this.ClientSize = new System.Drawing.Size(246, 124);
            this.Controls.Add(this.lcMain);
            this.Name = "FormChangePassword";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Password";
            this.Controls.SetChildIndex(this.lcMain, 0);
            this.Controls.SetChildIndex(this.lblFocus, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirmPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciOld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciConfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.efLayoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.efLayoutControlItem5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private efControls.efTextBox txtOldPassword;
        private efControls.efTextBox txtNewPassword;
        private efControls.efTextBox txtConfirmPassword;
        private efControls.efButton btnSave;
        private efControls.efButton btnClose;
        private efControls.efLayoutControl lcMain;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private efControls.lci lciOld;
        private efControls.lci lciNew;
        private efControls.lci lciConfirm;
        private efControls.lci efLayoutControlItem4;
        private efControls.lci efLayoutControlItem5;
    }
}
