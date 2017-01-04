using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace efControls
{
    public class efGridHandler : GridHandler
    {
        public efGridHandler(GridView gridView) : base(gridView) { }
        //protected override void OnKeyDown(KeyEventArgs e)
        //{
        //    base.OnKeyDown(e);
        //    if (e.KeyData == Keys.Delete && View.State == GridState.Normal)
        //        View.DeleteRow(View.FocusedRowHandle);
        //}
    }
}
