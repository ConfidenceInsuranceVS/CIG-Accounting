﻿using efControls;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Accounting
{
    public partial class BankSearchList : ITableAll
    {
        ITableAll _opt { get { return ((ITableAll)(this)); } }
        public Bank Bank { get; set; }
        public int ID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
    }
}
