using System;
using System.Collections.Generic;
using System.Linq;

namespace efControls
{
    public interface IUserInfo
    {
        string Createdbyid { get; set; }
        Nullable<DateTime> Creationdate { get; set; }
        string Modifiedbyid { get; set; }
        Nullable<DateTime> Modificationdate { get; set; }
        string Posted { get; set; }
    }

}
