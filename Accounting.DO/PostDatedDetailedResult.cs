using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Accounting
{
    public class PostDatedDetailedResult
    {
        public Nullable<System.DateTime> Jvdate { get; set; }
        public Nullable<System.DateTime> Maturity { get; set; }
        public string Document { get; set; }
        public string Cur { get; set; }
        public string Sc { get; set; }
        public string Bank { get; set; }
        public string DBType { get; set; }
        public Nullable<int> DBReference { get; set; }
        public string CRType { get; set; }
        public Nullable<int> CRReference { get; set; }
        public Nullable<decimal> Debit { get; set; }
        public Nullable<decimal> Credit { get; set; }
    }
}
