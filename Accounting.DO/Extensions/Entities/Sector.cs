using efControls;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Accounting
{
    public partial class Sector : object, ITableSome
    {
        ITableSome _opt
        {
            get { return ((ITableSome)(this)); }
        }
    }
}
