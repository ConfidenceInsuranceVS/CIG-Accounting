using System;
using System.Collections.Generic;
using System.Linq;

namespace Accounting
{
    public partial class JournalSearchList : StandardSearchList
    {
        public Journalparent JV { get; set; }
        public string JvType { get; set; }
        public int? Reference { get; set; }
        public string SC { get; set; }
        public bool? IsPosted { get; set; }
    }
}
