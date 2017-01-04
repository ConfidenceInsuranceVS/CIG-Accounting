using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using efControls;
using System.ComponentModel;
using static Accounting.AccountingServices;

namespace Accounting
{
    public partial class cboBanks : efComboBox
    {
        public enum DisplayValue { Code, Description };

        [Category("xProperties"), Browsable(true)]
        public DisplayValue ValueToDisplay { get; set; }

        [Category("xProperties"), Browsable(true)]
        public BindingSource bs { get; set; }

        public cboBanks()
        {
            InitializeComponent();
            ValueToDisplay = DisplayValue.Description;
        }
        protected override void OnPopupShown()
        {
            bs.DataSource = getBanks();
            RefreshPopup();
            base.OnPopupShown();
        }

        private List<Bank> fillBindingsource(AccountingEntities lc) { return lc.Banks.OrderBy(c => c.Description).ToList(); }
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            if (IsDesignMode) { return; }

            if (bs == null) { bs = new BindingSource() { DataSource = getCurrencies() }; }

            Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
                    new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 85, DevExpress.Utils.FormatType.None, string.Empty, true, DevExpress.Utils.HorzAlignment.Near)});
            Properties.DataSource = bs;
            Properties.DisplayMember = "Description";
            Properties.ValueMember = "ID";
            Properties.ShowHeader = true;
            Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            Properties.NullText = string.Empty;
            Properties.NullValuePrompt = "Select Bank Or Leave Blank";
            Properties.NullValuePromptShowForEmptyValue = true;
            ToolTip = "...";
            ToolTipTitle = "Press [CTRL+DELETE] To Clear Value ...";
            ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
