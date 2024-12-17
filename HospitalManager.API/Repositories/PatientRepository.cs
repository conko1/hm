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

        public async Task<Patient> GetByBirthNumber(string birthNumber)
        {
            var person = await _context.Patients.FirstOrDefaultAsync(p => p.BirthNumber == birthNumber);
            return person;
        }

        public async Task<bool> PatientExists(int id)
        {
            var patient = await GetById(id);
            return patient != null;
        }

        public async Task<Patient?> GetPatientWithPerson(int id)
        {
            var patient = await _context.Patients
                .Include(p => p.Person)
                .Where(p => p.Id == id)
                .FirstOrDefaultAsync();
            return patient;
        }

        public async Task<IEnumerable<Patient>> GetAllWithPerson()
        {
            return await this._context.Patients.Include(p => p.Person).ToListAsync();
        }
    }
}