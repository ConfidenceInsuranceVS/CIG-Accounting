using efControls;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Accounting
{
    public partial class Bank : object, ITableSome, ITableCode
    {
        ITableSome _opt
        {
            get { return ((ITableSome)(this)); }
        }
    }
}
