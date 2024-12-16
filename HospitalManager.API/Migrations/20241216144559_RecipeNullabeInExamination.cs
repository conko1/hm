using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalManager.API.Migrations
{
    /// <inheritdoc />
    public partial class RecipeNullabeInExamination : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Examination_Recipe_RecipeId",
                table: "Examination");

            migrationBuilder.AlterColumn<int>(
                name: "RecipeId",
                table: "Examination",
                type: "NUMBER(10)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)");

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 14, 45, 59, 115, DateTimeKind.Local).AddTicks(8996), new DateTime(2024, 12, 16, 14, 45, 59, 115, DateTimeKind.Local).AddTicks(8997) });

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 14, 45, 59, 115, DateTimeKind.Local).AddTicks(9001), new DateTime(2024, 12, 16, 14, 45, 59, 115, DateTimeKind.Local).AddTicks(9002) });

            migrationBuilder.AddForeignKey(
                name: "FK_Examination_Recipe_RecipeId",
                table: "Examination",
                column: "RecipeId",
                principalTable: "Recipe",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Examination_Recipe_RecipeId",
                table: "Examination");

            migrationBuilder.AlterColumn<int>(
                name: "RecipeId",
                table: "Examination",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 14, 42, 32, 550, DateTimeKind.Local).AddTicks(13), new DateTime(2024, 12, 16, 14, 42, 32, 550, DateTimeKind.Local).AddTicks(14) });

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 14, 42, 32, 550, DateTimeKind.Local).AddTicks(19), new DateTime(2024, 12, 16, 14, 42, 32, 550, DateTimeKind.Local).AddTicks(20) });

            migrationBuilder.AddForeignKey(
                name: "FK_Examination_Recipe_RecipeId",
                table: "Examination",
                column: "RecipeId",
                principalTable: "Recipe",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
