using System;
using System.Linq;
using efControls;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data.Entity.Core.EntityClient;
using efControls.Data;
using static Accounting.AccountingServices;
using System.ComponentModel;

namespace Accounting
{
    public partial class FormImportVoucher : efBaseForm
    {
        public Journalparent jp { get; set; }
        //public int jvRef { get; set; }
        public int jvType { get; set; }
        public FormImportVoucher()
        {
            InitializeComponent();

            spnYear.EditValue = App.WorkingYear;
            cboCompanies.EditValue = App.CompanyID;
            cboSubCompanies.EditValue = getDefaultSubCompanyID();
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            //to not display quit dialog
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            cboVoucherTypes.EditValue = jvType;
            txtReference.Focus();
        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            importJV();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
        private void importJV()
        {
            using (SecurityEntities se = new SecurityEntities(App.SecurityConnectionString))
            {
                var catalog = se.Companies.FirstOrDefault(c => c.ID == (int)cboCompanies.EditValue).DatabaseName;

                EntityConnectionStringBuilder es = new EntityConnectionStringBuilder()
                {
                    Provider = "System.Data.SqlClient",
                    Metadata = string.Format("res://*/{0}.csdl|res://*/{0}.ssdl|res://*/{0}.msl", App.ApplicationModel),
                    ProviderConnectionString = App.getConnectionString(catalog)
                };

                var ydat = int.Parse(spnYear.Text);
                var type = (int)cboVoucherTypes.EditValue;
                var refe = int.Parse(txtReference.Text);
                AccountingEntities ae = new AccountingEntities(es.ConnectionString);
                jp = ae.Journalparents.FirstOrDefault(c => c.YDate == ydat && c.Vouchertypeid == type && c.Reference == refe & c.SC == (int)cboSubCompanies.EditValue);
            }
        }
    }
}
