using HospitalManager.API.DbContexts;
using HospitalManager.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace HospitalManager.API.Repositories
{
    public class PatientRepository : IPatientRepository
    {
        private readonly ApiDbContext _context;

        public PatientRepository(ApiDbContext context)
        { 
            this._context = context;
        }

        public async Task Add(Patient patient)
        {
            await this._context.Patients.AddAsync(patient);
            await this._context.SaveChangesAsync();
        }

        public async Task<Patient> GetById(int id)
        {
            return await this._context.Patients.FindAsync(id);
        }

        public async Task Update(Patient patient)
        {
            this._context.Patients.Update(patient);
            await this._context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Patient>> GetAll()
        {
            return await this._context.Patients.ToListAsync();
        }

        public async Task Delete(Patient patient)
        {
            this._context.Patients.Remove(patient);
            await this._context.SaveChangesAsync();
        }
    }
}