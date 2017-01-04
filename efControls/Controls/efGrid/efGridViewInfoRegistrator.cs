using System;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Base.Handler;
using DevExpress.XtraGrid.Views.Base.ViewInfo;
using DevExpress.XtraGrid.Registrator;

namespace efControls
{
    public class efGridViewInfoRegistrator : GridInfoRegistrator
    {
        public override string ViewName { get { return "efGridView"; } }
        public override BaseView CreateView(GridControl grid) { return new efGridView(grid as GridControl); }
        public override BaseViewInfo CreateViewInfo(BaseView view) { return new efGridViewInfo(view as efGridView); }
        public override BaseViewHandler CreateHandler(BaseView view) { return new efGridHandler(view as efGridView); }

    }
}
