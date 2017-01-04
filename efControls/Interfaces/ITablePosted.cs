using System;
using System.Collections.Generic;
using System.Linq;

namespace efControls
{
    public interface ITablePosted : ITableAll, ITableSome
    {
        bool? Isposted { get; set; }
    }
}