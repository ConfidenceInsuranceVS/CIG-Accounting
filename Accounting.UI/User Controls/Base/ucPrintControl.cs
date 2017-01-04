using System;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using efControls;

namespace Accounting
{
    public partial class ucPrintControl : efUserControl
    {
        public ucPrintControl()
        {
            InitializeComponent();
        }

        protected override void OnFirstLoad()
        {
            base.OnFirstLoad();
            if (DesignMode) { return; }

            Left = (xParent.Width - Width) / 2;
            Top = (xParent.Height - Height) / 2;
            BringToFront();
            //xParent.xState = Enums.State.Off;
            //xParent.lcMain.Enabled = xParent.lcSearch.Enabled = xParent.toolBar.Visible = false;
        }
        private void ucBtnPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            print(true);
        }

        private void ucBtnPreview_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            print(false);
        }

        private void ucBtnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //xParent.xState = Enums.State.None;
            //xParent.lcMain.Enabled = xParent.lcSearch.Enabled = xParent.toolBar.Visible = true;
            xParent.Controls.Remove(this);
        }
        protected virtual void print(bool toPrint) { }
    }
}
