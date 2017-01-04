namespace efControls
{
    partial class efSetConnections
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(efSetConnections));
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.imageCollection = new DevExpress.Utils.ImageCollection();
            this.lcDatabase = new efControls.efLayoutControl();
            this.cmbSecurityDB = new efControls.efUnboundComboBox();
            this.image = new DevExpress.XtraEditors.PictureEdit();
            this.cmbSqlInstances = new efControls.efUnboundComboBox();
            this.cmbMainDB = new efControls.efUnboundComboBox();
            this.txtUser = new efControls.efTextBox();
            this.txtPassword = new efControls.efTextBox();
            this.lcgDatabase = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciServer = new efControls.lci();
            this.lciUserName = new efControls.lci();
            this.lciPassword = new efControls.lci();
            this.lciDatabase = new efControls.lci();
            this.lciImage = new efControls.lci();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.lciSecurity = new efControls.lci();
            this.barManager = new DevExpress.XtraBars.BarManager();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bbiAttach = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDetach = new DevExpress.XtraBars.BarButtonItem();
            this.bbiOk = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCancel = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcDatabase)).BeginInit();
            this.lcDatabase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSecurityDB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSqlInstances.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMainDB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciServer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSecurity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            this.SuspendLayout();
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.SelectedPath = "C:\\";
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.Images.SetKeyName(0, "database.png");
            this.imageCollection.Images.SetKeyName(1, "network_server.png");
            this.imageCollection.Images.SetKeyName(2, "database-user.png");
            this.imageCollection.Images.SetKeyName(3, "database-lock.png");
            this.imageCollection.Images.SetKeyName(4, "password.png");
            this.imageCollection.Images.SetKeyName(5, "cancel.png");
            this.imageCollection.Images.SetKeyName(6, "database-add.png");
            this.imageCollection.Images.SetKeyName(7, "database-delete.png");
            this.imageCollection.Images.SetKeyName(8, "ok_button.png");
            // 
            // lcDatabase
            // 
            this.lcDatabase.Controls.Add(this.cmbSecurityDB);
            this.lcDatabase.Controls.Add(this.image);
            this.lcDatabase.Controls.Add(this.cmbSqlInstances);
            this.lcDatabase.Controls.Add(this.cmbMainDB);
            this.lcDatabase.Controls.Add(this.txtUser);
            this.lcDatabase.Controls.Add(this.txtPassword);
            this.lcDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcDatabase.Images = this.imageCollection;
            this.lcDatabase.Location = new System.Drawing.Point(0, 0);
            this.lcDatabase.Margin = new System.Windows.Forms.Padding(0);
            this.lcDatabase.Name = "lcDatabase";
            this.lcDatabase.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1670, 39, 250, 616);
            this.lcDatabase.Root = this.lcgDatabase;
            this.lcDatabase.Size = new System.Drawing.Size(490, 140);
            this.lcDatabase.TabIndex = 15;
            this.lcDatabase.Text = "efLayoutControl1";
            // 
            // cmbSecurityDB
            // 
            this.cmbSecurityDB.colHeader1 = null;
            this.cmbSecurityDB.colHeader2 = null;
            this.cmbSecurityDB.DefaultState = efControls.Enums.ControlState.Default;
            this.cmbSecurityDB.EditValue = "";
            this.cmbSecurityDB.EnterMoveNextControl = true;
            this.cmbSecurityDB.Location = new System.Drawing.Point(222, 88);
            this.cmbSecurityDB.Name = "cmbSecurityDB";
            this.cmbSecurityDB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cmbSecurityDB.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.cmbSecurityDB.Properties.Name = "efUnboundComboBox";
            this.cmbSecurityDB.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmbSecurityDB_Properties_ButtonClick);
            this.cmbSecurityDB.Size = new System.Drawing.Size(264, 20);
            this.cmbSecurityDB.StyleController = this.lcDatabase;
            this.cmbSecurityDB.TabIndex = 15;
            // 
            // image
            // 
            this.image.Cursor = System.Windows.Forms.Cursors.Default;
            this.image.Location = new System.Drawing.Point(5, 5);
            this.image.Name = "image";
            this.image.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.image.Properties.Appearance.Options.UseBackColor = true;
            this.image.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.image.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.image.Properties.ZoomAccelerationFactor = 1D;
            this.image.Size = new System.Drawing.Size(124, 130);
            this.image.StyleController = this.lcDatabase;
            this.image.TabIndex = 14;
            // 
            // cmbSqlInstances
            // 
            this.cmbSqlInstances.colHeader1 = null;
            this.cmbSqlInstances.colHeader2 = null;
            this.cmbSqlInstances.DefaultState = efControls.Enums.ControlState.Default;
            this.cmbSqlInstances.EditValue = "";
            this.cmbSqlInstances.EnterMoveNextControl = true;
            this.cmbSqlInstances.Location = new System.Drawing.Point(222, 4);
            this.cmbSqlInstances.Name = "cmbSqlInstances";
            this.cmbSqlInstances.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSqlInstances.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.cmbSqlInstances.Properties.Name = "efUnboundComboBox";
            this.cmbSqlInstances.Size = new System.Drawing.Size(264, 20);
            this.cmbSqlInstances.StyleController = this.lcDatabase;
            this.cmbSqlInstances.TabIndex = 0;
            // 
            // cmbMainDB
            // 
            this.cmbMainDB.colHeader1 = null;
            this.cmbMainDB.colHeader2 = null;
            this.cmbMainDB.DefaultState = efControls.Enums.ControlState.Default;
            this.cmbMainDB.EditValue = "";
            this.cmbMainDB.EnterMoveNextControl = true;
            this.cmbMainDB.Location = new System.Drawing.Point(222, 116);
            this.cmbMainDB.Name = "cmbMainDB";
            this.cmbMainDB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cmbMainDB.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.cmbMainDB.Properties.Name = "efUnboundComboBox";
            this.cmbMainDB.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmbMainDB_Properties_ButtonClick);
            this.cmbMainDB.Size = new System.Drawing.Size(264, 20);
            this.cmbMainDB.StyleController = this.lcDatabase;
            this.cmbMainDB.TabIndex = 3;
            // 
            // txtUser
            // 
            this.txtUser.AllowLeadingSpace = false;
            this.txtUser.DefaultState = efControls.Enums.ControlState.Default;
            this.txtUser.DisplayType = efControls.Enums.DisplayType.Default;
            this.txtUser.EditValue = "";
            this.txtUser.EnterMoveNextControl = true;
            this.txtUser.Information = null;
            this.txtUser.Location = new System.Drawing.Point(222, 32);
            this.txtUser.Name = "txtUser";
            this.txtUser.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtUser.Properties.Appearance.Options.UseFont = true;
            this.txtUser.Properties.Appearance.Options.UseForeColor = true;
            this.txtUser.Properties.Name = "Properties";
            this.txtUser.Size = new System.Drawing.Size(264, 20);
            this.txtUser.StyleController = this.lcDatabase;
            this.txtUser.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.AllowLeadingSpace = false;
            this.txtPassword.DefaultState = efControls.Enums.ControlState.Default;
            this.txtPassword.DisplayType = efControls.Enums.DisplayType.Default;
            this.txtPassword.EditValue = "";
            this.txtPassword.EnterMoveNextControl = true;
            this.txtPassword.Information = null;
            this.txtPassword.Location = new System.Drawing.Point(222, 60);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Properties.Appearance.Options.UseFont = true;
            this.txtPassword.Properties.Appearance.Options.UseForeColor = true;
            this.txtPassword.Properties.Name = "Properties";
            this.txtPassword.Properties.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(264, 20);
            this.txtPassword.StyleController = this.lcDatabase;
            this.txtPassword.TabIndex = 2;
            // 
            // lcgDatabase
            // 
            this.lcgDatabase.CustomizationFormText = "Root";
            this.lcgDatabase.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgDatabase.GroupBordersVisible = false;
            this.lcgDatabase.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciServer,
            this.lciUserName,
            this.lciPassword,
            this.lciDatabase,
            this.lciImage,
            this.simpleSeparator1,
            this.lciSecurity});
            this.lcgDatabase.Location = new System.Drawing.Point(0, 0);
            this.lcgDatabase.Name = "Root";
            this.lcgDatabase.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcgDatabase.Size = new System.Drawing.Size(490, 140);
            this.lcgDatabase.TextVisible = false;
            // 
            // lciServer
            // 
            this.lciServer.Control = this.cmbSqlInstances;
            this.lciServer.CustomizationFormText = "Server";
            this.lciServer.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.lciServer.ImageIndex = 1;
            this.lciServer.IsRequired = null;
            this.lciServer.Location = new System.Drawing.Point(135, 0);
            this.lciServer.Name = "lciServer";
            this.lciServer.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.lciServer.Size = new System.Drawing.Size(355, 28);
            this.lciServer.Text = "Server";
            this.lciServer.TextSize = new System.Drawing.Size(80, 16);
            // 
            // lciUserName
            // 
            this.lciUserName.Control = this.txtUser;
            this.lciUserName.CustomizationFormText = "lciUserName";
            this.lciUserName.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.lciUserName.ImageIndex = 2;
            this.lciUserName.IsRequired = null;
            this.lciUserName.Location = new System.Drawing.Point(135, 28);
            this.lciUserName.Name = "lciUserName";
            this.lciUserName.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.lciUserName.Size = new System.Drawing.Size(355, 28);
            this.lciUserName.Text = "User";
            this.lciUserName.TextSize = new System.Drawing.Size(80, 16);
            // 
            // lciPassword
            // 
            this.lciPassword.Control = this.txtPassword;
            this.lciPassword.CustomizationFormText = "lciPassword";
            this.lciPassword.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.lciPassword.ImageIndex = 4;
            this.lciPassword.IsRequired = null;
            this.lciPassword.Location = new System.Drawing.Point(135, 56);
            this.lciPassword.Name = "lciPassword";
            this.lciPassword.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.lciPassword.Size = new System.Drawing.Size(355, 28);
            this.lciPassword.Text = "Password";
            this.lciPassword.TextSize = new System.Drawing.Size(80, 16);
            // 
            // lciDatabase
            // 
            this.lciDatabase.Control = this.cmbMainDB;
            this.lciDatabase.CustomizationFormText = "lciDatabase";
            this.lciDatabase.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.lciDatabase.ImageIndex = 0;
            this.lciDatabase.IsRequired = null;
            this.lciDatabase.Location = new System.Drawing.Point(135, 112);
            this.lciDatabase.Name = "lciDatabase";
            this.lciDatabase.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.lciDatabase.Size = new System.Drawing.Size(355, 28);
            this.lciDatabase.Text = "Main DB.";
            this.lciDatabase.TextSize = new System.Drawing.Size(80, 16);
            // 
            // lciImage
            // 
            this.lciImage.Control = this.image;
            this.lciImage.CustomizationFormText = "lciImage";
            this.lciImage.IsRequired = null;
            this.lciImage.Location = new System.Drawing.Point(0, 0);
            this.lciImage.MinSize = new System.Drawing.Size(30, 30);
            this.lciImage.Name = "lciImage";
            this.lciImage.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lciImage.Size = new System.Drawing.Size(134, 140);
            this.lciImage.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciImage.TextSize = new System.Drawing.Size(0, 0);
            this.lciImage.TextVisible = false;
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.CustomizationFormText = "simpleSeparator1";
            this.simpleSeparator1.Location = new System.Drawing.Point(134, 0);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(1, 140);
            this.simpleSeparator1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            // 
            // lciSecurity
            // 
            this.lciSecurity.Control = this.cmbSecurityDB;
            this.lciSecurity.CustomizationFormText = "Security DB.";
            this.lciSecurity.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.lciSecurity.ImageIndex = 3;
            this.lciSecurity.IsRequired = null;
            this.lciSecurity.Location = new System.Drawing.Point(135, 84);
            this.lciSecurity.Name = "lciSecurity";
            this.lciSecurity.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.lciSecurity.Size = new System.Drawing.Size(355, 28);
            this.lciSecurity.Text = "Security DB.";
            this.lciSecurity.TextSize = new System.Drawing.Size(80, 16);
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Images = this.imageCollection;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiAttach,
            this.bbiDetach,
            this.bbiOk,
            this.bbiCancel});
            this.barManager.MaxItemId = 4;
            this.barManager.StatusBar = this.bar3;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiAttach),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiDetach, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiOk, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiCancel, true)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // bbiAttach
            // 
            this.bbiAttach.Caption = "Attach";
            this.bbiAttach.Id = 0;
            this.bbiAttach.ImageIndex = 6;
            this.bbiAttach.Name = "bbiAttach";
            this.bbiAttach.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiAttach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAttach_ItemClick);
            // 
            // bbiDetach
            // 
            this.bbiDetach.Caption = "Detach";
            this.bbiDetach.Id = 1;
            this.bbiDetach.ImageIndex = 7;
            this.bbiDetach.Name = "bbiDetach";
            this.bbiDetach.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiDetach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDetach_ItemClick);
            // 
            // bbiOk
            // 
            this.bbiOk.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bbiOk.Caption = "&Ok";
            this.bbiOk.Id = 2;
            this.bbiOk.ImageIndex = 8;
            this.bbiOk.Name = "bbiOk";
            this.bbiOk.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiOk.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiOk_ItemClick);
            // 
            // bbiCancel
            // 
            this.bbiCancel.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bbiCancel.Caption = "&Cancel";
            this.bbiCancel.Id = 3;
            this.bbiCancel.ImageIndex = 5;
            this.bbiCancel.Name = "bbiCancel";
            this.bbiCancel.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiCancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiCancel_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(490, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 140);
            this.barDockControlBottom.Size = new System.Drawing.Size(490, 24);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 140);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(490, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 140);
            // 
            // efSetConnections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 164);
            this.Controls.Add(this.lcDatabase);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "efSetConnections";
            this.Text = "Database Specifications";
            this.Load += new System.EventHandler(this.efSetConnections_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcDatabase)).EndInit();
            this.lcDatabase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbSecurityDB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSqlInstances.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMainDB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciServer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSecurity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private efTextBox txtUser;
        private efTextBox txtPassword;
        private DevExpress.XtraEditors.PictureEdit image;
        private efUnboundComboBox cmbSqlInstances;
        private efUnboundComboBox cmbMainDB;
        public efLayoutControl lcDatabase;
        public DevExpress.XtraLayout.LayoutControlGroup lcgDatabase;
        public System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        public System.Windows.Forms.OpenFileDialog openFileDialog;
        public lci lciServer;
        public lci lciUserName;
        public lci lciPassword;
        public lci lciDatabase;
        public lci lciImage;
        public DevExpress.Utils.ImageCollection imageCollection;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        private efUnboundComboBox cmbSecurityDB;
        private lci lciSecurity;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem bbiAttach;
        private DevExpress.XtraBars.BarButtonItem bbiDetach;
        private DevExpress.XtraBars.BarButtonItem bbiOk;
        private DevExpress.XtraBars.BarButtonItem bbiCancel;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}