namespace efControls
{
    partial class efLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(efLogin));
            this.connection = new System.Data.SqlClient.SqlConnection();
            this.ValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.efErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.imgCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.peIn = new DevExpress.XtraEditors.PictureEdit();
            this.pnlLogin = new efControls.efPanel();
            this.separatorControl3 = new DevExpress.XtraEditors.SeparatorControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.separatorControl2 = new DevExpress.XtraEditors.SeparatorControl();
            this.peOut = new DevExpress.XtraEditors.PictureEdit();
            this.peMinimize = new DevExpress.XtraEditors.PictureEdit();
            this.peClose = new DevExpress.XtraEditors.PictureEdit();
            this.txtPassword = new efControls.efTextBox();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.chkRememberMe = new efControls.efCheckBox();
            this.btnLogin = new efControls.efButton();
            this.cboUsername = new efControls.efComboBox();
            this.tsPassword = new DevExpress.XtraEditors.ToggleSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.efErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peIn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLogin)).BeginInit();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peOut.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peMinimize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peClose.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkRememberMe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // connection
            // 
            this.connection.FireInfoMessageEventOnUserErrors = false;
            // 
            // efErrorProvider
            // 
            this.efErrorProvider.ContainerControl = this;
            // 
            // imgCollection
            // 
            this.imgCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgCollection.ImageStream")));
            this.imgCollection.Images.SetKeyName(0, "Manager-48.png");
            this.imgCollection.Images.SetKeyName(1, "Key-48.png");
            // 
            // peIn
            // 
            this.peIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.peIn.Cursor = System.Windows.Forms.Cursors.Default;
            this.peIn.EditValue = global::efControls.Properties.Resources.lock_3;
            this.peIn.Location = new System.Drawing.Point(316, 44);
            this.peIn.Name = "peIn";
            this.peIn.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.peIn.Properties.Appearance.Options.UseBackColor = true;
            this.peIn.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peIn.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peIn.Properties.ZoomAccelerationFactor = 1D;
            this.peIn.Size = new System.Drawing.Size(155, 200);
            this.peIn.TabIndex = 19;
            // 
            // pnlLogin
            // 
            this.pnlLogin.Appearance.BackColor = System.Drawing.Color.White;
            this.pnlLogin.Appearance.Options.UseBackColor = true;
            this.pnlLogin.ContentImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.pnlLogin.Controls.Add(this.separatorControl3);
            this.pnlLogin.Controls.Add(this.labelControl1);
            this.pnlLogin.Controls.Add(this.separatorControl2);
            this.pnlLogin.Controls.Add(this.peOut);
            this.pnlLogin.Controls.Add(this.peMinimize);
            this.pnlLogin.Controls.Add(this.peClose);
            this.pnlLogin.Controls.Add(this.txtPassword);
            this.pnlLogin.Controls.Add(this.separatorControl1);
            this.pnlLogin.Controls.Add(this.chkRememberMe);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.cboUsername);
            this.pnlLogin.Controls.Add(this.tsPassword);
            this.pnlLogin.DefaultState = efControls.Enums.ControlState.Default;
            this.pnlLogin.HighLighted = false;
            this.pnlLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlLogin.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlLogin.LookAndFeel.UseWindowsXPTheme = true;
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(415, 225);
            this.pnlLogin.TabIndex = 17;
            // 
            // separatorControl3
            // 
            this.separatorControl3.Location = new System.Drawing.Point(3, 32);
            this.separatorControl3.Name = "separatorControl3";
            this.separatorControl3.Padding = new System.Windows.Forms.Padding(2);
            this.separatorControl3.Size = new System.Drawing.Size(411, 10);
            this.separatorControl3.TabIndex = 25;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(116)))), ((int)(((byte)(168)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(6, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(148, 25);
            this.labelControl1.TabIndex = 24;
            this.labelControl1.Text = "Member Login";
            // 
            // separatorControl2
            // 
            this.separatorControl2.Location = new System.Drawing.Point(12, 131);
            this.separatorControl2.Name = "separatorControl2";
            this.separatorControl2.Padding = new System.Windows.Forms.Padding(2);
            this.separatorControl2.Size = new System.Drawing.Size(294, 4);
            this.separatorControl2.TabIndex = 23;
            // 
            // peOut
            // 
            this.peOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.peOut.Cursor = System.Windows.Forms.Cursors.Default;
            this.peOut.EditValue = global::efControls.Properties.Resources.lock_3;
            this.peOut.Location = new System.Drawing.Point(316, 44);
            this.peOut.Name = "peOut";
            this.peOut.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.peOut.Properties.Appearance.Options.UseBackColor = true;
            this.peOut.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peOut.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peOut.Properties.ZoomAccelerationFactor = 1D;
            this.peOut.Size = new System.Drawing.Size(155, 200);
            this.peOut.TabIndex = 18;
            // 
            // peMinimize
            // 
            this.peMinimize.Cursor = System.Windows.Forms.Cursors.Default;
            this.peMinimize.EditValue = ((object)(resources.GetObject("peMinimize.EditValue")));
            this.peMinimize.Location = new System.Drawing.Point(362, 5);
            this.peMinimize.Name = "peMinimize";
            this.peMinimize.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.peMinimize.Properties.Appearance.Options.UseBackColor = true;
            this.peMinimize.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peMinimize.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peMinimize.Properties.ZoomAccelerationFactor = 1D;
            this.peMinimize.Size = new System.Drawing.Size(24, 24);
            this.peMinimize.TabIndex = 19;
            this.peMinimize.Click += new System.EventHandler(this.peMinimize_Click);
            // 
            // peClose
            // 
            this.peClose.Cursor = System.Windows.Forms.Cursors.Default;
            this.peClose.EditValue = ((object)(resources.GetObject("peClose.EditValue")));
            this.peClose.Location = new System.Drawing.Point(386, 5);
            this.peClose.Name = "peClose";
            this.peClose.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.peClose.Properties.Appearance.Options.UseBackColor = true;
            this.peClose.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peClose.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peClose.Properties.ZoomAccelerationFactor = 1D;
            this.peClose.Size = new System.Drawing.Size(24, 24);
            this.peClose.TabIndex = 18;
            this.peClose.Click += new System.EventHandler(this.peClose_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.AllowLeadingSpace = false;
            this.txtPassword.DefaultState = efControls.Enums.ControlState.Default;
            this.txtPassword.DisplayType = efControls.Enums.DisplayType.Default;
            this.txtPassword.EditValue = "";
            this.txtPassword.EnterMoveNextControl = true;
            this.txtPassword.Information = null;
            this.txtPassword.Location = new System.Drawing.Point(12, 96);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.txtPassword.MaximumSize = new System.Drawing.Size(0, 35);
            this.txtPassword.MinimumSize = new System.Drawing.Size(0, 35);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.txtPassword.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(116)))), ((int)(((byte)(168)))));
            this.txtPassword.Properties.Appearance.Options.UseFont = true;
            this.txtPassword.Properties.Appearance.Options.UseForeColor = true;
            this.txtPassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtPassword.Properties.ContextImage = global::efControls.Properties.Resources.Key_48;
            this.txtPassword.Properties.Name = "efTextBox";
            this.txtPassword.Properties.NullValuePrompt = "Password";
            this.txtPassword.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtPassword.Properties.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(294, 35);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.ToolTip = "Enter Your Password";
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(12, 85);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Padding = new System.Windows.Forms.Padding(2);
            this.separatorControl1.Size = new System.Drawing.Size(294, 4);
            this.separatorControl1.TabIndex = 22;
            // 
            // chkRememberMe
            // 
            this.chkRememberMe.AutoSizeInLayoutControl = true;
            this.chkRememberMe.DefaultState = efControls.Enums.ControlState.Default;
            this.chkRememberMe.EditValue = true;
            this.chkRememberMe.EnterMoveNextControl = true;
            this.chkRememberMe.HighLighted = false;
            this.chkRememberMe.Location = new System.Drawing.Point(14, 146);
            this.chkRememberMe.Name = "chkRememberMe";
            this.chkRememberMe.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.chkRememberMe.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(116)))), ((int)(((byte)(168)))));
            this.chkRememberMe.Properties.Appearance.Options.UseFont = true;
            this.chkRememberMe.Properties.Appearance.Options.UseForeColor = true;
            this.chkRememberMe.Properties.Caption = "Remember Me ";
            this.chkRememberMe.Properties.Name = "efCheckBox";
            this.chkRememberMe.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.chkRememberMe.Size = new System.Drawing.Size(162, 20);
            this.chkRememberMe.TabIndex = 15;
            this.chkRememberMe.ValueType = efControls.Enums.ValueType.Boolean;
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
            this.btnLogin.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnLogin.DefaultState = efControls.Enums.ControlState.Default;
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnLogin.HighLighted = false;
            this.btnLogin.ImageList = this.imgCollection;
            this.btnLogin.Location = new System.Drawing.Point(12, 174);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(294, 35);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "&Login";
            // 
            // cboUsername
            // 
            this.cboUsername.DefaultState = efControls.Enums.ControlState.Default;
            this.cboUsername.EnterMoveNextControl = true;
            this.cboUsername.Location = new System.Drawing.Point(12, 50);
            this.cboUsername.MaximumSize = new System.Drawing.Size(0, 35);
            this.cboUsername.MinimumSize = new System.Drawing.Size(0, 35);
            this.cboUsername.Name = "cboUsername";
            this.cboUsername.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cboUsername.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(116)))), ((int)(((byte)(168)))));
            this.cboUsername.Properties.Appearance.Options.UseFont = true;
            this.cboUsername.Properties.Appearance.Options.UseForeColor = true;
            this.cboUsername.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Transparent;
            this.cboUsername.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.cboUsername.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cboUsername.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cboUsername.Properties.ContextImage = global::efControls.Properties.Resources.Manager_48;
            this.cboUsername.Properties.Name = "efComboBox";
            this.cboUsername.Properties.NullText = "";
            this.cboUsername.Properties.NullValuePrompt = "User Name";
            this.cboUsername.Properties.NullValuePromptShowForEmptyValue = true;
            this.cboUsername.Properties.ShowFooter = false;
            this.cboUsername.Properties.ShowHeader = false;
            this.cboUsername.Size = new System.Drawing.Size(294, 35);
            this.cboUsername.TabIndex = 16;
            this.cboUsername.EditValueChanged += new System.EventHandler(this.cboUsername_EditValueChanged);
            // 
            // tsPassword
            // 
            this.tsPassword.AutoSizeInLayoutControl = true;
            this.tsPassword.Location = new System.Drawing.Point(214, 142);
            this.tsPassword.Name = "tsPassword";
            this.tsPassword.Properties.AutoWidth = true;
            this.tsPassword.Properties.LookAndFeel.SkinName = "Whiteprint";
            this.tsPassword.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.tsPassword.Properties.OffText = "●●●";
            this.tsPassword.Properties.OnText = "ABC";
            this.tsPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tsPassword.Size = new System.Drawing.Size(94, 24);
            this.tsPassword.TabIndex = 21;
            this.tsPassword.TabStop = false;
            this.tsPassword.EditValueChanged += new System.EventHandler(this.tsPassword_EditValueChanged);
            // 
            // efLogin
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Appearance.Options.UseBackColor = true;
            this.ClientSize = new System.Drawing.Size(470, 250);
            this.ControlBox = false;
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.peIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "efLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Shown += new System.EventHandler(this.efLogin_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.efErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peIn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLogin)).EndInit();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peOut.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peMinimize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peClose.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkRememberMe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsPassword.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Data.SqlClient.SqlConnection connection;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider ValidationProvider;
        public DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider efErrorProvider;
        public efButton btnLogin;
        public efCheckBox chkRememberMe;
        private DevExpress.Utils.ImageCollection imgCollection;
        protected efPanel pnlLogin;
        private DevExpress.XtraEditors.PictureEdit peClose;
        private DevExpress.XtraEditors.PictureEdit peMinimize;
        public DevExpress.XtraEditors.ToggleSwitch tsPassword;
        private DevExpress.XtraEditors.SeparatorControl separatorControl2;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.SeparatorControl separatorControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        protected efComboBox cboUsername;
        protected efTextBox txtPassword;
        protected DevExpress.XtraEditors.PictureEdit peIn;
        protected DevExpress.XtraEditors.PictureEdit peOut;
    }
}