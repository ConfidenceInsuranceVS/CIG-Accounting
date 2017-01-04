using efControls;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Accounting
{
    public partial class vChartOfAccounts : object, ITableAll
    {
        ITableAll _opt { get { return ((ITableAll)(this)); } }
    }
}
