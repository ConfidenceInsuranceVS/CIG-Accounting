using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using efControls;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Accounting
{
    public partial class FormCashDistribution : FormBase
    {
        public FormCashDistribution()
        {
            InitializeComponent();
            de = new ITableSomeServices<Cashdistribution>() { f = this };
        }

        #region C.R.U.D
        protected override void onFormEdit()
        {
            base.onFormEdit();
            colCode.OptionsColumn.ReadOnly = true;
            gvForm.ShowEditForm();
        }
        protected override void onFormNew()
        {
            base.onFormNew();
            colCode.OptionsColumn.ReadOnly = false;
            gvForm.ShowEditForm();
        }
        protected override void onFormSave()
        {
            gvForm.CloseEditForm();
            base.onFormSave();
        }
        #endregion

        #region FormOverrides
        protected override string onFormGetDeleteString()
        {
            var rec = (Cashdistribution)bsMaster.Current;
            return string.Format("[{0}] [{1}]", rec.Code, rec.Description);
        }
        protected override void onFormGetMasterData()
        {
            bsMaster.DataSource = dbContext.Set<Cashdistribution>().ToList();
            base.onFormGetMasterData();
        }
        protected override void onShownSetPosition()
        {
            gvForm.MoveLast();
            base.onShownSetPosition();
        }
        protected override void onFormValidate()
        {
            if (bsMaster.List.OfType<Cashdistribution>().Where(c => string.IsNullOrEmpty(c.Code) & (!string.IsNullOrEmpty(c.Description))).Count() > 0)
                throw new Exception("Missing Code !!!");
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
                    case "CODE":
                        if (string.IsNullOrEmpty(ev.Value.ToString().Trim())) { throw new Exception("Empty Code !!!"); }
                        var rec = (Cashdistribution)bsMaster.Current;
                        var lst = bsMaster.List.OfType<Cashdistribution>().ToList().Where(c => c.Code == ev.Value.ToString().Trim() & c.ID != rec.ID).Count();
                        if (lst > 0)
                            throw new Exception("Duplicated Code !!!");
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
