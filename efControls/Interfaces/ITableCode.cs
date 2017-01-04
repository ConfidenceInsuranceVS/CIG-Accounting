using System;
using System.Collections.Generic;
using System.Linq;

namespace efControls
{
    public interface ITableCode : ITableAll
    {
        string Code { get; set; }
    }
}