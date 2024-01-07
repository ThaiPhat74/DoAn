namespace GUI_QLKS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOADON")]
    public partial class HOADON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOADON()
        {
            SUDUNGDICHVUs = new HashSet<SUDUNGDICHVU>();
            THUEPHONGs = new HashSet<THUEPHONG>();
        }

        [Key]
        public int MAHOADON { get; set; }

        public int MADOANHTHU { get; set; }

        public int MATAIKHOAN { get; set; }

        public DateTime? NGAYIN { get; set; }

        [StringLength(256)]
        public string GHICHU { get; set; }

        public double? TONG { get; set; }

        public bool? TINHTRANGTHANHTOAN { get; set; }

        public double? DISCOUNT { get; set; }

        public virtual DOANHTHU DOANHTHU { get; set; }

        public virtual TAIKHOAN TAIKHOAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SUDUNGDICHVU> SUDUNGDICHVUs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THUEPHONG> THUEPHONGs { get; set; }
    }
}
