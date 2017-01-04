using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Accounting
{
    public partial class FormJournalVouchers : FormTransactions
    {
        private string _type = string.Empty, _sc = string.Empty;
        private int _reference = 0;
        public FormJournalVouchers()
        {
            InitializeComponent();
            lcgDetails.Expanded = false;
            lockName = "FormJournalVouchers";
        }
        public FormJournalVouchers(int id)
        {
            lcgDetails.Expanded = false;
            _id = id;
            if (_id > 0) { isMoveLast = false; }
        }
        public FormJournalVouchers(string type, int reference, string sc)
        {
            lcgDetails.Expanded = false;
            _type = type;
            _reference = reference;
            _sc = sc;
        }
    }
}
