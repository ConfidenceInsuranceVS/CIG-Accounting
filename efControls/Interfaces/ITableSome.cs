using System;
using System.Collections.Generic;
using System.Linq;

namespace efControls
{
    public interface ITableSome : ITableAll
    {
        Nullable<int> CreatedByID { get; set; }
        Nullable<DateTime> Creationdate { get; set; }
        Nullable<int> ModifiedByID { get; set; }
        Nullable<DateTime> Modificationdate { get; set; }
    }
}
