using efControls;
using Microsoft.Win32;
using System;
using System.Windows.Forms;
using System.Linq;
using System.Data.Entity.Core.EntityClient;

namespace Accounting
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            var dr = DialogResult.No;
            //
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Screen Srn = Screen.PrimaryScreen;
            if (Srn.Bounds.Width < 1024)
            {
                App.screenWidth = Srn.Bounds.Width;
                App.screenHeight = Srn.Bounds.Height;
                Resolution.Change(1024, 768);
            }

            // set dateformat to dd/MM/yyyy
            RegistryKey rkey = Registry.CurrentUser.OpenSubKey(@"Control Panel\International", true);
            if (rkey.GetValue("sShortDate").ToString() != "dd/MM/yyyy")
            {
                rkey.SetValue("sShortDate", "dd/MM/yyyy");
                rkey.SetValue("sLongDate", "dd/MM/yyyy");
            }
            //
            //
            App.guid = Guid.NewGuid();
            App.Name = "Accounting";
            App.CompanyName = "Confidence Insurance Group s.a.l";
            //
            App.PrintSubtitle = App.ShowUserInfo = true;
            //
            App.setPaths();
            App.setPreferencesFile();
            App.setVisualStyles();
            Lock.DeleteTempFiles("Lock");
            //

            try
            {
                var aa = XML.Read(App.PreferencesFile, "General", "DataSource");
                if (string.IsNullOrEmpty(XML.Read(App.PreferencesFile, "General", "DataSource")))
                {
                    var frm = new FormSetConnections();
                    dr = frm.ShowDialog();
                    if (dr == DialogResult.No) { throw new Exception(); }
                }

                App.SecurityConnectionString = App.getSecurityConnectionString();
                using (var conn = new EntityConnection(App.SecurityConnectionString))
                {
                    conn.Open();
                }

                using (efLogin frm = new FormLogin())
                {
                    dr = frm.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        App.setVisualStyles();
                        FormMain mainform = new FormMain() { guid = frm.guid };
                        Application.Run(mainform);
                    }
                }
            }
            catch (Exception ex)
            {
                Alert.ShowMessage(ex.Message);
                if (App.screenWidth != 0 & App.screenHeight != 0) { Resolution.Change(App.screenWidth, App.screenHeight); }
                Application.Exit();
            }
        }
    }
}
