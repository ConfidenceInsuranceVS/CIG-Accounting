using System;
using System.Collections.Generic;
using System.Linq;

namespace efControls.Data
{
    //public partial class Department : object, ITableAll //stopped by samir on 29/12/2016-2  when creating a new department ModifiedbyId ,Creation Date not saving in database
    //{
    //    ITableAll _opt
    //    {
    //        get { return ((ITableAll)(this)); }
    //    }
    //    //public string CreatedBy { get; set; }
    //    //public string ModifiedBy { get; set; }
    //}

    public partial class Department : object, ITableSome, ITableAll // added by samir BU 29/12/2016-2 
    {
        ITableAll _opt
        {
            get { return ((ITableSome)(this)); }
        }
    }
}
