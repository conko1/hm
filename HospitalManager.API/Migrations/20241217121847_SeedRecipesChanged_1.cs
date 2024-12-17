using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HospitalManager.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedRecipesChanged_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Recipe",
                columns: new[] { "Id", "CreatedAt", "ExaminationId", "Expiration", "UpdatedAt", "Used" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 17, 12, 18, 46, 861, DateTimeKind.Local).AddTicks(6368), 1, new DateTime(2025, 1, 17, 12, 18, 46, 861, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 12, 17, 12, 18, 46, 861, DateTimeKind.Local).AddTicks(6368), 0 },
                    { 2, new DateTime(2024, 12, 17, 12, 18, 46, 861, DateTimeKind.Local).AddTicks(6371), 2, new DateTime(2025, 2, 17, 12, 18, 46, 861, DateTimeKind.Local).AddTicks(6370), new DateTime(2024, 12, 17, 12, 18, 46, 861, DateTimeKind.Local).AddTicks(6372), 1 }
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
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Doctor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 12, 17, 10, 985, DateTimeKind.Local).AddTicks(8048), new DateTime(2024, 12, 17, 12, 17, 10, 985, DateTimeKind.Local).AddTicks(8049) });

            migrationBuilder.UpdateData(
                table: "Doctor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 12, 17, 10, 985, DateTimeKind.Local).AddTicks(8052), new DateTime(2024, 12, 17, 12, 17, 10, 985, DateTimeKind.Local).AddTicks(8052) });

            migrationBuilder.UpdateData(
                table: "Examination",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ExaminationDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 12, 17, 10, 985, DateTimeKind.Local).AddTicks(8151), new DateTime(2024, 11, 17, 12, 17, 10, 985, DateTimeKind.Local).AddTicks(8139), new DateTime(2024, 12, 17, 12, 17, 10, 985, DateTimeKind.Local).AddTicks(8152) });

            migrationBuilder.UpdateData(
                table: "Examination",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ExaminationDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 12, 17, 10, 985, DateTimeKind.Local).AddTicks(8156), new DateTime(2025, 2, 17, 12, 17, 10, 985, DateTimeKind.Local).AddTicks(8154), new DateTime(2024, 12, 17, 12, 17, 10, 985, DateTimeKind.Local).AddTicks(8157) });

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 12, 17, 10, 985, DateTimeKind.Local).AddTicks(8250), new DateTime(2024, 12, 17, 12, 17, 10, 985, DateTimeKind.Local).AddTicks(8251) });

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 12, 17, 10, 985, DateTimeKind.Local).AddTicks(8254), new DateTime(2024, 12, 17, 12, 17, 10, 985, DateTimeKind.Local).AddTicks(8255) });

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 12, 17, 10, 985, DateTimeKind.Local).AddTicks(8257), new DateTime(2024, 12, 17, 12, 17, 10, 985, DateTimeKind.Local).AddTicks(8258) });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 12, 17, 10, 985, DateTimeKind.Local).AddTicks(8102), new DateTime(2024, 12, 17, 12, 17, 10, 985, DateTimeKind.Local).AddTicks(8103) });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 12, 17, 10, 985, DateTimeKind.Local).AddTicks(8105), new DateTime(2024, 12, 17, 12, 17, 10, 985, DateTimeKind.Local).AddTicks(8106) });
        }
    }
}
