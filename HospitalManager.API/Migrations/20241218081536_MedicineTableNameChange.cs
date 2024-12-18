using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalManager.API.Migrations
{
    /// <inheritdoc />
    public partial class MedicineTableNameChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MedicineImports",
                table: "MedicineImports");

            migrationBuilder.RenameTable(
                name: "MedicineImports",
                newName: "liek");

            migrationBuilder.AddPrimaryKey(
                name: "PK_liek",
                table: "liek",
                column: "sukl_kod");

            migrationBuilder.UpdateData(
                table: "Doctor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 18, 8, 15, 35, 434, DateTimeKind.Local).AddTicks(9838), new DateTime(2024, 12, 18, 8, 15, 35, 434, DateTimeKind.Local).AddTicks(9839) });

            migrationBuilder.UpdateData(
                table: "Doctor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 18, 8, 15, 35, 434, DateTimeKind.Local).AddTicks(9843), new DateTime(2024, 12, 18, 8, 15, 35, 434, DateTimeKind.Local).AddTicks(9844) });

            migrationBuilder.UpdateData(
                table: "Examination",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ExaminationDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 18, 8, 15, 35, 434, DateTimeKind.Local).AddTicks(9929), new DateTime(2024, 11, 18, 8, 15, 35, 434, DateTimeKind.Local).AddTicks(9921), new DateTime(2024, 12, 18, 8, 15, 35, 434, DateTimeKind.Local).AddTicks(9929) });

            migrationBuilder.UpdateData(
                table: "Examination",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ExaminationDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 18, 8, 15, 35, 434, DateTimeKind.Local).AddTicks(9934), new DateTime(2025, 2, 18, 8, 15, 35, 434, DateTimeKind.Local).AddTicks(9932), new DateTime(2024, 12, 18, 8, 15, 35, 434, DateTimeKind.Local).AddTicks(9935) });

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 18, 8, 15, 35, 434, DateTimeKind.Local).AddTicks(9977), new DateTime(2024, 12, 18, 8, 15, 35, 434, DateTimeKind.Local).AddTicks(9978) });

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 18, 8, 15, 35, 434, DateTimeKind.Local).AddTicks(9982), new DateTime(2024, 12, 18, 8, 15, 35, 434, DateTimeKind.Local).AddTicks(9982) });

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 18, 8, 15, 35, 434, DateTimeKind.Local).AddTicks(9985), new DateTime(2024, 12, 18, 8, 15, 35, 434, DateTimeKind.Local).AddTicks(9986) });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 18, 8, 15, 35, 434, DateTimeKind.Local).AddTicks(9879), new DateTime(2024, 12, 18, 8, 15, 35, 434, DateTimeKind.Local).AddTicks(9880) });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 18, 8, 15, 35, 434, DateTimeKind.Local).AddTicks(9886), new DateTime(2024, 12, 18, 8, 15, 35, 434, DateTimeKind.Local).AddTicks(9886) });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Expiration", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 18, 8, 15, 35, 435, DateTimeKind.Local).AddTicks(20), new DateTime(2025, 1, 18, 8, 15, 35, 435, DateTimeKind.Local).AddTicks(17), new DateTime(2024, 12, 18, 8, 15, 35, 435, DateTimeKind.Local).AddTicks(20) });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Expiration", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 18, 8, 15, 35, 435, DateTimeKind.Local).AddTicks(24), new DateTime(2025, 2, 18, 8, 15, 35, 435, DateTimeKind.Local).AddTicks(23), new DateTime(2024, 12, 18, 8, 15, 35, 435, DateTimeKind.Local).AddTicks(24) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_liek",
                table: "liek");

            migrationBuilder.RenameTable(
                name: "liek",
                newName: "MedicineImports");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MedicineImports",
                table: "MedicineImports",
                column: "sukl_kod");

            migrationBuilder.UpdateData(
                table: "Doctor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 18, 8, 12, 45, 646, DateTimeKind.Local).AddTicks(7097), new DateTime(2024, 12, 18, 8, 12, 45, 646, DateTimeKind.Local).AddTicks(7098) });

            migrationBuilder.UpdateData(
                table: "Doctor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 18, 8, 12, 45, 646, DateTimeKind.Local).AddTicks(7101), new DateTime(2024, 12, 18, 8, 12, 45, 646, DateTimeKind.Local).AddTicks(7102) });

            migrationBuilder.UpdateData(
                table: "Examination",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ExaminationDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 18, 8, 12, 45, 646, DateTimeKind.Local).AddTicks(7188), new DateTime(2024, 11, 18, 8, 12, 45, 646, DateTimeKind.Local).AddTicks(7179), new DateTime(2024, 12, 18, 8, 12, 45, 646, DateTimeKind.Local).AddTicks(7189) });

            migrationBuilder.UpdateData(
                table: "Examination",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ExaminationDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 18, 8, 12, 45, 646, DateTimeKind.Local).AddTicks(7193), new DateTime(2025, 2, 18, 8, 12, 45, 646, DateTimeKind.Local).AddTicks(7191), new DateTime(2024, 12, 18, 8, 12, 45, 646, DateTimeKind.Local).AddTicks(7194) });

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 18, 8, 12, 45, 646, DateTimeKind.Local).AddTicks(7238), new DateTime(2024, 12, 18, 8, 12, 45, 646, DateTimeKind.Local).AddTicks(7239) });

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 18, 8, 12, 45, 646, DateTimeKind.Local).AddTicks(7243), new DateTime(2024, 12, 18, 8, 12, 45, 646, DateTimeKind.Local).AddTicks(7244) });

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 18, 8, 12, 45, 646, DateTimeKind.Local).AddTicks(7246), new DateTime(2024, 12, 18, 8, 12, 45, 646, DateTimeKind.Local).AddTicks(7247) });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 18, 8, 12, 45, 646, DateTimeKind.Local).AddTicks(7140), new DateTime(2024, 12, 18, 8, 12, 45, 646, DateTimeKind.Local).AddTicks(7141) });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 18, 8, 12, 45, 646, DateTimeKind.Local).AddTicks(7143), new DateTime(2024, 12, 18, 8, 12, 45, 646, DateTimeKind.Local).AddTicks(7144) });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Expiration", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 18, 8, 12, 45, 646, DateTimeKind.Local).AddTicks(7283), new DateTime(2025, 1, 18, 8, 12, 45, 646, DateTimeKind.Local).AddTicks(7280), new DateTime(2024, 12, 18, 8, 12, 45, 646, DateTimeKind.Local).AddTicks(7283) });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Expiration", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 18, 8, 12, 45, 646, DateTimeKind.Local).AddTicks(7287), new DateTime(2025, 2, 18, 8, 12, 45, 646, DateTimeKind.Local).AddTicks(7286), new DateTime(2024, 12, 18, 8, 12, 45, 646, DateTimeKind.Local).AddTicks(7288) });
        }
    }
}
