using System;
using System.Collections.Generic;
using System.Linq;

namespace Accounting
{
    public class NotesSummary
    {
        public string currency { get; set; }
        public Nullable<int> count { get; set; }
        public string description { get; set; }
        public Nullable<decimal> debit { get; set; }
        public Nullable<decimal> credit { get; set; }
        public Nullable<decimal> balance { get; set; }
    }
}
