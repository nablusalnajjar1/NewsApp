//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FileworxObjects
{
    using System;
    using System.Collections.Generic;
    
    public partial class FXUser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FXUser()
        {
            this.BusinessObjects = new HashSet<BusinessObject>();
        }
    
        public string ID { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BusinessObject> BusinessObjects { get; set; }
        public virtual BusinessObject BusinessObject { get; set; }
    }
}