namespace GUI_QLKS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DICHVU")]
    public partial class DICHVU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DICHVU()
        {
            SUDUNGDICHVUs = new HashSet<SUDUNGDICHVU>();
        }

        [Key]
        public int MADICHVU { get; set; }

        public int MALDV { get; set; }

        [StringLength(30)]
        public string TEN { get; set; }

        [StringLength(30)]
        public string DONVITINH { get; set; }

        public double? THANHTIEN { get; set; }

        public bool? STATUS { get; set; }

        public virtual LOAIDICHVU LOAIDICHVU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SUDUNGDICHVU> SUDUNGDICHVUs { get; set; }
    }
}
