namespace WebBanSach.Models.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QuanLyBanSachDbContext : DbContext
    {
        public QuanLyBanSachDbContext()
            : base("name=QuanLyBanSachDbContext1")
        {
        }

        public virtual DbSet<Chinhanh> Chinhanhs { get; set; }
        public virtual DbSet<ChiTietGioHang> ChiTietGioHangs { get; set; }
        public virtual DbSet<Chude> Chudes { get; set; }
        public virtual DbSet<Giohangkh> Giohangkhs { get; set; }
        public virtual DbSet<Khachhang> Khachhangs { get; set; }
        public virtual DbSet<Nhaxuatban> Nhaxuatbans { get; set; }
        public virtual DbSet<Sach> Saches { get; set; }
        public virtual DbSet<Tacgia> Tacgias { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Chinhanh>()
                .Property(e => e.Sdt)
                .IsUnicode(false);

            modelBuilder.Entity<Khachhang>()
                .Property(e => e.Dienthoaikh)
                .IsUnicode(false);
        }
    }
}
