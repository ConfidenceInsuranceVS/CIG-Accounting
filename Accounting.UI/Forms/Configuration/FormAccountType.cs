using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraGrid.Views.Grid;
using efControls;
using System;
using System.Linq;
using static Accounting.AccountingServices;

namespace Accounting
{
    public partial class FormAccountType : efDataSearchForm
    {
        public FormAccountType()
        {
            InitializeComponent();
            de = new AllFormExtensions<AccountType>() { f = this };

        }

        private void TxtCode_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
          
            if (xState == Enums.State.Edit) { return; }// added by Samir 28/11/2016
            var ctrl = sender as efTextBox;
            var rec = (AccountType)bsMaster.Current;
            if (string.IsNullOrEmpty(ctrl.Text))  // added by Samir 28/11/2016
                setControlError(ctrl, "Code is required !!!", e);

            if (getAccountType().FirstOrDefault(c => c.Code == ctrl.Text) != null) // added by Samir 28/11/2016

                setControlError(ctrl, "Duplicated Code !!!", e);
            else
                clearControlError(ctrl, e);
        }

        #region C.R.U.D
        protected override void onFormEdit() { txtDescription.Focus(); }
        protected override void onFormNew() { txtCode.Focus(); }
        #endregion

        #region FormOverrides
        protected override string onFormGetDeleteString()
        {
            var rec = (AccountType)bsMaster.Current;
            return string.Format("[{0}] [{1}]", rec.Code, rec.Description);
        }
        protected override void onFormLoadSearchData()
        {
            base.onFormLoadSearchData();
            var _id = currentID;
            bsSearch.DataSource = listAccountType(dbContext as AccountingEntities);
            de.setPosition<AccountTypeSearchList>(_id);
            //
            bsMaster.DataMember = "AccountType";
        }
        #endregion
    }
}
