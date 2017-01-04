using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using DevExpress.XtraBars.Ribbon;
using DevExpress.Utils.Drawing;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting;

namespace efControls
{
    public partial class ucImageViewer : DevExpress.XtraEditors.XtraUserControl
    {
        public string imagePath;
        GalleryItemGroup gig;

        public ucImageViewer()
        {
            InitializeComponent();
            gig = new GalleryItemGroup();
            gcImages.Gallery.Groups.Add(gig);
        }
        protected List<string> GetImagesInFolder(string folder)
        {
            string strFilter = "*.bmp;*.tga;*.jpg;*.png;*.gif";
            string[] m_arExt = strFilter.Split(';');
            List<string> files = new List<string>();
            foreach (string filter in m_arExt)
            {
                string[] str = Directory.GetFiles(folder, filter);
                files.AddRange(str);
            }

            if (files.Count > 50)
                for (int i = files.Count - 1; i > 50; i--)
                {
                    files.RemoveAt(i);
                }
            return files;
        }
        public void getImages()
        {
            gig.Caption = imagePath;
            gig.Items.Clear();

            List<string> files = GetImagesInFolder(imagePath);
            if (files.Count > 0)
            {
                foreach (var file in files)
                {
                    Image img = Image.FromFile(file);
                    img.Tag = file;

                    GalleryItem gi = new GalleryItem(img, "", "");

                    gig.Items.Add(gi);
                }
            }
        }

        private void gcImages_Gallery_ItemDoubleClick(object sender, GalleryItemClickEventArgs e)
        {
            XtraReport xr = new XtraReport();
            XRPictureBox pb = new XRPictureBox()
            {
                Image = e.Item.Image,
                SizeF = new SizeF(597.9167F, 583.1665F),
                Sizing = ImageSizeMode.ZoomImage

            };
            DetailBand db = new DetailBand();
            xr.Bands.Add(db);
            db.Controls.AddRange(new XRControl[] { pb });

            using (ReportPrintTool printTool = new ReportPrintTool(xr)) { printTool.ShowPreviewDialog(); }
        }

    }
}
