using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalManager.API.Migrations
{
    /// <inheritdoc />
    public partial class AddSubjectIdNullableUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SubjectId",
                table: "User",
                type: "NVARCHAR2(2000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 17, 45, 18, 344, DateTimeKind.Local).AddTicks(5488), new DateTime(2024, 12, 16, 17, 45, 18, 344, DateTimeKind.Local).AddTicks(5489) });

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 17, 45, 18, 344, DateTimeKind.Local).AddTicks(5493), new DateTime(2024, 12, 16, 17, 45, 18, 344, DateTimeKind.Local).AddTicks(5493) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SubjectId",
                table: "User",
                type: "NVARCHAR2(2000)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 17, 42, 41, 952, DateTimeKind.Local).AddTicks(8763), new DateTime(2024, 12, 16, 17, 42, 41, 952, DateTimeKind.Local).AddTicks(8764) });

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 17, 42, 41, 952, DateTimeKind.Local).AddTicks(8768), new DateTime(2024, 12, 16, 17, 42, 41, 952, DateTimeKind.Local).AddTicks(8769) });
        }
    }
}
