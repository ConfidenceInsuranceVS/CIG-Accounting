using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace efControls
{

    public partial class ucControlNavigator : DevExpress.XtraEditors.XtraUserControl
    {
        [Category("xProperties"), Browsable(true)]
        public GridControl NavigatableControl { get; set; }
        [Category("xProperties"), Browsable(true)]
        public bool AlwaysEnabled { get; set; }
        public ucControlNavigator()
        {
            InitializeComponent();
        }
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            controlNavigator.NavigatableControl = NavigatableControl;
            chkLock.Checked = AlwaysEnabled;
        }
        public override void Refresh()
        {
            base.Refresh();
            Enabled = ((efBaseForm)ParentForm).xState == Enums.State.None ? true : false;
            chkLock.Checked = AlwaysEnabled ? true : !Enabled;
        }
        private void chkLock_CheckedChanged(object sender, EventArgs e)
        {
            chkLock.ImageIndex = chkLock.Checked ? 1 : 0;
            if (NavigatableControl != null)
                 ((GridView)NavigatableControl.MainView).OptionsBehavior.Editable = chkLock.Checked;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog()
            {
                FileName = string.Format("{0}-{1}-{2}-{3}.xlsx", ((efBaseForm)FindForm()).Name, DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day),
                Filter = "Excel Files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
            };
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                if (NavigatableControl != null)
                    ((GridView)NavigatableControl.MainView).ExportToXlsx(savefile.FileName);
            }
        }
    }
}
