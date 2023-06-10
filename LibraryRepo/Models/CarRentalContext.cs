using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace LibraryRepo.Models
{
    public partial class CarRentalContext : DbContext
    {
        public CarRentalContext()
        {
        }

        public CarRentalContext(DbContextOptions<CarRentalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Rental> Rentals { get; set; }
        public virtual DbSet<RentalDetail> RentalDetails { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer(GetConnectionString());
            }
        }
        private string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            var strConn = config["ConnectionStrings:BankAccountTypeDB"];
            return strConn;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("Account");

                entity.HasIndex(e => e.Email, "UQ__Account__A9D105345C4BBC25")
                    .IsUnique();

                entity.Property(e => e.AccountId).HasColumnName("Account_ID");

                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fullname).HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Account__User_ID__4E88ABD4");
            });

            modelBuilder.Entity<Brand>(entity =>
            {
                entity.ToTable("Brand");

                entity.Property(e => e.BrandId)
                    .ValueGeneratedNever()
                    .HasColumnName("BrandID");

                entity.Property(e => e.BrandName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Logo).IsUnicode(false);
            });

            modelBuilder.Entity<Car>(entity =>
            {
                entity.ToTable("Car");

                entity.Property(e => e.CarId).HasColumnName("Car_ID");

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.Describe).HasMaxLength(100);

                entity.Property(e => e.Fuel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Images)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Model).HasMaxLength(50);

                entity.Property(e => e.Transmission)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK__Car__BrandID__534D60F1");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.ToTable("Payment");

                entity.Property(e => e.PaymentId)
                    .ValueGeneratedNever()
                    .HasColumnName("Payment_ID");

                entity.Property(e => e.AccountId).HasColumnName("Account_ID");

                entity.Property(e => e.RentalDetailId).HasColumnName("RentalDetail_ID");

                entity.Property(e => e.TotalPrice)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("Total_price");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK__Payment__Account__5EBF139D");

                entity.HasOne(d => d.RentalDetail)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.RentalDetailId)
                    .HasConstraintName("FK__Payment__RentalD__5DCAEF64");
            });

            modelBuilder.Entity<Rental>(entity =>
            {
                entity.ToTable("Rental");

                entity.Property(e => e.RentalId).HasColumnName("Rental_ID");

                entity.Property(e => e.AccountId).HasColumnName("Account_ID");

                entity.Property(e => e.CarId).HasColumnName("Car_ID");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Rentals)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK__Rental__Account___5629CD9C");

                entity.HasOne(d => d.Car)
                    .WithMany(p => p.Rentals)
                    .HasForeignKey(d => d.CarId)
                    .HasConstraintName("FK__Rental__Car_ID__571DF1D5");
            });

            modelBuilder.Entity<RentalDetail>(entity =>
            {
                entity.ToTable("RentalDetail");

                entity.Property(e => e.RentalDetailId).HasColumnName("RentalDetail_ID");

                entity.Property(e => e.DropOffDate).HasColumnType("date");

                entity.Property(e => e.DropOffLocation)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PickupDate).HasColumnType("date");

                entity.Property(e => e.PickupLocation)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RentalId).HasColumnName("Rental_ID");

                entity.HasOne(d => d.Rental)
                    .WithMany(p => p.RentalDetails)
                    .HasForeignKey(d => d.RentalId)
                    .HasConstraintName("FK__RentalDet__Renta__5AEE82B9");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Username).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
