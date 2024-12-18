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
    [Migration("20241217235542_UpdatedUserSeed")]
    partial class UpdatedUserSeed
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

                    b.Property<string>("Specialization")
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TIMESTAMP(7)");

                    b.HasKey("Id");

                    b.HasIndex("BirthNumber");

                    b.ToTable("Doctor");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthNumber = "012345/1234",
                            CreatedAt = new DateTime(2024, 12, 17, 23, 55, 41, 565, DateTimeKind.Local).AddTicks(5356),
                            Specialization = "Všeobecný lekár",
                            UpdatedAt = new DateTime(2024, 12, 17, 23, 55, 41, 565, DateTimeKind.Local).AddTicks(5357)
                        },
                        new
                        {
                            Id = 2,
                            BirthNumber = "012345/1265",
                            CreatedAt = new DateTime(2024, 12, 17, 23, 55, 41, 565, DateTimeKind.Local).AddTicks(5360),
                            Specialization = "Všeobecný lekár",
                            UpdatedAt = new DateTime(2024, 12, 17, 23, 55, 41, 565, DateTimeKind.Local).AddTicks(5361)
                        });
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
                        .HasMaxLength(2000)
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("DoctorId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<DateTime>("ExaminationDate")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("Notes")
                        .HasMaxLength(2000)
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("PatientId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Symptoms")
                        .HasMaxLength(2000)
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Treatment")
                        .HasMaxLength(2000)
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TIMESTAMP(7)");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.ToTable("Examination");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 12, 17, 23, 55, 41, 565, DateTimeKind.Local).AddTicks(5463),
                            DoctorId = 1,
                            ExaminationDate = new DateTime(2024, 11, 17, 23, 55, 41, 565, DateTimeKind.Local).AddTicks(5454),
                            PatientId = 1,
                            UpdatedAt = new DateTime(2024, 12, 17, 23, 55, 41, 565, DateTimeKind.Local).AddTicks(5463)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 12, 17, 23, 55, 41, 565, DateTimeKind.Local).AddTicks(5468),
                            DoctorId = 1,
                            ExaminationDate = new DateTime(2025, 2, 17, 23, 55, 41, 565, DateTimeKind.Local).AddTicks(5466),
                            PatientId = 1,
                            UpdatedAt = new DateTime(2024, 12, 17, 23, 55, 41, 565, DateTimeKind.Local).AddTicks(5469)
                        });
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

                    b.HasData(
                        new
                        {
                            Code = 27,
                            Abbreviation = "UNION",
                            FullName = "Union zdravotná poisťovňa, a.s."
                        },
                        new
                        {
                            Code = 24,
                            Abbreviation = "Dôvera",
                            FullName = "Dôvera zdravotná poisťovňa, a.s."
                        },
                        new
                        {
                            Code = 25,
                            Abbreviation = "VZP",
                            FullName = "Všeobecná zdravotná poisťovňa, a.s."
                        });
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
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Dosage")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Quantity")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("SideEffects")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TIMESTAMP(7)");

                    b.HasKey("Id");

                    b.ToTable("Medicine");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 12, 17, 23, 55, 41, 565, DateTimeKind.Local).AddTicks(5510),
                            Description = "Sterilný roztok chloridu sodného (NaCl) určený na intravenózne podávanie. Používa sa na rehydratáciu organizmu, doplnenie elektrolytov a ako nosič pre iné lieky pri intravenóznej infúzii",
                            Dosage = "100 ml",
                            Name = "0,9 % Chlorid sodný Baxter-Viaflo",
                            Price = 6.79m,
                            Quantity = "1000 ml",
                            SideEffects = "Nerovnováha elektrolytov, preťaženie tekutinami, zvýšená hladina chloridov v krvi",
                            UpdatedAt = new DateTime(2024, 12, 17, 23, 55, 41, 565, DateTimeKind.Local).AddTicks(5510)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 12, 17, 23, 55, 41, 565, DateTimeKind.Local).AddTicks(5515),
                            Description = "Liečba rôznych bakteriálnych infekcií",
                            Dosage = "800 mg",
                            Name = "Abaktal 400 mg",
                            Price = 6.40m,
                            Quantity = "10 tabliet",
                            SideEffects = "Hnačka, nevolnosť, vracanie",
                            UpdatedAt = new DateTime(2024, 12, 17, 23, 55, 41, 565, DateTimeKind.Local).AddTicks(5515)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 12, 17, 23, 55, 41, 565, DateTimeKind.Local).AddTicks(5518),
                            Name = "Ibuprofen",
                            Price = 6.25m,
                            UpdatedAt = new DateTime(2024, 12, 17, 23, 55, 41, 565, DateTimeKind.Local).AddTicks(5519)
                        });
                });

            modelBuilder.Entity("HospitalManager.API.Entities.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Allergies")
                        .HasMaxLength(2000)
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("BirthNumber")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("BloodGroup")
                        .HasMaxLength(2000)
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<int>("DoctorId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int?>("InsuranceCode")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Medications")
                        .HasMaxLength(2000)
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("Vaccines")
                        .HasMaxLength(2000)
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("Id");

                    b.HasIndex("BirthNumber");

                    b.HasIndex("DoctorId");

                    b.HasIndex("InsuranceCode");

                    b.ToTable("Patient");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthNumber = "012345/1235",
                            CreatedAt = new DateTime(2024, 12, 17, 23, 55, 41, 565, DateTimeKind.Local).AddTicks(5407),
                            DoctorId = 1,
                            UpdatedAt = new DateTime(2024, 12, 17, 23, 55, 41, 565, DateTimeKind.Local).AddTicks(5408)
                        },
                        new
                        {
                            Id = 2,
                            BirthNumber = "012345/1214",
                            CreatedAt = new DateTime(2024, 12, 17, 23, 55, 41, 565, DateTimeKind.Local).AddTicks(5411),
                            DoctorId = 2,
                            UpdatedAt = new DateTime(2024, 12, 17, 23, 55, 41, 565, DateTimeKind.Local).AddTicks(5411)
                        });
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

                    b.Property<int?>("UserId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("BirthNumber");

                    b.HasIndex("AddressId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("Person");

                    b.HasData(
                        new
                        {
                            BirthNumber = "012345/1234",
                            Email = "doktorTest@gmail.com",
                            FirstName = "Doktor",
                            LastName = "Test",
                            Telephone = "+421123456785"
                        },
                        new
                        {
                            BirthNumber = "012345/1235",
                            Email = "pacientTest@gmail.com",
                            FirstName = "Pacient",
                            LastName = "test",
                            Telephone = "+421987654321"
                        },
                        new
                        {
                            BirthNumber = "012345/1265",
                            Email = "peter@gmail.com",
                            FirstName = "Peter",
                            LastName = "Petrový",
                            Telephone = "+421987654321"
                        },
                        new
                        {
                            BirthNumber = "012345/1214",
                            Email = "marek@gmail.com",
                            FirstName = "Marek",
                            LastName = "Marekovy",
                            Telephone = "+421987654321"
                        });
                });

            modelBuilder.Entity("HospitalManager.API.Entities.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<int>("ExaminationId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<DateTime>("Expiration")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<int>("Used")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("Id");

                    b.HasIndex("ExaminationId");

                    b.ToTable("Recipe");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 12, 17, 23, 55, 41, 565, DateTimeKind.Local).AddTicks(5568),
                            ExaminationId = 1,
                            Expiration = new DateTime(2025, 1, 17, 23, 55, 41, 565, DateTimeKind.Local).AddTicks(5565),
                            UpdatedAt = new DateTime(2024, 12, 17, 23, 55, 41, 565, DateTimeKind.Local).AddTicks(5569),
                            Used = 0
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 12, 17, 23, 55, 41, 565, DateTimeKind.Local).AddTicks(5573),
                            ExaminationId = 2,
                            Expiration = new DateTime(2025, 2, 17, 23, 55, 41, 565, DateTimeKind.Local).AddTicks(5572),
                            UpdatedAt = new DateTime(2024, 12, 17, 23, 55, 41, 565, DateTimeKind.Local).AddTicks(5574),
                            Used = 1
                        });
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

                    b.HasData(
                        new
                        {
                            MedicinesId = 1,
                            RecipesId = 1
                        },
                        new
                        {
                            MedicinesId = 2,
                            RecipesId = 1
                        },
                        new
                        {
                            MedicinesId = 2,
                            RecipesId = 2
                        },
                        new
                        {
                            MedicinesId = 3,
                            RecipesId = 2
                        });
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

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
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

                    b.HasOne("HospitalManager.API.Entities.Doctor", "Doctor")
                        .WithMany("Patients")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HospitalManager.API.Entities.Insurance", "Insurance")
                        .WithMany()
                        .HasForeignKey("InsuranceCode");

                    b.Navigation("Doctor");

                    b.Navigation("Insurance");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("HospitalManager.API.Entities.Person", b =>
                {
                    b.HasOne("HospitalManager.API.Entities.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.HasOne("HospitalManager.API.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Address");

                    b.Navigation("User");
                });

            modelBuilder.Entity("HospitalManager.API.Entities.Recipe", b =>
                {
                    b.HasOne("HospitalManager.API.Entities.Examination", "Examination")
                        .WithMany()
                        .HasForeignKey("ExaminationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Examination");
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
