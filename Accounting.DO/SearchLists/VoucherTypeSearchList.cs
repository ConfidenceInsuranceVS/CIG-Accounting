using efControls;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Accounting
{
    public partial class VoucherTypeSearchList : ITableAll
    {
        ITableAll _opt { get { return ((ITableAll)(this)); } }
        public Vouchertype Vouchertype { get; set; }
        public int ID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public Nullable<bool> JV { get; set; }
        public Nullable<bool> PV { get; set; }
        public Nullable<bool> RV { get; set; }
        public Nullable<bool> CN { get; set; }
        public Nullable<bool> DN { get; set; }
        public Nullable<int> OrderID { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
    }
}
