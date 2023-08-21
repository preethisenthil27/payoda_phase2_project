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

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("data source=.\\SQLEXPRESS; initial catalog=TourismManagement; integrated security=SSPI; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BookingDetail>(entity =>
        {
            entity.HasKey(e => e.BookingId).HasName("pk_booking_id");

            entity.ToTable("Booking_details");

            entity.Property(e => e.BookingId).HasColumnName("booking_id");
            entity.Property(e => e.BookingDate)
                .HasColumnType("date")
                .HasColumnName("booking_date");
            entity.Property(e => e.BookingPrice).HasColumnName("booking_price");
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
            entity.HasKey(e => e.CId).HasName("PK__Credenta__213EE77426978E94");

            entity.HasIndex(e => e.CEmail, "UQ_Email").IsUnique();

            entity.Property(e => e.CId).HasColumnName("c_id");
            entity.Property(e => e.CEmail)
                .HasMaxLength(25)
                .HasColumnName("c_email");
            entity.Property(e => e.CName)
                .HasMaxLength(50)
                .HasColumnName("c_name");
            entity.Property(e => e.CPassword)
                .HasMaxLength(50)
                .HasColumnName("c_password");
            entity.Property(e => e.PhnNumber).HasColumnName("phn_number");
        });

        modelBuilder.Entity<PackageDetail>(entity =>
        {
            entity.HasKey(e => e.PackageId).HasName("pk_package_id");

            entity.ToTable("Package_details");

            entity.Property(e => e.PackageId).HasColumnName("package_id");
            entity.Property(e => e.ImageUrl)
                .HasMaxLength(100)
                .HasColumnName("Image_url");
            entity.Property(e => e.PackageDescription1)
                .HasColumnType("text")
                .HasColumnName("package_description1");
            entity.Property(e => e.PackageDescription2)
                .HasColumnType("text")
                .HasColumnName("package_description2");
            entity.Property(e => e.PackageDescription3)
                .HasColumnType("text")
                .HasColumnName("package_description3");
            entity.Property(e => e.PackageDuration)
                .HasMaxLength(25)
                .HasColumnName("package_duration");
            entity.Property(e => e.PackageName)
                .HasMaxLength(60)
                .HasColumnName("package_name");
            entity.Property(e => e.PackagePrice).HasColumnName("package_price");
            entity.Property(e => e.RegionId).HasColumnName("region_id");
            entity.Property(e => e.SpotName)
                .HasMaxLength(60)
                .HasColumnName("spot_name");

            entity.HasOne(d => d.Region).WithMany(p => p.PackageDetails)
                .HasForeignKey(d => d.RegionId)
                .HasConstraintName("fk_region_id");
        });

        modelBuilder.Entity<RegionDetail>(entity =>
        {
            entity.HasKey(e => e.RegionId).HasName("PK__Region_d__01146BAE0305AAC5");

            entity.ToTable("Region_details");

            entity.Property(e => e.RegionId).HasColumnName("region_id");
            entity.Property(e => e.RegionName)
                .HasMaxLength(50)
                .HasColumnName("region_name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
