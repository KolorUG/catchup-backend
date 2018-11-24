using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CatchUp.Migrations.Roles
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    City = table.Column<string>(nullable: true),
                    PostalCode = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    Number = table.Column<string>(nullable: true),
                    Flat = table.Column<string>(nullable: true),
                    Latitude = table.Column<double>(nullable: false),
                    Longitude = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Offer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HomeVisits = table.Column<bool>(nullable: false),
                    VisitRange = table.Column<float>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddressId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subject",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SubjectTypeId = table.Column<int>(nullable: false),
                    Leveld = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    LessonMinutes = table.Column<int>(nullable: false),
                    OfferId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subject_Offer_OfferId",
                        column: x => x.OfferId,
                        principalTable: "Offer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddressId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    OffersId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teachers_Offer_OffersId",
                        column: x => x.OffersId,
                        principalTable: "Offer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StudentId = table.Column<int>(nullable: false),
                    TeacherId = table.Column<int>(nullable: false),
                    OfferId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rating",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LessonId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false),
                    Rate = table.Column<short>(nullable: false),
                    StudentId = table.Column<int>(nullable: false),
                    TeacherId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rating", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rating_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rating_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Schedule",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TeacherId = table.Column<int>(nullable: false),
                    Day = table.Column<int>(nullable: false),
                    Begining = table.Column<string>(maxLength: 5, nullable: true),
                    Ending = table.Column<string>(maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Schedule_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Login = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    StudentId = table.Column<int>(nullable: true),
                    TeacherId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Order_StudentId",
                table: "Order",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_TeacherId",
                table: "Order",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Rating_StudentId",
                table: "Rating",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Rating_TeacherId",
                table: "Rating",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedule_TeacherId",
                table: "Schedule",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Subject_OfferId",
                table: "Subject",
                column: "OfferId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_OffersId",
                table: "Teachers",
                column: "OffersId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_StudentId",
                table: "Users",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_TeacherId",
                table: "Users",
                column: "TeacherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Rating");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Schedule");

            migrationBuilder.DropTable(
                name: "Subject");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Offer");
        }
    }
}
