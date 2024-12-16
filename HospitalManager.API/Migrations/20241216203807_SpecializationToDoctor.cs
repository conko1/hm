using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HospitalManager.API.Migrations
{
    /// <inheritdoc />
    public partial class SpecializationToDoctor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patient_Doctor_DoctorId",
                table: "Patient");

            migrationBuilder.DropForeignKey(
                name: "FK_Patient_Insurance_insuranceCode",
                table: "Patient");

            migrationBuilder.RenameColumn(
                name: "insuranceCode",
                table: "Patient",
                newName: "InsuranceCode");

            migrationBuilder.RenameIndex(
                name: "IX_Patient_insuranceCode",
                table: "Patient",
                newName: "IX_Patient_InsuranceCode");

            migrationBuilder.AlterColumn<int>(
                name: "DoctorId",
                table: "Patient",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Specialization",
                table: "Doctor",
                type: "NVARCHAR2(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 20, 38, 6, 115, DateTimeKind.Local).AddTicks(9685), new DateTime(2024, 12, 16, 20, 38, 6, 115, DateTimeKind.Local).AddTicks(9685) });

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 20, 38, 6, 115, DateTimeKind.Local).AddTicks(9690), new DateTime(2024, 12, 16, 20, 38, 6, 115, DateTimeKind.Local).AddTicks(9690) });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "BirthNumber", "AddressId", "Email", "FirstName", "LastName", "Telephone", "UserId" },
                values: new object[,]
                {
                    { "012345/1234", null, "peter@gmail.com", "Peter", "Petrovič", "+421123456785", null },
                    { "012345/1235", null, "daniel@gmail.com", "Daniel", "Danielovič", "+421987654321", null },
                    { "012345/1236", null, "martina@gmail.com", "Martina", "Martinová", "+421976431285", null },
                    { "012345/1237", null, "frederika@gmail.com", "Frederika", "Frederiková", "+421842862357", null }
                });

            migrationBuilder.InsertData(
                table: "Doctor",
                columns: new[] { "Id", "BirthNumber", "CreatedAt", "Specialization", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "012345/1234", new DateTime(2024, 12, 16, 20, 38, 6, 115, DateTimeKind.Local).AddTicks(9522), "Všeobecný lekár", new DateTime(2024, 12, 16, 20, 38, 6, 115, DateTimeKind.Local).AddTicks(9522) },
                    { 2, "012345/1236", new DateTime(2024, 12, 16, 20, 38, 6, 115, DateTimeKind.Local).AddTicks(9564), "Detský lekár", new DateTime(2024, 12, 16, 20, 38, 6, 115, DateTimeKind.Local).AddTicks(9565) }
                });

            migrationBuilder.InsertData(
                table: "Patient",
                columns: new[] { "Id", "Allergies", "BirthNumber", "BloodGroup", "CreatedAt", "DoctorId", "InsuranceCode", "Medications", "UpdatedAt", "Vaccines" },
                values: new object[,]
                {
                    { 1, null, "012345/1235", null, new DateTime(2024, 12, 16, 20, 38, 6, 115, DateTimeKind.Local).AddTicks(9632), 1, null, null, new DateTime(2024, 12, 16, 20, 38, 6, 115, DateTimeKind.Local).AddTicks(9633), null },
                    { 2, null, "012345/1237", null, new DateTime(2024, 12, 16, 20, 38, 6, 115, DateTimeKind.Local).AddTicks(9636), 2, null, null, new DateTime(2024, 12, 16, 20, 38, 6, 115, DateTimeKind.Local).AddTicks(9637), null }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_Doctor_DoctorId",
                table: "Patient",
                column: "DoctorId",
                principalTable: "Doctor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_Insurance_InsuranceCode",
                table: "Patient",
                column: "InsuranceCode",
                principalTable: "Insurance",
                principalColumn: "Code");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patient_Doctor_DoctorId",
                table: "Patient");

            migrationBuilder.DropForeignKey(
                name: "FK_Patient_Insurance_InsuranceCode",
                table: "Patient");

            migrationBuilder.DeleteData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Doctor",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctor",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "BirthNumber",
                keyValue: "012345/1235");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "BirthNumber",
                keyValue: "012345/1237");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "BirthNumber",
                keyValue: "012345/1234");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "BirthNumber",
                keyValue: "012345/1236");

            migrationBuilder.DropColumn(
                name: "Specialization",
                table: "Doctor");

            migrationBuilder.RenameColumn(
                name: "InsuranceCode",
                table: "Patient",
                newName: "insuranceCode");

            migrationBuilder.RenameIndex(
                name: "IX_Patient_InsuranceCode",
                table: "Patient",
                newName: "IX_Patient_insuranceCode");

            migrationBuilder.AlterColumn<int>(
                name: "DoctorId",
                table: "Patient",
                type: "NUMBER(10)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)");

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 17, 55, 59, 435, DateTimeKind.Local).AddTicks(6066), new DateTime(2024, 12, 16, 17, 55, 59, 435, DateTimeKind.Local).AddTicks(6068) });

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 17, 55, 59, 435, DateTimeKind.Local).AddTicks(6071), new DateTime(2024, 12, 16, 17, 55, 59, 435, DateTimeKind.Local).AddTicks(6072) });

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_Doctor_DoctorId",
                table: "Patient",
                column: "DoctorId",
                principalTable: "Doctor",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_Insurance_insuranceCode",
                table: "Patient",
                column: "insuranceCode",
                principalTable: "Insurance",
                principalColumn: "Code");
        }
    }
}
