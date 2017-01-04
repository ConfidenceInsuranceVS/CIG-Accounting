using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using static Accounting.AccountingServices;

namespace Accounting
{
    public partial class cboCurrencies : efControls.efComboBox
    {
        public enum DisplayValue { Code, Description };

        [Category("xProperties"), Browsable(true)]
        public DisplayValue ValueToDisplay { get; set; }

        [Category("xProperties"), Browsable(true)]
        public BindingSource bs { get; set; }

        public cboCurrencies()
        {
            ValueToDisplay = DisplayValue.Description;
        }

        protected override void OnPopupShown()
        {
            bs.DataSource = getCurrencies();
            RefreshPopup();
            base.OnPopupShown();
        }
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            if (IsDesignMode) { return; }

            if (bs == null) { bs = new BindingSource() { DataSource = getCurrencies() }; }

            Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
                    new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 85, DevExpress.Utils.FormatType.None, string.Empty, true, DevExpress.Utils.HorzAlignment.Near),
                    new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 15, DevExpress.Utils.FormatType.None, string.Empty, true, DevExpress.Utils.HorzAlignment.Near) });
            Properties.DataSource = bs;
            Properties.DisplayMember = ValueToDisplay == DisplayValue.Code ? "Code" : "Description";
            Properties.ValueMember = "ID";
            Properties.ShowHeader = true;
            Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            Properties.NullText = string.Empty;
            Properties.NullValuePrompt = "Select Currency Or Leave Blank";
            Properties.NullValuePromptShowForEmptyValue = true;
            ToolTip = "...";
            ToolTipTitle = "Press [CTRL+DELETE] To Clear Value ...";
            ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
