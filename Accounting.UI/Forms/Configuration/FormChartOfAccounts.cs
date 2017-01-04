using efControls;
using System;
using System.Collections.Generic;
using System.Linq;
using static Accounting.AccountingServices;

namespace Accounting
{
    public partial class FormChartOfAccounts : efDataSearchForm
    {
        public FormChartOfAccounts()
        {
            InitializeComponent();
            isMoveLast = false;
            de = new AllFormExtensions<Chartofaccount>() { f = this };
            //
            bsMaster.DataMember = "Chart";
            bsDetails.DataMember = "Chartofaccountsdetails";
            //
            txtcode.Properties.MaxLength = App.AccLength;
            lcgDetails.Enabled = false;
        }

        #region C.R.U.D
        protected override void onFormNew() { txtcode.Focus(); }
        protected override void onFormEdit() { txtDescription.Focus(); }
        #endregion

        #region on Form Functions
        protected override void onFormLoadSearchData()
        {
            base.onFormLoadSearchData();
            var _id = currentID;
            bsSearch.DataSource = listCharts(dbContext as AccountingEntities);
            de.setPosition<ChartSearchList>(_id);
        }
        protected override string onFormGetDeleteString()
        {
            var rec = (Chartofaccount)bsMaster.Current;
            return string.Format("[{0}] [{1}]", rec.Code, rec.Description);
        }
        #endregion
        private void txtcode_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //var ctrl = sender as efTextBox;
            //if (!ctrl.toValidate()) { return; }

            //var rec = (Chartofaccount)bsMaster.Current;
            //if (string.IsNullOrEmpty(txtcode.Text))
            //    setControlError(ctrl, "Code is required !!!", e);
            //else if (dbContext.Set<Chartofaccount>().FirstOrDefault(c => c.Code == ctrl.Text.TrimEnd()) != null)
            //    setControlError(ctrl, "Duplicated Code !!!", e);

            if (xState == Enums.State.Edit) { return; }// added by Samir 28/11/2016
            if (!txtcode.toValidate()) { return; }
            var ctrl = sender as efTextBox;
            var rec = (Chartofaccount)bsMaster.Current;
            if (string.IsNullOrEmpty(txtcode.Text))
                setControlError(ctrl, "Code is required !!!", e);

            if (getChartOfAccount().FirstOrDefault(c => c.Code == ctrl.Text) != null) // added by Samir 28/11/2016

                setControlError(ctrl, "Duplicated Code !!!", e);
            else
                clearControlError(ctrl, e);
        }
        private void cboAccountType_EditValueChanged(object sender, EventArgs e)
        {
            //if (cboAccountType.EditValue == null)
            //    lcgDetails.Enabled = false;
            //else
            //{
            //    var rec = (Chartofaccount)bsMaster.Current;
            //    rec.Accounttypeid = (int)cboAccountType.EditValue;

            //    if (rec.Chartofaccountsdetails.Count == 0)
            //        bsDetails.Add(new Chartofaccountsdetail() { Accountid = rec.ID });

            //    lcgDetails.Enabled = true;
            //}
        }
    }
}
