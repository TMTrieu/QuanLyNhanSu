<<<<<<< HEAD
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

=======
>>>>>>> master
namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class BOPHAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOPHAN()
        {

            this.NHANVIENs = new HashSet<NHANVIEN>();

        }
    
        public int IDBP { get; set; }
        public string TENBP { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

        public virtual ICollection<NHANVIEN> NHANVIENs { get; set; }

    }
}
