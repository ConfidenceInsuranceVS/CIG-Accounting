using efControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Accounting
{
    public partial class FormSetConnections : efControls.efSetConnections
    {
        public FormSetConnections()
        {
            InitializeComponent();
        }

        private void beVFP_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 0)
            {
                folderBrowserDialog.Description = "Select Insurance [VFP] Data Path";
                folderBrowserDialog.ShowDialog();
                beVFP.Text = folderBrowserDialog.SelectedPath;
            }
        }

        public override void setConnectionString()
        {
            base.setConnectionString();
            XML.Write(App.PreferencesFile, "General", "VfpPath", beVFP.Text);
        }
    }
}
