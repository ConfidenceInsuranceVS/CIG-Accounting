
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Accounting
{
    public partial class PostdatedChequesInstantSummary //// added by samir BU 05/01/2017-2 
    {
        public string Sc { get; set; }
        public int Cheques { get; set; }
        public string Currency { get; set; }
        public Nullable<decimal> Debit1st { get; set; }
        public Nullable<decimal> Credit1st { get; set; }
        public Nullable<decimal> DebitBalance { get; set; }
        public Nullable<decimal> CreditBalance { get; set; }
        public Nullable<decimal> Debit { get; set; }
        public Nullable<decimal> Credit { get; set; }
    }
}

