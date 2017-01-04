using System;
using System.Collections.Generic;
using System.Linq;
using efControls;
using System.IO;
using System.Drawing;

namespace Accounting
{
    public partial class ucScan : ucScanControl
    {
        public ucScan()
        {
            InitializeComponent();
        }
        public ucScan(efDataForm xfrm, string xfilename)
        {
            InitializeComponent();
            frm = xfrm;
            filename = xfilename;
            Dock = System.Windows.Forms.DockStyle.Fill;
            EnableParent(false);
            frm.Controls.Add(this);

            if (File.Exists(filename)) { loadFile(filename); }
            fillDeviceSources();
            beiSelect.EditValue = XML.Read(App.PreferencesFile, "General", "Scanner");

            BringToFront();
        }
    }
}
