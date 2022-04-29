using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClockInClockOut.Migrations
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

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "IdNumber", "FirstName", "IsClockedIN", "LastName" },
                values: new object[] { 1234, "Max", false, "Samuel" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "IdNumber", "FirstName", "IsClockedIN", "LastName" },
                values: new object[] { 1995, "Hensley", false, "Wint" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "IdNumber", "FirstName", "IsClockedIN", "LastName" },
                values: new object[] { 2020, "Jason", false, "Choi" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
