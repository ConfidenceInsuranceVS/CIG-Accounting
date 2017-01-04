using System;
using System.Collections.Generic;
using Dosadi.EZTwain;
using System.Text;
using DevExpress.XtraEditors;
using System.IO;
using DevExpress.XtraBars;
using System.Windows.Forms;

namespace efControls
{
    public partial class ucScanControl : XtraUserControl
    {
        public string filename;
        public efDataForm frm;
        public ucScanControl()
        {
            InitializeComponent();
        }
        private void btnScan_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                EZTwain.LogFile(1);
                EZTwain.SetHideUI(false);
                EZTwain.SetJpegQuality(75);

                bool iOpen;
                if (beiSelect.EditValue != null)
                    iOpen = EZTwain.OpenSource(beiSelect.EditValue.ToString());
                else
                    iOpen = EZTwain.SelectImageSource(IntPtr.Zero);

                if (!iOpen) { throw new Exception("Unable To Open Scanner"); }
                EZTwain.SetFileAppendFlag(true);

                // If you can't get a Window handle, use IntPtr.Zero:
                IntPtr hDib = (IntPtr)EZTwain.AcquireMultipageFile(Handle, filename);
                if (hDib.ToInt32() > 0)
                {
                    EZTwain.DibWritePage(hDib);
                    EZTwain.DIB_Free(hDib);
                }

                EZTwain.EndMultipageFile();
                EZTwain.CloseSource();

                if (EZTwain.LastErrorCode() != 0) { throw new Exception("Unable To Scan"); }
                loadFile(filename);
                XML.Write(App.PreferencesFile, "General", "Scanner", beiSelect.EditValue.ToString());
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!File.Exists(filename)) { return; }
            //
            var yn = Alert.ShowDialogMessage(String.Format("Delete File : {0}", filename));
            if (yn == DialogResult.No) { return; }
            //
            pdfViewer.CloseDocument();
            _close(true);
        }
        private void btnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            _close(false);
        }
        protected void fillDeviceSources()
        {
            StringBuilder buffer = new StringBuilder();
            if (EZTwain.GetSourceList())
            {
                buffer.EnsureCapacity(64);
                while (EZTwain.GetNextSourceName(buffer))
                {
                    riCboScanners.Items.Add(buffer.ToString());
                    buffer.EnsureCapacity(64);
                }
            }
            else
            {
                XtraMessageBox.Show("No TWAIN devices found.");
            }
        }
        protected void loadFile(string filename)
        {
            try
            {
                pdfViewer.LoadDocument(filename);
            }
            catch (Exception)
            {
                Alert.Show("Corrupted PDF ...", Enums.AlertType.Information);
            }
        }
        protected void EnableParent(bool enabled)
        {
            frm.sccMain.Visible = enabled;
            frm.lcSearch.Enabled = frm.lcMain.Enabled = enabled;
            frm.toolBar.BeginUpdate();
            try
            {
                foreach (BarItemLink link in frm.toolBar.ItemLinks)
                    link.Item.Enabled = enabled;
            }
            finally
            {
                frm.toolBar.EndUpdate();
            }
        }
        private void _close(bool delete)
        {
            EnableParent(true);
            frm.Controls.Remove(this);
            if (delete) { File.Delete(filename); }
            frm.Refresh();
        }
    }
}
