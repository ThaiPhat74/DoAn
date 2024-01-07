namespace GUI_QLKS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHANVIEN")]
    public partial class NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHANVIEN()
        {
            TAIKHOANs = new HashSet<TAIKHOAN>();
        }

        [Key]
        [StringLength(10)]
        public string MANHANVIEN { get; set; }

        public int? MATAIKHOAN { get; set; }

        [StringLength(30)]
        public string HOTEN { get; set; }

        [StringLength(50)]
        public string DIACHI { get; set; }

        [StringLength(11)]
        public string SDT { get; set; }

        public DateTime? NGAYSINH { get; set; }

        [StringLength(12)]
        public string CMND { get; set; }

        [StringLength(50)]
        public string CHUCVU { get; set; }

        public virtual TAIKHOAN TAIKHOAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TAIKHOAN> TAIKHOANs { get; set; }
    }
}
