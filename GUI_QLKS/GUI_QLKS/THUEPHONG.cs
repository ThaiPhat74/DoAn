namespace GUI_QLKS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("THUEPHONG")]
    public partial class THUEPHONG
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MAKHACH { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MAPHONG { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MAHOADON { get; set; }

        public DateTime? CHECK_IN { get; set; }

        public DateTime? CHECK_OUT { get; set; }

        [StringLength(10)]
        public string THANHTOAN { get; set; }

        [StringLength(256)]
        public string GHICHU { get; set; }

        public virtual HOADON HOADON { get; set; }

        public virtual KHACH KHACH { get; set; }

        public virtual PHONG PHONG { get; set; }
    }
}
