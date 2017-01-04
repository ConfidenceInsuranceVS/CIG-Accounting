using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using efControls;
using efControls.Data;
using System.Collections;

namespace efControls.Forms.SecurityForms
{
    public partial class FormChangeUserPassword : efBaseForm // form created by samir ref UE-21/12/2016-1
    {

        private SecurityEntities sc;
        private User lu;
        public string strUserName = string.Empty;
        public int? intUserId = null;
        public FormChangeUserPassword()
        {
            InitializeComponent();

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                Alert.Show("Enter Confirm Password !!", Enums.AlertType.Warning);
                txtNewPassword.ErrorText = ("Enter Confirm Password !!");
              txtConfirmPassword.Focus();
                return;
            }

            sc.SaveChanges();
            Alert.Show("Password Changed Successfuly !!", Enums.AlertType.None, 5000);
            Close();
        }

        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {

            if (!checkComplexity(txtNewPassword.Text))
            {
                txtNewPassword.ErrorText = "Password does not meet complexity standard !!";
                e.Cancel = true;
            }
        }
        private bool checkComplexity(string p)
        {
            return p.Length >= 8 &&
                p.Count(c => char.IsDigit(c)) >= 1 &&
                p.Count(c => char.IsSymbol(c)) >= 1;
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            lu.Password = null;
            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                txtConfirmPassword.ErrorText = "Passwords does not match !!";
                e.Cancel = true;
            }
            else
            {
                lu.Password = SecurityService.Encryptmd5(txtNewPassword.Text);
                //  lu.Name = "Samir "; lu is updating sc
            }
        }

        private void FormChangeUserPassword_Load(object sender, EventArgs e) //ref UE-21/12/2016-1
        {

            if (strUserName != null && intUserId != null)
            {
                sc = new SecurityEntities(App.SecurityConnectionString);
                lu = sc.Users.Where(u => u.ID == intUserId).FirstOrDefault();
                lblUsername.Text = "Change Password of " + strUserName;
            }
            else
            {
                sc = new SecurityEntities(App.SecurityConnectionString);
                lu = sc.Users.Where(u => u.ID == App.UserID).FirstOrDefault();
                lblUsername.Text = "Change Password of " + App.UserName;
            }
        }


    }
}
