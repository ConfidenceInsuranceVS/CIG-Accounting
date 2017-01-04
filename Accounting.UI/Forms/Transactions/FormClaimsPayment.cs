using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Accounting
{
    public partial class FormClaimsPayment : FormTransactions
    {
        private string _type = string.Empty;
        private string _sc = string.Empty;
        private int _reference = 0;
        public FormClaimsPayment()
        {
            InitializeComponent();
            lcgDetails.Expanded = true;
            lockName = "FormJournalVouchers";
            defaultType = "PV";
        }
        public FormClaimsPayment(string type, int reference) : this()
        {
            _type = type;
            _reference = reference;
        }
        public FormClaimsPayment(int id) : this()
        {
            if (DesignMode | base.DesignMode) { return; }

            lcgDetails.Expanded = true;
            _id = id;
            if (_id > 0) { isMoveLast = false; }
        }
        public FormClaimsPayment(string type, int reference, string sc) : this()
        {
            if (DesignMode | base.DesignMode) { return; }

            _type = type;
            _reference = reference;
            _sc = sc;
        }

        //protected override void onShownSetPosition()
        //{
        //    base.onShownSetPosition();
        //    gvSearch.SetRowCellValue(GridControl.AutoFilterRowHandle, colSearch, "CP");
        //    gvSearch.MoveLast();
        //    if (!string.IsNullOrEmpty(_type))
        //    {
        //        gvSearch.SetRowCellValue(GridControl.AutoFilterRowHandle, colSearch, _type);
        //        gvSearch.SetRowCellValue(GridControl.AutoFilterRowHandle, colRef, _reference);
        //        if (gvSearch.RowCount > 0) { gvSearch.FocusedRowHandle = 0; }
        //    }
        //}
    }
}
