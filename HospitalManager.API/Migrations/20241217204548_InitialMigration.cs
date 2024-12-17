using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HospitalManager.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    City = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    Region = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    District = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    Street = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    StreetNumber = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    PostalCode = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Insurance",
                columns: table => new
                {
                    Code = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Abbreviation = table.Column<string>(type: "NVARCHAR2(10)", maxLength: 10, nullable: false),
                    FullName = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Insurance", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "Medicine",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Name = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Description = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Dosage = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Quantity = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    SideEffects = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicine", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    SubjectId = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Email = table.Column<string>(type: "NVARCHAR2(254)", maxLength: 254, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Invitation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Used = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    JwtToken = table.Column<string>(type: "NCLOB", maxLength: 2048, nullable: false),
                    UserId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invitation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Invitation_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    BirthNumber = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    FirstName = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "NVARCHAR2(254)", maxLength: 254, nullable: false),
                    Telephone = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    AddressId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    UserId = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.BirthNumber);
                    table.ForeignKey(
                        name: "FK_Person_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Person_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Doctor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    BirthNumber = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    Specialization = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doctor_Person_BirthNumber",
                        column: x => x.BirthNumber,
                        principalTable: "Person",
                        principalColumn: "BirthNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    InsuranceCode = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    BirthNumber = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    Allergies = table.Column<string>(type: "NVARCHAR2(2000)", maxLength: 2000, nullable: true),
                    BloodGroup = table.Column<string>(type: "NVARCHAR2(2000)", maxLength: 2000, nullable: true),
                    Medications = table.Column<string>(type: "NVARCHAR2(2000)", maxLength: 2000, nullable: true),
                    Vaccines = table.Column<string>(type: "NVARCHAR2(2000)", maxLength: 2000, nullable: true),
                    DoctorId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patient_Doctor_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Patient_Insurance_InsuranceCode",
                        column: x => x.InsuranceCode,
                        principalTable: "Insurance",
                        principalColumn: "Code");
                    table.ForeignKey(
                        name: "FK_Patient_Person_BirthNumber",
                        column: x => x.BirthNumber,
                        principalTable: "Person",
                        principalColumn: "BirthNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Examination",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    DoctorId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    PatientId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    ExaminationDate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    Symptoms = table.Column<string>(type: "NVARCHAR2(2000)", maxLength: 2000, nullable: true),
                    Diagnosis = table.Column<string>(type: "NVARCHAR2(2000)", maxLength: 2000, nullable: true),
                    Treatment = table.Column<string>(type: "NVARCHAR2(2000)", maxLength: 2000, nullable: true),
                    Notes = table.Column<string>(type: "NVARCHAR2(2000)", maxLength: 2000, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Examination", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Examination_Doctor_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Examination_Patient_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Recipe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Expiration = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    ExaminationId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Used = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recipe_Examination_ExaminationId",
                        column: x => x.ExaminationId,
                        principalTable: "Examination",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicineRecipe",
                columns: table => new
                {
                    MedicinesId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    RecipesId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicineRecipe", x => new { x.MedicinesId, x.RecipesId });
                    table.ForeignKey(
                        name: "FK_MedicineRecipe_Medicine_MedicinesId",
                        column: x => x.MedicinesId,
                        principalTable: "Medicine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicineRecipe_Recipe_RecipesId",
                        column: x => x.RecipesId,
                        principalTable: "Recipe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Insurance",
                columns: new[] { "Code", "Abbreviation", "FullName" },
                values: new object[,]
                {
                    { 24, "Dôvera", "Dôvera zdravotná poisťovňa, a.s." },
                    { 25, "VZP", "Všeobecná zdravotná poisťovňa, a.s." },
                    { 27, "UNION", "Union zdravotná poisťovňa, a.s." }
                });

            migrationBuilder.InsertData(
                table: "Medicine",
                columns: new[] { "Id", "CreatedAt", "Description", "Dosage", "Name", "Price", "Quantity", "SideEffects", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 17, 20, 45, 47, 777, DateTimeKind.Local).AddTicks(5393), "Sterilný roztok chloridu sodného (NaCl) určený na intravenózne podávanie. Používa sa na rehydratáciu organizmu, doplnenie elektrolytov a ako nosič pre iné lieky pri intravenóznej infúzii", "100 ml", "0,9 % Chlorid sodný Baxter-Viaflo", 6.79m, "1000 ml", "Nerovnováha elektrolytov, preťaženie tekutinami, zvýšená hladina chloridov v krvi", new DateTime(2024, 12, 17, 20, 45, 47, 777, DateTimeKind.Local).AddTicks(5394) },
                    { 2, new DateTime(2024, 12, 17, 20, 45, 47, 777, DateTimeKind.Local).AddTicks(5590), "Liečba rôznych bakteriálnych infekcií", "800 mg", "Abaktal 400 mg", 6.40m, "10 tabliet", "Hnačka, nevolnosť, vracanie", new DateTime(2024, 12, 17, 20, 45, 47, 777, DateTimeKind.Local).AddTicks(5591) },
                    { 3, new DateTime(2024, 12, 17, 20, 45, 47, 777, DateTimeKind.Local).AddTicks(5594), null, null, "Ibuprofen", 6.25m, null, null, new DateTime(2024, 12, 17, 20, 45, 47, 777, DateTimeKind.Local).AddTicks(5595) }
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "BirthNumber", "AddressId", "Email", "FirstName", "LastName", "Telephone", "UserId" },
                values: new object[,]
                {
                    { "012345/1234", null, "doktorTest@gmail.com", "Doktor", "Test", "+421123456785", null },
                    { "012345/1235", null, "pacientTest@gmail.com", "Pacient", "test", "+421987654321", null }
                });

            migrationBuilder.InsertData(
                table: "Doctor",
                columns: new[] { "Id", "BirthNumber", "CreatedAt", "Specialization", "UpdatedAt" },
                values: new object[] { 1, "012345/1234", new DateTime(2024, 12, 17, 20, 45, 47, 777, DateTimeKind.Local).AddTicks(5269), "Všeobecný lekár", new DateTime(2024, 12, 17, 20, 45, 47, 777, DateTimeKind.Local).AddTicks(5270) });

            migrationBuilder.InsertData(
                table: "Patient",
                columns: new[] { "Id", "Allergies", "BirthNumber", "BloodGroup", "CreatedAt", "DoctorId", "InsuranceCode", "Medications", "UpdatedAt", "Vaccines" },
                values: new object[] { 1, null, "012345/1235", null, new DateTime(2024, 12, 17, 20, 45, 47, 777, DateTimeKind.Local).AddTicks(5307), 1, null, null, new DateTime(2024, 12, 17, 20, 45, 47, 777, DateTimeKind.Local).AddTicks(5308), null });

            migrationBuilder.InsertData(
                table: "Examination",
                columns: new[] { "Id", "CreatedAt", "Diagnosis", "DoctorId", "ExaminationDate", "Notes", "PatientId", "Symptoms", "Treatment", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 17, 20, 45, 47, 777, DateTimeKind.Local).AddTicks(5349), null, 1, new DateTime(2024, 11, 17, 20, 45, 47, 777, DateTimeKind.Local).AddTicks(5342), null, 1, null, null, new DateTime(2024, 12, 17, 20, 45, 47, 777, DateTimeKind.Local).AddTicks(5350) },
                    { 2, new DateTime(2024, 12, 17, 20, 45, 47, 777, DateTimeKind.Local).AddTicks(5354), null, 1, new DateTime(2025, 2, 17, 20, 45, 47, 777, DateTimeKind.Local).AddTicks(5352), null, 1, null, null, new DateTime(2024, 12, 17, 20, 45, 47, 777, DateTimeKind.Local).AddTicks(5355) }
                });

            migrationBuilder.InsertData(
                table: "Recipe",
                columns: new[] { "Id", "CreatedAt", "ExaminationId", "Expiration", "UpdatedAt", "Used" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 17, 20, 45, 47, 777, DateTimeKind.Local).AddTicks(5698), 1, new DateTime(2025, 1, 17, 20, 45, 47, 777, DateTimeKind.Local).AddTicks(5695), new DateTime(2024, 12, 17, 20, 45, 47, 777, DateTimeKind.Local).AddTicks(5699), 0 },
                    { 2, new DateTime(2024, 12, 17, 20, 45, 47, 777, DateTimeKind.Local).AddTicks(5702), 2, new DateTime(2025, 2, 17, 20, 45, 47, 777, DateTimeKind.Local).AddTicks(5701), new DateTime(2024, 12, 17, 20, 45, 47, 777, DateTimeKind.Local).AddTicks(5703), 1 }
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

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_BirthNumber",
                table: "Doctor",
                column: "BirthNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Examination_DoctorId",
                table: "Examination",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Examination_PatientId",
                table: "Examination",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Invitation_UserId",
                table: "Invitation",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicineRecipe_RecipesId",
                table: "MedicineRecipe",
                column: "RecipesId");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_BirthNumber",
                table: "Patient",
                column: "BirthNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_DoctorId",
                table: "Patient",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_InsuranceCode",
                table: "Patient",
                column: "InsuranceCode");

            migrationBuilder.CreateIndex(
                name: "IX_Person_AddressId",
                table: "Person",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_Email",
                table: "Person",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Person_UserId",
                table: "Person",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipe_ExaminationId",
                table: "Recipe",
                column: "ExaminationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Invitation");

            migrationBuilder.DropTable(
                name: "MedicineRecipe");

            migrationBuilder.DropTable(
                name: "Medicine");

            migrationBuilder.DropTable(
                name: "Recipe");

            migrationBuilder.DropTable(
                name: "Examination");

            migrationBuilder.DropTable(
                name: "Patient");

            migrationBuilder.DropTable(
                name: "Doctor");

            migrationBuilder.DropTable(
                name: "Insurance");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
