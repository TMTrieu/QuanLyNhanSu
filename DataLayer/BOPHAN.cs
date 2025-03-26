namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class BOPHAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOPHAN()
        {
            this.NHANVIENs = new HashSet<NHANVIEN>(); // Giữ lại một cách nhất quán
        }
    
        public int IDBP { get; set; }
        public string TENBP { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHANVIEN> NHANVIENs { get; set; } // Giữ một kiểu đặt tên duy nhất
    }
}
