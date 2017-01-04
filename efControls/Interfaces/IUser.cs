using System;
using System.Collections.Generic;
using System.Linq;

namespace efControls
{
    public interface IUser
    {
        int ID { get; set; }
        string Code { get; set; }
        string Name { get; set; }
        string Password { get; set; }
        Nullable<int> DepartmentID { get; set; }
        Nullable<int> GroupID { get; set; }
        Nullable<int> LevelID { get; set; }
        Nullable<bool> isBlocked { get; set; }
        string Notes { get; set; }
        Nullable<DateTime> BirthDate { get; set; }
        Nullable<DateTime> LastLogin { get; set; }
        Nullable<int> CreatedByID { get; set; }
        Nullable<DateTime> Creationdate { get; set; }
        Nullable<int> ModifiedByID { get; set; }
        Nullable<DateTime> Modificationdate { get; set; }
    }

}
