using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalManager.API.Migrations
{
    /// <inheritdoc />
    public partial class AddressNullablePerson : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Person_Address_AddressId",
                table: "Person");

            migrationBuilder.AlterColumn<int>(
                name: "AddressId",
                table: "Person",
                type: "NUMBER(10)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)");

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 17, 41, 1, 914, DateTimeKind.Local).AddTicks(3460), new DateTime(2024, 12, 16, 17, 41, 1, 914, DateTimeKind.Local).AddTicks(3461) });

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 17, 41, 1, 914, DateTimeKind.Local).AddTicks(3465), new DateTime(2024, 12, 16, 17, 41, 1, 914, DateTimeKind.Local).AddTicks(3466) });

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Address_AddressId",
                table: "Person",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Person_Address_AddressId",
                table: "Person");

            migrationBuilder.AlterColumn<int>(
                name: "AddressId",
                table: "Person",
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
                values: new object[] { new DateTime(2024, 12, 16, 14, 45, 59, 115, DateTimeKind.Local).AddTicks(8996), new DateTime(2024, 12, 16, 14, 45, 59, 115, DateTimeKind.Local).AddTicks(8997) });

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 14, 45, 59, 115, DateTimeKind.Local).AddTicks(9001), new DateTime(2024, 12, 16, 14, 45, 59, 115, DateTimeKind.Local).AddTicks(9002) });

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Address_AddressId",
                table: "Person",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
