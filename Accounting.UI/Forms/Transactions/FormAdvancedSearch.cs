using efControls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static Accounting.AccountingServices;

namespace Accounting
{
    public partial class FormAdvancedSearch : efBaseForm
    {
        AccountingEntities ae;
        public FormAdvancedSearch()
        {
            InitializeComponent();

            ae = new AccountingEntities(App.MainConnectionString);
            spnYear.Properties.MinValue = 2003;
            spnYear.Properties.MaxValue = DateTime.Now.Year;
            spnYear.EditValue = App.WorkingYear;

            gvResult.OptionsBehavior.Editable = false;
            gvResult.OptionsBehavior.ReadOnly = true;

            colSC.Visible = App.HasSubCompanies;
            xState = Enums.State.None; //??
        }

        protected override void OnShown(EventArgs e)
        {
            getData(App.WorkingYear);
            base.OnShown(e);
        }
        private void getData(int year)
        {
            try
            {
                lcAdvancedSearch.Enabled = false;
                Splash.Show(this);
                bsResult.DataSource = ae.AdvancedSearch(year).ToList();
                Splash.Close();
                lcAdvancedSearch.Enabled = true;
            }
            catch (Exception )
            {
            }
        }

        private void spnYear_EditValueChanged(object sender, EventArgs e)
        {
            int year = 0;
            if (spnYear.EditValue != null)
                year = int.Parse(spnYear.Text);
            getData(year);
        }

        private void gvResult_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            var rec = (AdvancedSearch)bsResult.Current;
            if (e.Clicks == 2)
                CallTransactionForm.callTransactionForm((FormMain)this.MdiParent, ((DateTime)rec.jvdate).Year, rec.type, (int)rec.ID);
            else
                if (e.Column == colScan)
                {
                    var doc = getfileName(rec.ID);
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
        }

        private void gvResult_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Row == null) { return; }
            if (e.IsGetData)
            {
                var rec = (AdvancedSearch)e.Row;
                if (rec.ID > 0)
                {
                    var doc = getfileName((int)rec.ID);
                    if (File.Exists(doc))
                        e.Value = formImages.Images[0];
                    else
                        e.Value = null;
                }
            }
        }

        private void cmdExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("AdvancedSearch-{0}-{1}-{2}.xlsx", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

            savefile.Filter = "Excel Files (*.xlsx)|*.xlsx|All files (*.*)|*.*";

            if (savefile.ShowDialog() == DialogResult.OK)
                gvResult.ExportToXlsx(savefile.FileName);
        }
    }
}
