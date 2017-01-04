using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace efControls
{
    public class efGridViewInfo : GridViewInfo
    {
        public efGridViewInfo(DevExpress.XtraGrid.Views.Grid.GridView gridView) : base(gridView) { }

        //public override int CalcRowHeight(Graphics graphics, int rowHandle, int min, int level, bool useCache, GridColumnsInfo columns)
        //{
        //    return base.CalcRowHeight(graphics, rowHandle, MinRowHeight, level, useCache, columns);
        //}

        public override int MinRowHeight { get { return base.MinRowHeight - 2; } }
    }
}
