using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraGrid.Views.Grid;
using efControls;
using System;
using System.Linq;
using System.Windows.Forms;
using static Accounting.AccountingServices;

namespace Accounting
{
    public partial class FormVoucherType : efDataSearchForm
    {
        public FormVoucherType()
        {
            InitializeComponent();
            de = new AllFormExtensions<Vouchertype>() { f = this };

            
        }

        private void TxtCode_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //if (xState == Enums.State.Edit) { return; }// added by Samir 28/11/2016
            //var ctrl = sender as efTextBox;
            //var rec = (Vouchertype)bsMaster.Current;
            //try
            //{
            //    if (string.IsNullOrEmpty(ctrl.Text))  // added by Samir 28/11/2016
            //        throw new Exception("Code is required !!!");

            //    if (getVoucherTypes().FirstOrDefault(c => c.Code == ctrl.Text) != null) // added by Samir 28/11/2016
            //        throw new Exception("Duplicated Code !!!");

            //    clearControlError(ctrl, e);
            //}
            //catch (Exception ex)
            //{
            //    setControlError(ctrl, ex.Message, e);
            //    e.Cancel = true;
            //}

            //if (xState == Enums.State.Edit) { return; }// added by Samir 28/11/2016
            //var ctrl = sender as efTextBox;
            //var rec = (Vouchertype)bsMaster.Current;
            //if (string.IsNullOrEmpty(ctrl.Text))  // added by Samir 28/11/2016
            //    setControlError(ctrl, "Code is required !!!", e);

            //if (getVoucherTypes().FirstOrDefault(c => c.Code == ctrl.Text) != null) // added by Samir 28/11/2016
            //    setControlError(ctrl, "Duplicated Code !!!", e);
            //else
            //    clearControlError(ctrl, e);
            


            if (xState == Enums.State.Edit) { return; }         // added by Samir 28 / 11 / 2016
            var ctrl = sender as efTextBox;
            var rec = (Vouchertype)bsMaster.Current;
           
            if (getVoucherTypes().FirstOrDefault(c => c.Code == ctrl.Text) != null)
                setControlError(ctrl, "Duplicated Code !!!", e);
            else
                clearControlError(ctrl, e);
            
        }

      

        //protected override void OnLoad(EventArgs e) // added by Samir
        //{
        //     base.OnLoad(e);
        //    //ValidationProvider.SetValidationRule(txtCode, new CustomValidationRule());

        //    //var aa = new CustomValidationRule();
        //    //aa.Validate(txtCode, string.IsNullOrEmpty(txtCode.Text));
        //    //aa.ErrorText = "AJSDGAJKSGDKAJS";
        //    //aa.ErrorType = ErrorType.Information;
        //    //ValidationProvider.SetValidationRule(txtCode, aa);
        //}
        #region C.R.U.D
        protected override void onFormEdit() { txtDescription.Focus(); }
        protected override void onFormNew() { txtCode.Focus(); }
        protected override void onFormSave()
        {
               base.onFormSave();
            
        }
        #endregion

        

        #region FormOverrides
        protected override string onFormGetDeleteString()
        {
            var rec = (Vouchertype)bsMaster.Current;
            return string.Format("[{0}] [{1}]", rec.Code, rec.Description);
        }
        protected override void onFormLoadSearchData()
        {
            base.onFormLoadSearchData();
            var _id = currentID;
            bsSearch.DataSource = listVoucherTypes(dbContext as AccountingEntities).OrderBy(c=>c.OrderID);
            de.setPosition<VoucherTypeSearchList>(_id);
            //
            bsMaster.DataMember = "Vouchertype";
        }
        #endregion

    }
}
