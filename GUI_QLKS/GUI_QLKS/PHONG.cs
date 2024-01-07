namespace GUI_QLKS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHONG")]
    public partial class PHONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHONG()
        {
            THUEPHONGs = new HashSet<THUEPHONG>();
        }

        [Key]
        public int MAPHONG { get; set; }

        public int MALOAIPHONG { get; set; }

        [StringLength(30)]
        public string TEN { get; set; }

        public bool? TINHTRANGPHONG { get; set; }

        [StringLength(30)]
        public string TRANGTHAI { get; set; }

        public virtual LOAIPHONG LOAIPHONG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THUEPHONG> THUEPHONGs { get; set; }
    }
}
