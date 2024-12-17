using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HospitalManager.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedRecipesChanged : Migration
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Doctor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 23, 21, 6, 250, DateTimeKind.Local).AddTicks(2398), new DateTime(2024, 12, 16, 23, 21, 6, 250, DateTimeKind.Local).AddTicks(2399) });

            migrationBuilder.UpdateData(
                table: "Doctor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 23, 21, 6, 250, DateTimeKind.Local).AddTicks(2401), new DateTime(2024, 12, 16, 23, 21, 6, 250, DateTimeKind.Local).AddTicks(2402) });

            migrationBuilder.UpdateData(
                table: "Examination",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ExaminationDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 23, 21, 6, 250, DateTimeKind.Local).AddTicks(2476), new DateTime(2024, 11, 16, 23, 21, 6, 250, DateTimeKind.Local).AddTicks(2468), new DateTime(2024, 12, 16, 23, 21, 6, 250, DateTimeKind.Local).AddTicks(2476) });

            migrationBuilder.UpdateData(
                table: "Examination",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ExaminationDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 23, 21, 6, 250, DateTimeKind.Local).AddTicks(2481), new DateTime(2025, 2, 16, 23, 21, 6, 250, DateTimeKind.Local).AddTicks(2478), new DateTime(2024, 12, 16, 23, 21, 6, 250, DateTimeKind.Local).AddTicks(2481) });

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 23, 21, 6, 250, DateTimeKind.Local).AddTicks(2513), new DateTime(2024, 12, 16, 23, 21, 6, 250, DateTimeKind.Local).AddTicks(2514) });

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 23, 21, 6, 250, DateTimeKind.Local).AddTicks(2517), new DateTime(2024, 12, 16, 23, 21, 6, 250, DateTimeKind.Local).AddTicks(2517) });

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 23, 21, 6, 250, DateTimeKind.Local).AddTicks(2519), new DateTime(2024, 12, 16, 23, 21, 6, 250, DateTimeKind.Local).AddTicks(3023) });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 23, 21, 6, 250, DateTimeKind.Local).AddTicks(2436), new DateTime(2024, 12, 16, 23, 21, 6, 250, DateTimeKind.Local).AddTicks(2437) });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 23, 21, 6, 250, DateTimeKind.Local).AddTicks(2439), new DateTime(2024, 12, 16, 23, 21, 6, 250, DateTimeKind.Local).AddTicks(2439) });

            migrationBuilder.InsertData(
                table: "Recipe",
                columns: new[] { "Id", "CreatedAt", "ExaminationId", "Expiration", "UpdatedAt", "Used" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 16, 23, 21, 6, 250, DateTimeKind.Local).AddTicks(4522), 1, new DateTime(2025, 1, 16, 23, 21, 6, 250, DateTimeKind.Local).AddTicks(4518), new DateTime(2024, 12, 16, 23, 21, 6, 250, DateTimeKind.Local).AddTicks(4523), 0 },
                    { 2, new DateTime(2024, 12, 16, 23, 21, 6, 250, DateTimeKind.Local).AddTicks(4527), 2, new DateTime(2025, 2, 16, 23, 21, 6, 250, DateTimeKind.Local).AddTicks(4526), new DateTime(2024, 12, 16, 23, 21, 6, 250, DateTimeKind.Local).AddTicks(4527), 1 }
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
