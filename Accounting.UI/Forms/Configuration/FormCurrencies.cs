using DevExpress.XtraGrid.Views.Base;
using efControls;
using System;
using System.Collections.Generic;
using System.Linq;
using static Accounting.AccountingServices;

namespace Accounting
{
    public partial class FormCurrencies : efDataSearchForm
    {
        public FormCurrencies()
        {
            InitializeComponent();
            de = new AllFormExtensions<Currency>() { f = this };
            //
            bsMaster.DataMember = "Currency";
            bsDetails.DataMember = "Rates";
            //
            spnOrder.Properties.MinValue = 1;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            spnOrder.Properties.MaxValue = dbContext.Set<Currency>().Count() + 1;
        }

        #region C.R.U.D
        protected override void onFormNew() { txtcode.Focus(); }
        protected override void onFormEdit() { txtDescription.Focus(); }
        protected override bool onFormPrint(bool toPrint)
        {
            var rec = (Currency)bsMaster.Current;
            ReportTitle = string.Format("Currency : {0}", rec.Description);
            return base.onFormPrint(toPrint);
        }
        #endregion
        public override bool onFormCanDelete()
        {
            var aa = dbContext.Set<Journalchild>().Where(c => c.Currencyid == ((Currency)bsMaster.Current).ID).FirstOrDefault();
            var bb = aa == null;
            return dbContext.Set<Journalchild>().FirstOrDefault(c => c.Currencyid == ((Currency)bsMaster.Current).ID) == null;
        }
        protected override string onFormGetDeleteString()
        {
            var rec = (Currency)bsMaster.Current;
            return string.Format("[{0}] [{1}]", rec.Code, rec.Description);
        }
        protected override void onFormLoadSearchData()
        {
            base.onFormLoadSearchData();
            var _id = currentID;
            bsSearch.DataSource = listCurrencies(dbContext as AccountingEntities).OrderBy(c => c.Description);
            de.setPosition<CurrencySearchList>(_id);
        }
        private void txtcode_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //if (!txtcode.toValidate()) { return; }
            //if (dbContext.Set<Currency>().Where(c => c.Code == txtcode.Text.TrimEnd() | string.IsNullOrEmpty(txtcode.Text)).FirstOrDefault() != null)
            //{
            //    ControlValidate(txtcode);
            //    txtcode.Text = string.Empty;
            //    e.Cancel = true;
            //}

            if (xState == Enums.State.Edit) { return; }// added by Samir 28/11/2016
            //if (!txtcode.toValidate()) { return; }
            var ctrl = sender as efTextBox;
            var rec = (Currency)bsMaster.Current;
            if (string.IsNullOrEmpty(ctrl.Text))  // added by Samir 28/11/2016
                setControlError(ctrl, "Code is required !!!", e);

            if (getCurrencies().FirstOrDefault(c => c.Code == ctrl.Text) != null) // added by Samir 28/11/2016

                setControlError(ctrl, "Duplicated Code !!!", e);
            else
                clearControlError(ctrl, e);
        }
        private void bbigvAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bsDetails.AddNew();

            var view = (ColumnView)gcRates.MainView;
            view.FocusedColumn = view.VisibleColumns[3];
            view.ShowEditor();
        }
        private void bbigvDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gvRates.DeleteSelectedRows();
        }
    }
}
