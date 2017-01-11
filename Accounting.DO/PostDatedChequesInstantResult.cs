
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Accounting
{
    public class PostDatedChequesInstantResult // added by samir BU 05/01/2017-2
    {
        public Nullable<System.DateTime> Maturity { get; set; }
        public Nullable<int> Document { get; set; }
        public Nullable<int> Bank { get; set; }
        public Nullable<int> Account { get; set; }
        public Nullable<int> Description { get; set; }
        public string Currency { get; set; }
        public Nullable<decimal> Debit { get; set; }
        public Nullable<decimal> Credit { get; set; }
        public Nullable<decimal> Debit1st { get; set; }
        public Nullable<decimal> Credit1st { get; set; }
        public Nullable<decimal> Balance1st { get; set; }
        public Nullable<decimal> Debit2nd { get; set; }
        public Nullable<decimal> Credit2nd { get; set; }
        public Nullable<decimal> Balance2nd { get; set; }
        public Nullable<int> Type { get; set; }
        public Nullable<int> Reference { get; set; }
        public Nullable<int> Jvdate { get; set; }
        public Nullable<int> Ydate { get; set; }
        public string Sc { get; set; }
        public int JvID { get; set; }
        public Nullable<decimal> Amount { get; set; } //// added by samir BU 05/01/2017-2
    }
}
