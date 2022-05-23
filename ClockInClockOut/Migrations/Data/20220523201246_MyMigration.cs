using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClockInClockOut.Migrations.Data
{
    public partial class MyMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    IdNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsClockedIN = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.IdNumber);
                });

            migrationBuilder.CreateTable(
                name: "Records",
                columns: table => new
                {
                    ItemNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdNumber = table.Column<int>(type: "int", nullable: false),
                    EmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClockInTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClockOutTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalHoursWorked = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Records", x => x.ItemNumber);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "IdNumber", "FirstName", "IsClockedIN", "LastName" },
                values: new object[,]
                {
                    { 1234, "Max", false, "Samuel" },
                    { 1995, "Hensley", false, "Wint" },
                    { 2020, "Jason", false, "Choi" }
                });

            migrationBuilder.InsertData(
                table: "Records",
                columns: new[] { "ItemNumber", "ClockInTime", "ClockOutTime", "EmployeeName", "IdNumber", "TotalHoursWorked" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hensley Wint", 1995, 0.0 },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jason Choi", 2020, 0.0 },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Max Samuel", 1234, 0.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Records");
        }
    }
}
