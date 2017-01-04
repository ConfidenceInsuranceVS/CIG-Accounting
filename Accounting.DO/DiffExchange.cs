using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Accounting
{
    public partial class DiffExchange
    {
        public int ID { get; set; }
        public string Account { get; set; }
        public Nullable<int> AccountID { get; set; }
        public Nullable<int> CurrencyID { get; set; }
        public Nullable<decimal> Balance { get; set; }
        public Nullable<decimal> Balance1st { get; set; }
        public Nullable<decimal> Balance2nd { get; set; }
        public Nullable<decimal> nBalance1st { get; set; }
        public Nullable<decimal> nBalance2nd { get; set; }
        public Nullable<decimal> Difference1st { get; set; }
        public Nullable<decimal> Difference2nd { get; set; }
        public Nullable<int> AccountID1st { get; set; }
        public Nullable<int> AccountID2nd { get; set; }
        public Nullable<decimal> Rate { get; set; }
    }
}
