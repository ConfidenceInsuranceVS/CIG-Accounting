using System;
using System.Collections.Generic;
using System.Linq;

namespace Accounting
{
    public class PrintVouchers
    {
        public Nullable<System.DateTime> JvDate { get; set; }
        public string Type { get; set; }
        public Nullable<int> Reference { get; set; }
        public string Account { get; set; }
        public string AccountDescription { get; set; }
        public string Description { get; set; }
        public string Currency { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<decimal> Amount1st { get; set; }
        public Nullable<decimal> Amount2nd { get; set; }
        public string DC { get; set; }
        public string SC { get; set; }
        public string TypeDescription { get; set; }
        public string cvCur { get; set; }
        public Nullable<decimal> cvAmount { get; set; }
        public string fromTo { get; set; }
        public string details { get; set; }
        public int ID { get; set; }
        public Nullable<decimal> RateCurrency { get; set; }// added by samir BU 03/01/2017-1
    }
}
