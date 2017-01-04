using System;
using System.Collections.Generic;
using System.Linq;

namespace efControls.Data
{
    public partial class Group : object, ITableSome
    {
        ITableAll _opt
        {
            get { return ((ITableSome)(this)); }
        }
    }
}
