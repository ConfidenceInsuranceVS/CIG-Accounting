using efControls.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static efControls.SecurityService;// added by samir 20/12




namespace efControls
{
    public partial class FormUsers : efDataSearchForm
    {

        public FormUsers()
        {
            InitializeComponent();
            isSecurity = true;
            de = new efFormExtensions<User>() { f = this };
        }

        protected override void onFormLoadSearchData()// added by samir 1/12
        {
            base.onFormLoadSearchData();
            var _id = currentID;
            //  var aa = SecurityService.listDepartments();
            //  bsSearch.DataSource = SecurityService.listUsers();//stopped by samir 20/12/2016
            //de.setPosition<User>(_id);// stopped by samir  2/12/2016 on edit it is retrieving data for user id 1
            //
            //bsMaster.DataMember = "User";

            //
            bsSearch.DataSource = listUsers();// dbContext as SecurityEntities); //added by samir 20/12/2016

            //  de.setPosition<listUsers>(_id);
            bsMaster.DataMember = "User";
            if (xState == Enums.State.Edit)
            {
                btnChangePassword.Visible = true;
                pcePassword.Visible = false;
            }
            else
            {
                btnChangePassword.Visible = false;
            }
            
            //

        }
        protected override void onFormGetLookupData()
        {
            base.onFormGetLookupData();
            bsDepartments.DataSource = dbContext.Set<Department>().OrderBy(c => c.Description).ToList();
            bsGroups.DataSource = dbContext.Set<Group>().OrderBy(c => c.Description).ToList();
        }
        protected override void onFormSave()//added by Samir BU 13/12/2016-User
        {

            //if (string.IsNullOrEmpty(txtConfirm.Text)) {
            //    Alert.Show("Enter Password !!", Enums.AlertType.Warning);
            //    return;
            //}
            //if (!ValidatePasswords(txtPassword, txtConfirm)) {
            //    Alert.Show("Passwords does not match ...", Enums.AlertType.Warning);
            //   // return;
            //}

            //if (xState == Enums.State.New)
            //{
            //    txtPassword.CausesValidation = true;
            //    txtConfirm.CausesValidation = true;
            //    txtPassword.DoValidate();
            //    txtConfirm.DoValidate();
            //}

            var rec = (User)bsMaster.Current; // added by samir BU 13/12/2016-User 
            rec.Password = SecurityService.Encryptmd5(txtConfirm.Text.Trim()); // added by samir BU 13/12/2016-User
            base.onFormSave();

        }
        #region C.R.U.D
        protected override string onFormGetDeleteString()// added 02/12 by samir
        {
            //var rec = (Bank)bsMaster.Current;
            //return string.Format("[{0}] [{1}]", rec.Code, rec.Description);
            //var rec = (Department)bsMaster.Current;
            //return string.Format("[{0}] [{1}]", rec.ID, rec.Description);
            var rec = (User)bsMaster.Current;
            return string.Format("[{0}] [{1}]", rec.ID, rec.Name);
        }
        protected override void onFormEdit()
        {
            //base.onFormEdit();
            nameefTextBox.Focus();

            lcgPassword.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never; //added by samir UE-20/12/2016-1
            ValidationProvider.SetValidationRule(txtPassword, null);//added by samir UE-20/12/2016-1
            ValidationProvider.SetValidationRule(txtConfirm, null);//added by samir UE-20/12/2016-1
            ValidationProvider.SetValidationRule(txtOldPass, null);//added by samir UE-20/12/2016-1
            //  pcePassword.Properties.Buttons[0].Visible = false; //added by samir UE-20/12/2016-1
            txtOldPass.Properties.ReadOnly = true;//added by Samir BU 13/12/2016-User
            btnChangePassword.Visible = true; //added by samir UE-21/12/2016-1
      //      pcePassword.Visible = false;// added by samir 22/12/2016

        }
        protected override void onFormCancel()
        {
            clearValidation(); //added by samir UE-20/12/2016-1
                               //clearControlError(nameefTextBox, null);

        }
        protected override void onFormNew()
        {
            base.onFormNew();
            var rec = (User)bsMaster.Current;
            rec.isBlocked = false;
            codeTextEdit.Focus();
            txtOldPass.Text = txtPassword.Text = txtConfirm.Text = string.Empty; // added by samir BU 13/12/ 2016 - User
            txtOldPass.Properties.ReadOnly = true;//added by Samir BU 13/12/2016-User
            txtOldPass.Text = string.Empty; // added by samir BU 13/12/2016-User
            lcgPassword.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always; //added by samir UE-21/12/2016-1
                                                                                          //  ValidationProvider.SetValidationRule(txtPassword, (DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule)ValidationProvider.GetValidationRule(txtPassword));
                                                                                          //  ValidationProvider.SetValidationRule(txtConfirm, (DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule)ValidationProvider.GetValidationRule(txtConfirm));
                                                                                          //  ValidationProvider.SetValidationRule(txtOldPass, (DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule)ValidationProvider.GetValidationRule(txtOldPass));//added by samir UE-20/12/2016-1

            // DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            //  ValidationProvider.SetValidationRule(txtPassword, conditionValidationRule1);//added by samir UE-20/12/2016-1
            //txtPassword.CausesValidation = true;
            //txtConfirm.CausesValidation = true;
            //txtPassword.DoValidate();
            //txtConfirm.DoValidate();

            //   conditionValidationRule1.DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1



        }
        #endregion
        private void txtOldPass_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (xState == Enums.State.New) { return; } //added by Samir BU 13/12/2016-User
            if (string.IsNullOrEmpty(txtOldPass.Text)) { return; }

            var rec = (User)bsMaster.Current;
            try
            {
                if (!SecurityService.checkPassword(rec.Password, txtOldPass.Text))
                    throw new Exception("Reenter Correct Password ...");
                txtPassword.Properties.ReadOnly = txtConfirm.Properties.ReadOnly = false;
                e.Cancel = false;
            }
            catch (Exception ex)
            {
                Alert.Show(ex.Message);
                txtOldPass.Text = string.Empty;
                txtPassword.Properties.ReadOnly = txtConfirm.Properties.ReadOnly = true;
                e.Cancel = true;
            }

        }
        private void txtPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtPassword.Text)) { return; }
            try
            {
                if (txtPassword.Text.Trim() == txtOldPass.Text.Trim())
                    throw new Exception("Same as old password ...");

                if (!SecurityService.checkComplexity(txtPassword.Text))
                    throw new Exception("Password does not meet complexity standard ...");
                e.Cancel = false;
            }
            catch (Exception ex)
            {
                Alert.Show(ex.Message);
                e.Cancel = true;
            }
        }
        private void txtConfirm_Validating(object sender, System.ComponentModel.CancelEventArgs e)// modifed by Samir ref BU 13/12/2016-User I replaced with ErrorProvider using the property
        {
            if (string.IsNullOrEmpty(txtConfirm.Text))
            {
                e.Cancel = false;
                return;
            }

            //try  // stopped by samir BU 13/12/2016-User
            //{
            //    //  if (txtPassword.Text.Trim() != txtConfirm.Text.Trim())
            //    if (txtPassword.EditValue != txtConfirm.EditValue)
            //        throw new Exception("Passwords does not match ...");

            //    e.Cancel = false;
            //}
            //catch (Exception ex)
            //{
            //    Alert.Show(ex.Message, Enums.AlertType.Warning);
            //    txtPassword.Focus();
            //    e.Cancel = true;
            //}

        }
        private void txtConfirm_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfirm.Text)) { return; }

            //    var rec = (User)bsMaster.Current; // stopped by samir BU 13/12/2016-User 
            //   rec.Password = SecurityService.Encryptmd5(txtConfirm.Text.Trim()); //stopped by samir BU 13/12/2016-User

            // txtOldPass.Text = txtPassword.Text = txtConfirm.Text = string.Empty; stopped by samir BU 13/12/2016-User 
            pccPassword.OwnerEdit.ClosePopup();
        }
        private void pcePassword_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            var rec = (User)bsMaster.Current;
            if (rec.Password == null)
            {
                txtOldPass.Properties.ReadOnly = true;
                //  txtOldPass.Visible = false;//added by samir BU 13/12/2016-User
                txtPassword.Properties.ReadOnly = txtConfirm.Properties.ReadOnly = false;
                txtPassword.Focus();
            }
            else
            {
                if (xState == Enums.State.New)
                { // added by samir BU 13/12/2016-User
                    txtPassword.Properties.ReadOnly = txtConfirm.Properties.ReadOnly = false;
                    txtOldPass.Properties.ReadOnly = true;
                    txtPassword.Focus();
                }
                else if (xState == Enums.State.Edit) // added by samir 19/12/2016
                {
                    txtPassword.Properties.ReadOnly = txtConfirm.Properties.ReadOnly = false;

                }
                else
                {
                    txtPassword.Properties.ReadOnly = txtConfirm.Properties.ReadOnly = true;
                    txtOldPass.Focus();
                }
                //txtPassword.Properties.ReadOnly = txtConfirm.Properties.ReadOnly = true; // modified by Samir BU 13/12/2016-User
                //txtOldPass.Focus();
            }
        }
        private void codeTextEdit_Validating(object sender, System.ComponentModel.CancelEventArgs e)//added by Samir BU 13/12/2016-User
        {
            if (xState == Enums.State.Edit) { return; }// added by Samir also on 28/11/2016
            var ctrl = sender as efTextBox;
            var rec = (User)bsMaster.Current;

            if (getUsers().FirstOrDefault(c => c.Code == ctrl.Text) != null)

                setControlError(ctrl, "Duplicated Code !!!", e);
            else
                clearControlError(ctrl, e);
        }
        #region getUsers
        private List<User> getUsers() // added by samir  BU 13/12/2016-User
        {
            List<User> lst = null;
            using (var se = new SecurityEntities(App.SecurityConnectionString))
            {
                lst = se.Users.ToList();
            }
            return lst;
        }

        private void pcePassword_Enter(object sender, EventArgs e)
        {
            if (xState == Enums.State.New) { txtPassword.Focus(); }
        }

        #endregion
        //public static bool ValidatePasswords(efTextBox textbox1, efTextBox textbox2)//added by Samir BU 13/12/2016-User
        //{
        //    return textbox1.Text.Trim() == textbox2.Text.Trim();
        //}
        private void txtConfirm_Leave(object sender, EventArgs e)// added by samir BU 13/12/2016-User 
        {
            //if (string.IsNullOrEmpty(txtConfirm.Text)) { return; }
            //var rec = (User)bsMaster.Current; // added by samir BU 13/12/2016-User 
            //rec.Password = SecurityService.Encryptmd5(txtConfirm.Text.Trim()); // added by samir BU 13/12/2016-User

        }
        private void pcePassword_Click(object sender, EventArgs e)// added by samir UE 13/12/2016-User
        {
            txtPassword.Focus();
        }

        private void btnChangePassword_Click(object sender, EventArgs e) // added by samir ref UE-21/12/2016-1
        {
            // directClick = true;
            var frm = new Forms.SecurityForms.FormChangeUserPassword { StartPosition = FormStartPosition.CenterParent };
            var rec = (User)bsMaster.Current;
            
            //List<object> ObjUser = new List<object>();  this is how to pass by using Tag
            //ObjUser.Add(rec.ID);
            //ObjUser.Add(rec.Name);
            //   frm.Tag = ObjUser;
            frm.strUserName = rec.Name;
            frm.intUserId = rec.ID;
            frm.ShowDialog();
        }
    }
}
