using efControls;
using efControls.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Accounting
{
    public partial class FormChangePassword : efBaseForm
    {
        private readonly SecurityEntities sc;
        //private readonly SecurityService ss;
        private readonly User lu;
        public FormChangePassword()
        {
            InitializeComponent();

            sc = new SecurityEntities(App.SecurityConnectionString);
            lu = sc.Users.Where(u => u.ID == App.UserID).FirstOrDefault();
        }

        private void efButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtOldPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtOldPassword.Text))
            {
                return;
            }
            
            if (!SecurityService.checkPassword(lu.Password, txtOldPassword.Text))
            {
                txtOldPassword.ErrorText = "Wrong Password !!";
                txtNewPassword.Enabled = txtConfirmPassword.Enabled = false;
                e.Cancel = true;
            }
            else
            {
                txtNewPassword.Enabled = txtConfirmPassword.Enabled = true;
                txtNewPassword.Focus(); // Added
            }
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
                    //efControls.SecurityService.Encrypt(txtNewPassword.Text);
            }
        }

        private void efButton1_Click(object sender, EventArgs e)
        {
            sc.SaveChanges();
            Alert.Show("Password Changed Successfuly !!", Enums.AlertType.None, 2000);
            Close();
        }
    }
}
