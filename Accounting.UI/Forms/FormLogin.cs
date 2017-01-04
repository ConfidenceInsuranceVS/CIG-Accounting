using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using efControls;
using efControls.Data;

namespace Accounting
{
    public partial class FormLogin : efLogin
    {
        private readonly SecurityEntities sc;
        private readonly List<User> allUsers;
        private User usr;
        private Company company;
        public FormLogin()
        {
            InitializeComponent();

            sc = new SecurityEntities(App.SecurityConnectionString);
            if (cboCompanies.EditValue != null) { setCompanyValues((int)cboCompanies.EditValue); }

            var aa = sc.Users.ToList();
            allUsers = sc.Users.Where(c => !(bool)c.isBlocked | c.isBlocked == null).OrderBy(c => c.Name).ToList();
            if (allUsers.Count == 0)
            {
                getUsers();
                allUsers = sc.Users.Where(c => !(bool)c.isBlocked | c.isBlocked == null).OrderBy(c => c.Name).ToList();
            }

            userBS.DataSource = allUsers;
            DialogResult = DialogResult.No;

            var lastusr = XML.Read(App.LocalPreferencesFile, "General", "LastLoggedAs");
            if (!string.IsNullOrEmpty(lastusr))
            {
                usr = allUsers.Find(x => x.ID == int.Parse(lastusr));
                if (usr != null)
                {
                    cboUsername.Text = usr.Name;
                    cboUsername.EditValue = usr.ID;
                }
            }

            var lastcompany = XML.Read(App.LocalPreferencesFile, "General", "LastCompany");
            if (!string.IsNullOrEmpty(lastcompany))
            {
                var toint = int.Parse(lastcompany);
                var company = sc.Companies.FirstOrDefault(c => c.ID == toint);
                if (company != null)
                {
                    cboCompanies.Text = company.Description;
                    cboCompanies.EditValue = company.ID;
                }
            }

            var lastyear = XML.Read(App.LocalPreferencesFile, "General", "LastYear");
            if (!string.IsNullOrEmpty(lastyear))
            {
                spnYear.EditValue = int.Parse(lastyear);
            }
        }
        private void getUsers()
        {
            folderBrowserDialog.Description = "Select Users Path";
            folderBrowserDialog.ShowDialog();
            string connectionString = string.Format(@"Provider=VFPOLEDB.1;Exclusive=NO;Data Source={0}\Users.dbf", folderBrowserDialog.SelectedPath);
            using (OleDbConnection oc = new OleDbConnection(connectionString))
            {
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter() { SelectCommand = new OleDbCommand("SELECT * FROM Users", oc) };
                da.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    var l = new User()
                    {
                        Code = dt.Rows[i]["Code"].ToString().TrimEnd(),
                        Name = dt.Rows[i]["Name"].ToString().TrimEnd()
                    };

                    allUsers.Add(l);
                    sc.Users.Add(l);
                }
                sc.SaveChanges();
            }
        }
        private void FormLogin_Load(object sender, EventArgs e)
        {
            cboUsername.EditValue = XML.Read(App.PreferencesFile, "General", "LastUser");
        }
        private void cboUsername_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboUsername.Text))
            {
                return;
            }
            usr = allUsers.Find(x => x.ID == (int)cboUsername.EditValue);
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            dg = DialogResult.No;
            efErrorProvider.ClearErrors();
            try
            {
                if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
                    throw new Exception("1");

                if (!SecurityService.checkPassword(usr.Password, txtPassword.Text))
                    throw new Exception("2");

                App.UserID = usr.ID;
                App.UserGroupID = (int)(usr.GroupID ?? 0);
                App.UserCode = usr.Code;
                App.UserName = usr.Name;
                App.UserLevel = usr.LevelID ?? 0;
                App.WorkingYear = int.Parse(spnYear.Text);

                ((User)userBS.Current).LastLogin = DateTime.Now;
                sc.SaveChanges();
                dg = DialogResult.OK;
            }
            catch (Exception ex)
            {
                switch (ex.Message)
                {
                    case "1":
                        efErrorProvider.SetError(txtPassword, "Field Cannot Be Blank !");
                        break;
                    case "2":
                        efErrorProvider.SetError(txtPassword, "Wrong Password !");
                        break;
                    default:
                        efErrorProvider.SetError(cboCompanies, ex.Message);
                        break;
                }
            }
        }
        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dg == DialogResult.None) { return; }

            if (dg == DialogResult.OK)
            {
                DialogResult = dg;
                if (chkRememberMe.Checked)
                {
                    XML.Write(App.LocalPreferencesFile, "General", "LastLoggedAs", cboUsername.EditValue.ToString());
                    XML.Write(App.LocalPreferencesFile, "General", "LastCompany", cboCompanies.EditValue.ToString());
                    XML.Write(App.LocalPreferencesFile, "General", "LastYear", spnYear.EditValue.ToString());
                }
                else
                {
                    XML.Write(App.LocalPreferencesFile, "General", "LastLoggedAs", string.Empty);
                    XML.Write(App.LocalPreferencesFile, "General", "LastCompany", string.Empty);
                    XML.Write(App.LocalPreferencesFile, "General", "LastYear", string.Empty);
                }
            }
            else
            {
                e.Cancel = true;
            }
        }
        private void cboCompanies_EditValueChanged(object sender, EventArgs e)
        {
            setCompanyValues((int)cboCompanies.EditValue);
        }
        private void setCompanyValues(int CompanyID)
        {
            company = sc.Companies.FirstOrDefault(c => c.ID == CompanyID);
            App.CompanyID = CompanyID;
            App.HasSubCompanies = (bool)company.HasSubCompanies;
            App.CompanyName = company.Description;
            App.MainConnectionString = App.getMainConnectionString(company.DatabaseName);
            App.LocalCurreny = (int)company.FirstLocalCurrencyid;
            App.ForeignCurreny = (int)company.SecondLocalCurrencyid;
            App.AccLength = company.AccountLength ?? 9;

            if (App.UserGroupID != App.AdminGroupID)
            {
                using (var ae = new AccountingEntities(App.MainConnectionString))
                {
                    if (ae.Journalparents.Count() == 0)
                    {
                        spnYear.Properties.MinValue = spnYear.Properties.MaxValue = DateTime.Now.Year;
                    }
                    else
                    {
                        spnYear.Properties.MinValue = ae.Journalparents.Select(c => c.YDate).Min().Value;
                        spnYear.Properties.MaxValue = ae.Journalparents.Select(c => c.YDate).Max().Value;
                    }
                };
            }
        }
    }
}
