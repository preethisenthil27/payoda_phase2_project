using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace HolidayPackages.Models;

public partial class HolidayPackagesContext : DbContext
{
    public HolidayPackagesContext()
    {
    }

    public HolidayPackagesContext(DbContextOptions<HolidayPackagesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BookingTable> BookingTables { get; set; }

    public virtual DbSet<Credential> Credentials { get; set; }

    public virtual DbSet<PackageTable> PackageTables { get; set; }

    public virtual DbSet<RegionTable> RegionTables { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        => optionsBuilder.UseSqlServer("data source = .\\SQLEXPRESS; initial catalog =HolidayPackages; integrated security=SSPI; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BookingTable>(entity =>
        {
            entity.HasKey(e => e.BId).HasName("pk_b_id");

            entity.ToTable("Booking_table");

            entity.Property(e => e.BId)
                .ValueGeneratedNever()
                .HasColumnName("b_id");
            entity.Property(e => e.BDate)
                .HasColumnType("date")
                .HasColumnName("b_date");
            entity.Property(e => e.BTime).HasColumnName("b_time");
            entity.Property(e => e.Email)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.NoPersons).HasColumnName("no_persons");
            entity.Property(e => e.PId).HasColumnName("p_id");

            entity.HasOne(d => d.PIdNavigation).WithMany(p => p.BookingTables)
                .HasForeignKey(d => d.PId)
                .HasConstraintName("fk_p_id");
        });

        modelBuilder.Entity<Credential>(entity =>
        {
            entity.HasKey(e => e.CId).HasName("pk_c_id");

            entity.Property(e => e.CId)
                .ValueGeneratedNever()
                .HasColumnName("c_id");
            entity.Property(e => e.CName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("c_name");
            entity.Property(e => e.Email)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.PassWord)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("pass_word");
            entity.Property(e => e.PhNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ph_number");
        });

        modelBuilder.Entity<PackageTable>(entity =>
        {
            entity.HasKey(e => e.PId).HasName("pk_p_id");

            entity.ToTable("package_table");

            entity.Property(e => e.PId)
                .ValueGeneratedNever()
                .HasColumnName("p_id");
            entity.Property(e => e.PDesc1)
                .HasColumnType("text")
                .HasColumnName("p_desc_1");
            entity.Property(e => e.PDesc2)
                .HasColumnType("text")
                .HasColumnName("p_desc_2");
            entity.Property(e => e.PDesc3)
                .HasColumnType("text")
                .HasColumnName("p_desc_3");
            entity.Property(e => e.PDuration)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("p_duration");
            entity.Property(e => e.PName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("p_name");
            entity.Property(e => e.PPrice).HasColumnName("p_price");
            entity.Property(e => e.RId).HasColumnName("r_id");
            entity.Property(e => e.SpotDesc)
                .HasColumnType("text")
                .HasColumnName("spot_desc");

            entity.HasOne(d => d.RIdNavigation).WithMany(p => p.PackageTables)
                .HasForeignKey(d => d.RId)
                .HasConstraintName("fk_r_id");
        });

        modelBuilder.Entity<RegionTable>(entity =>
        {
            entity.HasKey(e => e.RId).HasName("pk");

            entity.ToTable("region_table");

            entity.Property(e => e.RId)
                .ValueGeneratedNever()
                .HasColumnName("r_id");
            entity.Property(e => e.RName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("r_name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
