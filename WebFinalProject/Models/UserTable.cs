//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebFinalProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserTable()
        {
            this.RentDetailTables = new HashSet<RentDetailTable>();
            this.RentTables = new HashSet<RentTable>();
        }
    
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string U_Pwd { get; set; }
        public Nullable<int> RoleID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RentDetailTable> RentDetailTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RentTable> RentTables { get; set; }
        public virtual RoleTable RoleTable { get; set; }
        public virtual UserInfoTable UserInfoTable { get; set; }
    }
}