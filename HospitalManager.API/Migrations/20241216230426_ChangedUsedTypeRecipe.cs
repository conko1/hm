using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HospitalManager.API.Migrations
{
    /// <inheritdoc />
    public partial class ChangedUsedTypeRecipe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MedicineRecipe",
                keyColumns: new[] { "MedicinesId", "RecipesId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "MedicineRecipe",
                keyColumns: new[] { "MedicinesId", "RecipesId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "MedicineRecipe",
                keyColumns: new[] { "MedicinesId", "RecipesId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "MedicineRecipe",
                keyColumns: new[] { "MedicinesId", "RecipesId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Examination",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Examination",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Doctor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 23, 4, 25, 936, DateTimeKind.Local).AddTicks(5358), new DateTime(2024, 12, 16, 23, 4, 25, 936, DateTimeKind.Local).AddTicks(5359) });

            migrationBuilder.UpdateData(
                table: "Doctor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 23, 4, 25, 936, DateTimeKind.Local).AddTicks(5384), new DateTime(2024, 12, 16, 23, 4, 25, 936, DateTimeKind.Local).AddTicks(5385) });

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 23, 4, 25, 936, DateTimeKind.Local).AddTicks(5448), new DateTime(2024, 12, 16, 23, 4, 25, 936, DateTimeKind.Local).AddTicks(5449) });

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 23, 4, 25, 936, DateTimeKind.Local).AddTicks(5452), new DateTime(2024, 12, 16, 23, 4, 25, 936, DateTimeKind.Local).AddTicks(5452) });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 23, 4, 25, 936, DateTimeKind.Local).AddTicks(5415), new DateTime(2024, 12, 16, 23, 4, 25, 936, DateTimeKind.Local).AddTicks(5416) });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 23, 4, 25, 936, DateTimeKind.Local).AddTicks(5418), new DateTime(2024, 12, 16, 23, 4, 25, 936, DateTimeKind.Local).AddTicks(5418) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Doctor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 23, 0, 21, 50, DateTimeKind.Local).AddTicks(192), new DateTime(2024, 12, 16, 23, 0, 21, 50, DateTimeKind.Local).AddTicks(193) });

            migrationBuilder.UpdateData(
                table: "Doctor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 23, 0, 21, 50, DateTimeKind.Local).AddTicks(196), new DateTime(2024, 12, 16, 23, 0, 21, 50, DateTimeKind.Local).AddTicks(196) });

            migrationBuilder.InsertData(
                table: "Examination",
                columns: new[] { "Id", "CreatedAt", "Diagnosis", "DoctorId", "ExaminationDate", "Notes", "PatientId", "Symptoms", "Treatment", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 16, 23, 0, 21, 50, DateTimeKind.Local).AddTicks(361), null, 1, new DateTime(2024, 11, 16, 23, 0, 21, 50, DateTimeKind.Local).AddTicks(352), null, 2, null, null, new DateTime(2024, 12, 16, 23, 0, 21, 50, DateTimeKind.Local).AddTicks(362) },
                    { 2, new DateTime(2024, 12, 16, 23, 0, 21, 50, DateTimeKind.Local).AddTicks(367), null, 2, new DateTime(2025, 2, 16, 23, 0, 21, 50, DateTimeKind.Local).AddTicks(364), null, 1, null, null, new DateTime(2024, 12, 16, 23, 0, 21, 50, DateTimeKind.Local).AddTicks(368) }
                });

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 23, 0, 21, 50, DateTimeKind.Local).AddTicks(408), new DateTime(2024, 12, 16, 23, 0, 21, 50, DateTimeKind.Local).AddTicks(408) });

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 23, 0, 21, 50, DateTimeKind.Local).AddTicks(412), new DateTime(2024, 12, 16, 23, 0, 21, 50, DateTimeKind.Local).AddTicks(413) });

            migrationBuilder.InsertData(
                table: "Medicine",
                columns: new[] { "Id", "CreatedAt", "Description", "Dosage", "Name", "Price", "Quantity", "SideEffects", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2024, 12, 16, 23, 0, 21, 50, DateTimeKind.Local).AddTicks(416), null, null, "Ibuprofen", 6.25m, null, null, new DateTime(2024, 12, 16, 23, 0, 21, 50, DateTimeKind.Local).AddTicks(416) });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 23, 0, 21, 50, DateTimeKind.Local).AddTicks(303), new DateTime(2024, 12, 16, 23, 0, 21, 50, DateTimeKind.Local).AddTicks(303) });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 23, 0, 21, 50, DateTimeKind.Local).AddTicks(306), new DateTime(2024, 12, 16, 23, 0, 21, 50, DateTimeKind.Local).AddTicks(306) });

            migrationBuilder.InsertData(
                table: "Recipe",
                columns: new[] { "Id", "CreatedAt", "ExaminationId", "Expiration", "UpdatedAt", "Used" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 16, 23, 0, 21, 50, DateTimeKind.Local).AddTicks(457), 1, new DateTime(2025, 1, 16, 23, 0, 21, 50, DateTimeKind.Local).AddTicks(455), new DateTime(2024, 12, 16, 23, 0, 21, 50, DateTimeKind.Local).AddTicks(458), false },
                    { 2, new DateTime(2024, 12, 16, 23, 0, 21, 50, DateTimeKind.Local).AddTicks(461), 2, new DateTime(2025, 2, 16, 23, 0, 21, 50, DateTimeKind.Local).AddTicks(460), new DateTime(2024, 12, 16, 23, 0, 21, 50, DateTimeKind.Local).AddTicks(462), false }
                });

            migrationBuilder.InsertData(
                table: "MedicineRecipe",
                columns: new[] { "MedicinesId", "RecipesId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 2, 2 },
                    { 3, 2 }
                });
        }
    }
}
