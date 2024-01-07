namespace GUI_QLKS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOAIPHONG")]
    public partial class LOAIPHONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAIPHONG()
        {
            PHONGs = new HashSet<PHONG>();
        }

        [Key]
        public int MALOAIPHONG { get; set; }

        [StringLength(50)]
        public string TENLOAI { get; set; }

        [StringLength(256)]
        public string MOTA { get; set; }

        public int? SOGIUONG { get; set; }

        public double? TINHTHEOGIO { get; set; }

        public double? TINHTHEONGAY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHONG> PHONGs { get; set; }
    }
}
