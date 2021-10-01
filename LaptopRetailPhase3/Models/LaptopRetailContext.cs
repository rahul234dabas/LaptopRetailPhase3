using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace LaptopRetailPhase3.Models
{
    public partial class LaptopRetailContext : DbContext
    {
        public LaptopRetailContext()
        {
        }

        public LaptopRetailContext(DbContextOptions<LaptopRetailContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblAdmin> TblAdmins { get; set; }
        public virtual DbSet<TblCustomer> TblCustomers { get; set; }
        public virtual DbSet<TblLaptop> TblLaptops { get; set; }
        public virtual DbSet<TblSeller> TblSellers { get; set; }
        public virtual DbSet<TblSellerCustomer> TblSellerCustomers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=H5CG1220K2K;integrated security =true;database=LaptopRetail");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TblAdmin>(entity =>
            {
                entity.HasKey(e => e.Sno);

                entity.ToTable("tbl_admin");

                entity.Property(e => e.Sno)
                    .ValueGeneratedNever()
                    .HasColumnName("sno");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Uname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("uname");
            });

            modelBuilder.Entity<TblCustomer>(entity =>
            {
                entity.HasKey(e => e.Sno)
                    .HasName("PK__tbl_cust__DDDF6446DDF0D4BC");

                entity.ToTable("tbl_customers");

                entity.Property(e => e.Sno)
                    .ValueGeneratedNever()
                    .HasColumnName("sno");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.Cemail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cemail");

                entity.Property(e => e.FName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fName");

                entity.Property(e => e.LName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lName");

                entity.Property(e => e.LaptopPurchased).HasColumnName("laptop_purchased");

                entity.Property(e => e.Pno)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("pno");

                entity.HasOne(d => d.LaptopPurchasedNavigation)
                    .WithMany(p => p.TblCustomers)
                    .HasForeignKey(d => d.LaptopPurchased)
                    .HasConstraintName("FK__tbl_custo__lapto__2A4B4B5E");
            });

            modelBuilder.Entity<TblLaptop>(entity =>
            {
                entity.HasKey(e => e.Sno);

                entity.ToTable("tbl_laptops");

                entity.Property(e => e.Sno)
                    .ValueGeneratedNever()
                    .HasColumnName("sno");

                entity.Property(e => e.LaptopName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("laptopName");

                entity.Property(e => e.ModelNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("modelNo");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Processor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("processor");

                entity.Property(e => e.Ram)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ram");

                entity.Property(e => e.Rom)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("rom");
            });

            modelBuilder.Entity<TblSeller>(entity =>
            {
                entity.HasKey(e => e.Sno);

                entity.ToTable("tbl_seller");

                entity.Property(e => e.Sno)
                    .ValueGeneratedNever()
                    .HasColumnName("sno");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.FName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fName");

                entity.Property(e => e.LName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lName");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("password");
            });

            modelBuilder.Entity<TblSellerCustomer>(entity =>
            {
                entity.HasKey(e => new { e.SellerSno, e.CustomerSno })
                    .HasName("PK__tbl_sell__1B33B1E8AF093916");

                entity.ToTable("tbl_seller_customer");

                entity.Property(e => e.SellerSno).HasColumnName("seller_sno");

                entity.Property(e => e.CustomerSno).HasColumnName("customer_sno");

                entity.HasOne(d => d.CustomerSnoNavigation)
                    .WithMany(p => p.TblSellerCustomers)
                    .HasForeignKey(d => d.CustomerSno)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbl_selle__custo__2E1BDC42");

                entity.HasOne(d => d.SellerSnoNavigation)
                    .WithMany(p => p.TblSellerCustomers)
                    .HasForeignKey(d => d.SellerSno)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbl_selle__selle__2D27B809");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
