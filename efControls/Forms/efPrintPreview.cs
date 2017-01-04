using DevExpress.DocumentView;
using DevExpress.XtraPrinting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace efControls
{
    public partial class efPrintPreview : DevExpress.XtraEditors.XtraForm
    {
        private Document rep;
        public efPrintPreview()
        {
            InitializeComponent();
        }

        public efPrintPreview(efMainForm mf) :this()
        {
            Size = mf.mfSize;
            DesktopLocation = mf.mfLocation;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            rep = documentViewer.PrintingSystem.Document;
        }
        private void bbiSettings_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var ps = documentViewer.PrintingSystem.PageSettings;
            var str = new StringBuilder();
            str.Append(beiPrinters.EditValue.ToString());
            str.AppendFormat("|{0}", ps.PaperName);
            str.AppendFormat("|{0}", ps.PaperKind);
            str.AppendFormat("|{0}", ps.Landscape ? rep.PrintingSystem.PageBounds.Height : rep.PrintingSystem.PageBounds.Width);
            str.AppendFormat("|{0}", ps.Landscape ? rep.PrintingSystem.PageBounds.Width : rep.PrintingSystem.PageBounds.Height);
            str.AppendFormat("|{0}", ps.Landscape);
            str.AppendFormat("|{0}", ps.Margins.Left);
            str.AppendFormat("|{0}", ps.Margins.Right);
            str.AppendFormat("|{0}", ps.Margins.Top);
            str.AppendFormat("|{0}", ps.Margins.Bottom);
            str.AppendFormat("|{0}", documentViewer.PrintingSystem.Document.AutoFitToPagesWidth);
            str.AppendFormat("|{0}", documentViewer.PrintingSystem.Document.ScaleFactor);

            XML.Write(App.LocalPreferencesFile, "Reports", rep.Name, str.ToString());
        }

        private void efPrintPreview_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)27) { Close(); }
        }
    }
}