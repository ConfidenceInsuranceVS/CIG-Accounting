//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace efControls.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Form
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Form()
        {
            this.GroupRoles = new ObservableListSource<GroupRole>();
            this.UserRoles = new ObservableListSource<UserRole>();
        }
    
        public int ID { get; set; }
        public string Panel { get; set; }
        public string FormGroup { get; set; }
        public string FormName { get; set; }
        public Nullable<int> CreatedByID { get; set; }
        public Nullable<System.DateTime> Creationdate { get; set; }
        public Nullable<int> ModifiedByID { get; set; }
        public Nullable<System.DateTime> Modificationdate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<GroupRole> GroupRoles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<UserRole> UserRoles { get; set; }
    }
}