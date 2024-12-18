using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalManager.API.Migrations
{
    /// <inheritdoc />
    public partial class MedicineImport : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MedicineImports",
                columns: table => new
                {
                    sukl_kod = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    nazov = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    doplnok = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    kod_statu = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    reg_cislo = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    exspiracia = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    vydaj = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    dat_reg = table.Column<string>(type: "NVARCHAR2(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicineImports", x => x.sukl_kod);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedicineImports");

            migrationBuilder.UpdateData(
                table: "Doctor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 23, 55, 41, 565, DateTimeKind.Local).AddTicks(5356), new DateTime(2024, 12, 17, 23, 55, 41, 565, DateTimeKind.Local).AddTicks(5357) });

            migrationBuilder.UpdateData(
                table: "Doctor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 23, 55, 41, 565, DateTimeKind.Local).AddTicks(5360), new DateTime(2024, 12, 17, 23, 55, 41, 565, DateTimeKind.Local).AddTicks(5361) });

            migrationBuilder.UpdateData(
                table: "Examination",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ExaminationDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 23, 55, 41, 565, DateTimeKind.Local).AddTicks(5463), new DateTime(2024, 11, 17, 23, 55, 41, 565, DateTimeKind.Local).AddTicks(5454), new DateTime(2024, 12, 17, 23, 55, 41, 565, DateTimeKind.Local).AddTicks(5463) });

            migrationBuilder.UpdateData(
                table: "Examination",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ExaminationDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 23, 55, 41, 565, DateTimeKind.Local).AddTicks(5468), new DateTime(2025, 2, 17, 23, 55, 41, 565, DateTimeKind.Local).AddTicks(5466), new DateTime(2024, 12, 17, 23, 55, 41, 565, DateTimeKind.Local).AddTicks(5469) });

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 23, 55, 41, 565, DateTimeKind.Local).AddTicks(5510), new DateTime(2024, 12, 17, 23, 55, 41, 565, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 23, 55, 41, 565, DateTimeKind.Local).AddTicks(5515), new DateTime(2024, 12, 17, 23, 55, 41, 565, DateTimeKind.Local).AddTicks(5515) });

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 23, 55, 41, 565, DateTimeKind.Local).AddTicks(5518), new DateTime(2024, 12, 17, 23, 55, 41, 565, DateTimeKind.Local).AddTicks(5519) });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 23, 55, 41, 565, DateTimeKind.Local).AddTicks(5407), new DateTime(2024, 12, 17, 23, 55, 41, 565, DateTimeKind.Local).AddTicks(5408) });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 23, 55, 41, 565, DateTimeKind.Local).AddTicks(5411), new DateTime(2024, 12, 17, 23, 55, 41, 565, DateTimeKind.Local).AddTicks(5411) });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Expiration", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 23, 55, 41, 565, DateTimeKind.Local).AddTicks(5568), new DateTime(2025, 1, 17, 23, 55, 41, 565, DateTimeKind.Local).AddTicks(5565), new DateTime(2024, 12, 17, 23, 55, 41, 565, DateTimeKind.Local).AddTicks(5569) });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Expiration", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 23, 55, 41, 565, DateTimeKind.Local).AddTicks(5573), new DateTime(2025, 2, 17, 23, 55, 41, 565, DateTimeKind.Local).AddTicks(5572), new DateTime(2024, 12, 17, 23, 55, 41, 565, DateTimeKind.Local).AddTicks(5574) });
        }
    }
}
