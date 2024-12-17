using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalManager.API.Migrations
{
    /// <inheritdoc />
    public partial class RecipeDoctorPacientFkRemoved : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipe_Doctor_DoctorId",
                table: "Recipe");

            migrationBuilder.DropForeignKey(
                name: "FK_Recipe_Patient_PatientId",
                table: "Recipe");

            migrationBuilder.DropIndex(
                name: "IX_Recipe_DoctorId",
                table: "Recipe");

            migrationBuilder.DropIndex(
                name: "IX_Recipe_PatientId",
                table: "Recipe");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "Recipe");

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "Recipe");

            migrationBuilder.UpdateData(
                table: "Doctor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 22, 14, 28, 708, DateTimeKind.Local).AddTicks(5698), new DateTime(2024, 12, 16, 22, 14, 28, 708, DateTimeKind.Local).AddTicks(5699) });

            migrationBuilder.UpdateData(
                table: "Doctor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 22, 14, 28, 708, DateTimeKind.Local).AddTicks(5734), new DateTime(2024, 12, 16, 22, 14, 28, 708, DateTimeKind.Local).AddTicks(5734) });

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 22, 14, 28, 708, DateTimeKind.Local).AddTicks(5812), new DateTime(2024, 12, 16, 22, 14, 28, 708, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 22, 14, 28, 708, DateTimeKind.Local).AddTicks(5817), new DateTime(2024, 12, 16, 22, 14, 28, 708, DateTimeKind.Local).AddTicks(5817) });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 22, 14, 28, 708, DateTimeKind.Local).AddTicks(5773), new DateTime(2024, 12, 16, 22, 14, 28, 708, DateTimeKind.Local).AddTicks(5774) });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 22, 14, 28, 708, DateTimeKind.Local).AddTicks(5776), new DateTime(2024, 12, 16, 22, 14, 28, 708, DateTimeKind.Local).AddTicks(5777) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DoctorId",
                table: "Recipe",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PatientId",
                table: "Recipe",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Doctor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 20, 38, 6, 115, DateTimeKind.Local).AddTicks(9522), new DateTime(2024, 12, 16, 20, 38, 6, 115, DateTimeKind.Local).AddTicks(9522) });

            migrationBuilder.UpdateData(
                table: "Doctor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 20, 38, 6, 115, DateTimeKind.Local).AddTicks(9564), new DateTime(2024, 12, 16, 20, 38, 6, 115, DateTimeKind.Local).AddTicks(9565) });

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

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 20, 38, 6, 115, DateTimeKind.Local).AddTicks(9632), new DateTime(2024, 12, 16, 20, 38, 6, 115, DateTimeKind.Local).AddTicks(9633) });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 20, 38, 6, 115, DateTimeKind.Local).AddTicks(9636), new DateTime(2024, 12, 16, 20, 38, 6, 115, DateTimeKind.Local).AddTicks(9637) });

            migrationBuilder.CreateIndex(
                name: "IX_Recipe_DoctorId",
                table: "Recipe",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipe_PatientId",
                table: "Recipe",
                column: "PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipe_Doctor_DoctorId",
                table: "Recipe",
                column: "DoctorId",
                principalTable: "Doctor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Recipe_Patient_PatientId",
                table: "Recipe",
                column: "PatientId",
                principalTable: "Patient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
