using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DAL.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bodies",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bodies", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CarSalons",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    City = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 60, nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 15, nullable: false),
                    Site = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarSalons", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ColorTypes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColorTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CompleteSets",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: false),
                    Photo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompleteSets", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DriveWheelses",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriveWheelses", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Engines",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FuelType = table.Column<string>(nullable: false),
                    Value = table.Column<float>(nullable: false),
                    ValueByHundred = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Engines", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "GearBoxes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GearBoxes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ColorCode = table.Column<string>(nullable: false),
                    ColorTypeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Colors_ColorTypes_ColorTypeID",
                        column: x => x.ColorTypeID,
                        principalTable: "ColorTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transmitions",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DriveWheelsID = table.Column<int>(nullable: false),
                    GearBoxID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transmitions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Transmitions_DriveWheelses_DriveWheelsID",
                        column: x => x.DriveWheelsID,
                        principalTable: "DriveWheelses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transmitions_GearBoxes_GearBoxID",
                        column: x => x.GearBoxID,
                        principalTable: "GearBoxes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BodyID = table.Column<int>(nullable: false),
                    CarClass = table.Column<string>(nullable: true),
                    CarSalonID = table.Column<int>(nullable: false),
                    ColorID = table.Column<int>(nullable: false),
                    CompleteSetID = table.Column<int>(nullable: false),
                    EngineID = table.Column<int>(nullable: false),
                    ManufacturerName = table.Column<string>(nullable: false),
                    ModelName = table.Column<string>(nullable: false),
                    Price = table.Column<float>(nullable: false),
                    ProductionTime = table.Column<DateTime>(nullable: false),
                    TransmitionID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Cars_Bodies_BodyID",
                        column: x => x.BodyID,
                        principalTable: "Bodies",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_CarSalons_CarSalonID",
                        column: x => x.CarSalonID,
                        principalTable: "CarSalons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_Colors_ColorID",
                        column: x => x.ColorID,
                        principalTable: "Colors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_CompleteSets_CompleteSetID",
                        column: x => x.CompleteSetID,
                        principalTable: "CompleteSets",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_Engines_EngineID",
                        column: x => x.EngineID,
                        principalTable: "Engines",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_Transmitions_TransmitionID",
                        column: x => x.TransmitionID,
                        principalTable: "Transmitions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Photo",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CarID = table.Column<int>(nullable: false),
                    PhotoURL = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photo", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Photo_Cars_CarID",
                        column: x => x.CarID,
                        principalTable: "Cars",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_BodyID",
                table: "Cars",
                column: "BodyID");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CarSalonID",
                table: "Cars",
                column: "CarSalonID");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_ColorID",
                table: "Cars",
                column: "ColorID");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CompleteSetID",
                table: "Cars",
                column: "CompleteSetID");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_EngineID",
                table: "Cars",
                column: "EngineID");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_TransmitionID",
                table: "Cars",
                column: "TransmitionID");

            migrationBuilder.CreateIndex(
                name: "IX_Colors_ColorTypeID",
                table: "Colors",
                column: "ColorTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Photo_CarID",
                table: "Photo",
                column: "CarID");

            migrationBuilder.CreateIndex(
                name: "IX_Transmitions_DriveWheelsID",
                table: "Transmitions",
                column: "DriveWheelsID");

            migrationBuilder.CreateIndex(
                name: "IX_Transmitions_GearBoxID",
                table: "Transmitions",
                column: "GearBoxID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Photo");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Bodies");

            migrationBuilder.DropTable(
                name: "CarSalons");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "CompleteSets");

            migrationBuilder.DropTable(
                name: "Engines");

            migrationBuilder.DropTable(
                name: "Transmitions");

            migrationBuilder.DropTable(
                name: "ColorTypes");

            migrationBuilder.DropTable(
                name: "DriveWheelses");

            migrationBuilder.DropTable(
                name: "GearBoxes");
        }
    }
}
