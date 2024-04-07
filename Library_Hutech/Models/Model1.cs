using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Library_Hutech.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model11")
        {
        }

        public virtual DbSet<LoaiSach> LoaiSach { get; set; }
        public virtual DbSet<NXB> NXB { get; set; }
        public virtual DbSet<PhieuMuon> PhieuMuon { get; set; }
        public virtual DbSet<Sach> Sach { get; set; }
        public virtual DbSet<SinhVien> SinhVien { get; set; }
        public virtual DbSet<TacGia> TacGia { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<ViTri> ViTri { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LoaiSach>()
                .Property(e => e.MaLoaiSach)
                .IsFixedLength();

            modelBuilder.Entity<LoaiSach>()
                .HasMany(e => e.Saches)
                .WithOptional(e => e.LoaiSach1)
                .HasForeignKey(e => e.LoaiSach);

            modelBuilder.Entity<NXB>()
                .Property(e => e.MaNXB)
                .IsFixedLength();

            modelBuilder.Entity<NXB>()
                .HasMany(e => e.Saches)
                .WithOptional(e => e.NXB1)
                .HasForeignKey(e => e.NXB);

            modelBuilder.Entity<PhieuMuon>()
                .Property(e => e.MaMuon)
                .IsFixedLength();

            modelBuilder.Entity<PhieuMuon>()
                .HasMany(e => e.Saches)
                .WithOptional(e => e.PhieuMuon)
                .HasForeignKey(e => e.Muon);

            modelBuilder.Entity<Sach>()
                .Property(e => e.MaSach)
                .IsFixedLength();

            modelBuilder.Entity<Sach>()
                .Property(e => e.NamXB)
                .IsFixedLength();

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.MaSV)
                .IsFixedLength();

            modelBuilder.Entity<SinhVien>()
                .HasMany(e => e.PhieuMuons)
                .WithOptional(e => e.SinhVien)
                .HasForeignKey(e => e.NguoiMuon);

            modelBuilder.Entity<TacGia>()
                .Property(e => e.MaTacGia)
                .IsFixedLength();

            modelBuilder.Entity<TacGia>()
                .HasMany(e => e.Saches)
                .WithOptional(e => e.TacGia1)
                .HasForeignKey(e => e.TacGia);

            modelBuilder.Entity<User>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<ViTri>()
                .Property(e => e.MaViTri)
                .IsFixedLength();

            modelBuilder.Entity<ViTri>()
                .HasMany(e => e.Saches)
                .WithOptional(e => e.ViTri1)
                .HasForeignKey(e => e.ViTri);
        }
    }
}
