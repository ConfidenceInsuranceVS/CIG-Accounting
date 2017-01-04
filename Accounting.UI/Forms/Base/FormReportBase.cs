using DevExpress.XtraEditors;
using efControls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using static Accounting.AccountingServices;

namespace Accounting
{
    public partial class FormReportBase : efBaseForm
    {
        enum CommandType { Browse, Print, Preview, Exit };
        public FormReportBase()
        {
            InitializeComponent();
            de = new AllFormExtensions<ITableAll>();
        }
        protected virtual void proceed() { }
        protected virtual void print(bool toPrint) { }
        private void execute(CommandType cmd)
        {
            try
            {
                Splash.Show(this);
                lcReport.Enabled = false;
                switch (cmd)
                {
                    case CommandType.Browse:
                        proceed();
                        break;
                    case CommandType.Preview:
                        print(false);
                        break;
                    case CommandType.Print:
                        print(true);
                        break;
                    case CommandType.Exit:
                        Close();
                        break;
                }
                lcReport.Enabled = true;
                Splash.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            lcReport.Enabled = true;
            Splash.Close();
        }
        private void cmdBrowse_Click(object sender, EventArgs e)
        {
            execute(CommandType.Browse);
        }
        private void cmdPreview_Click(object sender, EventArgs e)
        {
            execute(CommandType.Preview);
        }
        private void cmdPrint_Click(object sender, EventArgs e)
        {
            execute(CommandType.Print);
        }
        private void cmdExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        protected void showPDF(int id)
        {
            var doc = getfileName(id);
            if (File.Exists(doc))
                try
                {
                    var b = new bfPDF();
                    b.fp.OwnerControl = new Control(this, "bf", PointToClient(Cursor.Position).X, PointToClient(Cursor.Position).Y, 0, 0);
                    b.pdfViewer.LoadDocument(doc);
                    b.fp.ShowBeakForm();
                }
                catch (Exception)
                {
                    Alert.Show("Corrupted PDF ...", Enums.AlertType.Warning);
                }
        }
        protected string getFilterString(efGridView gv)
        {
            return string.IsNullOrEmpty(gv.ActiveFilterString) ? string.Empty : string.Format("Filter : {0}", gv.ActiveFilterString);
        }
    }
}
