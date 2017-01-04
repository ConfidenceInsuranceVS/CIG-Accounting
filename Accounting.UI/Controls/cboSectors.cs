using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using efControls;

namespace Accounting
{
    public partial class cboSectors : efComboBox
    {
        private BindingSource bs;
        public cboSectors()
        {
            InitializeComponent();

            bs = new BindingSource();
        }
        protected override void OnPopupShown()
        {
            using (var lc = new AccountingEntities(App.MainConnectionString))
            {
                bs.DataSource = fillBindingsource(lc);
            }
            RefreshPopup();
            base.OnPopupShown();
        }

        private List<Sector> fillBindingsource(AccountingEntities lc) { return lc.Sectors.OrderBy(c => c.Description).ToList(); }
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            if (!DesignMode)
            {
                using (var lc = new AccountingEntities(App.MainConnectionString))
                {
                    bs.DataSource = fillBindingsource(lc);
                    Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
                    new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 85, DevExpress.Utils.FormatType.None, string.Empty, true, DevExpress.Utils.HorzAlignment.Near)});
                    Properties.DataSource = bs;
                    Properties.DisplayMember = "Description";
                    Properties.ValueMember = "ID";
                    Properties.ShowHeader = true;
                    Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
                    Properties.NullText = string.Empty;
                    Properties.NullValuePrompt = "Select Sector Or Leave Blank";
                    Properties.NullValuePromptShowForEmptyValue = true;
                    ToolTip = "...";
                    ToolTipTitle = "Press [CTRL+DELETE] To Clear Value ...";
                    ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
                    Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                }
            }
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
