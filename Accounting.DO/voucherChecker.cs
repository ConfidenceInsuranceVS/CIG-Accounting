using System;
using System.Collections.Generic;
using System.Linq;

namespace Accounting
{
    public class voucherChecker
    {
        public int Id { get; set; }
        public string Result { get; set; }
        public string Type { get; set; }
        public int Reference { get; set; }
        public bool Ischecked { get; set; }
    }
}
