using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HospitalManager.API.Migrations
{
    /// <inheritdoc />
    public partial class RecipeMedicineSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Examination",
                columns: new[] { "Id", "CreatedAt", "Diagnosis", "DoctorId", "ExaminationDate", "Notes", "PatientId", "Symptoms", "Treatment", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 16, 23, 5, 42, 990, DateTimeKind.Local).AddTicks(5324), null, 1, new DateTime(2024, 11, 16, 23, 5, 42, 990, DateTimeKind.Local).AddTicks(5316), null, 2, null, null, new DateTime(2024, 12, 16, 23, 5, 42, 990, DateTimeKind.Local).AddTicks(5325) },
                    { 2, new DateTime(2024, 12, 16, 23, 5, 42, 990, DateTimeKind.Local).AddTicks(5329), null, 2, new DateTime(2025, 2, 16, 23, 5, 42, 990, DateTimeKind.Local).AddTicks(5327), null, 1, null, null, new DateTime(2024, 12, 16, 23, 5, 42, 990, DateTimeKind.Local).AddTicks(5330) }
                });

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

            migrationBuilder.InsertData(
                table: "Medicine",
                columns: new[] { "Id", "CreatedAt", "Description", "Dosage", "Name", "Price", "Quantity", "SideEffects", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2024, 12, 16, 23, 5, 42, 990, DateTimeKind.Local).AddTicks(5372), null, null, "Ibuprofen", 6.25m, null, null, new DateTime(2024, 12, 16, 23, 5, 42, 990, DateTimeKind.Local).AddTicks(5373) });

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

            migrationBuilder.InsertData(
                table: "Recipe",
                columns: new[] { "Id", "CreatedAt", "ExaminationId", "Expiration", "UpdatedAt", "Used" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 16, 23, 5, 42, 990, DateTimeKind.Local).AddTicks(5412), 1, new DateTime(2025, 1, 16, 23, 5, 42, 990, DateTimeKind.Local).AddTicks(5410), new DateTime(2024, 12, 16, 23, 5, 42, 990, DateTimeKind.Local).AddTicks(5413), 0 },
                    { 2, new DateTime(2024, 12, 16, 23, 5, 42, 990, DateTimeKind.Local).AddTicks(5416), 2, new DateTime(2025, 2, 16, 23, 5, 42, 990, DateTimeKind.Local).AddTicks(5415), new DateTime(2024, 12, 16, 23, 5, 42, 990, DateTimeKind.Local).AddTicks(5417), 1 }
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
