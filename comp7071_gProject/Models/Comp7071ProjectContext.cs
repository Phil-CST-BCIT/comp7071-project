﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace comp7071_project.Models;

public partial class Comp7071ProjectContext : DbContext
{
    public Comp7071ProjectContext()
    {
    }

    public Comp7071ProjectContext(DbContextOptions<Comp7071ProjectContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Appliance> Appliances { get; set; }

    public virtual DbSet<Applicant> Applicants { get; set; }

    public virtual DbSet<Application> Applications { get; set; }

    public virtual DbSet<Asset> Assets { get; set; }

    public virtual DbSet<Damage> Damages { get; set; }

    public virtual DbSet<Invoice> Invoices { get; set; }

    public virtual DbSet<JobReport> JobReports { get; set; }

    public virtual DbSet<LineItem> LineItems { get; set; }

    public virtual DbSet<MaintenanceRequest> MaintenanceRequests { get; set; }

    public virtual DbSet<OccupancyHistory> OccupancyHistories { get; set; }

    public virtual DbSet<Reference> References { get; set; }

    public virtual DbSet<RentHistory> RentHistories { get; set; }

    public virtual DbSet<Renter> Renters { get; set; }

    public virtual DbSet<Service> Services { get; set; }

    public virtual DbSet<WorkItem> WorkItems { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.;Database=comp7071_project;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Appliance>(entity =>
        {
            entity.ToTable("Appliance");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Make)
                .HasMaxLength(25)
                .IsFixedLength();
            entity.Property(e => e.Model)
                .HasMaxLength(30)
                .IsFixedLength();
        });

        modelBuilder.Entity<Applicant>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_APPLICANT");

            entity.ToTable("Applicant");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Employer)
                .HasMaxLength(40)
                .IsFixedLength();
            entity.Property(e => e.Name)
                .HasMaxLength(40)
                .IsFixedLength();
        });

        modelBuilder.Entity<Application>(entity =>
        {
            entity.HasKey(e => new { e.ApplicantId, e.AssetId }).HasName("PK_APPLICATION");

            entity.ToTable("Application");

            entity.HasIndex(e => e.AssetId, "UQ__Applicat__991A54CF0F6814E5").IsUnique();

            entity.HasIndex(e => e.ApplicantId, "UQ__Applicat__9F9A133EB34FD41E").IsUnique();

            entity.Property(e => e.ApplicantId).HasColumnName("Applicant_id");
            entity.Property(e => e.AssetId).HasColumnName("Asset_id");

            entity.HasOne(d => d.Applicant).WithOne(p => p.Application)
                .HasForeignKey<Application>(d => d.ApplicantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APPLICANT_APPLICATION");

            entity.HasOne(d => d.Asset).WithOne(p => p.Application)
                .HasForeignKey<Application>(d => d.AssetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ASSET_APPLICATION");
        });

        modelBuilder.Entity<Asset>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ASSET");

            entity.ToTable("Asset");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Location)
                .HasMaxLength(40)
                .IsFixedLength();
            entity.Property(e => e.Status)
                .HasMaxLength(40)
                .IsFixedLength();
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .IsFixedLength();
        });

        modelBuilder.Entity<Damage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DAMAGE");

            entity.ToTable("Damage");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.AssetId).HasColumnName("Asset_id");
            entity.Property(e => e.DateReported)
                .HasColumnType("datetime")
                .HasColumnName("Date_reported");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Asset).WithMany(p => p.Damages)
                .HasForeignKey(d => d.AssetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ASSET_DAMAGE");
        });

        modelBuilder.Entity<Invoice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_INVOICE");

            entity.ToTable("Invoice");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.DueDate)
                .HasColumnType("datetime")
                .HasColumnName("Due_Date");
            entity.Property(e => e.RentAmount).HasColumnName("Rent_amount");
        });

        modelBuilder.Entity<JobReport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_JOB_REPORT");

            entity.ToTable("Job_report");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.DateCompleted)
                .HasColumnType("datetime")
                .HasColumnName("Date_completed");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MaintenanceRequestId).HasColumnName("Maintenance_request_id");

            entity.HasOne(d => d.MaintenanceRequest).WithMany(p => p.JobReports)
                .HasForeignKey(d => d.MaintenanceRequestId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MAINTENANCE_REQUEST_JOB_REPORT");
        });

        modelBuilder.Entity<LineItem>(entity =>
        {
            entity.HasKey(e => new { e.ServiceId, e.InvoiceId }).HasName("PK_LINE_ITEM");

            entity.ToTable("Line_item");

            entity.Property(e => e.ServiceId).HasColumnName("Service_id");
            entity.Property(e => e.InvoiceId).HasColumnName("Invoice_id");

            entity.HasOne(d => d.Invoice).WithMany(p => p.LineItems)
                .HasForeignKey(d => d.InvoiceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INVOICE_LINE_ITEM");

            entity.HasOne(d => d.Service).WithMany(p => p.LineItems)
                .HasForeignKey(d => d.ServiceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SERVICE_LINE_ITEM");
        });

        modelBuilder.Entity<MaintenanceRequest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_MAINTENANCE_REQUEST");

            entity.ToTable("Maintenance_request");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ApplianceId).HasColumnName("Appliance_id");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RenterId).HasColumnName("Renter_id");

            entity.HasOne(d => d.Appliance).WithMany(p => p.MaintenanceRequests)
                .HasForeignKey(d => d.ApplianceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APPLIANCE_MAINTENACE_REQUEST");

            entity.HasOne(d => d.Renter).WithMany(p => p.MaintenanceRequests)
                .HasForeignKey(d => d.RenterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RENTER_MAINTENACE_REQUEST");
        });

        modelBuilder.Entity<OccupancyHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_OCCUPANCY_HISTORY");

            entity.ToTable("Occupancy_history");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.AssetId).HasColumnName("Asset_id");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("End_date");
            entity.Property(e => e.LicensePlate)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("License_plate");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("Start_date");

            entity.HasOne(d => d.Asset).WithMany(p => p.OccupancyHistories)
                .HasForeignKey(d => d.AssetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ASSET_OCCUPANCY_HISTORY");
        });

        modelBuilder.Entity<Reference>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_REFERENCE");

            entity.ToTable("Reference");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Relationship)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RentHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_RENT_HISTORY");

            entity.ToTable("Rent_history");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.AssetId).HasColumnName("Asset_id");
            entity.Property(e => e.Date).HasColumnType("datetime");

            entity.HasOne(d => d.Asset).WithMany(p => p.RentHistories)
                .HasForeignKey(d => d.AssetId)
                .HasConstraintName("FK_ASSET_RENT_HISTORY");
        });

        modelBuilder.Entity<Renter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_RENTER");

            entity.ToTable("Renter");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.EmergencyContactEmail)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("Emergency_contact_email");
            entity.Property(e => e.FamilyDoctorEmail)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("Family_doctor_email");
            entity.Property(e => e.Name)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Service>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_SERVICE");

            entity.ToTable("Service");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WorkItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_WORK_ITEM");

            entity.ToTable("Work_item");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.MaintenanceRequestId).HasColumnName("Maintenance_request_id");
            entity.Property(e => e.Status)
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.HasOne(d => d.MaintenanceRequest).WithMany(p => p.WorkItems)
                .HasForeignKey(d => d.MaintenanceRequestId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MAINTENANCE_REQUEST_WORK_ITEM");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
