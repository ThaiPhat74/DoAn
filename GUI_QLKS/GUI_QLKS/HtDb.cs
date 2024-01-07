using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace GUI_QLKS
{
    public partial class HtDb : DbContext
    {
        public HtDb()
            : base("name=HtDb")
        {
        }

        public virtual DbSet<DICHVU> DICHVUs { get; set; }
        public virtual DbSet<DOANHTHU> DOANHTHUs { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<KHACH> KHACHes { get; set; }
        public virtual DbSet<LOAIDICHVU> LOAIDICHVUs { get; set; }
        public virtual DbSet<LOAIPHONG> LOAIPHONGs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<PHONG> PHONGs { get; set; }
        public virtual DbSet<SUDUNGDICHVU> SUDUNGDICHVUs { get; set; }
        public virtual DbSet<TAIKHOAN> TAIKHOANs { get; set; }
        public virtual DbSet<THUEPHONG> THUEPHONGs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DICHVU>()
                .Property(e => e.DONVITINH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DICHVU>()
                .HasMany(e => e.SUDUNGDICHVUs)
                .WithRequired(e => e.DICHVU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DOANHTHU>()
                .HasMany(e => e.HOADONs)
                .WithRequired(e => e.DOANHTHU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOADON>()
                .HasMany(e => e.SUDUNGDICHVUs)
                .WithRequired(e => e.HOADON)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOADON>()
                .HasMany(e => e.THUEPHONGs)
                .WithRequired(e => e.HOADON)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHACH>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KHACH>()
                .Property(e => e.CMND)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KHACH>()
                .HasMany(e => e.THUEPHONGs)
                .WithRequired(e => e.KHACH)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOAIDICHVU>()
                .HasMany(e => e.DICHVUs)
                .WithRequired(e => e.LOAIDICHVU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOAIPHONG>()
                .HasMany(e => e.PHONGs)
                .WithRequired(e => e.LOAIPHONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MANHANVIEN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.CMND)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.TAIKHOANs)
                .WithRequired(e => e.NHANVIEN)
                .HasForeignKey(e => e.MANHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHONG>()
                .HasMany(e => e.THUEPHONGs)
                .WithRequired(e => e.PHONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.MANHANVIEN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.TENDANGNHAP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.MATKHAU)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TAIKHOAN>()
                .HasMany(e => e.HOADONs)
                .WithRequired(e => e.TAIKHOAN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TAIKHOAN>()
                .HasMany(e => e.NHANVIENs)
                .WithOptional(e => e.TAIKHOAN)
                .HasForeignKey(e => e.MATAIKHOAN);

            modelBuilder.Entity<THUEPHONG>()
                .Property(e => e.THANHTOAN)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
