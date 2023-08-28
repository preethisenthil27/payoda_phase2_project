using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TourismManagement.Models;

public partial class TourismManagementContext : DbContext
{
    public TourismManagementContext()
    {
    }

    public TourismManagementContext(DbContextOptions<TourismManagementContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BookingDetail> BookingDetails { get; set; }

    public virtual DbSet<Credentail> Credentails { get; set; }

    public virtual DbSet<PackageDetail> PackageDetails { get; set; }

    public virtual DbSet<RegionDetail> RegionDetails { get; set; }

    public virtual DbSet<SpotDetail> SpotDetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("data source = LAPTOP-DUQR4FJF\\SQLEXPRESS; initial catalog = TourismManagement; integrated security=SSPI; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BookingDetail>(entity =>
        {
            entity.HasKey(e => e.BookingId).HasName("pk_booking_id");

            entity.ToTable("Booking_details");

            entity.Property(e => e.BookingId)
                .ValueGeneratedNever()
                .HasColumnName("booking_id");
            entity.Property(e => e.BookingDate)
                .HasColumnType("date")
                .HasColumnName("booking_date");
            entity.Property(e => e.CId).HasColumnName("c_id");
            entity.Property(e => e.NoOfPersons).HasColumnName("no_of_persons");
            entity.Property(e => e.PackageId).HasColumnName("package_id");

            entity.HasOne(d => d.CIdNavigation).WithMany(p => p.BookingDetails)
                .HasForeignKey(d => d.CId)
                .HasConstraintName("fk_c_id");

            entity.HasOne(d => d.Package).WithMany(p => p.BookingDetails)
                .HasForeignKey(d => d.PackageId)
                .HasConstraintName("fk_package_id");
        });

        modelBuilder.Entity<Credentail>(entity =>
        {
            entity.HasKey(e => e.CId).HasName("PK__Credenta__213EE7748645D288");

            entity.Property(e => e.CId)
                .ValueGeneratedNever()
                .HasColumnName("c_id");
            entity.Property(e => e.CEmail)
                .HasMaxLength(25)
                .HasColumnName("c_email");
            entity.Property(e => e.CName)
                .HasMaxLength(25)
                .HasColumnName("c_name");
            entity.Property(e => e.CPassword)
                .HasMaxLength(25)
                .HasColumnName("c_password");
            entity.Property(e => e.PhnNumber).HasColumnName("phn_number");
        });

        modelBuilder.Entity<PackageDetail>(entity =>
        {
            entity.HasKey(e => e.PackageId).HasName("pk_package_id");

            entity.ToTable("Package_details");

            entity.Property(e => e.PackageId)
                .ValueGeneratedNever()
                .HasColumnName("package_id");
            entity.Property(e => e.PackageDescription)
                .HasColumnType("text")
                .HasColumnName("package_description");
            entity.Property(e => e.PackageDuration)
                .HasMaxLength(25)
                .HasColumnName("package_duration");
            entity.Property(e => e.PackageName)
                .HasMaxLength(25)
                .HasColumnName("package_name");
            entity.Property(e => e.PackagePrice).HasColumnName("package_price");
            entity.Property(e => e.RegionId).HasColumnName("region_id");
            entity.Property(e => e.SpotId).HasColumnName("spot_id");

            entity.HasOne(d => d.Region).WithMany(p => p.PackageDetails)
                .HasForeignKey(d => d.RegionId)
                .HasConstraintName("fk_region_id");

            entity.HasOne(d => d.Spot).WithMany(p => p.PackageDetails)
                .HasForeignKey(d => d.SpotId)
                .HasConstraintName("fk_spot_id");
        });

        modelBuilder.Entity<RegionDetail>(entity =>
        {
            entity.HasKey(e => e.RegionId).HasName("PK__Region_d__01146BAEC507BA49");

            entity.ToTable("Region_details");

            entity.Property(e => e.RegionId)
                .ValueGeneratedNever()
                .HasColumnName("region_id");
            entity.Property(e => e.RegionName)
                .HasMaxLength(25)
                .HasColumnName("region_name");
        });

        modelBuilder.Entity<SpotDetail>(entity =>
        {
            entity.HasKey(e => e.SpotId).HasName("PK__Spot_det__330AF0F6FF4C4AB2");

            entity.ToTable("Spot_details");

            entity.Property(e => e.SpotId)
                .ValueGeneratedNever()
                .HasColumnName("spot_id");
            entity.Property(e => e.SpotName)
                .HasMaxLength(25)
                .HasColumnName("spot_name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
