using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalManager.API.Migrations
{
    /// <inheritdoc />
    public partial class ExaminationRecipeRemoved : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Examination_Recipe_RecipeId",
                table: "Examination");

            migrationBuilder.DropIndex(
                name: "IX_Examination_RecipeId",
                table: "Examination");

            migrationBuilder.DropColumn(
                name: "RecipeId",
                table: "Examination");

            migrationBuilder.AddColumn<int>(
                name: "ExaminationId",
                table: "Recipe",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Doctor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 22, 17, 56, 52, DateTimeKind.Local).AddTicks(4407), new DateTime(2024, 12, 16, 22, 17, 56, 52, DateTimeKind.Local).AddTicks(4409) });

            migrationBuilder.UpdateData(
                table: "Doctor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 22, 17, 56, 52, DateTimeKind.Local).AddTicks(4451), new DateTime(2024, 12, 16, 22, 17, 56, 52, DateTimeKind.Local).AddTicks(4452) });

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 22, 17, 56, 52, DateTimeKind.Local).AddTicks(4544), new DateTime(2024, 12, 16, 22, 17, 56, 52, DateTimeKind.Local).AddTicks(4544) });

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 22, 17, 56, 52, DateTimeKind.Local).AddTicks(4548), new DateTime(2024, 12, 16, 22, 17, 56, 52, DateTimeKind.Local).AddTicks(4549) });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 22, 17, 56, 52, DateTimeKind.Local).AddTicks(4499), new DateTime(2024, 12, 16, 22, 17, 56, 52, DateTimeKind.Local).AddTicks(4500) });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 22, 17, 56, 52, DateTimeKind.Local).AddTicks(4502), new DateTime(2024, 12, 16, 22, 17, 56, 52, DateTimeKind.Local).AddTicks(4503) });

            migrationBuilder.CreateIndex(
                name: "IX_Recipe_ExaminationId",
                table: "Recipe",
                column: "ExaminationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipe_Examination_ExaminationId",
                table: "Recipe",
                column: "ExaminationId",
                principalTable: "Examination",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipe_Examination_ExaminationId",
                table: "Recipe");

            migrationBuilder.DropIndex(
                name: "IX_Recipe_ExaminationId",
                table: "Recipe");

            migrationBuilder.DropColumn(
                name: "ExaminationId",
                table: "Recipe");

            migrationBuilder.AddColumn<int>(
                name: "RecipeId",
                table: "Examination",
                type: "NUMBER(10)",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Examination_RecipeId",
                table: "Examination",
                column: "RecipeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Examination_Recipe_RecipeId",
                table: "Examination",
                column: "RecipeId",
                principalTable: "Recipe",
                principalColumn: "Id");
        }
    }
}
