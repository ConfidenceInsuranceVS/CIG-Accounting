using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static Accounting.AccountingServices;

namespace Accounting
{
    public partial class FormPostUnpost : efControls.efBaseForm
    {
        DateTime? fDate, tDate;
        int? vType, yDate, fReference, tReference, sc;
        public FormPostUnpost()
        {
            InitializeComponent();

            deFrom.Properties.MinValue = deTo.Properties.MinValue = new DateTime(App.WorkingYear, 1, 1);
            deFrom.Properties.MaxValue = deTo.Properties.MaxValue = new DateTime(App.WorkingYear, 12, 31);

            deFrom.EditValue = new DateTime(App.WorkingYear, 1, 1);
            deTo.EditValue = getMaxDate(App.WorkingYear);  //DateTime.Now.AddDays(-1);
        }

        private void deFrom_Validated(object sender, EventArgs e)
        {
            if (deFrom.EditValue == null) { return; }
            if (deTo.EditValue == null) { deTo.EditValue = deFrom.EditValue; }
        }

        private void deTo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (deTo.EditValue == null) { return; }
            if ((DateTime?)deTo.EditValue < (DateTime?)deFrom.EditValue) { deTo.EditValue = deFrom.EditValue; }
        }

        private void txtFromReference_Validated(object sender, EventArgs e)
        {
            if(txtFromReference.EditValue == null) { return; }
            if(txtToReference.EditValue  == null) { txtToReference.EditValue = txtFromReference.EditValue; }
        }

        private void txtToReference_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtToReference.EditValue == null) { return; }
            if ((int?)txtToReference.EditValue < (int?)txtFromReference.EditValue) { txtToReference.EditValue = txtFromReference.EditValue; }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            if (efControls.Alert.ShowDialogMessage("Are you sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            fillVars();
            int result = 0;
            using(AccountingEntities ae = new AccountingEntities(App.MainConnectionString))
            {
                result = ae.PostUnpostVouchers(true, yDate, fDate, tDate, vType, fReference, tReference, sc);
            }
            efControls.Alert.ShowMessage(string.Format("{0} Voucher(s) Posted !!!", result));
        }

        private void btnUnPost_Click(object sender, EventArgs e)
        {
            if (efControls.Alert.ShowDialogMessage("Are you sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            fillVars();
            int result = 0;
            using (AccountingEntities ae = new AccountingEntities(App.MainConnectionString))
            {
                result = ae.PostUnpostVouchers(false, yDate, fDate, tDate, vType, fReference, tReference, sc);
            }
            efControls.Alert.ShowMessage(string.Format("{0} Voucher(s) UnPosted !!!", result));
        }

        private void fillVars()
        {
            fDate = (DateTime?)deFrom.EditValue;
            tDate = (DateTime?)deTo.EditValue;
            fReference = (int?)txtFromReference.EditValue;
            tReference = (int?)txtToReference.EditValue;
            yDate = App.WorkingYear;
            vType = (int?)cboVoucherTypes.EditValue;
            sc = (int?)cboSubCompanies.EditValue;
        }
    }
}
