using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Accounting
{
    public partial class FormDebitNotes : FormTransactions
    {
        private string _type = string.Empty;
        private int _reference = 0;
        private string _sc = string.Empty;
        public FormDebitNotes()
        {
            InitializeComponent();
            lockName = "FormJournalVouchers";
            lcgDetails.Expanded = true;
            defaultType = "DN";
        }
        public FormDebitNotes(int id)
        {
            lcgDetails.Expanded = true;
            _id = id;
            if (_id > 0) { isMoveLast = false; }
        }
        public FormDebitNotes(string type, int reference, string sc) : this()
        {
            _type = type;
            _reference = reference;
            _sc = sc;
        }
    }
}
