
using efControls;
using efControls.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace efControls
{
    public partial class GroupsSearchList : ITableAll // added by Samir 1/12/2016
    {
        ITableAll _opt { get { return ((ITableAll)(this)); } }
        public Group Group { get; set; }
        public int ID { get; set; }
         public string Description { get; set; }
       
        public DateTime LastLogin { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }

    }
}
