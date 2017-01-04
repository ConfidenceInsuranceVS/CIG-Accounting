using System;
using System.Collections.Generic;
using efControls;
using System.Linq;
using System.Data.SqlClient;
using System.IO;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using efControls.Data;
using DevExpress.XtraGrid.Views.Base;
using System.Text;
using static Accounting.AccountingServices;

namespace Accounting
{
    public partial class FormCompanyCreation : efDataSearchForm
    {
        AccountingEntities ae;
        SecurityEntities se;
        public FormCompanyCreation()
        {
            InitializeComponent();

            lciSubCompany.ContentVisible = lciGridToolbar.ContentVisible = false;
            isSecurity = true;
            de = new AllFormExtensions<Company>() { f = this };
            ae = new AccountingEntities(App.MainConnectionString);
            se = new SecurityEntities(App.SecurityConnectionString);
            //
            bsMaster.DataMember = "Company";
            bsSubCompany.DataMember = "SubCompanies";

        }
        protected override void onFormLoadSearchData()
        {
            base.onFormLoadSearchData();
            var _id = currentID;
            //
            bsSearch.DataSource = listCompanies(se).OrderBy(c => c.Description);
            //
            de.setPosition<CompanySearchList>(_id);
            btnDelete.Enabled = false;// I have disabled the delete button a database must not be deleted from UI ref BU 27/12/2016-1 
        }

        #region C.R.U.D
        protected override void onFormNew() { txtDescription.Focus(); }
        protected override void onFormEdit() { txtDescription.Focus(); }
        protected override void onFormSave()
        {
            lcMain.Enabled = false;
            //
            var sc = bsSubCompany.List.OfType<SubCompany>().ToList();
            if (sc.Count > 0)
            {
                var count = sc.Where(c => c.isDefault == true).Count();
                if (count == 0)
                    throw new AppException("At least one default must be specified !!!");
                if (count > 1)
                    throw new AppException("Only One Sub Company can be default !!!");
            }

            base.onFormSave();

            //update JournalParents SC
            var sb = new StringBuilder();
            sb.Append("ATTENTION !!!");
            sb.AppendLine("This will replace all empty sub company value");
            sb.AppendLine("with the default value, Continue?");

            if (chkUpdateSC.Checked && Alert.ShowDialogMessage(sb.ToString()) == System.Windows.Forms.DialogResult.Yes)
            {
                var rec = (Company)bsMaster.Current;
                var def = dbContext.Set<SubCompany>().FirstOrDefault(c => c.CompanyID == rec.ID && c.isDefault == true).ID;
                ae.updateSubCompany(def, 0);
            }
            ae.SaveChanges();

            //Create and Save New Database
            if (xState == Enums.State.New) { saveDataBase(); }
            lciCheckData.ContentVisible = false;
            lcMain.Enabled = true;
        }
        protected override void onFormCancel()
        {
            base.onFormCancel();
            lciCheckData.ContentVisible = false;
        }
        protected override void onFormDelete()
        {
            Alert.Show("Cannot Delete a Database !!", Enums.AlertType.Warning);

            //if (App.CompanyName == txtDescription.Text)
            //    Alert.Show("Cannot Delete Current Database !!", Enums.AlertType.Warning);
            //else
            //{
            //    //bool result = deleteDatabase(); // added by samir 27/12/2016
            //    //                                // deleteDatabase(); //stopped by samir 27/12/2016
            //    // if (result)
            //    // {
            //    //     base.onFormDelete();
            //    // }
            //    // else
            //    // {
            //    //     return;
            //    // }


            //}
        }
        protected override void onFormRefresh()
        {
            try
            {
                bbiGridAdd.Enabled = bbiGridDelete.Enabled = btnSave.Enabled;
            }
            catch (Exception)
            {
            }
        }
        #endregion
        private string getConnectionString()
        {
            SqlConnectionStringBuilder cn = new SqlConnectionStringBuilder()
            {
                DataSource = XML.Read(App.PreferencesFile, "General", "DataSource"),
                UserID = SecurityService.Decrypt(XML.Read(App.PreferencesFile, "General", "UserName")),
                Password = SecurityService.Decrypt(XML.Read(App.PreferencesFile, "General", "UserPassword")),
                InitialCatalog = "Master"
            };
            return cn.ConnectionString;
        }
        private void saveDataBase()
        {
            try
            {
                if (!Directory.Exists(@"C:\TEMP")) { Directory.CreateDirectory(@"C:\TEMP"); }

                using (SqlConnection sConn = new SqlConnection(getConnectionString()))
                {
                    sConn.Open();

                    var serverConnection = new ServerConnection(sConn);
                    var server = new Server(serverConnection);
                    var defaultDataPath = string.IsNullOrEmpty(server.Settings.DefaultFile) ? server.MasterDBPath : server.Settings.DefaultFile;

                    // var bakDatabase = "C:\\TEMP\\Accounting.bak";                                               // stopped by Samir  BU 23/12/2016-1 
                    var bakDatabase = "C:\\TEMP\\Accounting.Company.bak";      //added by Samir BU 23 / 12 / 2016 - 1
                                                                               // var query = string.Format("Backup database [Accounting] to disk='{0}'", bakDatabase);  // stopped by Samir  BU 23/12/2016-1 
                    var query = string.Format("Backup database [Accounting.Company] to disk='{0}'", bakDatabase);//added by Samir BU 23 / 12 / 2016 - 1
                    var cmd = new SqlCommand(query, sConn); // stopped by Samir  BU 23/12/2016-1 
                    cmd.ExecuteNonQuery();

                    // var cmd = new SqlCommand();// added by samir  BU 23/12/2016-1 
                    cmd = new SqlCommand("USE master", sConn);
                    cmd.ExecuteNonQuery();

                    var newDatabase = txtDatabase.Text;
                    cmd = new SqlCommand(string.Format(@"Create DATABASE [{0}]", newDatabase), sConn);
                    cmd.ExecuteNonQuery();

                    //   string Restore = string.Format("RESTORE DATABASE [{0}] FROM DISK = '{1}' WITH REPLACE, Move 'Accounting' to '{2}{0}.mdf', Move 'Accounting_log' to '{2}{0}_log.ldf'", newDatabase, bakDatabase, defaultDataPath); // stopped by samir BU 23/12/2016-1 
                    string Restore = string.Format("RESTORE DATABASE [{0}] FROM DISK = '{1}' WITH REPLACE, Move 'Accounting.Company' to '{2}{0}.mdf', Move 'Accounting.Company_log' to '{2}{0}_log.ldf'", newDatabase, bakDatabase, defaultDataPath);
                    cmd = new SqlCommand("USE master", sConn);

                    cmd = new SqlCommand(Restore, sConn);
                    cmd.CommandTimeout = 600;
                    cmd.ExecuteNonQuery();

                    if (chkData.Checked)
                    {
                        using (SecurityEntities sc = new SecurityEntities(App.SecurityConnectionString))
                        {
                            var company = sc.Companies.FirstOrDefault(c => c.ID == App.CompanyID);
                            ae.fillLookups(string.Format("[{0}]", company.DatabaseName), string.Format("[{0}]", newDatabase));
                        }
                    }
                }
                File.Delete("C:\\TEMP\\Accounting.Company.bak");
            }
            catch (Exception ex)
            {
                Alert.Show(ex.Message, Enums.AlertType.Critical);
            }
        }
        //private  void deleteDatabase() //modified by samir 27/12/2016 on  BU 23/12/2016-1
        private bool deleteDatabase()
        {
            if (Alert.ShowDialogMessage("This will delete the company database, Continue?") == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection sConn = new SqlConnection(getConnectionString()))
                    {
                        sConn.Open();
                        var query = string.Format("use [Master]; Drop Database [{0}]", txtDatabase.Text);
                        var cmd = new SqlCommand(query, sConn);
                        cmd.ExecuteNonQuery();
                        return true; // added by samir BU 23/12/2016-1


                    }
                }
                catch (Exception ex)
                {
                    // Alert.Show(ex.Message, Enums.AlertType.Critical);
                    Alert.ShowMessage("Database Not Deleted, Please Delete Manually !!!");
                    return false; // added by samir BU 23/12/2016-1
                }

            }
            return false;// added by samir BU 23/12/2016-1
        }

        #region on Form Functions
        protected override string onFormGetDeleteString()
        {
            var rec = (Company)bsMaster.Current;
            return string.Format("[{0}]", rec.Description);
        }
        #endregion

        private void txtDatabase_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (xState == Enums.State.None) { return; }

            txtDatabase.Text = txtDatabase.Text.Replace(" ", string.Empty);
            try
            {
                var exist = dbContext.Set<Company>().FirstOrDefault(c => c.DatabaseName == txtDatabase.Text);
                if (exist != null)
                    throw new Exception("Database Name In Use, Choose Another !!");
                if (!txtDatabase.Text.StartsWith("Accounting."))
                    throw new Exception("Database Name In Must Start With [Accounting.] !!");
            }
            catch (Exception ex)
            {
                txtDatabase.Text = "Accounting.";
                txtDatabase.SelectionStart = txtDatabase.Text.Length;
                Alert.Show(ex.Message, "Attention !!", Enums.AlertType.Warning);
                e.Cancel = true;
            }
        }
        private void chkSubCompany_CheckedChanged(object sender, EventArgs e)
        {
            lciSubCompany.ContentVisible = lciGridToolbar.ContentVisible = chkSubCompany.Checked ? true : false;
        }
        private void bbiGridAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bsSubCompany.AddNew();

            var view = (ColumnView)gcSubCompany.MainView;
            view.FocusedColumn = view.VisibleColumns[0];
            view.ShowEditor();
        }
        private void bbiGridDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //var par = (Company)bsMaster.Current;
            var rec = (SubCompany)bsSubCompany.Current;
            //var jvs = ae.Journalparents.Where(c => c.SC == rec.ID).ToList();
            //if (jvs.Count > 0)
            //jvs.ForEach(c => c.SC = null);

            //gvSubCompany.DeleteSelectedRows();
            var sb = new StringBuilder();
            sb.Append("ATTENTION !!!");
            sb.AppendLine("This will replace all sub company with null value, Continue?");

            if (Alert.ShowDialogMessage(sb.ToString()) == System.Windows.Forms.DialogResult.Yes)
            {
                ae.updateSubCompany(rec.ID, 1);
                //par.SubCompanies.Remove(rec);
                dbContext.Set<SubCompany>().Remove(rec);
            }
        }
        protected override bool onFormValidate()
        {
            bool result = true;
            if (string.IsNullOrEmpty(txtDatabase.Text)) // added by samir BU 29/12/2016-3
            {
                Alert.Show("Enter Database name !!", Enums.AlertType.Warning);
                txtDatabase.Focus();
                return result = false;
            }

            try
            {
                bsSubCompany.EndEdit();
                var count = bsSubCompany.List.OfType<SubCompany>().ToList().Where(c => c.isDefault == true).Count();
                if (count > 1) { throw new Exception("Only One Sub Company can be default !!!"); }

                var recs = bsSubCompany.List.OfType<SubCompany>().Where(c => c.Code == null).ToList();
                foreach (var rec in recs)
                    bsSubCompany.Remove(rec);
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }
        private void gvSubCompany_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            var gv = (efGridView)sender;
            var result = true;
            try
            {
                switch (gv.FocusedColumn.FieldName.ToUpper())
                {
                    case "CODE":
                        if (e.Value == null | string.IsNullOrEmpty(e.Value.ToString())) { throw new Exception("Empty Code !!!"); }
                        var lst = bsSubCompany.List.OfType<SubCompany>().ToList().Where(c => c.Code == e.Value.ToString().Trim()).Count();
                        if (lst > 0)
                            throw new Exception("Duplicated Code !!!");
                        break;

                    case "DESCRIPTION":
                        if (e.Value == null | string.IsNullOrEmpty(e.Value.ToString())) { throw new Exception("Empty Description !!!"); }
                        break;

                    //case "ISDEFAULT":
                    //    var count = bsSubCompany.List.OfType<SubCompany>().ToList().Where(c => c.isDefault == true).Count();
                    //    if (count > 1)
                    //        throw new Exception("Only One Sub Company can be default !!!");
                    //    break;

                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Alert.Show(ex.Message, Enums.AlertType.Warning);
                result = false;
            }
            e.Valid = result;
            e.ErrorText = string.Empty;
        }
        private void gvSubCompany_ShownEditor(object sender, EventArgs e)
        {
            gvSubCompany.ActiveEditor.IsModified = true;
        }
    }
}
