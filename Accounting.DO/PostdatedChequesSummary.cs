using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Accounting
{
    public partial class PostdatedChequesSummary
    {
        public string Sc { get; set; }
        public int Cheques { get; set; }
        public string Cur { get; set; }
        public Nullable<decimal> Debit { get; set; }
        public Nullable<decimal> Credit { get; set; }
        public Nullable<decimal> DebitBalance { get; set; }
        public Nullable<decimal> CreditBalance { get; set; }
    }
}
