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
    
    public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options){}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>().HasData(
            new Person()
            {
                BirthNumber = "012345/1234",
                FirstName = "Peter",
                LastName = "Petrovič",
                Email = "peter@gmail.com",
                Telephone = "+421123456785",
                Address = null,
                User = null,
            },
            new Person()
            {
                BirthNumber = "012345/1235",
                FirstName = "Daniel",
                LastName = "Danielovič",
                Email = "daniel@gmail.com",
                Telephone = "+421987654321",
                Address = null,
                User = null,
            },
            new Person()
            {
                BirthNumber = "012345/1236",
                FirstName = "Martina",
                LastName = "Martinová",
                Email = "martina@gmail.com",
                Telephone = "+421976431285",
                Address = null,
                User = null,
            },
            new Person()
            {
                BirthNumber = "012345/1237",
                FirstName = "Frederika",
                LastName = "Frederiková",
                Email = "frederika@gmail.com",
                Telephone = "+421842862357",
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
                BirthNumber = "012345/1236",
                Specialization = "Detský lekár",
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
                BirthNumber = "012345/1237",
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
            }
        );
        
        base.OnModelCreating(modelBuilder);
    }
}