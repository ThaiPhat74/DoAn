namespace GUI_QLKS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SUDUNGDICHVU")]
    public partial class SUDUNGDICHVU
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MADICHVU { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MAHOADON { get; set; }

        public int? SOLUONG { get; set; }

        public virtual DICHVU DICHVU { get; set; }

        public virtual HOADON HOADON { get; set; }
    }
}
