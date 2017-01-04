using DevExpress.XtraGrid.Views.Grid;
using efControls;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Accounting
{
    public partial class FormBalanceSheetAccounts : FormBase
    {
        public FormBalanceSheetAccounts()
        {
            InitializeComponent();
            de = new ITableSomeServices<Balancesheetaccount>() { f = this };
        }

        #region C.R.U.D
        protected override void onFormEdit()
        {
            base.onFormEdit();
            gvForm.ShowEditForm();
        }
        protected override void onFormNew()
        {
            base.onFormNew();
            gvForm.ShowEditForm();
        }
        protected override void onFormSave()
        {
            gvForm.CloseEditForm();
            base.onFormSave();
        }
        #endregion

        #region FormOverrides
        //public override bool onFormCanDelete()
        //{
        //    return dbContext.Set<Chartofaccount>().FirstOrDefault(c => c.Balancesheetid == ((Balancesheetaccount)bsMaster.Current).ID) == null;
        //}
        protected override string onFormGetDeleteString()
        {
            var rec = (Balancesheetaccount)bsMaster.Current;
            return string.Format("[{0}]", rec.Description);
        }
        protected override void onFormGetMasterData()
        {
            bsMaster.DataSource = dbContext.Set<Balancesheetaccount>().OrderBy(c => c.Description).ToList();
            base.onFormGetMasterData();
        }
        protected override void onShownSetPosition()
        {
            gvForm.MoveLast();
            base.onShownSetPosition();
        }
        #endregion

        private void gvForm_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            var ev = (EditFormValidateEditorEventArgs)e;
            var gv = (efGridView)sender;
            if (gv.IsFilterRow(gv.FocusedRowHandle)) { return; }

            var result = true;
            try
            {
                switch (ev.Column.FieldName.ToUpper())
                {
                    case "DESCRIPTION":
                        if (string.IsNullOrEmpty(ev.Value.ToString().Trim())) { throw new Exception("Empty Description !!!"); }
                        var rec = (Balancesheetaccount)bsMaster.Current;
                        var lst = bsMaster.List.OfType<Balancesheetaccount>().ToList().Where(c => c.Description == ev.Value.ToString().Trim() & c.ID != rec.ID).Count();
                        if (lst > 0)
                            throw new Exception("Duplicated Description !!!");
                        break;

                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Alert.Show(Enums.AlertType.AccessDenied, ex.Message);
                result = false;
            }
            ev.ErrorText = string.Empty;
            ev.Valid = result;
        }
    }
}
