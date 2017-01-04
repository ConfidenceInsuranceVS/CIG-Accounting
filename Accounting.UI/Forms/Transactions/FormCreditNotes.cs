using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Accounting
{
    public partial class FormCreditNotes : FormTransactions
    {
        private string _type = string.Empty;
        private string _sc = string.Empty;
        private int _reference = 0;
        public FormCreditNotes()
        {
            InitializeComponent();
            lcgDetails.Expanded = true;
            lockName = "FormJournalVouchers";
            defaultType = "CN";
            defaultDc = "C";
        }
        public FormCreditNotes(int id)
        {
            lcgDetails.Expanded = true;
            _id = id;
            if (_id > 0) { isMoveLast = false; }
        }
        public FormCreditNotes(string type, int reference, string sc) : this()
        {
            _type = type;
            _reference = reference;
            _sc = sc;
        }
    }
}
