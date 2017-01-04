using efControls;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Accounting
{
    public partial class Currency : object, ITableSome
    {
        ITableSome _opt
        {
            get { return ((ITableSome)(this)); }
        }
    }
}
