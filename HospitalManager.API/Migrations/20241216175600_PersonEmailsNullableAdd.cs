using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalManager.API.Migrations
{
    /// <inheritdoc />
    public partial class PersonEmailsNullableAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Person_User_UserId",
                table: "Person");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Person",
                type: "NUMBER(10)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Person",
                type: "NVARCHAR2(254)",
                maxLength: 254,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(254)",
                oldMaxLength: 254);

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
                name: "FK_Person_User_UserId",
                table: "Person",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Person_User_UserId",
                table: "Person");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Person",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Person",
                type: "NVARCHAR2(254)",
                maxLength: 254,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(254)",
                oldMaxLength: 254,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 17, 47, 58, 524, DateTimeKind.Local).AddTicks(6859), new DateTime(2024, 12, 16, 17, 47, 58, 524, DateTimeKind.Local).AddTicks(6860) });

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 17, 47, 58, 524, DateTimeKind.Local).AddTicks(6864), new DateTime(2024, 12, 16, 17, 47, 58, 524, DateTimeKind.Local).AddTicks(6865) });

            migrationBuilder.AddForeignKey(
                name: "FK_Person_User_UserId",
                table: "Person",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
