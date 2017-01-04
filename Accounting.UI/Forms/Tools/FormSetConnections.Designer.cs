namespace Accounting
{
    partial class FormSetConnections
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSetConnections));
            this.beVFP = new efControls.efButtonEdit();
            this.lciVFP = new efControls.lci();
            ((System.ComponentModel.ISupportInitialize)(this.lcDatabase)).BeginInit();
            this.lcDatabase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcgDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciServer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beVFP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciVFP)).BeginInit();
            this.SuspendLayout();
            // 
            // lcDatabase
            // 
            this.lcDatabase.Controls.Add(this.beVFP);
            this.lcDatabase.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1670, 39, 250, 616);
            this.lcDatabase.Size = new System.Drawing.Size(500, 169);
            this.lcDatabase.Controls.SetChildIndex(this.beVFP, 0);
            // 
            // lcgDatabase
            // 
            this.lcgDatabase.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciVFP});
            this.lcgDatabase.Size = new System.Drawing.Size(500, 169);
            // 
            // lciServer
            // 
            this.lciServer.Location = new System.Drawing.Point(155, 0);
            this.lciServer.Size = new System.Drawing.Size(345, 28);
            // 
            // lciUserName
            // 
            this.lciUserName.Location = new System.Drawing.Point(155, 28);
            this.lciUserName.Size = new System.Drawing.Size(345, 28);
            // 
            // lciPassword
            // 
            this.lciPassword.Location = new System.Drawing.Point(155, 56);
            this.lciPassword.Size = new System.Drawing.Size(345, 28);
            // 
            // lciDatabase
            // 
            this.lciDatabase.Location = new System.Drawing.Point(155, 112);
            this.lciDatabase.Size = new System.Drawing.Size(345, 28);
            // 
            // lciImage
            // 
            this.lciImage.Size = new System.Drawing.Size(154, 169);
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
            this.imageCollection.Images.SetKeyName(9, "Fox16.png");
            // 
            // beVFP
            // 
            this.beVFP.DefaultState = efControls.Enums.ControlState.Default;
            this.beVFP.DisplayType = efControls.Enums.DisplayType.Default;
            this.beVFP.EnterMoveNextControl = true;
            this.beVFP.HighLighted = false;
            this.beVFP.Location = new System.Drawing.Point(242, 144);
            this.beVFP.Name = "beVFP";
            this.beVFP.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.beVFP.Properties.Name = "efButtonEdit";
            this.beVFP.Size = new System.Drawing.Size(254, 20);
            this.beVFP.StyleController = this.lcDatabase;
            this.beVFP.TabIndex = 16;
            this.beVFP.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.beVFP_ButtonClick);
            // 
            // lciVFP
            // 
            this.lciVFP.Control = this.beVFP;
            this.lciVFP.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.lciVFP.ImageIndex = 9;
            this.lciVFP.IsRequired = null;
            this.lciVFP.Location = new System.Drawing.Point(154, 140);
            this.lciVFP.Name = "lciVFP";
            this.lciVFP.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.lciVFP.Size = new System.Drawing.Size(346, 29);
            this.lciVFP.TextSize = new System.Drawing.Size(80, 16);
            // 
            // FormSetConnections
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(500, 193);
            this.Name = "FormSetConnections";
            ((System.ComponentModel.ISupportInitialize)(this.lcDatabase)).EndInit();
            this.lcDatabase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcgDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciServer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beVFP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciVFP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private efControls.efButtonEdit beVFP;
        private efControls.lci lciVFP;
    }
}
