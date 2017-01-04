using efControls;
using efControls.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Accounting
{
    public partial class cboCompanies : efComboBox
    {
        private BindingSource bs;
        public cboCompanies()
        {
            InitializeComponent();

            bs = new BindingSource();
        }
        protected override void OnPopupShown()
        {
            using (var lc = new SecurityEntities(App.SecurityConnectionString))
            {
                bs.DataSource = fillBindingsource(lc);
            }
            RefreshPopup();
            base.OnPopupShown();
        }

        private List<Company> fillBindingsource(SecurityEntities lc) { return lc.Companies.OrderBy(c => c.Description).ToList(); }
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            if (!DesignMode)
            {
                using (var lc = new SecurityEntities(App.SecurityConnectionString))
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
                    Properties.NullValuePrompt = "Select Company";
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
