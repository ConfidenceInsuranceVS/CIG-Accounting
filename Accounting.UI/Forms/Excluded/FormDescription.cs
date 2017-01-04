using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using efControls;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Accounting
{
    public partial class FormDescription : FormBase
    {
        public FormDescription()
        {
            InitializeComponent();
            de = new ITableSomeServices<description>() { f = this };
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
        protected override void onFormGetMasterData()
        {
            bsMaster.DataSource = dbContext.Set<description>().OrderBy(c=>c.Description).ToList();
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
                switch (gv.FocusedColumn.FieldName.ToUpper())
                {
                    case "CODE":
                        if (string.IsNullOrEmpty(ev.Value.ToString().Trim())) { throw new Exception("Empty Code !!!"); }
                        var rec = (description)bsMaster.Current;
                        var lst = bsMaster.List.OfType<description>().ToList().Where(c => c.Code == ev.Value.ToString().Trim() & c.ID != rec.ID).Count();
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
