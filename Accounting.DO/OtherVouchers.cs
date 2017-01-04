using System;
using System.Collections.Generic;
using System.Linq;

namespace Accounting
{
    public class OtherVouchers
    {
        public Nullable<System.DateTime> jvdate { get; set; }
        public string type { get; set; }
        public Nullable<int> reference { get; set; }
        public string description { get; set; }
        public string cur { get; set; }
        public Nullable<decimal> amount { get; set; }
        public Nullable<decimal> Amount1st { get; set; }
        public Nullable<decimal> Amount2nd { get; set; }
        public string cvCur { get; set; }
        public Nullable<decimal> cvAmount { get; set; }
        public string account { get; set; }
        public string accountDescription { get; set; }
        public string fromTo { get; set; }
        public string details { get; set; }
        public string typeDescription { get; set; }
        public string Dc { get; set; }
        public string SC { get; set; }
        public int ID { get; set; }

    }
}
