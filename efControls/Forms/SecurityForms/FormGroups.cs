using DevExpress.XtraGrid.Views.Grid;
using efControls.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace efControls
{
    public partial class FormGroups : efDataForm
    {
        private GroupRole gr;

        public FormGroups()
        {
            InitializeComponent();
            de = new SecurityDataFormServices<Group>() { f = this };
        }

        #region C.R.U.D
        protected override void onFormNew()
        {
            base.onFormNew();
            gvGroups.ShowEditForm();
        }
        protected override void onFormEdit()
        {
            base.onFormEdit();
            gvGroups.ShowEditForm();
        }
        protected override void onFormSave()
        {
            gvGroups.CloseEditForm();
            base.onFormSave();
            createRoles(((Group)bsMaster.Current).ID);
        }
        #endregion
        protected override void onFormLoadSearchData()// added by samir 1/12
        {
            base.onFormLoadSearchData();
            var _id = currentID;
            //  var aa = SecurityService.listDepartments();
            bsSearch.DataSource = SecurityService.listGroups();
          //  de.setPosition<User>(_id);
            //
            bsMaster.DataMember = "Group";
        }


        protected override void onFormGetMasterData()
        {
            bsMaster.DataSource = dbContext.Set<Group>().OrderBy(c => c.Description).ToList();
            base.onFormGetMasterData();
        }
        protected override void onShownSetPosition()
        {
            gvGroups.MoveLast();
            base.onShownSetPosition();
        }
        //protected override void onFormValidate()
        //{
        //    if (bsMaster.List.OfType<Group>().Where(c => !string.IsNullOrEmpty(c.Description)).Count() > 0)
        //        throw new Exception("Missing Description !!!");
        //}

        private void createRoles(int id)
        {
            foreach (var form in dbContext.Set<Form>().ToList())
            {
                var grs = dbContext.Set<GroupRole>().Where(g => g.GroupID == id & g.FormID == form.ID).ToList();
                if (grs.Count == 0)
                {
                    gr = new GroupRole()
                    {
                        GroupID = id,
                        FormID = form.ID
                    };
                    dbContext.Set<GroupRole>().Add(gr);
                }
            }
            dbContext.SaveChanges();
        }

        //#region FormOverrides
        //protected override bool recordExist() { return recordExist<Group>(bsMaster); }
        //protected override bool doGetSearchData() { return checkChanges<Group>("Groups", null); }
        //protected override void onFormRefreshRecord() { refreshRecord<Group>(); }
        //#endregion

        private void gvGroups_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            var ev = (EditFormValidateEditorEventArgs)e;
            var gv = (efGridView)sender;
            if (gv.IsFilterRow(gv.FocusedRowHandle)) { return; }

            var result = true;
            try
            {
                switch (gv.FocusedColumn.FieldName.ToUpper())
                {
                    case "DESCRIPTION":
                        if (string.IsNullOrEmpty(ev.Value.ToString().Trim())) { throw new Exception("Empty Code !!!"); }
                        var rec = (Group)bsMaster.Current;
                        var lst = bsMaster.List.OfType<Group>().ToList().Where(c => c.Description == ev.Value.ToString().Trim() & c.ID != rec.ID).Count();
                        if (lst > 0)
                            throw new Exception("Duplicated Description !!!");
                        break;

                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Alert.Show(ex.Message, "Access Denied !!!", Enums.AlertType.Critical);
                result = false;
            }
            ev.ErrorText = string.Empty;
            ev.Valid = result;
        }
    }
}
