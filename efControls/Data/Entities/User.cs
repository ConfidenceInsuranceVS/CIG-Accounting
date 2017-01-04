using System;
using System.Collections.Generic;
using System.Linq;

namespace efControls.Data
{
    //  public partial class User : object, ITableSome  stopped by samir 20/12/2016
    public partial class User : object, ITableSome, ITableCode // added by samir 20/12/2016
    {
        ITableAll _opt
        {
            get { return ((ITableSome)(this)); }
        }
    }
}
