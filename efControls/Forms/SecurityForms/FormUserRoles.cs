using efControls.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using static efControls.SecurityService;// added by samir 20/12

namespace efControls
{
    public partial class FormUserRoles : efDataSearchForm
    {
        public FormUserRoles()
        {
            InitializeComponent();
            de = new efFormExtensions<User>() { f = this };
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //esSearch.QueryableSource = dbContext.Set<User>();
            //esSearch.DefaultSorting = "Name";
        }

        protected override void onFormLoadSearchData()// added by samir 1/12
        {
            base.onFormLoadSearchData();
            var _id = currentID;
            //  var aa = SecurityService.listDepartments();
            //   bsSearch.DataSource = SecurityService.listUsers();// stopped by samir 20/12/2016
            bsSearch.DataSource = listUsers();//dbContext as SecurityEntities);// added by samir 20/12/2016
            // de.setPosition<User>(_id);
            //
            bsMaster.DataMember = "User";
        }

        protected override void onFormGetLookupData()
        {
            base.onFormGetLookupData();
            bsForms.DataSource = dbContext.Set<Form>().OrderBy(c => c.FormGroup).ThenBy(c => c.FormGroup).ToList();
        }
        #region C.R.U.D
        //private void FormUserRoles_xCancel(object sender, EventArgs e)
        //{
        //    bsRoles.CancelEdit();
        //    gvRoles.CancelUpdateCurrentRow();
        //}
        //private void FormUserRoles_xSave(object sender, EventArgs e)
        //{
        //    switch (xState)
        //    {
        //        case Enums.State.New:
        //            dbContext.InsertRecord<User>((User)bsMaster.Current);
        //            break;
        //        case Enums.State.Edit:
        //            dbContext.UpdateRecord<User>((User)bsMaster.Current); ;
        //            break;
        //    }
        //}
        //private void FormUserRoles_xDelete(object sender, EventArgs e)
        //{
        //    dbContext.DeleteRecord<User>((User)bsMaster.Current);
        //}
        //private void FormUserRoles_xEdit(object sender, EventArgs e)
        //{
        //    cboForms.Focus();
        //}
        protected override void onFormEdit()
        {
            base.onFormEdit();
            cboForms.Focus();
        }
        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboForms.EditValue == null) { return; }

              var ur = new UserRole() { FormID = (int)cboForms.EditValue, Form = cboForms.GetSelectedDataRow() as Form };
              
                bsRoles.Add(ur);
                Refresh();
            }
            catch(Exception ex)
            {
                Alert.ShowMessage(ex.Message.ToString());
            }
        
        }

        // Added
        private void btnDeleteForm_Click(object sender, EventArgs e)
        {
            var ur = (UserRole)bsRoles.Current;
            bsRoles.Remove(ur);
            Refresh();
        }
    }
}
