using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalManager.API.Migrations
{
    /// <inheritdoc />
    public partial class UsedRangeInsteadOfColumnType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Used",
                table: "Recipe",
                type: "NUMBER(10)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "NUMBER(1)");

            migrationBuilder.UpdateData(
                table: "Doctor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 23, 21, 6, 250, DateTimeKind.Local).AddTicks(2398), new DateTime(2024, 12, 16, 23, 21, 6, 250, DateTimeKind.Local).AddTicks(2399) });

            migrationBuilder.UpdateData(
                table: "Doctor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 23, 21, 6, 250, DateTimeKind.Local).AddTicks(2401), new DateTime(2024, 12, 16, 23, 21, 6, 250, DateTimeKind.Local).AddTicks(2402) });

            migrationBuilder.UpdateData(
                table: "Examination",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ExaminationDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 23, 21, 6, 250, DateTimeKind.Local).AddTicks(2476), new DateTime(2024, 11, 16, 23, 21, 6, 250, DateTimeKind.Local).AddTicks(2468), new DateTime(2024, 12, 16, 23, 21, 6, 250, DateTimeKind.Local).AddTicks(2476) });

            migrationBuilder.UpdateData(
                table: "Examination",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ExaminationDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 23, 21, 6, 250, DateTimeKind.Local).AddTicks(2481), new DateTime(2025, 2, 16, 23, 21, 6, 250, DateTimeKind.Local).AddTicks(2478), new DateTime(2024, 12, 16, 23, 21, 6, 250, DateTimeKind.Local).AddTicks(2481) });

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 23, 21, 6, 250, DateTimeKind.Local).AddTicks(2513), new DateTime(2024, 12, 16, 23, 21, 6, 250, DateTimeKind.Local).AddTicks(2514) });

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 23, 21, 6, 250, DateTimeKind.Local).AddTicks(2517), new DateTime(2024, 12, 16, 23, 21, 6, 250, DateTimeKind.Local).AddTicks(2517) });

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 23, 21, 6, 250, DateTimeKind.Local).AddTicks(2519), new DateTime(2024, 12, 16, 23, 21, 6, 250, DateTimeKind.Local).AddTicks(3023) });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 23, 21, 6, 250, DateTimeKind.Local).AddTicks(2436), new DateTime(2024, 12, 16, 23, 21, 6, 250, DateTimeKind.Local).AddTicks(2437) });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 23, 21, 6, 250, DateTimeKind.Local).AddTicks(2439), new DateTime(2024, 12, 16, 23, 21, 6, 250, DateTimeKind.Local).AddTicks(2439) });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Expiration", "UpdatedAt", "Used" },
                values: new object[] { new DateTime(2024, 12, 16, 23, 21, 6, 250, DateTimeKind.Local).AddTicks(4522), new DateTime(2025, 1, 16, 23, 21, 6, 250, DateTimeKind.Local).AddTicks(4518), new DateTime(2024, 12, 16, 23, 21, 6, 250, DateTimeKind.Local).AddTicks(4523), 0 });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Expiration", "UpdatedAt", "Used" },
                values: new object[] { new DateTime(2024, 12, 16, 23, 21, 6, 250, DateTimeKind.Local).AddTicks(4527), new DateTime(2025, 2, 16, 23, 21, 6, 250, DateTimeKind.Local).AddTicks(4526), new DateTime(2024, 12, 16, 23, 21, 6, 250, DateTimeKind.Local).AddTicks(4527), 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Used",
                table: "Recipe",
                type: "NUMBER(1)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)");

            migrationBuilder.UpdateData(
                table: "Doctor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 23, 5, 42, 990, DateTimeKind.Local).AddTicks(5237), new DateTime(2024, 12, 16, 23, 5, 42, 990, DateTimeKind.Local).AddTicks(5238) });

            migrationBuilder.UpdateData(
                table: "Doctor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 23, 5, 42, 990, DateTimeKind.Local).AddTicks(5241), new DateTime(2024, 12, 16, 23, 5, 42, 990, DateTimeKind.Local).AddTicks(5242) });

            migrationBuilder.UpdateData(
                table: "Examination",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ExaminationDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 23, 5, 42, 990, DateTimeKind.Local).AddTicks(5324), new DateTime(2024, 11, 16, 23, 5, 42, 990, DateTimeKind.Local).AddTicks(5316), new DateTime(2024, 12, 16, 23, 5, 42, 990, DateTimeKind.Local).AddTicks(5325) });

            migrationBuilder.UpdateData(
                table: "Examination",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ExaminationDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 23, 5, 42, 990, DateTimeKind.Local).AddTicks(5329), new DateTime(2025, 2, 16, 23, 5, 42, 990, DateTimeKind.Local).AddTicks(5327), new DateTime(2024, 12, 16, 23, 5, 42, 990, DateTimeKind.Local).AddTicks(5330) });

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 23, 5, 42, 990, DateTimeKind.Local).AddTicks(5365), new DateTime(2024, 12, 16, 23, 5, 42, 990, DateTimeKind.Local).AddTicks(5365) });

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 23, 5, 42, 990, DateTimeKind.Local).AddTicks(5369), new DateTime(2024, 12, 16, 23, 5, 42, 990, DateTimeKind.Local).AddTicks(5369) });

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 23, 5, 42, 990, DateTimeKind.Local).AddTicks(5372), new DateTime(2024, 12, 16, 23, 5, 42, 990, DateTimeKind.Local).AddTicks(5373) });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 23, 5, 42, 990, DateTimeKind.Local).AddTicks(5277), new DateTime(2024, 12, 16, 23, 5, 42, 990, DateTimeKind.Local).AddTicks(5278) });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 23, 5, 42, 990, DateTimeKind.Local).AddTicks(5280), new DateTime(2024, 12, 16, 23, 5, 42, 990, DateTimeKind.Local).AddTicks(5281) });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Expiration", "UpdatedAt", "Used" },
                values: new object[] { new DateTime(2024, 12, 16, 23, 5, 42, 990, DateTimeKind.Local).AddTicks(5412), new DateTime(2025, 1, 16, 23, 5, 42, 990, DateTimeKind.Local).AddTicks(5410), new DateTime(2024, 12, 16, 23, 5, 42, 990, DateTimeKind.Local).AddTicks(5413), 0 });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Expiration", "UpdatedAt", "Used" },
                values: new object[] { new DateTime(2024, 12, 16, 23, 5, 42, 990, DateTimeKind.Local).AddTicks(5416), new DateTime(2025, 2, 16, 23, 5, 42, 990, DateTimeKind.Local).AddTicks(5415), new DateTime(2024, 12, 16, 23, 5, 42, 990, DateTimeKind.Local).AddTicks(5417), 1 });
        }
    }
}
