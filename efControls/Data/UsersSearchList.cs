
using efControls;
using efControls.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace efControls
{
    public partial class UsersSearchList : ITableAll // added by Samir 1/12/2016
    {
        ITableAll _opt { get { return ((ITableAll)(this)); } }
     
        public User User { get; set; }
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int DepartmentId { get; set; }
        public int GroupId { get; set; }
        public int? LevelId { get; set; }//nullable
        public bool isBlocked { get; set; }
        public string Notes { get; set; }
        public DateTime Birthdate { get; set; }
        public DateTime LastLogin { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }

    }
}
