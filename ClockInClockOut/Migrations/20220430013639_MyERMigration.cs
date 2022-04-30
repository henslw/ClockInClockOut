using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClockInClockOut.Migrations
{
    public partial class MyERMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "IdNumber",
                keyValue: 1234,
                columns: new[] { "ClockInTime", "ClockOutTime" },
                values: new object[] { new DateTime(2022, 4, 29, 18, 36, 39, 602, DateTimeKind.Local).AddTicks(9724), new DateTime(2022, 4, 29, 18, 36, 39, 602, DateTimeKind.Local).AddTicks(9726) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "IdNumber",
                keyValue: 1995,
                columns: new[] { "ClockInTime", "ClockOutTime" },
                values: new object[] { new DateTime(2022, 4, 29, 18, 36, 39, 602, DateTimeKind.Local).AddTicks(9681), new DateTime(2022, 4, 29, 18, 36, 39, 602, DateTimeKind.Local).AddTicks(9718) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "IdNumber",
                keyValue: 2020,
                columns: new[] { "ClockInTime", "ClockOutTime" },
                values: new object[] { new DateTime(2022, 4, 29, 18, 36, 39, 602, DateTimeKind.Local).AddTicks(9721), new DateTime(2022, 4, 29, 18, 36, 39, 602, DateTimeKind.Local).AddTicks(9722) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "IdNumber",
                keyValue: 1234,
                columns: new[] { "ClockInTime", "ClockOutTime" },
                values: new object[] { new DateTime(2022, 4, 29, 17, 44, 49, 570, DateTimeKind.Local).AddTicks(4311), new DateTime(2022, 4, 29, 17, 44, 49, 570, DateTimeKind.Local).AddTicks(4313) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "IdNumber",
                keyValue: 1995,
                columns: new[] { "ClockInTime", "ClockOutTime" },
                values: new object[] { new DateTime(2022, 4, 29, 17, 44, 49, 570, DateTimeKind.Local).AddTicks(4248), new DateTime(2022, 4, 29, 17, 44, 49, 570, DateTimeKind.Local).AddTicks(4301) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "IdNumber",
                keyValue: 2020,
                columns: new[] { "ClockInTime", "ClockOutTime" },
                values: new object[] { new DateTime(2022, 4, 29, 17, 44, 49, 570, DateTimeKind.Local).AddTicks(4305), new DateTime(2022, 4, 29, 17, 44, 49, 570, DateTimeKind.Local).AddTicks(4307) });
        }
    }
}
