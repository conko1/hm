﻿// <auto-generated />
using System;
using HospitalManager.API.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace HospitalManager.API.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    [Migration("20241216174519_AddSubjectIdNullableUser")]
    partial class AddSubjectIdNullableUser
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HospitalManager.API.Entities.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)");

                    b.Property<int>("PostalCode")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)");

                    b.Property<int>("StreetNumber")
                        .HasColumnType("NUMBER(10)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TIMESTAMP(7)");

                    b.HasKey("Id");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("HospitalManager.API.Entities.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BirthNumber")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TIMESTAMP(7)");

                    b.HasKey("Id");

                    b.HasIndex("BirthNumber");

                    b.ToTable("Doctor");
                });

            modelBuilder.Entity("HospitalManager.API.Entities.Examination", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("Diagnosis")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("DoctorId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<DateTime>("ExaminationDate")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("PatientId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int?>("RecipeId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Symptoms")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Treatment")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TIMESTAMP(7)");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.HasIndex("RecipeId");

                    b.ToTable("Examination");
                });

            modelBuilder.Entity("HospitalManager.API.Entities.Insurance", b =>
                {
                    b.Property<int>("Code")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Code"));

                    b.Property<string>("Abbreviation")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("NVARCHAR2(10)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)");

                    b.HasKey("Code");

                    b.ToTable("Insurance");
                });

            modelBuilder.Entity("HospitalManager.API.Entities.Invitation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("JwtToken")
                        .IsRequired()
                        .HasMaxLength(2048)
                        .HasColumnType("NCLOB");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<bool>("Used")
                        .HasColumnType("NUMBER(1)");

                    b.Property<int>("UserId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Invitation");
                });

            modelBuilder.Entity("HospitalManager.API.Entities.Medicine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Dosage")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Quantity")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("SideEffects")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TIMESTAMP(7)");

                    b.HasKey("Id");

                    b.ToTable("Medicine");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 12, 16, 17, 45, 18, 344, DateTimeKind.Local).AddTicks(5488),
                            Description = "Sterilný roztok chloridu sodného (NaCl) určený na intravenózne podávanie. Používa sa na rehydratáciu organizmu, doplnenie elektrolytov a ako nosič pre iné lieky pri intravenóznej infúzii",
                            Dosage = "100 ml",
                            Name = "0,9 % Chlorid sodný Baxter-Viaflo",
                            Price = 6.79m,
                            Quantity = "1000 ml",
                            SideEffects = "Nerovnováha elektrolytov, preťaženie tekutinami, zvýšená hladina chloridov v krvi",
                            UpdatedAt = new DateTime(2024, 12, 16, 17, 45, 18, 344, DateTimeKind.Local).AddTicks(5489)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 12, 16, 17, 45, 18, 344, DateTimeKind.Local).AddTicks(5493),
                            Description = "Liečba rôznych bakteriálnych infekcií",
                            Dosage = "800 mg",
                            Name = "Abaktal 400 mg",
                            Price = 6.40m,
                            Quantity = "10 tabliet",
                            SideEffects = "Hnačka, nevolnosť, vracanie",
                            UpdatedAt = new DateTime(2024, 12, 16, 17, 45, 18, 344, DateTimeKind.Local).AddTicks(5493)
                        });
                });

            modelBuilder.Entity("HospitalManager.API.Entities.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Allergies")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("BirthNumber")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("BloodGroup")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<int?>("DoctorId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Medications")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("Vaccines")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("insuranceCode")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("Id");

                    b.HasIndex("BirthNumber");

                    b.HasIndex("DoctorId");

                    b.HasIndex("insuranceCode");

                    b.ToTable("Patient");
                });

            modelBuilder.Entity("HospitalManager.API.Entities.Person", b =>
                {
                    b.Property<string>("BirthNumber")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<int?>("AddressId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(254)
                        .HasColumnType("NVARCHAR2(254)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)");

                    b.Property<string>("Telephone")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("UserId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("BirthNumber");

                    b.HasIndex("AddressId");

                    b.HasIndex("UserId");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("HospitalManager.API.Entities.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<int>("DoctorId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<DateTime>("Expiration")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<int>("PatientId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<bool>("Used")
                        .HasColumnType("NUMBER(1)");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.ToTable("Recipe");
                });

            modelBuilder.Entity("HospitalManager.API.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(254)
                        .HasColumnType("NVARCHAR2(254)");

                    b.Property<string>("SubjectId")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TIMESTAMP(7)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("MedicineRecipe", b =>
                {
                    b.Property<int>("MedicinesId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("RecipesId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("MedicinesId", "RecipesId");

                    b.HasIndex("RecipesId");

                    b.ToTable("MedicineRecipe");
                });

            modelBuilder.Entity("HospitalManager.API.Entities.Doctor", b =>
                {
                    b.HasOne("HospitalManager.API.Entities.Person", "Person")
                        .WithMany()
                        .HasForeignKey("BirthNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("HospitalManager.API.Entities.Examination", b =>
                {
                    b.HasOne("HospitalManager.API.Entities.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HospitalManager.API.Entities.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HospitalManager.API.Entities.Recipe", "Recipe")
                        .WithMany()
                        .HasForeignKey("RecipeId");

                    b.Navigation("Doctor");

                    b.Navigation("Patient");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("HospitalManager.API.Entities.Invitation", b =>
                {
                    b.HasOne("HospitalManager.API.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("HospitalManager.API.Entities.Patient", b =>
                {
                    b.HasOne("HospitalManager.API.Entities.Person", "Person")
                        .WithMany()
                        .HasForeignKey("BirthNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HospitalManager.API.Entities.Doctor", null)
                        .WithMany("Patients")
                        .HasForeignKey("DoctorId");

                    b.HasOne("HospitalManager.API.Entities.Insurance", "insurance")
                        .WithMany()
                        .HasForeignKey("insuranceCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");

                    b.Navigation("insurance");
                });

            modelBuilder.Entity("HospitalManager.API.Entities.Person", b =>
                {
                    b.HasOne("HospitalManager.API.Entities.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.HasOne("HospitalManager.API.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("User");
                });

            modelBuilder.Entity("HospitalManager.API.Entities.Recipe", b =>
                {
                    b.HasOne("HospitalManager.API.Entities.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HospitalManager.API.Entities.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("MedicineRecipe", b =>
                {
                    b.HasOne("HospitalManager.API.Entities.Medicine", null)
                        .WithMany()
                        .HasForeignKey("MedicinesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HospitalManager.API.Entities.Recipe", null)
                        .WithMany()
                        .HasForeignKey("RecipesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HospitalManager.API.Entities.Doctor", b =>
                {
                    b.Navigation("Patients");
                });
#pragma warning restore 612, 618
        }
    }
}