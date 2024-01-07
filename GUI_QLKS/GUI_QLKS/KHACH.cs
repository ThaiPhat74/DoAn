namespace GUI_QLKS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHACH")]
    public partial class KHACH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHACH()
        {
            THUEPHONGs = new HashSet<THUEPHONG>();
        }

        [Key]
        public int MAKHACH { get; set; }

        [StringLength(30)]
        public string HOTEN { get; set; }

        [StringLength(11)]
        public string SDT { get; set; }

        [StringLength(12)]
        public string CMND { get; set; }

        public DateTime? NGAYSINH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THUEPHONG> THUEPHONGs { get; set; }
    }
}
