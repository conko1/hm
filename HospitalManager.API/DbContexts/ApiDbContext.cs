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
}