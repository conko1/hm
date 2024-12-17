using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HospitalManager.API.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedUserSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Doctor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 23, 55, 41, 565, DateTimeKind.Local).AddTicks(5356), new DateTime(2024, 12, 17, 23, 55, 41, 565, DateTimeKind.Local).AddTicks(5357) });

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

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "BirthNumber", "AddressId", "Email", "FirstName", "LastName", "Telephone", "UserId" },
                values: new object[,]
                {
                    { "012345/1214", null, "marek@gmail.com", "Marek", "Marekovy", "+421987654321", null },
                    { "012345/1265", null, "peter@gmail.com", "Peter", "Petrový", "+421987654321", null }
                });

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

            migrationBuilder.InsertData(
                table: "Doctor",
                columns: new[] { "Id", "BirthNumber", "CreatedAt", "Specialization", "UpdatedAt" },
                values: new object[] { 2, "012345/1265", new DateTime(2024, 12, 17, 23, 55, 41, 565, DateTimeKind.Local).AddTicks(5360), "Všeobecný lekár", new DateTime(2024, 12, 17, 23, 55, 41, 565, DateTimeKind.Local).AddTicks(5361) });

            migrationBuilder.InsertData(
                table: "Patient",
                columns: new[] { "Id", "Allergies", "BirthNumber", "BloodGroup", "CreatedAt", "DoctorId", "InsuranceCode", "Medications", "UpdatedAt", "Vaccines" },
                values: new object[] { 2, null, "012345/1214", null, new DateTime(2024, 12, 17, 23, 55, 41, 565, DateTimeKind.Local).AddTicks(5411), 2, null, null, new DateTime(2024, 12, 17, 23, 55, 41, 565, DateTimeKind.Local).AddTicks(5411), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Doctor",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "BirthNumber",
                keyValue: "012345/1214");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "BirthNumber",
                keyValue: "012345/1265");

            migrationBuilder.UpdateData(
                table: "Doctor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 19, 46, 14, 22, DateTimeKind.Local).AddTicks(8194), new DateTime(2024, 12, 17, 19, 46, 14, 22, DateTimeKind.Local).AddTicks(8195) });

            migrationBuilder.UpdateData(
                table: "Examination",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ExaminationDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 19, 46, 14, 22, DateTimeKind.Local).AddTicks(8275), new DateTime(2024, 11, 17, 19, 46, 14, 22, DateTimeKind.Local).AddTicks(8267), new DateTime(2024, 12, 17, 19, 46, 14, 22, DateTimeKind.Local).AddTicks(8276) });

            migrationBuilder.UpdateData(
                table: "Examination",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ExaminationDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 19, 46, 14, 22, DateTimeKind.Local).AddTicks(8280), new DateTime(2025, 2, 17, 19, 46, 14, 22, DateTimeKind.Local).AddTicks(8278), new DateTime(2024, 12, 17, 19, 46, 14, 22, DateTimeKind.Local).AddTicks(8281) });

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 19, 46, 14, 22, DateTimeKind.Local).AddTicks(8318), new DateTime(2024, 12, 17, 19, 46, 14, 22, DateTimeKind.Local).AddTicks(8318) });

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 19, 46, 14, 22, DateTimeKind.Local).AddTicks(8322), new DateTime(2024, 12, 17, 19, 46, 14, 22, DateTimeKind.Local).AddTicks(8323) });

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 19, 46, 14, 22, DateTimeKind.Local).AddTicks(8326), new DateTime(2024, 12, 17, 19, 46, 14, 22, DateTimeKind.Local).AddTicks(8326) });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 19, 46, 14, 22, DateTimeKind.Local).AddTicks(8230), new DateTime(2024, 12, 17, 19, 46, 14, 22, DateTimeKind.Local).AddTicks(8231) });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Expiration", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 19, 46, 14, 22, DateTimeKind.Local).AddTicks(8368), new DateTime(2025, 1, 17, 19, 46, 14, 22, DateTimeKind.Local).AddTicks(8363), new DateTime(2024, 12, 17, 19, 46, 14, 22, DateTimeKind.Local).AddTicks(8368) });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Expiration", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 19, 46, 14, 22, DateTimeKind.Local).AddTicks(8372), new DateTime(2025, 2, 17, 19, 46, 14, 22, DateTimeKind.Local).AddTicks(8371), new DateTime(2024, 12, 17, 19, 46, 14, 22, DateTimeKind.Local).AddTicks(8373) });
        }
    }
}
