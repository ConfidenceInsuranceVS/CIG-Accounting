
using efControls;
using efControls.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace efControls
{
    public partial class UserRolesSearchList : ITableAll // added by Samir 1/12/2016
    {
        ITableAll _opt { get { return ((ITableAll)(this)); } }
        public UserRole UserRole { get; set; }
        public int ID { get; set; }
        public int UserID { get; set; }
        public int FormID { get; set; }
        public bool Allowed { get; set; }
        public bool CanAdd { get; set; }
        public bool CanEdit { get; set; }
        public bool CanDelete { get; set; }
        public bool CanPrint { get; set; }

    }
}
