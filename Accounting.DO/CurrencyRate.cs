//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Accounting
{
    using System;
    using System.Collections.Generic;
    
    public partial class CurrencyRate
    {
        public int ID { get; set; }
        public Nullable<System.DateTime> Ratedate { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public Nullable<decimal> Parity { get; set; }
        public Nullable<int> Currencyid { get; set; }
        public Nullable<int> CreatedByID { get; set; }
        public Nullable<System.DateTime> Creationdate { get; set; }
        public Nullable<int> ModifiedByID { get; set; }
        public Nullable<System.DateTime> Modificationdate { get; set; }
        public Nullable<int> YDate { get; set; }
        public Nullable<int> MDate { get; set; }
        public Nullable<int> DDate { get; set; }
    
        public virtual Currency Currency { get; set; }
    }
}
