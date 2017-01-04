using System;
using System.Collections.Generic;
using System.Linq;

namespace efControls.Data
{
    public partial class UserRole : object, ITableAll
    {
        ITableAll _opt
        {
            get { return ((ITableAll)(this)); }
        }
    }
}
