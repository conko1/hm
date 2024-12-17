using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HospitalManager.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: "012345/1237");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "BirthNumber",
                keyValue: "012345/1236");

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
                columns: new[] { "CreatedAt", "ExaminationDate", "PatientId", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 19, 46, 14, 22, DateTimeKind.Local).AddTicks(8275), new DateTime(2024, 11, 17, 19, 46, 14, 22, DateTimeKind.Local).AddTicks(8267), 1, new DateTime(2024, 12, 17, 19, 46, 14, 22, DateTimeKind.Local).AddTicks(8276) });

            migrationBuilder.UpdateData(
                table: "Examination",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DoctorId", "ExaminationDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 19, 46, 14, 22, DateTimeKind.Local).AddTicks(8280), 1, new DateTime(2025, 2, 17, 19, 46, 14, 22, DateTimeKind.Local).AddTicks(8278), new DateTime(2024, 12, 17, 19, 46, 14, 22, DateTimeKind.Local).AddTicks(8281) });

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
                table: "Person",
                keyColumn: "BirthNumber",
                keyValue: "012345/1234",
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "doktorTest@gmail.com", "Doktor", "Test" });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "BirthNumber",
                keyValue: "012345/1235",
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "pacientTest@gmail.com", "Pacient", "test" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Doctor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 17, 51, 14, 240, DateTimeKind.Local).AddTicks(5350), new DateTime(2024, 12, 17, 17, 51, 14, 240, DateTimeKind.Local).AddTicks(5351) });

            migrationBuilder.UpdateData(
                table: "Examination",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ExaminationDate", "PatientId", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 17, 51, 14, 240, DateTimeKind.Local).AddTicks(5443), new DateTime(2024, 11, 17, 17, 51, 14, 240, DateTimeKind.Local).AddTicks(5435), 2, new DateTime(2024, 12, 17, 17, 51, 14, 240, DateTimeKind.Local).AddTicks(5444) });

            migrationBuilder.UpdateData(
                table: "Examination",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DoctorId", "ExaminationDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 17, 51, 14, 240, DateTimeKind.Local).AddTicks(5448), 2, new DateTime(2025, 2, 17, 17, 51, 14, 240, DateTimeKind.Local).AddTicks(5446), new DateTime(2024, 12, 17, 17, 51, 14, 240, DateTimeKind.Local).AddTicks(5449) });

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
                table: "Person",
                keyColumn: "BirthNumber",
                keyValue: "012345/1234",
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "peter@gmail.com", "Peter", "Petrovič" });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "BirthNumber",
                keyValue: "012345/1235",
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "daniel@gmail.com", "Daniel", "Danielovič" });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "BirthNumber", "AddressId", "Email", "FirstName", "LastName", "Telephone", "UserId" },
                values: new object[,]
                {
                    { "012345/1236", null, "martina@gmail.com", "Martina", "Martinová", "+421976431285", null },
                    { "012345/1237", null, "frederika@gmail.com", "Frederika", "Frederiková", "+421842862357", null }
                });

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

            migrationBuilder.InsertData(
                table: "Doctor",
                columns: new[] { "Id", "BirthNumber", "CreatedAt", "Specialization", "UpdatedAt" },
                values: new object[] { 2, "012345/1236", new DateTime(2024, 12, 17, 17, 51, 14, 240, DateTimeKind.Local).AddTicks(5354), "Detský lekár", new DateTime(2024, 12, 17, 17, 51, 14, 240, DateTimeKind.Local).AddTicks(5355) });

            migrationBuilder.InsertData(
                table: "Patient",
                columns: new[] { "Id", "Allergies", "BirthNumber", "BloodGroup", "CreatedAt", "DoctorId", "InsuranceCode", "Medications", "UpdatedAt", "Vaccines" },
                values: new object[] { 2, null, "012345/1237", null, new DateTime(2024, 12, 17, 17, 51, 14, 240, DateTimeKind.Local).AddTicks(5400), 2, null, null, new DateTime(2024, 12, 17, 17, 51, 14, 240, DateTimeKind.Local).AddTicks(5400), null });
        }
    }
}
