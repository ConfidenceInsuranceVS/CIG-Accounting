namespace efControls
{
    partial class ucImageViewer
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
            this.gcImages = new DevExpress.XtraBars.Ribbon.GalleryControl();
            this.galleryControlClient1 = new DevExpress.XtraBars.Ribbon.GalleryControlClient();
            ((System.ComponentModel.ISupportInitialize)(this.gcImages)).BeginInit();
            this.gcImages.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcImages
            // 
            this.gcImages.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.gcImages.Controls.Add(this.galleryControlClient1);
            this.gcImages.DesignGalleryGroupIndex = 0;
            this.gcImages.DesignGalleryItemIndex = 0;
            this.gcImages.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // galleryControlGallery1
            // 
            this.gcImages.Gallery.AllowHoverImages = true;
            this.gcImages.Gallery.HoverImageSize = new System.Drawing.Size(256, 192);
            this.gcImages.Gallery.ImageSize = new System.Drawing.Size(128, 128);
            this.gcImages.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.ZoomOutside;
            this.gcImages.Gallery.ShowItemText = true;
            this.gcImages.Gallery.ItemDoubleClick += new DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(this.gcImages_Gallery_ItemDoubleClick);
            this.gcImages.Location = new System.Drawing.Point(0, 0);
            this.gcImages.Name = "gcImages";
            this.gcImages.Size = new System.Drawing.Size(820, 190);
            this.gcImages.TabIndex = 0;
            this.gcImages.Text = "galleryControl1";
            // 
            // galleryControlClient1
            // 
            this.galleryControlClient1.GalleryControl = this.gcImages;
            this.galleryControlClient1.Location = new System.Drawing.Point(3, 3);
            this.galleryControlClient1.Size = new System.Drawing.Size(797, 184);
            // 
            // ucImageViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcImages);
            this.Name = "ucImageViewer";
            this.Size = new System.Drawing.Size(820, 190);
            ((System.ComponentModel.ISupportInitialize)(this.gcImages)).EndInit();
            this.gcImages.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.GalleryControl gcImages;
        private DevExpress.XtraBars.Ribbon.GalleryControlClient galleryControlClient1;

    }
}
