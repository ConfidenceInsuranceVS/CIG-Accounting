using efControls;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Accounting
{
    public partial class AccountType : object, ITableAll, ITableCode
    {
        ITableAll _opt
        {
            get { return ((ITableAll)(this)); }
        }
    }
}
