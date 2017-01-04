using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace efControls
{
    public partial class efSetConnections : XtraForm
    {
        public efSetConnections()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void efSetConnections_Load(object sender, EventArgs e)
        {
            if (DesignMode || base.DesignMode) { return; }
            var instance = SqlDataSourceEnumerator.Instance;
            var table = instance.GetDataSources();
            cmbSqlInstances.Properties.Items.Clear();
            foreach (DataRow dr in table.Rows)
            {
                if (!string.IsNullOrEmpty(dr[1].ToString()))
                {
                    cmbSqlInstances.Properties.Items.Add(String.Format("{0}\\{1}", dr[0], dr[1]));
                }
                else
                {
                    cmbSqlInstances.Properties.Items.Add(dr[0].ToString());
                }
            }
            //SplashScreenManager.CloseForm();
        }
        private void cmbMainDB_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
                fillDB();
        }
        public static bool checkSelection(Control ctrl)
        {
            if (string.IsNullOrEmpty(ctrl.Text))
            {
                Alert.ShowMessage("Complete your selection !");
                ctrl.Focus();
                return false;
            }
            return true;
        }
        public virtual void setConnectionString()
        {
            XML.Write(App.PreferencesFile, "General", "DataSource", cmbSqlInstances.Text);
            XML.Write(App.PreferencesFile, "General", "MainCatalog", cmbMainDB.Text);
            XML.Write(App.PreferencesFile, "General", "SecurityCatalog", cmbSecurityDB.Text);
            XML.Write(App.PreferencesFile, "General", "UserName", SecurityService.Encrypt(txtUser.Text));
            XML.Write(App.PreferencesFile, "General", "UserPassword", SecurityService.Encrypt(txtPassword.Text));
        }
        private void bbiAttach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var serverName = cmbSqlInstances.Text;
            var userName = txtUser.Text;
            var userPassword = txtPassword.Text;
            if (string.IsNullOrEmpty(serverName) | string.IsNullOrEmpty(userName) | string.IsNullOrEmpty(userPassword))
                return;

            openFileDialog.DefaultExt = "mdf";
            openFileDialog.ShowDialog();
            var dbPath = Path.GetDirectoryName(openFileDialog.FileName);
            var dbName = Path.GetFileNameWithoutExtension(openFileDialog.FileName);

            var connectionString = String.Format("Data Source={0};User ID={1};Password={2}", serverName, userName, userPassword);
            using (var conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (var cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.Text;
                        //cmd.CommandText = String.Format("sys.sp_attach_single_file_db @dbname = '{0}', @physname = '{1}'", Path.GetFileNameWithoutExtension(openFileDialog.FileName), openFileDialog.FileName);
                        cmd.CommandText = String.Format("CREATE DATABASE {0} ON PRIMARY ( FILENAME =  '{1}.mdf' ), FILEGROUP {0}_Log ( FILENAME = '{1}_log.ldf') FOR ATTACH", dbName, String.Format("{0}\\{1}", dbPath, dbName));
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (SqlException ex)
                {
                    Alert.ShowMessage(ex.Message);
                }
            }
        }
        private void bbiDetach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var serverName = cmbSqlInstances.Text;
            var userName = txtUser.Text;
            var userPassword = txtPassword.Text;
            var dbName = cmbMainDB.Text;
            if (string.IsNullOrEmpty(serverName) | string.IsNullOrEmpty(userName) |
                string.IsNullOrEmpty(userPassword) | string.IsNullOrEmpty(dbName))
                return;

            var connectionString = String.Format("Data Source={0};User ID={1};Password={2}", serverName, userName, userPassword);
            using (var conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (var cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = String.Format("DROP DATABASE {0}", dbName);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (SqlException ex)
                {
                    Alert.ShowMessage(ex.Message);
                }
            }
        }
        private void bbiOk_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!checkSelection(cmbSqlInstances)) { return; }
            if (!checkSelection(txtUser)) { return; }
            if (!checkSelection(txtPassword)) { return; }
            if (!checkSelection(cmbMainDB)) { return; }

            setConnectionString();
            DialogResult = DialogResult.OK;
            Close();
        }
        private void bbiCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }
        private void cmbSecurityDB_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
                fillDB();
        }
        private void fillDB()
        {
            cmbMainDB.Properties.Items.Clear();
            cmbSecurityDB.Properties.Items.Clear();
            var serverName = cmbSqlInstances.Text;
            var userName = txtUser.Text;
            var userPassword = txtPassword.Text;
            var connectionString = String.Format("Data Source={0};User ID={1};Password={2}", serverName, userName, userPassword);
            using (var conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (var cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "sp_databases";
                        var dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            cmbMainDB.Properties.Items.Add(dr.GetString(0));
                            cmbSecurityDB.Properties.Items.Add(dr.GetString(0));
                        }
                    }
                }
                catch (SqlException)
                {
                }
            }
        }
    }
}
