using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CoffeeManagement.Models
{
    public partial class QuanLyCaPheModels : DbContext
    {
        public QuanLyCaPheModels()
            : base("name=QuanLyCaPheModels")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<AccountName> AccountNames { get; set; }
        public virtual DbSet<Ban> Bans { get; set; }
        public virtual DbSet<ChiTietBill> ChiTietBills { get; set; }
        public virtual DbSet<DanhMuc> DanhMucs { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<Mon> Mons { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TheThanhVien> TheThanhViens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<AccountName>()
                .HasMany(e => e.Accounts)
                .WithRequired(e => e.AccountName)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ban>()
                .HasMany(e => e.HoaDons)
                .WithRequired(e => e.Ban)
                .HasForeignKey(e => e.IdBan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DanhMuc>()
                .HasMany(e => e.Mons)
                .WithRequired(e => e.DanhMuc)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HoaDon>()
                .HasMany(e => e.ChiTietBills)
                .WithRequired(e => e.HoaDon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Mon>()
                .HasMany(e => e.ChiTietBills)
                .WithRequired(e => e.Mon)
                .WillCascadeOnDelete(false);
        }
    }
}
