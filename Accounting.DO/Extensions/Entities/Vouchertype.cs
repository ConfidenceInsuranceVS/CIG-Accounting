using efControls;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Accounting
{
    public partial class Vouchertype : object, ITableSome, ITableCode
    {
        ITableSome _opt
        {
            get { return ((ITableSome)(this)); }
        }
    }
}
