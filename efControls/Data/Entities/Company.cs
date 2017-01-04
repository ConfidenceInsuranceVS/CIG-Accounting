using System;
using System.Collections.Generic;
using System.Linq;

namespace efControls.Data
{
    //public partial class Company : object, ITableAll // stopped by samir BU 29/12/2016-3 on new company it is not saving createdby id and datecreation
    //{
    //    ITableAll _opt
    //    {
    //        get { return ((ITableAll)(this)); }
    //    }
    //}
    public partial class Company : object, ITableSome, ITableAll // added by samir BU 29/12/2016-3 
    {
        ITableAll _opt
        {
            get { return ((ITableSome)(this)); }
        }
    }
}
