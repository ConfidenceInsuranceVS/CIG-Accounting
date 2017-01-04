using efControls;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Accounting
{
    public partial class Journalparent : object, ITableSome, ITablePosted
    {
        ITablePosted _opt { get { return ((ITablePosted)(this)); } }
    }
}
