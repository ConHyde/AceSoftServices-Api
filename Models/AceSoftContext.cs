using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

/// <summary>
/// Scaffold-DbContext "Server=acesoft-db.database.windows.net;Database=AceSoft;Trusted_Connection=True;Trusted_Connection=False;
/// Encrypt=True; user=systemadmin ;password=;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Mode
/// </summary>

namespace AceSoftServices_Api.Models
{
    public partial class AceSoftContext : DbContext
    {
        public AceSoftContext()
        {
        }

        public AceSoftContext(DbContextOptions<AceSoftContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Driver> Driver { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Endorsement> Endorsement { get; set; }
        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<Prospect> Prospect { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=acesoft-db.database.windows.net;Database=AceSoft;Trusted_Connection=True;Trusted_Connection=False;Encrypt=True; user=systemadmin ;password=Justdoit55#;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Mobile).HasColumnType("numeric(11, 0)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Postcode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Sector)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Telephone).HasColumnType("numeric(11, 0)");
            });

            modelBuilder.Entity<Driver>(entity =>
            {
                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.CarOwned)
                    .IsRequired()
                    .HasColumnName("Car_Owned")
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.CpcExpiry)
                    .HasColumnName("CPC_Expiry")
                    .HasColumnType("datetime");

                entity.Property(e => e.DigiExpiry)
                    .HasColumnName("Digi_Expiry")
                    .HasColumnType("datetime");

                entity.Property(e => e.DoB).HasColumnType("date");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.EmployeeId).HasDefaultValueSql("('0')");

                entity.Property(e => e.Forename)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastContact)
                    .HasColumnName("Last_Contact")
                    .HasColumnType("date");

                entity.Property(e => e.LicenseChecked)
                    .HasColumnName("License_Checked")
                    .HasColumnType("date");

                entity.Property(e => e.LicenseExpiry)
                    .HasColumnName("License_Expiry")
                    .HasColumnType("datetime");

                entity.Property(e => e.LicenseNextCheck)
                    .HasColumnName("License_Next_Check")
                    .HasColumnType("date");

                entity.Property(e => e.LicenseNum)
                    .HasColumnName("License_Num")
                    .HasMaxLength(20);

                entity.Property(e => e.LicenseValid)
                    .HasColumnName("License_Valid")
                    .HasColumnType("datetime");

                entity.Property(e => e.Mobile)
                    .IsRequired()
                    .HasMaxLength(11);

                entity.Property(e => e.Nationality).HasMaxLength(25);

                entity.Property(e => e.NiNum)
                    .HasColumnName("NI_Num")
                    .HasMaxLength(9);

                entity.Property(e => e.Notes).HasMaxLength(500);

                entity.Property(e => e.Postcode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Prospect)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telephone).HasMaxLength(11);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Driver)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_Driver_Employee");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Endorsement>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(6);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.YearsOnLicense)
                    .HasColumnName("Years_on_License")
                    .HasColumnType("numeric(3, 1)");
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Prospect>(entity =>
            {
                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Forename)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).HasMaxLength(500);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
