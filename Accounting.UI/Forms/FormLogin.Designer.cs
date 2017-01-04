namespace Accounting
{
    partial class FormLogin

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.spnYear = new efControls.efSpinner();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.userBS = new System.Windows.Forms.BindingSource();
            this.separatorControl4 = new DevExpress.XtraEditors.SeparatorControl();
            this.separatorControl5 = new DevExpress.XtraEditors.SeparatorControl();
            this.cboCompanies = new Accounting.cboCompanies();
            ((System.ComponentModel.ISupportInitialize)(this.efErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkRememberMe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLogin)).BeginInit();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tsPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peIn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peOut.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCompanies.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(116)))), ((int)(((byte)(168)))));
            this.btnLogin.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogin.Appearance.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogin.Appearance.Options.UseBackColor = true;
            this.btnLogin.Appearance.Options.UseFont = true;
            this.btnLogin.Appearance.Options.UseForeColor = true;
            this.btnLogin.AppearanceHovered.BackColor = System.Drawing.Color.LightBlue;
            this.btnLogin.AppearanceHovered.Options.UseBackColor = true;
            this.btnLogin.Location = new System.Drawing.Point(12, 222);
            this.btnLogin.LookAndFeel.SkinName = "Office 2010 Black";
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // chkRememberMe
            // 
            this.chkRememberMe.Location = new System.Drawing.Point(13, 189);
            this.chkRememberMe.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.chkRememberMe.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.chkRememberMe.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(116)))), ((int)(((byte)(168)))));
            this.chkRememberMe.Properties.Appearance.Options.UseBackColor = true;
            this.chkRememberMe.Properties.Appearance.Options.UseFont = true;
            this.chkRememberMe.Properties.Appearance.Options.UseForeColor = true;
            this.chkRememberMe.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Transparent;
            this.chkRememberMe.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.chkRememberMe.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Transparent;
            this.chkRememberMe.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.chkRememberMe.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Transparent;
            this.chkRememberMe.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.chkRememberMe.TabIndex = 6;
            // 
            // pnlLogin
            // 
            this.pnlLogin.Appearance.BackColor = System.Drawing.Color.White;
            this.pnlLogin.Appearance.Options.UseBackColor = true;
            this.pnlLogin.Controls.Add(this.separatorControl5);
            this.pnlLogin.Controls.Add(this.separatorControl4);
            this.pnlLogin.Controls.Add(this.spnYear);
            this.pnlLogin.Controls.Add(this.cboCompanies);
            this.pnlLogin.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlLogin.LookAndFeel.UseWindowsXPTheme = true;
            this.pnlLogin.Size = new System.Drawing.Size(415, 262);
            this.pnlLogin.Controls.SetChildIndex(this.peOut, 0);
            this.pnlLogin.Controls.SetChildIndex(this.tsPassword, 0);
            this.pnlLogin.Controls.SetChildIndex(this.chkRememberMe, 0);
            this.pnlLogin.Controls.SetChildIndex(this.btnLogin, 0);
            this.pnlLogin.Controls.SetChildIndex(this.txtPassword, 0);
            this.pnlLogin.Controls.SetChildIndex(this.cboUsername, 0);
            this.pnlLogin.Controls.SetChildIndex(this.cboCompanies, 0);
            this.pnlLogin.Controls.SetChildIndex(this.spnYear, 0);
            this.pnlLogin.Controls.SetChildIndex(this.separatorControl4, 0);
            this.pnlLogin.Controls.SetChildIndex(this.separatorControl5, 0);
            // 
            // tsPassword
            // 
            this.tsPassword.Location = new System.Drawing.Point(209, 185);
            this.tsPassword.Properties.LookAndFeel.SkinName = "Whiteprint";
            this.tsPassword.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            // 
            // cboUsername
            // 
            this.cboUsername.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.cboUsername.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(116)))), ((int)(((byte)(168)))));
            this.cboUsername.Properties.Appearance.Options.UseFont = true;
            this.cboUsername.Properties.Appearance.Options.UseForeColor = true;
            this.cboUsername.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Transparent;
            this.cboUsername.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.cboUsername.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 5, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.cboUsername.Properties.DataSource = this.userBS;
            this.cboUsername.Properties.DisplayMember = "Name";
            this.cboUsername.Properties.ValueMember = "ID";
            this.cboUsername.TabIndex = 0;
            this.cboUsername.Validated += new System.EventHandler(this.cboUsername_Validated);
            // 
            // txtPassword
            // 
            this.txtPassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.txtPassword.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(116)))), ((int)(((byte)(168)))));
            this.txtPassword.Properties.Appearance.Options.UseFont = true;
            this.txtPassword.Properties.Appearance.Options.UseForeColor = true;
            this.txtPassword.TabIndex = 1;
            // 
            // peIn
            // 
            this.peIn.Location = new System.Drawing.Point(316, 81);
            this.peIn.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.peIn.Properties.Appearance.Options.UseBackColor = true;
            // 
            // peOut
            // 
            this.peOut.Location = new System.Drawing.Point(316, 81);
            this.peOut.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.peOut.Properties.Appearance.Options.UseBackColor = true;
            // 
            // spnYear
            // 
            this.spnYear.AllowLeadingSpace = false;
            this.spnYear.DefaultState = efControls.Enums.ControlState.Default;
            this.spnYear.DisplayType = efControls.Enums.DisplayType.Default;
            this.spnYear.EditValue = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.spnYear.EnterMoveNextControl = true;
            this.spnYear.Information = null;
            this.spnYear.Location = new System.Drawing.Point(246, 143);
            this.spnYear.MaximumSize = new System.Drawing.Size(0, 35);
            this.spnYear.MinimumSize = new System.Drawing.Size(0, 35);
            this.spnYear.Name = "spnYear";
            this.spnYear.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.spnYear.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(116)))), ((int)(((byte)(168)))));
            this.spnYear.Properties.Appearance.Options.UseFont = true;
            this.spnYear.Properties.Appearance.Options.UseForeColor = true;
            this.spnYear.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.spnYear.Properties.ContextImage = ((System.Drawing.Image)(resources.GetObject("spnYear.Properties.ContextImage")));
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
            this.spnYear.Properties.NullValuePrompt = "Year";
            this.spnYear.Properties.NullValuePromptShowForEmptyValue = true;
            this.spnYear.Size = new System.Drawing.Size(60, 35);
            this.spnYear.TabIndex = 3;
            // 
            // userBS
            // 
            this.userBS.DataSource = typeof(efControls.Data.User);
            // 
            // separatorControl4
            // 
            this.separatorControl4.Location = new System.Drawing.Point(13, 179);
            this.separatorControl4.Name = "separatorControl4";
            this.separatorControl4.Padding = new System.Windows.Forms.Padding(2);
            this.separatorControl4.Size = new System.Drawing.Size(233, 4);
            this.separatorControl4.TabIndex = 26;
            // 
            // separatorControl5
            // 
            this.separatorControl5.Location = new System.Drawing.Point(246, 179);
            this.separatorControl5.Name = "separatorControl5";
            this.separatorControl5.Padding = new System.Windows.Forms.Padding(2);
            this.separatorControl5.Size = new System.Drawing.Size(60, 4);
            this.separatorControl5.TabIndex = 27;
            // 
            // cboCompanies
            // 
            this.cboCompanies.DefaultState = efControls.Enums.ControlState.Default;
            this.cboCompanies.EnterMoveNextControl = true;
            this.cboCompanies.Location = new System.Drawing.Point(12, 143);
            this.cboCompanies.MaximumSize = new System.Drawing.Size(0, 35);
            this.cboCompanies.MinimumSize = new System.Drawing.Size(0, 35);
            this.cboCompanies.Name = "cboCompanies";
            this.cboCompanies.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboCompanies.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.cboCompanies.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(116)))), ((int)(((byte)(168)))));
            this.cboCompanies.Properties.Appearance.Options.UseFont = true;
            this.cboCompanies.Properties.Appearance.Options.UseForeColor = true;
            this.cboCompanies.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cboCompanies.Properties.ContextImage = ((System.Drawing.Image)(resources.GetObject("cboCompanies.Properties.ContextImage")));
            this.cboCompanies.Properties.Name = "efComboBox";
            this.cboCompanies.Properties.NullText = "";
            this.cboCompanies.Properties.NullValuePrompt = "Company";
            this.cboCompanies.Properties.NullValuePromptShowForEmptyValue = true;
            this.cboCompanies.Properties.ShowFooter = false;
            this.cboCompanies.Properties.ShowHeader = false;
            this.cboCompanies.Size = new System.Drawing.Size(233, 35);
            this.cboCompanies.TabIndex = 2;
            this.cboCompanies.EditValueChanged += new System.EventHandler(this.cboCompanies_EditValueChanged);
            // 
            // FormLogin
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(470, 287);
            this.MaximumSize = new System.Drawing.Size(470, 287);
            this.MinimumSize = new System.Drawing.Size(470, 287);
            this.Name = "FormLogin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_FormClosing);
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.efErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkRememberMe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLogin)).EndInit();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tsPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peIn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peOut.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCompanies.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private cboCompanies cboCompanies;
        private efControls.efSpinner spnYear;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.BindingSource userBS;
        private DevExpress.XtraEditors.SeparatorControl separatorControl5;
        private DevExpress.XtraEditors.SeparatorControl separatorControl4;
    }
}
