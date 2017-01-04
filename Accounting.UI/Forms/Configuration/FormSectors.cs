using DevExpress.XtraGrid.Views.Grid;
using efControls;
using System;
using System.Collections.Generic;
using System.Linq;
using static Accounting.AccountingServices;

namespace Accounting
{
    public partial class FormSectors : efDataSearchForm
    {
        public FormSectors()
        {
            InitializeComponent();
            de = new AllFormExtensions<Sector>() { f = this };
        }
        private void TxtCode_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (xState == Enums.State.Edit) { return; }// added by Samir 28/11/2016
            var ctrl = sender as efTextBox;
            var rec = (Sector)bsMaster.Current;
                    
            if (getSectors().FirstOrDefault(c => c.Code == ctrl.Text) != null) // added by Samir 28/11/2016

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
            var rec = (Sector)bsMaster.Current;
            return string.Format("[{0}] [{1}]", rec.Code, rec.Description);
        }
        protected override void onFormLoadSearchData()
        {
            base.onFormLoadSearchData();
            var _id = currentID;
            bsSearch.DataSource = listSectors(dbContext as AccountingEntities);
            de.setPosition<SectorSearchList>(_id);
            //
            bsMaster.DataMember = "Sector";
        }
        public override bool onFormCanDelete()
        {
            var rec = (Sector)bsMaster.Current;
            var result = dbContext.Set<Chartofaccountsdetail>().FirstOrDefault(c => c.sectorid == rec.ID) == null ? true : false; 
            return result;
        }
        #endregion
    }
}
