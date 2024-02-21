using System;
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

    public virtual DbSet<Appliance> Appliance { get; set; }

    public virtual DbSet<Applicant> Applicant { get; set; }

    public virtual DbSet<Application> Application { get; set; }

    public virtual DbSet<Asset> Asset { get; set; }

    public virtual DbSet<Damage> Damage { get; set; }

    public virtual DbSet<Invoice> Invoice { get; set; }

    public virtual DbSet<JobReport> JobReport { get; set; }

    public virtual DbSet<LineItem> LineItem { get; set; }

    public virtual DbSet<MaintenanceRequest> MaintenanceRequest { get; set; }

    public virtual DbSet<OccupancyHistory> OccupancyHistory { get; set; }

    public virtual DbSet<Reference> Reference { get; set; }

    public virtual DbSet<RentHistory> RentHistory { get; set; }

    public virtual DbSet<Renter> Renter { get; set; }

    public virtual DbSet<Service> Service { get; set; }
    
    public virtual DbSet<ApplianceDim> ApplianceDim { get; set; }

    public virtual DbSet<AssetDim> AssetDim { get; set; }
    
    public virtual DbSet<RenterDim> RenterDim { get; set; }
    
    public virtual DbSet<DateDim> DateDim { get; set; }
    
    public virtual DbSet<MaintenanceRequestDim> MaintenanceRequestDim { get; set; }
    
    public virtual DbSet<InvoiceFact> InvoiceFact { get; set; }
    
    public virtual DbSet<RentHistoryDim> RentHistoryDim { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Need to inform EF that the table associated has a trigger in place
        // https://learn.microsoft.com/en-us/ef/core/providers/sql-server/misc
        modelBuilder.Entity<Asset>()
            .ToTable(tb => tb.HasTrigger("AfterApplianceINSERT"));
        modelBuilder.Entity<Asset>()
            .ToTable(tb => tb.HasTrigger("AfterAssetINSERT"));
        modelBuilder.Entity<Asset>()
            .ToTable(tb => tb.HasTrigger("AfterRenterINSERT"));
        modelBuilder.Entity<Asset>()
            .ToTable(tb => tb.HasTrigger("AfterMaintenanceRequestINSERT"));
        modelBuilder.Entity<Asset>()
            .ToTable(tb => tb.HasTrigger("AfterInvoiceINSERT"));
    }
//
//     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
// #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//         => optionsBuilder.UseSqlServer("Server=localhost,8844;Database=comp7071_project;Trusted_Connection=True;TrustServerCertificate=True");
//
//     protected override void OnModelCreating(ModelBuilder modelBuilder)
//     {
//         modelBuilder.Entity<Appliance>(entity =>
//         {
//             entity.HasKey(e => e.Id).HasName("PK_APPLIANCE");
//
//             entity.ToTable("Appliance");
//
//             entity.Property(e => e.AssetId).HasColumnName("Asset_id");
//             entity.Property(e => e.Make)
//                 .HasMaxLength(50)
//                 .IsUnicode(false);
//             entity.Property(e => e.Model)
//                 .HasMaxLength(50)
//                 .IsUnicode(false);
//
//             entity.HasOne(d => d.Asset).WithMany(p => p.Appliances)
//                 .HasForeignKey(d => d.AssetId)
//                 .OnDelete(DeleteBehavior.ClientSetNull)
//                 .HasConstraintName("FK_ASSET_APPLIANCE");
//         });
//
//         modelBuilder.Entity<Applicant>(entity =>
//         {
//             entity.HasKey(e => e.Id).HasName("PK_APPLICANT");
//
//             entity.ToTable("Applicant");
//
//             entity.Property(e => e.Employer)
//                 .HasMaxLength(50)
//                 .IsUnicode(false);
//             entity.Property(e => e.Name)
//                 .HasMaxLength(50)
//                 .IsUnicode(false);
//         });
//
//         modelBuilder.Entity<Application>(entity =>
//         {
//             entity.HasKey(e => new { e.ApplicantId, e.AssetId }).HasName("PK_APPLICATION");
//
//             entity.ToTable("Application");
//
//             entity.HasIndex(e => e.AssetId, "UQ__Applicat__991A54CF0F6814E5").IsUnique();
//
//             entity.HasIndex(e => e.ApplicantId, "UQ__Applicat__9F9A133EB34FD41E").IsUnique();
//
//             entity.Property(e => e.ApplicantId).HasColumnName("Applicant_id");
//             entity.Property(e => e.AssetId).HasColumnName("Asset_id");
//
//             entity.HasOne(d => d.Applicant).WithOne(p => p.Application)
//                 .HasForeignKey<Application>(d => d.ApplicantId)
//                 .OnDelete(DeleteBehavior.ClientSetNull)
//                 .HasConstraintName("FK_APPLICANT_APPLICATION");
//
//             entity.HasOne(d => d.Asset).WithOne(p => p.Application)
//                 .HasForeignKey<Application>(d => d.AssetId)
//                 .OnDelete(DeleteBehavior.ClientSetNull)
//                 .HasConstraintName("FK_ASSET_APPLICATION");
//         });
//
//         modelBuilder.Entity<Asset>(entity =>
//         {
//             entity.HasKey(e => e.Id).HasName("PK_ASSET");
//
//             entity.ToTable("Asset");
//
//             entity.Property(e => e.Location)
//                 .HasMaxLength(70)
//                 .IsUnicode(false);
//             entity.Property(e => e.Status)
//                 .HasMaxLength(40)
//                 .IsUnicode(false);
//             entity.Property(e => e.Type)
//                 .HasMaxLength(20)
//                 .IsUnicode(false);
//         });
//
//         modelBuilder.Entity<Damage>(entity =>
//         {
//             entity.HasKey(e => e.Id).HasName("PK_DAMAGE");
//
//             entity.ToTable("Damage");
//
//             entity.Property(e => e.AssetId).HasColumnName("Asset_id");
//             entity.Property(e => e.DateReported).HasColumnName("Date_reported");
//             entity.Property(e => e.Description)
//                 .HasMaxLength(100)
//                 .IsUnicode(false);
//
//             entity.HasOne(d => d.Asset).WithMany(p => p.Damages)
//                 .HasForeignKey(d => d.AssetId)
//                 .OnDelete(DeleteBehavior.ClientSetNull)
//                 .HasConstraintName("FK_ASSET_DAMAGE");
//         });
//
//         modelBuilder.Entity<Invoice>(entity =>
//         {
//             entity.HasKey(e => e.Id).HasName("PK_INVOICE");
//
//             entity.ToTable("Invoice");
//
//             entity.Property(e => e.DueDate).HasColumnName("Due_date");
//             entity.Property(e => e.RentAmount).HasColumnName("Rent_amount");
//         });
//
//         modelBuilder.Entity<JobReport>(entity =>
//         {
//             entity.HasKey(e => e.Id).HasName("PK_JOB_REPORT");
//
//             entity.ToTable("Job_report");
//
//             entity.Property(e => e.DateCompleted).HasColumnName("Date_completed");
//             entity.Property(e => e.Description)
//                 .HasMaxLength(100)
//                 .IsUnicode(false);
//             entity.Property(e => e.MaintenanceRequestId).HasColumnName("Maintenance_request_id");
//
//             entity.HasOne(d => d.MaintenanceRequest).WithMany(p => p.JobReports)
//                 .HasForeignKey(d => d.MaintenanceRequestId)
//                 .OnDelete(DeleteBehavior.ClientSetNull)
//                 .HasConstraintName("FK_MAINTENANCE_REQUEST_JOB_REPORT");
//         });
//
//         modelBuilder.Entity<LineItem>(entity =>
//         {
//             entity.HasKey(e => new { e.ServiceId, e.InvoiceId }).HasName("PK_LINE_ITEM");
//
//             entity.ToTable("Line_item");
//
//             entity.Property(e => e.ServiceId).HasColumnName("Service_id");
//             entity.Property(e => e.InvoiceId).HasColumnName("Invoice_id");
//
//             entity.HasOne(d => d.Invoice).WithMany(p => p.LineItems)
//                 .HasForeignKey(d => d.InvoiceId)
//                 .OnDelete(DeleteBehavior.ClientSetNull)
//                 .HasConstraintName("FK_INVOICE_LINE_ITEM");
//
//             entity.HasOne(d => d.Service).WithMany(p => p.LineItems)
//                 .HasForeignKey(d => d.ServiceId)
//                 .OnDelete(DeleteBehavior.ClientSetNull)
//                 .HasConstraintName("FK_SERVICE_LINE_ITEM");
//         });
//
//         modelBuilder.Entity<MaintenanceRequest>(entity =>
//         {
//             entity.HasKey(e => e.Id).HasName("PK_MAINTENANCE_REQUEST");
//
//             entity.ToTable("Maintenance_request");
//
//             entity.Property(e => e.ApplianceId).HasColumnName("Appliance_id");
//             entity.Property(e => e.Description)
//                 .HasMaxLength(100)
//                 .IsUnicode(false);
//             entity.Property(e => e.RenterId).HasColumnName("Renter_id");
//
//             entity.HasOne(d => d.Appliance).WithMany(p => p.MaintenanceRequests)
//                 .HasForeignKey(d => d.ApplianceId)
//                 .HasConstraintName("FK_APPLIANCE_MAINTENANCE_REQUEST");
//
//             entity.HasOne(d => d.Renter).WithMany(p => p.MaintenanceRequests)
//                 .HasForeignKey(d => d.RenterId)
//                 .OnDelete(DeleteBehavior.ClientSetNull)
//                 .HasConstraintName("FK_RENTER_MAINTENANCE_REQUEST");
//         });
//
//         modelBuilder.Entity<OccupancyHistory>(entity =>
//         {
//             entity.HasKey(e => e.Id).HasName("PK_OCCUPANCY_HISTORY");
//
//             entity.ToTable("Occupancy_history");
//
//             entity.Property(e => e.AssetId).HasColumnName("Asset_id");
//             entity.Property(e => e.EndDate).HasColumnName("End_date");
//             entity.Property(e => e.LicensePlate)
//                 .HasMaxLength(20)
//                 .IsUnicode(false)
//                 .HasColumnName("License_plate");
//             entity.Property(e => e.StartDate).HasColumnName("Start_date");
//
//             entity.HasOne(d => d.Asset).WithMany(p => p.OccupancyHistories)
//                 .HasForeignKey(d => d.AssetId)
//                 .OnDelete(DeleteBehavior.ClientSetNull)
//                 .HasConstraintName("FK_ASSET_OCCUPANCY_HISTORY");
//         });
//
//         modelBuilder.Entity<Reference>(entity =>
//         {
//             entity.HasKey(e => e.Id).HasName("PK_REFERENCE");
//
//             entity.ToTable("Reference");
//
//             entity.Property(e => e.Name)
//                 .HasMaxLength(50)
//                 .IsUnicode(false);
//             entity.Property(e => e.Relationship)
//                 .HasMaxLength(40)
//                 .IsUnicode(false);
//         });
//
//         modelBuilder.Entity<RentHistory>(entity =>
//         {
//             entity.HasKey(e => e.Id).HasName("PK_RENT_HISTORY");
//
//             entity.ToTable("Rent_history");
//
//             entity.Property(e => e.AssetId).HasColumnName("Asset_id");
//
//             entity.HasOne(d => d.Asset).WithMany(p => p.RentHistories)
//                 .HasForeignKey(d => d.AssetId)
//                 .OnDelete(DeleteBehavior.ClientSetNull)
//                 .HasConstraintName("PK_ASSET_RENT_HISTORY");
//         });
//
//         modelBuilder.Entity<Renter>(entity =>
//         {
//             entity.HasKey(e => e.Id).HasName("PK_RENTER");
//
//             entity.ToTable("Renter");
//
//             entity.Property(e => e.EmergencyContactEmail)
//                 .HasMaxLength(75)
//                 .IsUnicode(false)
//                 .HasColumnName("Emergency_contact_email");
//             entity.Property(e => e.FamilyDoctorEmail)
//                 .HasMaxLength(75)
//                 .IsUnicode(false)
//                 .HasColumnName("Family_doctor_email");
//             entity.Property(e => e.Name)
//                 .HasMaxLength(50)
//                 .IsUnicode(false);
//         });
//
//         modelBuilder.Entity<Service>(entity =>
//         {
//             entity.HasKey(e => e.Id).HasName("PK_SERVICE");
//
//             entity.ToTable("Service");
//
//             entity.Property(e => e.Type)
//                 .HasMaxLength(50)
//                 .IsUnicode(false);
//         });
//
//         modelBuilder.Entity<WorkItem>(entity =>
//         {
//             entity.HasKey(e => e.Id).HasName("PK_WORK_ITEM");
//
//             entity.ToTable("Work_item");
//
//             entity.Property(e => e.MaintenanceRequestId).HasColumnName("Maintenance_request_id");
//             entity.Property(e => e.Status)
//                 .HasMaxLength(50)
//                 .IsUnicode(false);
//
//             entity.HasOne(d => d.MaintenanceRequest).WithMany(p => p.WorkItems)
//                 .HasForeignKey(d => d.MaintenanceRequestId)
//                 .OnDelete(DeleteBehavior.ClientSetNull)
//                 .HasConstraintName("FK_MAINTENANCE_REQUEST_WORK_ITEM");
//         });
//
//         OnModelCreatingPartial(modelBuilder);
//     }
//
//     partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
