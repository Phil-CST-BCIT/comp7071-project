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
                name: "ApplianceDims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Make = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplianceDims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Asset",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true),
                    Location = table.Column<string>(type: "varchar(70)", unicode: false, maxLength: 70, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ASSET", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AssetDims",
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
                    table.PrimaryKey("PK_AssetDims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerDims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Employer = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerDims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DateDims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: true),
                    EndDate = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DateDims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaintenanceRequestDims",
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
                    table.PrimaryKey("PK_MaintenanceRequestDims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reference",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Relationship = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_REFERENCE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Renter",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Emergency_contact_email = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: true),
                    Family_doctor_email = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RENTER", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RentHistoryDims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateOnly>(type: "date", nullable: true),
                    Amount = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentHistoryDims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Rate = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SERVICE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Appliance",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Asset_id = table.Column<int>(type: "int", nullable: false),
                    Make = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Model = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_APPLIANCE", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ASSET_APPLIANCE",
                        column: x => x.Asset_id,
                        principalTable: "Asset",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Damage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Asset_id = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Date_reported = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DAMAGE", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ASSET_DAMAGE",
                        column: x => x.Asset_id,
                        principalTable: "Asset",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Occupancy_history",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Asset_id = table.Column<int>(type: "int", nullable: false),
                    Start_date = table.Column<DateOnly>(type: "date", nullable: true),
                    End_date = table.Column<DateOnly>(type: "date", nullable: true),
                    License_plate = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OCCUPANCY_HISTORY", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ASSET_OCCUPANCY_HISTORY",
                        column: x => x.Asset_id,
                        principalTable: "Asset",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Rent_history",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Asset_id = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateOnly>(type: "date", nullable: true),
                    Amount = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RENT_HISTORY", x => x.Id);
                    table.ForeignKey(
                        name: "PK_ASSET_RENT_HISTORY",
                        column: x => x.Asset_id,
                        principalTable: "Asset",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Applicant",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Employer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Income = table.Column<double>(type: "float", nullable: true),
                    ReferenceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_APPLICANT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Applicant_Reference_ReferenceId",
                        column: x => x.ReferenceId,
                        principalTable: "Reference",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Invoice",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rent_amount = table.Column<double>(type: "float", nullable: true),
                    Tax = table.Column<double>(type: "float", nullable: true),
                    Due_date = table.Column<DateOnly>(type: "date", nullable: true),
                    RenterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INVOICE", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Invoice_Renter_RenterId",
                        column: x => x.RenterId,
                        principalTable: "Renter",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RentFacts",
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
                    table.PrimaryKey("PK_RentFacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RentFacts_ApplianceDims_ApplianceDimId",
                        column: x => x.ApplianceDimId,
                        principalTable: "ApplianceDims",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RentFacts_AssetDims_AssetDimId",
                        column: x => x.AssetDimId,
                        principalTable: "AssetDims",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RentFacts_CustomerDims_CustomerDimId",
                        column: x => x.CustomerDimId,
                        principalTable: "CustomerDims",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RentFacts_DateDims_DateDimId",
                        column: x => x.DateDimId,
                        principalTable: "DateDims",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RentFacts_MaintenanceRequestDims_MaintenanceRequestDimId",
                        column: x => x.MaintenanceRequestDimId,
                        principalTable: "MaintenanceRequestDims",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RentFacts_RentHistoryDims_RentHistoryDimId",
                        column: x => x.RentHistoryDimId,
                        principalTable: "RentHistoryDims",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Maintenance_request",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Renter_id = table.Column<int>(type: "int", nullable: false),
                    Appliance_id = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateOnly>(type: "date", nullable: true),
                    Description = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAINTENANCE_REQUEST", x => x.Id);
                    table.ForeignKey(
                        name: "FK_APPLIANCE_MAINTENANCE_REQUEST",
                        column: x => x.Appliance_id,
                        principalTable: "Appliance",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RENTER_MAINTENANCE_REQUEST",
                        column: x => x.Renter_id,
                        principalTable: "Renter",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Application",
                columns: table => new
                {
                    Applicant_id = table.Column<int>(type: "int", nullable: false),
                    Asset_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_APPLICATION", x => new { x.Applicant_id, x.Asset_id });
                    table.ForeignKey(
                        name: "FK_APPLICANT_APPLICATION",
                        column: x => x.Applicant_id,
                        principalTable: "Applicant",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ASSET_APPLICATION",
                        column: x => x.Asset_id,
                        principalTable: "Asset",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Line_item",
                columns: table => new
                {
                    Service_id = table.Column<int>(type: "int", nullable: false),
                    Invoice_id = table.Column<int>(type: "int", nullable: false),
                    Hours = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LINE_ITEM", x => new { x.Service_id, x.Invoice_id });
                    table.ForeignKey(
                        name: "FK_INVOICE_LINE_ITEM",
                        column: x => x.Invoice_id,
                        principalTable: "Invoice",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SERVICE_LINE_ITEM",
                        column: x => x.Service_id,
                        principalTable: "Service",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Job_report",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Maintenance_request_id = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Date_completed = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JOB_REPORT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MAINTENANCE_REQUEST_JOB_REPORT",
                        column: x => x.Maintenance_request_id,
                        principalTable: "Maintenance_request",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Work_item",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Maintenance_request_id = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WORK_ITEM", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MAINTENANCE_REQUEST_WORK_ITEM",
                        column: x => x.Maintenance_request_id,
                        principalTable: "Maintenance_request",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appliance_Asset_id",
                table: "Appliance",
                column: "Asset_id");

            migrationBuilder.CreateIndex(
                name: "IX_Applicant_ReferenceId",
                table: "Applicant",
                column: "ReferenceId");

            migrationBuilder.CreateIndex(
                name: "UQ__Applicat__991A54CF0F6814E5",
                table: "Application",
                column: "Asset_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__Applicat__9F9A133EB34FD41E",
                table: "Application",
                column: "Applicant_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Damage_Asset_id",
                table: "Damage",
                column: "Asset_id");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_RenterId",
                table: "Invoice",
                column: "RenterId");

            migrationBuilder.CreateIndex(
                name: "IX_Job_report_Maintenance_request_id",
                table: "Job_report",
                column: "Maintenance_request_id");

            migrationBuilder.CreateIndex(
                name: "IX_Line_item_Invoice_id",
                table: "Line_item",
                column: "Invoice_id");

            migrationBuilder.CreateIndex(
                name: "IX_Maintenance_request_Appliance_id",
                table: "Maintenance_request",
                column: "Appliance_id");

            migrationBuilder.CreateIndex(
                name: "IX_Maintenance_request_Renter_id",
                table: "Maintenance_request",
                column: "Renter_id");

            migrationBuilder.CreateIndex(
                name: "IX_Occupancy_history_Asset_id",
                table: "Occupancy_history",
                column: "Asset_id");

            migrationBuilder.CreateIndex(
                name: "IX_Rent_history_Asset_id",
                table: "Rent_history",
                column: "Asset_id");

            migrationBuilder.CreateIndex(
                name: "IX_RentFacts_ApplianceDimId",
                table: "RentFacts",
                column: "ApplianceDimId");

            migrationBuilder.CreateIndex(
                name: "IX_RentFacts_AssetDimId",
                table: "RentFacts",
                column: "AssetDimId");

            migrationBuilder.CreateIndex(
                name: "IX_RentFacts_CustomerDimId",
                table: "RentFacts",
                column: "CustomerDimId");

            migrationBuilder.CreateIndex(
                name: "IX_RentFacts_DateDimId",
                table: "RentFacts",
                column: "DateDimId");

            migrationBuilder.CreateIndex(
                name: "IX_RentFacts_MaintenanceRequestDimId",
                table: "RentFacts",
                column: "MaintenanceRequestDimId");

            migrationBuilder.CreateIndex(
                name: "IX_RentFacts_RentHistoryDimId",
                table: "RentFacts",
                column: "RentHistoryDimId");

            migrationBuilder.CreateIndex(
                name: "IX_Work_item_Maintenance_request_id",
                table: "Work_item",
                column: "Maintenance_request_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Application");

            migrationBuilder.DropTable(
                name: "Damage");

            migrationBuilder.DropTable(
                name: "Job_report");

            migrationBuilder.DropTable(
                name: "Line_item");

            migrationBuilder.DropTable(
                name: "Occupancy_history");

            migrationBuilder.DropTable(
                name: "Rent_history");

            migrationBuilder.DropTable(
                name: "RentFacts");

            migrationBuilder.DropTable(
                name: "Work_item");

            migrationBuilder.DropTable(
                name: "Applicant");

            migrationBuilder.DropTable(
                name: "Invoice");

            migrationBuilder.DropTable(
                name: "Service");

            migrationBuilder.DropTable(
                name: "ApplianceDims");

            migrationBuilder.DropTable(
                name: "AssetDims");

            migrationBuilder.DropTable(
                name: "CustomerDims");

            migrationBuilder.DropTable(
                name: "DateDims");

            migrationBuilder.DropTable(
                name: "MaintenanceRequestDims");

            migrationBuilder.DropTable(
                name: "RentHistoryDims");

            migrationBuilder.DropTable(
                name: "Maintenance_request");

            migrationBuilder.DropTable(
                name: "Reference");

            migrationBuilder.DropTable(
                name: "Appliance");

            migrationBuilder.DropTable(
                name: "Renter");

            migrationBuilder.DropTable(
                name: "Asset");
        }
    }
}
