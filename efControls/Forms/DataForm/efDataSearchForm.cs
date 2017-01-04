using System;
using System.Linq;
using System.Collections.Generic;

namespace efControls
{
    public partial class efDataSearchForm : efDataForm
    {
        public efDataSearchForm()
        {
            InitializeComponent();

            bsSearch.CurrentChanged += BsSearch_CurrentChanged;
        }
        protected internal virtual void onFormCurrentChanged() { }
        private void BsSearch_CurrentChanged(object sender, EventArgs e)
        {

            try // BU 29/12/2016-1  i have added try catch to bypass error can use base.checkAvailability
            {
                currentID = ((ITableAll)bsSearch.Current).ID;
                onFormCurrentChanged();
            }
                catch
            {
            }

           
            //}
        }

        //protected override void OnShown(EventArgs e)
        //{
        //    if (base.DesignMode) { return; }
        //    if (isMoveLast)
        //    {
        //        isMoveLast = false;
        //        if (gvSearch.RowCount == 1)
        //            onFormRowChanged();
        //        else
        //            gvSearch.MoveLast();
        //    }
        //    base.OnShown(e);
        //}
        protected override void checkAvailability(int id)
        {
            base.checkAvailability(id);
            if (lcSearch.Visible) { gvSearch.MakeRowVisible(gvSearch.FocusedRowHandle); }
        }

        //protected override void LoadData()
        //{
        //    var pos = gvSearch.FocusedRowHandle;
        //    //
        //    base.LoadData();
        //    //
        //    gvSearch.FocusedRowHandle = pos;
        //}

        //protected override void onFormRowChanged()
        //{
        //    if (NavigationGrid.FocusedRowHandle < 0) { return; }
        //    if (isMoveLast && NavigationGrid.FocusedRowHandle == 0) { return; }
        //    //
        //    de.GetMasterData(((ITableAll)gvSearch.GetFocusedRow()).ID);
        //    onFormGetMasterData();
        //    //
        //    base.onFormRowChanged();
        //}

        //protected override void onFormGetSearchData()
        //{
        //    esSearch.Reload();
        //    if (rowID > 0) { gvSearch.FocusedRowHandle = gvSearch.LocateByValue("ID", rowID); }
        //}

        //protected override void onFormDelete()
        //{
        //    //
        //    var rh = gvSearch.FocusedRowHandle;
        //    if (gvSearch.RowCount > 1)
        //    {
        //        if (gvSearch.IsLastRow)
        //            rowID = (int)gvSearch.GetRowCellValue(rh - 1, "ID");
        //        else
        //            rowID = (int)gvSearch.GetRowCellValue(rh + 1, "ID");
        //    }
        //    else
        //        rowID = -1;
        //    //
        //    base.onFormDelete();
        //    if (rowID == -1) { bsMaster.Clear(); }
        //    onFormGetSearchData();
        //}
    }
}
