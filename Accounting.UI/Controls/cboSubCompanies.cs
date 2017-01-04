using efControls.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Accounting
{
    public partial class cboSubCompanies : efControls.efComboBox
    {

        [Category("xProperties"), Browsable(true)]
        public BindingSource bs { get; set; }

        public cboSubCompanies()
        {
            InitializeComponent();
        }

        protected override void OnPopupShown()
        {
            bs.DataSource = getSubCompanies();
            RefreshPopup();
            base.OnPopupShown();
        }
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            setVisibility();

            if (App.HasSubCompanies)
            {
                if (bs == null) { bs = new BindingSource(); }
                bs.DataSource = getSubCompanies();

                Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
                    new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 15, DevExpress.Utils.FormatType.None, string.Empty, true, DevExpress.Utils.HorzAlignment.Near),
                    new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 85, DevExpress.Utils.FormatType.None, string.Empty, true, DevExpress.Utils.HorzAlignment.Near)});
                Properties.DataSource = bs;
                Properties.DisplayMember = "Code";
                Properties.ValueMember = "ID";
                Properties.ShowHeader = true;
                Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
                Properties.NullText = string.Empty;
                Properties.NullValuePrompt = string.Empty;
                Properties.NullValuePromptShowForEmptyValue = false;
                ToolTip = "...";
                ToolTipTitle = "Press [CTRL+DELETE] To Clear Value ...";
                ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
                Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
                Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick;
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
        private void setVisibility()
        {
            var lci = ((efControls.efLayoutControl)Parent).GetItemByControl(this);
            if (lci != null)
            {
                lci.Visibility = 
                    App.HasSubCompanies 
                    ? DevExpress.XtraLayout.Utils.LayoutVisibility.Always 
                    : DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
        }
        private static List<SubCompany> getSubCompanies()
        {
            List<SubCompany> lst = null;
            using (var se = new SecurityEntities(App.SecurityConnectionString))
            {
                lst = se.SubCompanies.OrderBy(c => c.Code).ToList();
            }
            return lst;
        }

    }
}
