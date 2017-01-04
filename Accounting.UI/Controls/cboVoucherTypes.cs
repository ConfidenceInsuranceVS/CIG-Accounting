using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using efControls;
using System.ComponentModel;
using DevExpress.XtraEditors;

namespace Accounting
{
    public partial class cboVoucherTypes : efComboBox
    {
        public enum jvFilter { JV, PV, RV, CN, DN };
        private BindingSource bs;

        [Category("xProperties"), Browsable(true)]
        public jvFilter Filter { get; set; }

        public int id;
        public string Code, Description;

        public cboVoucherTypes()
        {
            InitializeComponent();
            EditValueChanged += CboVoucherTypes_EditValueChanged;
            bs = new BindingSource();
        }

        private void CboVoucherTypes_EditValueChanged(object sender, EventArgs e)
        {
            var edit = sender as LookUpEdit;
            var row = (ucVoucherTypes)edit.GetSelectedDataRow();

            if (EditValue == null || row == null)
                clear();
            else
            {
                id = (int)row.ID;
                Code = row.Code;
                Description = row.Description;
            }
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

        private List<ucVoucherTypes> fillBindingsource(AccountingEntities lc) 
        {
            List<ucVoucherTypes> result = null;
            switch (Filter)
            {
                case jvFilter.JV:
                    result = lc.Vouchertypes.Where(c => c.JV == true)
                        .Select(c => new ucVoucherTypes { ID = c.ID, Code = c.Code, Description = c.Code + "\t" + c.Description, Torder = c.OrderID ?? 9 }).ToList();
                    break;
                case jvFilter.PV:
                    result = lc.Vouchertypes.Where(c => c.PV == true)
                        .Select(c => new ucVoucherTypes { ID = c.ID, Code = c.Code, Description = c.Code + "\t" + c.Description, Torder = c.OrderID ?? 9 }).ToList();
                    break;
                case jvFilter.RV:
                    result = lc.Vouchertypes.Where(c => c.RV == true)
                        .Select(c => new ucVoucherTypes { ID = c.ID, Code = c.Code, Description = c.Code + "\t" + c.Description, Torder = c.OrderID ?? 9 }).ToList();
                    break;
                case jvFilter.CN:
                    result = lc.Vouchertypes.Where(c => c.CN == true)
                        .Select(c => new ucVoucherTypes { ID = c.ID, Code = c.Code, Description = c.Code + "\t" + c.Description, Torder = c.OrderID ?? 9 }).ToList();
                    break;
                case jvFilter.DN:
                    result = lc.Vouchertypes.Where(c => c.DN == true)
                        .Select(c => new ucVoucherTypes { ID = c.ID, Code = c.Code, Description = c.Code + "\t" + c.Description, Torder = c.OrderID ?? 9 }).ToList();
                    break;
            }
            return result.OrderBy(c => c.Torder).ThenBy(c => c.Description).ToList();

            #region ToDelete
            //switch (Filter)
            //{
            //    case jvFilter.JV:
            //        result = lc.Vouchertypes.Where(c => c.JV == true).OrderBy(c => c.OrderID).ToList();
            //        break;
            //    case jvFilter.PV:
            //        result = lc.Vouchertypes.Where(c => c.PV == true).OrderBy(c => c.OrderID).ToList();
            //        break;
            //    case jvFilter.RV:
            //        result = lc.Vouchertypes.Where(c => c.RV == true).OrderBy(c => c.OrderID).ToList();
            //        break;
            //    case jvFilter.CN:
            //        result = lc.Vouchertypes.Where(c => c.CN == true).OrderBy(c => c.OrderID).ToList();
            //        break;
            //    case jvFilter.DN:
            //        result = lc.Vouchertypes.Where(c => c.DN == true).OrderBy(c => c.OrderID).ToList();
            //        break;
            //}
            //return result;
            #endregion
        }
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
                    Properties.NullValuePrompt = "Select Voucher Type Or Leave Blank";
                    Properties.NullValuePromptShowForEmptyValue = true;
                    ToolTip = "...";
                    ToolTipTitle = "Press [CTRL+DELETE] To Clear Value ...";
                    ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
                    Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
                }
            }
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
        public void clear()
        {
            EditValue = null;
            Code = Description = string.Empty;
            id = 0;
        }

    }
}
