using HospitalManager.API.DbContexts;
using HospitalManager.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace HospitalManager.API.Repositories
{
    public class PatientRepository : IPatientRepository
    {
        private readonly ApiDbContext context;

        public PatientRepository(ApiDbContext context)
        { 
            this.context = context;
        }

        public async Task Add(Patient patient)
        {
            await this.context.Patients.AddAsync(patient);
            await this.context.SaveChangesAsync();
        }

        public async Task<Patient> GetById(int id)
        {
            return await this.context.Patients.FindAsync(id);
        }

        public async Task Update(Patient patient)
        {
            this.context.Patients.Update(patient);
            await this.context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Patient>> GetAll()
        {
            return await this.context.Patients.ToListAsync();
        }

        public async Task Delete(Patient patient)
        {
            this.context.Patients.Remove(patient);
            await this.context.SaveChangesAsync();
        }
    }
}