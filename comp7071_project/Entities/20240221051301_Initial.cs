using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace comp7071_project.Entities
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplianceDim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Make = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplianceDim", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Applicant",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Employer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Income = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applicant", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AssetDim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetDim", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DateDim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DueDate = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DateDim", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaintenanceRequestDim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateRequested = table.Column<DateOnly>(type: "date", nullable: true),
                    DateCompleted = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaintenanceRequestDim", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Renter",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Income = table.Column<float>(type: "real", nullable: false),
                    EmergencyContactEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FamilyDoctorEmail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Renter", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RenterDim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Income = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RenterDim", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RentHistoryDim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateOnly>(type: "date", nullable: true),
                    Amount = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentHistoryDim", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rate = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reference",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Relationship = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicantId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reference", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reference_Applicant_ApplicantId",
                        column: x => x.ApplicantId,
                        principalTable: "Applicant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Asset",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RenterId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asset", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Asset_Renter_RenterId",
                        column: x => x.RenterId,
                        principalTable: "Renter",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Invoice",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentAmount = table.Column<double>(type: "float", nullable: false),
                    Tax = table.Column<double>(type: "float", nullable: false),
                    DueDate = table.Column<DateOnly>(type: "date", nullable: false),
                    RenterID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Invoice_Renter_RenterID",
                        column: x => x.RenterID,
                        principalTable: "Renter",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceFact",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<float>(type: "real", nullable: false),
                    ApplianceDimId = table.Column<int>(type: "int", nullable: true),
                    AssetDimId = table.Column<int>(type: "int", nullable: true),
                    CustomerDimId = table.Column<int>(type: "int", nullable: true),
                    DateDimId = table.Column<int>(type: "int", nullable: true),
                    MaintenanceRequestDimId = table.Column<int>(type: "int", nullable: true),
                    RentHistoryDimId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceFact", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InvoiceFact_ApplianceDim_ApplianceDimId",
                        column: x => x.ApplianceDimId,
                        principalTable: "ApplianceDim",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InvoiceFact_AssetDim_AssetDimId",
                        column: x => x.AssetDimId,
                        principalTable: "AssetDim",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InvoiceFact_DateDim_DateDimId",
                        column: x => x.DateDimId,
                        principalTable: "DateDim",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InvoiceFact_MaintenanceRequestDim_MaintenanceRequestDimId",
                        column: x => x.MaintenanceRequestDimId,
                        principalTable: "MaintenanceRequestDim",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InvoiceFact_RentHistoryDim_RentHistoryDimId",
                        column: x => x.RentHistoryDimId,
                        principalTable: "RentHistoryDim",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InvoiceFact_RenterDim_CustomerDimId",
                        column: x => x.CustomerDimId,
                        principalTable: "RenterDim",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Appliance",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Make = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssetId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appliance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appliance_Asset_AssetId",
                        column: x => x.AssetId,
                        principalTable: "Asset",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Application",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicantId = table.Column<int>(type: "int", nullable: false),
                    AssetId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Application", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Application_Applicant_ApplicantId",
                        column: x => x.ApplicantId,
                        principalTable: "Applicant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Application_Asset_AssetId",
                        column: x => x.AssetId,
                        principalTable: "Asset",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Damage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateReported = table.Column<DateOnly>(type: "date", nullable: false),
                    AssetId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Damage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Damage_Asset_AssetId",
                        column: x => x.AssetId,
                        principalTable: "Asset",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OccupancyHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    EndDate = table.Column<DateOnly>(type: "date", nullable: true),
                    LicensePlate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssetId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OccupancyHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OccupancyHistory_Asset_AssetId",
                        column: x => x.AssetId,
                        principalTable: "Asset",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RentHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EffectiveDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    AssetId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RentHistory_Asset_AssetId",
                        column: x => x.AssetId,
                        principalTable: "Asset",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LineItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Hours = table.Column<int>(type: "int", nullable: false),
                    InvoiceId = table.Column<int>(type: "int", nullable: false),
                    ServiceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LineItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LineItem_Invoice_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "Invoice",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LineItem_Service_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Service",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaintenanceRequest",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ApplianceId = table.Column<int>(type: "int", nullable: false),
                    RenterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaintenanceRequest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MaintenanceRequest_Appliance_ApplianceId",
                        column: x => x.ApplianceId,
                        principalTable: "Appliance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaintenanceRequest_Renter_RenterId",
                        column: x => x.RenterId,
                        principalTable: "Renter",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobReport",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCompleted = table.Column<DateOnly>(type: "date", nullable: true),
                    MaintenanceRequestId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobReport", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobReport_MaintenanceRequest_MaintenanceRequestId",
                        column: x => x.MaintenanceRequestId,
                        principalTable: "MaintenanceRequest",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appliance_AssetId",
                table: "Appliance",
                column: "AssetId");

            migrationBuilder.CreateIndex(
                name: "IX_Application_ApplicantId",
                table: "Application",
                column: "ApplicantId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Application_AssetId",
                table: "Application",
                column: "AssetId");

            migrationBuilder.CreateIndex(
                name: "IX_Asset_RenterId",
                table: "Asset",
                column: "RenterId");

            migrationBuilder.CreateIndex(
                name: "IX_Damage_AssetId",
                table: "Damage",
                column: "AssetId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_RenterID",
                table: "Invoice",
                column: "RenterID");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceFact_ApplianceDimId",
                table: "InvoiceFact",
                column: "ApplianceDimId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceFact_AssetDimId",
                table: "InvoiceFact",
                column: "AssetDimId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceFact_CustomerDimId",
                table: "InvoiceFact",
                column: "CustomerDimId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceFact_DateDimId",
                table: "InvoiceFact",
                column: "DateDimId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceFact_MaintenanceRequestDimId",
                table: "InvoiceFact",
                column: "MaintenanceRequestDimId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceFact_RentHistoryDimId",
                table: "InvoiceFact",
                column: "RentHistoryDimId");

            migrationBuilder.CreateIndex(
                name: "IX_JobReport_MaintenanceRequestId",
                table: "JobReport",
                column: "MaintenanceRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_LineItem_InvoiceId",
                table: "LineItem",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_LineItem_ServiceId",
                table: "LineItem",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceRequest_ApplianceId",
                table: "MaintenanceRequest",
                column: "ApplianceId");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceRequest_RenterId",
                table: "MaintenanceRequest",
                column: "RenterId");

            migrationBuilder.CreateIndex(
                name: "IX_OccupancyHistory_AssetId",
                table: "OccupancyHistory",
                column: "AssetId");

            migrationBuilder.CreateIndex(
                name: "IX_Reference_ApplicantId",
                table: "Reference",
                column: "ApplicantId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RentHistory_AssetId",
                table: "RentHistory",
                column: "AssetId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Application");

            migrationBuilder.DropTable(
                name: "Damage");

            migrationBuilder.DropTable(
                name: "InvoiceFact");

            migrationBuilder.DropTable(
                name: "JobReport");

            migrationBuilder.DropTable(
                name: "LineItem");

            migrationBuilder.DropTable(
                name: "OccupancyHistory");

            migrationBuilder.DropTable(
                name: "Reference");

            migrationBuilder.DropTable(
                name: "RentHistory");

            migrationBuilder.DropTable(
                name: "ApplianceDim");

            migrationBuilder.DropTable(
                name: "AssetDim");

            migrationBuilder.DropTable(
                name: "DateDim");

            migrationBuilder.DropTable(
                name: "MaintenanceRequestDim");

            migrationBuilder.DropTable(
                name: "RentHistoryDim");

            migrationBuilder.DropTable(
                name: "RenterDim");

            migrationBuilder.DropTable(
                name: "MaintenanceRequest");

            migrationBuilder.DropTable(
                name: "Invoice");

            migrationBuilder.DropTable(
                name: "Service");

            migrationBuilder.DropTable(
                name: "Applicant");

            migrationBuilder.DropTable(
                name: "Appliance");

            migrationBuilder.DropTable(
                name: "Asset");

            migrationBuilder.DropTable(
                name: "Renter");
        }
    }
}
