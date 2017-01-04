using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using System;
using System.Collections.Generic;
using System.Linq;

namespace efControls
{
    public class efGridColumnCollection : GridColumnCollection
    {
        public efGridColumnCollection(ColumnView view) : base(view) { }
        protected override GridColumn CreateColumn() { return new efGridColumn(); }
    }
}
