using HospitalManager.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace HospitalManager.API.DbContexts;

public class ApiDbContext : DbContext
{
    public DbSet<Address> Addresses { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Examination> Examinations { get; set; }
    public DbSet<Insurance> Insurances { get; set; }
    public DbSet<Invitation> Invitations { get; set; }
    public DbSet<Medicine> Medicines { get; set; }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Person> Persons { get; set; }
    public DbSet<Recipe> Recipes { get; set; }
    public DbSet<User> Users { get; set; }
    
    public DbSet<MedicineImport> MedicineImports { get; set; }
    
    public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options){}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>()
            .HasIndex(u => u.Email)
            .IsUnique();

        modelBuilder.Entity<Person>().HasData(
            new Person()
            {
                BirthNumber = "012345/1234",
                FirstName = "Doktor",
                LastName = "Test",
                Email = "doktorTest@gmail.com",
                Telephone = "+421123456785",
                Address = null,
                User = null,
            },
            new Person()
            {
                BirthNumber = "012345/1235",
                FirstName = "Pacient",
                LastName = "test",
                Email = "pacientTest@gmail.com",
                Telephone = "+421987654321",
                Address = null,
                User = null,
            },
            new Person()
            {
                BirthNumber = "012345/1265",
                FirstName = "Peter",
                LastName = "Petrový",
                Email = "peter@gmail.com",
                Telephone = "+421987654321",
                Address = null,
                User = null,
            },
            new Person()
            {
                BirthNumber = "012345/1214",
                FirstName = "Marek",
                LastName = "Marekovy",
                Email = "marek@gmail.com",
                Telephone = "+421987654321",
                Address = null,
                User = null,
            }
        );

        modelBuilder.Entity<Doctor>().HasData(
            new Doctor()
            {
                Id = 1,
                BirthNumber = "012345/1234",
                Specialization = "Všeobecný lekár",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            },
            new Doctor()
            {
                Id = 2,
                BirthNumber = "012345/1265",
                Specialization = "Všeobecný lekár",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            }
        );
        
        modelBuilder.Entity<Patient>().HasData(
            new Patient()
            {
                Id = 1,
                DoctorId = 1,
                BirthNumber = "012345/1235",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            },
            new Patient()
            {
                Id = 2,
                DoctorId = 2,
                BirthNumber = "012345/1214",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            }
        );

        modelBuilder.Entity<Examination>().HasData(
            new Examination()
            {
                Id = 1,
                DoctorId = 1,
                PatientId = 1,
                ExaminationDate = DateTime.Now.AddMonths(-1),
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            },
            new Examination()
            {
                Id = 2,
                DoctorId = 1,
                PatientId = 1,
                ExaminationDate = DateTime.Now.AddMonths(2),
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            }
        );
        
        modelBuilder.Entity<Medicine>().HasData(
            new Medicine() {
                Id = 1,
                Name = "0,9 % Chlorid sodný Baxter-Viaflo",
                Description = "Sterilný roztok chloridu sodného (NaCl) určený na intravenózne podávanie. Používa sa na rehydratáciu organizmu, doplnenie elektrolytov a ako nosič pre iné lieky pri intravenóznej infúzii",
                Dosage = "100 ml",
                Quantity = "1000 ml",
                SideEffects = "Nerovnováha elektrolytov, preťaženie tekutinami, zvýšená hladina chloridov v krvi",
                Price = 6.79m,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            },
            new Medicine() {
                Id = 2,
                Name = "Abaktal 400 mg",
                Description = "Liečba rôznych bakteriálnych infekcií",
                Dosage = "800 mg",
                Quantity = "10 tabliet",
                SideEffects = "Hnačka, nevolnosť, vracanie",
                Price = 6.40m,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            },
            new Medicine { 
                Id = 3,
                Name = "Ibuprofen",
                Price = 6.25m,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            }
        );
        
        modelBuilder.Entity<Recipe>().HasData(
            new Recipe
            {
                Id = 1,
                Expiration = DateTime.Now.AddMonths(1),
                Used = 0,
                ExaminationId = 1,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            },
            new Recipe { 
                Id = 2,
                Expiration = DateTime.Now.AddMonths(2),
                Used = 1,
                ExaminationId = 2,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            }
        );

        modelBuilder.Entity<Recipe>()
            .HasMany(r => r.Medicines)
            .WithMany(m => m.Recipes)
            .UsingEntity(j => j.HasData(
                new { RecipesId = 1, MedicinesId = 1 },
                new { RecipesId = 1, MedicinesId = 2 },
                new { RecipesId = 2, MedicinesId = 2 },
                new { RecipesId = 2, MedicinesId = 3 }
            ));

        modelBuilder.Entity<Insurance>().HasData(
            new Insurance()
            {
                Code = 27,
                FullName = "Union zdravotná poisťovňa, a.s.",
                Abbreviation = "UNION"
            },
            new Insurance()
            {
                Code = 24,
                FullName = "Dôvera zdravotná poisťovňa, a.s.",
                Abbreviation = "Dôvera"
            },
            new Insurance()
            {
                Code = 25,
                FullName = "Všeobecná zdravotná poisťovňa, a.s.",
                Abbreviation = "VZP"
            }
        );
        
        base.OnModelCreating(modelBuilder);
    }
}