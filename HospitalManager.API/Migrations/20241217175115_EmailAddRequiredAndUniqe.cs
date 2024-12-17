using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HospitalManager.API.Migrations
{
    /// <inheritdoc />
    public partial class EmailAddRequiredAndUniqe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Person",
                type: "NVARCHAR2(254)",
                maxLength: 254,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(254)",
                oldMaxLength: 254,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Doctor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 17, 51, 14, 240, DateTimeKind.Local).AddTicks(5350), new DateTime(2024, 12, 17, 17, 51, 14, 240, DateTimeKind.Local).AddTicks(5351) });

            migrationBuilder.UpdateData(
                table: "Doctor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 17, 51, 14, 240, DateTimeKind.Local).AddTicks(5354), new DateTime(2024, 12, 17, 17, 51, 14, 240, DateTimeKind.Local).AddTicks(5355) });

            migrationBuilder.UpdateData(
                table: "Examination",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ExaminationDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 17, 51, 14, 240, DateTimeKind.Local).AddTicks(5443), new DateTime(2024, 11, 17, 17, 51, 14, 240, DateTimeKind.Local).AddTicks(5435), new DateTime(2024, 12, 17, 17, 51, 14, 240, DateTimeKind.Local).AddTicks(5444) });

            migrationBuilder.UpdateData(
                table: "Examination",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ExaminationDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 17, 51, 14, 240, DateTimeKind.Local).AddTicks(5448), new DateTime(2025, 2, 17, 17, 51, 14, 240, DateTimeKind.Local).AddTicks(5446), new DateTime(2024, 12, 17, 17, 51, 14, 240, DateTimeKind.Local).AddTicks(5449) });

            migrationBuilder.InsertData(
                table: "Insurance",
                columns: new[] { "Code", "Abbreviation", "FullName" },
                values: new object[,]
                {
                    { 24, "Dôvera", "Dôvera zdravotná poisťovňa, a.s." },
                    { 25, "VZP", "Všeobecná zdravotná poisťovňa, a.s." },
                    { 27, "UNION", "Union zdravotná poisťovňa, a.s." }
                });

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 17, 51, 14, 240, DateTimeKind.Local).AddTicks(5488), new DateTime(2024, 12, 17, 17, 51, 14, 240, DateTimeKind.Local).AddTicks(5489) });

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 17, 51, 14, 240, DateTimeKind.Local).AddTicks(5493), new DateTime(2024, 12, 17, 17, 51, 14, 240, DateTimeKind.Local).AddTicks(5493) });

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 17, 51, 14, 240, DateTimeKind.Local).AddTicks(5559), new DateTime(2024, 12, 17, 17, 51, 14, 240, DateTimeKind.Local).AddTicks(5560) });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 17, 51, 14, 240, DateTimeKind.Local).AddTicks(5397), new DateTime(2024, 12, 17, 17, 51, 14, 240, DateTimeKind.Local).AddTicks(5397) });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 17, 51, 14, 240, DateTimeKind.Local).AddTicks(5400), new DateTime(2024, 12, 17, 17, 51, 14, 240, DateTimeKind.Local).AddTicks(5400) });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Expiration", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 17, 51, 14, 240, DateTimeKind.Local).AddTicks(5607), new DateTime(2025, 1, 17, 17, 51, 14, 240, DateTimeKind.Local).AddTicks(5603), new DateTime(2024, 12, 17, 17, 51, 14, 240, DateTimeKind.Local).AddTicks(5607) });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Expiration", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 17, 51, 14, 240, DateTimeKind.Local).AddTicks(5611), new DateTime(2025, 2, 17, 17, 51, 14, 240, DateTimeKind.Local).AddTicks(5610), new DateTime(2024, 12, 17, 17, 51, 14, 240, DateTimeKind.Local).AddTicks(5612) });

            migrationBuilder.CreateIndex(
                name: "IX_Person_Email",
                table: "Person",
                column: "Email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Person_Email",
                table: "Person");

            migrationBuilder.DeleteData(
                table: "Insurance",
                keyColumn: "Code",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Insurance",
                keyColumn: "Code",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Insurance",
                keyColumn: "Code",
                keyValue: 27);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Person",
                type: "NVARCHAR2(254)",
                maxLength: 254,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(254)",
                oldMaxLength: 254);

            migrationBuilder.UpdateData(
                table: "Doctor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 12, 18, 46, 861, DateTimeKind.Local).AddTicks(6221), new DateTime(2024, 12, 17, 12, 18, 46, 861, DateTimeKind.Local).AddTicks(6222) });

            migrationBuilder.UpdateData(
                table: "Doctor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 12, 18, 46, 861, DateTimeKind.Local).AddTicks(6225), new DateTime(2024, 12, 17, 12, 18, 46, 861, DateTimeKind.Local).AddTicks(6226) });

            migrationBuilder.UpdateData(
                table: "Examination",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ExaminationDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 12, 18, 46, 861, DateTimeKind.Local).AddTicks(6295), new DateTime(2024, 11, 17, 12, 18, 46, 861, DateTimeKind.Local).AddTicks(6287), new DateTime(2024, 12, 17, 12, 18, 46, 861, DateTimeKind.Local).AddTicks(6295) });

            migrationBuilder.UpdateData(
                table: "Examination",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ExaminationDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 12, 18, 46, 861, DateTimeKind.Local).AddTicks(6299), new DateTime(2025, 2, 17, 12, 18, 46, 861, DateTimeKind.Local).AddTicks(6297), new DateTime(2024, 12, 17, 12, 18, 46, 861, DateTimeKind.Local).AddTicks(6299) });

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 12, 18, 46, 861, DateTimeKind.Local).AddTicks(6330), new DateTime(2024, 12, 17, 12, 18, 46, 861, DateTimeKind.Local).AddTicks(6331) });

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 12, 18, 46, 861, DateTimeKind.Local).AddTicks(6333), new DateTime(2024, 12, 17, 12, 18, 46, 861, DateTimeKind.Local).AddTicks(6334) });

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 12, 18, 46, 861, DateTimeKind.Local).AddTicks(6336), new DateTime(2024, 12, 17, 12, 18, 46, 861, DateTimeKind.Local).AddTicks(6337) });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 12, 18, 46, 861, DateTimeKind.Local).AddTicks(6255), new DateTime(2024, 12, 17, 12, 18, 46, 861, DateTimeKind.Local).AddTicks(6255) });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 12, 18, 46, 861, DateTimeKind.Local).AddTicks(6257), new DateTime(2024, 12, 17, 12, 18, 46, 861, DateTimeKind.Local).AddTicks(6258) });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Expiration", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 12, 18, 46, 861, DateTimeKind.Local).AddTicks(6368), new DateTime(2025, 1, 17, 12, 18, 46, 861, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 12, 17, 12, 18, 46, 861, DateTimeKind.Local).AddTicks(6368) });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Expiration", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 12, 18, 46, 861, DateTimeKind.Local).AddTicks(6371), new DateTime(2025, 2, 17, 12, 18, 46, 861, DateTimeKind.Local).AddTicks(6370), new DateTime(2024, 12, 17, 12, 18, 46, 861, DateTimeKind.Local).AddTicks(6372) });
        }
    }
}
