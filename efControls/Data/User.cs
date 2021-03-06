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
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.UserRoles = new ObservableListSource<UserRole>();
        }
    
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public Nullable<int> DepartmentID { get; set; }
        public Nullable<int> GroupID { get; set; }
        public Nullable<int> LevelID { get; set; }
        public Nullable<bool> isBlocked { get; set; }
        public string Notes { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public Nullable<System.DateTime> LastLogin { get; set; }
        public Nullable<int> CreatedByID { get; set; }
        public Nullable<System.DateTime> Creationdate { get; set; }
        public Nullable<int> ModifiedByID { get; set; }
        public Nullable<System.DateTime> Modificationdate { get; set; }
    
        public virtual Department Department { get; set; }
        public virtual Group Group { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<UserRole> UserRoles { get; set; }
    }
}
