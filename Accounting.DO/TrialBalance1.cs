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
    
    public partial class TrialBalance1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TrialBalance1()
        {
            this.Journalchilds = new ObservableListSource<Journalchild>();
        }
    
        public string AccountYearCurrency { get; set; }
        public int Year { get; set; }
        public int Accountid { get; set; }
        public int CurrencyID { get; set; }
        public Nullable<decimal> Credit { get; set; }
        public Nullable<decimal> Debit { get; set; }
        public Nullable<decimal> Credit1st { get; set; }
        public Nullable<decimal> Debit1st { get; set; }
        public Nullable<decimal> Credit2nd { get; set; }
        public Nullable<decimal> Debit2nd { get; set; }
        public Nullable<decimal> OpenCredit { get; set; }
        public Nullable<decimal> OpenDebit { get; set; }
        public Nullable<decimal> OpenCredit1st { get; set; }
        public Nullable<decimal> OpenDebit1st { get; set; }
        public Nullable<decimal> OpenCredit2nd { get; set; }
        public Nullable<decimal> OpenDebit2nd { get; set; }
        public Nullable<decimal> Credit01 { get; set; }
        public Nullable<decimal> Credit02 { get; set; }
        public Nullable<decimal> Credit03 { get; set; }
        public Nullable<decimal> Credit04 { get; set; }
        public Nullable<decimal> Credit05 { get; set; }
        public Nullable<decimal> Credit06 { get; set; }
        public Nullable<decimal> Credit07 { get; set; }
        public Nullable<decimal> Credit08 { get; set; }
        public Nullable<decimal> Credit09 { get; set; }
        public Nullable<decimal> Credit10 { get; set; }
        public Nullable<decimal> Credit11 { get; set; }
        public Nullable<decimal> Credit12 { get; set; }
        public Nullable<decimal> Debit01 { get; set; }
        public Nullable<decimal> Debit02 { get; set; }
        public Nullable<decimal> Debit03 { get; set; }
        public Nullable<decimal> Debit04 { get; set; }
        public Nullable<decimal> Debit05 { get; set; }
        public Nullable<decimal> Debit06 { get; set; }
        public Nullable<decimal> Debit07 { get; set; }
        public Nullable<decimal> Debit08 { get; set; }
        public Nullable<decimal> Debit09 { get; set; }
        public Nullable<decimal> Debit10 { get; set; }
        public Nullable<decimal> Debit11 { get; set; }
        public Nullable<decimal> Debit12 { get; set; }
        public Nullable<decimal> Credit1st01 { get; set; }
        public Nullable<decimal> Credit1st02 { get; set; }
        public Nullable<decimal> Credit1st03 { get; set; }
        public Nullable<decimal> Credit1st04 { get; set; }
        public Nullable<decimal> Credit1st05 { get; set; }
        public Nullable<decimal> Credit1st06 { get; set; }
        public Nullable<decimal> Credit1st07 { get; set; }
        public Nullable<decimal> Credit1st08 { get; set; }
        public Nullable<decimal> Credit1st09 { get; set; }
        public Nullable<decimal> Credit1st10 { get; set; }
        public Nullable<decimal> Credit1st11 { get; set; }
        public Nullable<decimal> Credit1st12 { get; set; }
        public Nullable<decimal> Debit1st01 { get; set; }
        public Nullable<decimal> Debit1st02 { get; set; }
        public Nullable<decimal> Debit1st03 { get; set; }
        public Nullable<decimal> Debit1st04 { get; set; }
        public Nullable<decimal> Debit1st05 { get; set; }
        public Nullable<decimal> Debit1st06 { get; set; }
        public Nullable<decimal> Debit1st07 { get; set; }
        public Nullable<decimal> Debit1st08 { get; set; }
        public Nullable<decimal> Debit1st09 { get; set; }
        public Nullable<decimal> Debit1st10 { get; set; }
        public Nullable<decimal> Debit1st11 { get; set; }
        public Nullable<decimal> Debit1st12 { get; set; }
        public Nullable<decimal> Credit2nd01 { get; set; }
        public Nullable<decimal> Credit2nd02 { get; set; }
        public Nullable<decimal> Credit2nd03 { get; set; }
        public Nullable<decimal> Credit2nd04 { get; set; }
        public Nullable<decimal> Credit2nd05 { get; set; }
        public Nullable<decimal> Credit2nd06 { get; set; }
        public Nullable<decimal> Credit2nd07 { get; set; }
        public Nullable<decimal> Credit2nd08 { get; set; }
        public Nullable<decimal> Credit2nd09 { get; set; }
        public Nullable<decimal> Credit2nd10 { get; set; }
        public Nullable<decimal> Credit2nd11 { get; set; }
        public Nullable<decimal> Credit2nd12 { get; set; }
        public Nullable<decimal> Debit2nd01 { get; set; }
        public Nullable<decimal> Debit2nd02 { get; set; }
        public Nullable<decimal> Debit2nd03 { get; set; }
        public Nullable<decimal> Debit2nd04 { get; set; }
        public Nullable<decimal> Debit2nd05 { get; set; }
        public Nullable<decimal> Debit2nd06 { get; set; }
        public Nullable<decimal> Debit2nd07 { get; set; }
        public Nullable<decimal> Debit2nd08 { get; set; }
        public Nullable<decimal> Debit2nd09 { get; set; }
        public Nullable<decimal> Debit2nd10 { get; set; }
        public Nullable<decimal> Debit2nd11 { get; set; }
        public Nullable<decimal> Debit2nd12 { get; set; }
        public Nullable<decimal> CloseCredit { get; set; }
        public Nullable<decimal> CloseDebit { get; set; }
        public Nullable<decimal> CloseCredit1st { get; set; }
        public Nullable<decimal> CloseDebit1st { get; set; }
        public Nullable<decimal> CloseCredit2nd { get; set; }
        public Nullable<decimal> CloseDebit2nd { get; set; }
        public Nullable<decimal> Balance { get; set; }
        public Nullable<decimal> Balance1st { get; set; }
        public Nullable<decimal> Balance2nd { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<Journalchild> Journalchilds { get; set; }
    }
}