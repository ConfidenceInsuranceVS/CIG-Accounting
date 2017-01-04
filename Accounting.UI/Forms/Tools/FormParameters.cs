using efControls;
using System;
using System.Collections.Generic;

namespace Accounting
{
    public partial class FormParameters : efBaseForm
    {
        public FormParameters()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            fillControls();
        }
        private void fillControls()
        {
            chkSubtitle.Checked = App.PrintSubtitle;
            chkUserInfo.Checked = App.ShowUserInfo;
            try
            {
                txtEOY.Text = XML.Read(App.PreferencesFile, "Application", "EOYDescription");
                txtDE.Text = XML.Read(App.PreferencesFile, "Application", "DOXDescription");
                //
                txt1stLocal.Text = XML.Read(App.PreferencesFile, "Application", "Ml1stLocal");
                txt2ndLocal.Text = XML.Read(App.PreferencesFile, "Application", "Ml2ndLocal");
                //
                cboAccountsNeg.EditValue = int.Parse(XML.Read(App.PreferencesFile, "Application", "DOXNEGATIF"));
                cboAccountsPos.EditValue = int.Parse(XML.Read(App.PreferencesFile, "Application", "DOXPOSITIF"));
            }
            catch (Exception)
            {
                XML.Write(App.PreferencesFile, "Application", "EOYDescription", string.Empty);
                XML.Write(App.PreferencesFile, "Application", "DOXDescription", string.Empty);
                //
                XML.Write(App.PreferencesFile, "Application", "Ml1stLocal", string.Empty);
                XML.Write(App.PreferencesFile, "Application", "Ml2ndLocal", string.Empty);
                //
                XML.Write(App.PreferencesFile, "Application", "DOXNEGATIF", string.Empty);
                XML.Write(App.PreferencesFile, "Application", "DOXPOSITIF", string.Empty);
            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            XML.Write(App.PreferencesFile, "Application", "EOYDescription", txtEOY.Text);
            XML.Write(App.PreferencesFile, "Application", "DOXDescription", txtDE.Text);
            //
            XML.Write(App.PreferencesFile, "Application", "Ml1stLocal", txt1stLocal.Text);
            XML.Write(App.PreferencesFile, "Application", "Ml2ndLocal", txt2ndLocal.Text);
            //
            XML.Write(App.PreferencesFile, "Application", "DOXNEGATIF", cboAccountsNeg.EditValue.ToString());
            XML.Write(App.PreferencesFile, "Application", "DOXPOSITIF", cboAccountsPos.EditValue.ToString());
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chkSubtitle_CheckedChanged(object sender, EventArgs e)
        {
            App.PrintSubtitle = chkSubtitle.Checked;
        }

        private void chkUserInfo_CheckedChanged(object sender, EventArgs e)
        {
            App.ShowUserInfo = chkUserInfo.Checked;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            fillControls();
        }
    }
}
