using System;
using System.Collections.Generic;
using efControls;
using System.Linq;

namespace Accounting
{
    public partial class ucPrintGrid : ucPrintControl
    {
        public efGridView gv;

        public ucPrintGrid()
        {
            InitializeComponent();
        }

        protected override void OnFirstLoad()
        {
            base.OnFirstLoad();
            lcgMain.Text = string.Format(" Print / {0} ", xParent.Text);
        }

        protected override void print(bool toPrint)
        {
            switch (rgSelection.SelectedIndex)
            {
                case 0:
                    gv.SelectRow(gv.FocusedRowHandle);
                    break;
                case 1:
                    gv.SelectAll();
                    break;
                case 2:
                    break;
            }
            if (toPrint)
            {
                gv.PrintDialog();
            }
            else
            {
                gv.ShowPrintPreview();
            }
            gv.ClearSelection();
        }
    }
}
