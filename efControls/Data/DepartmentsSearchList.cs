using efControls;
using efControls.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace efControls
{
    public partial class DepartmentsSearchList : ITableAll
    {
        ITableAll _opt { get { return ((ITableAll)(this)); } }
        public Department Department { get; set; }
        public int ID { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string Notes { get; set; }
    }
}
