using HospitalManager.API.Entities;

namespace HospitalManager.API.Repositories
{
    public interface IPatientRepository
    {
        Task<Patient?> GetById(int? id);
        Task<IEnumerable<Patient>> GetAll();
        Task Add(Patient patient);
        Task Update(Patient patient);
        Task Delete(Patient patient);

        Task<Patient> GetByBirthNumber(string birthNumber);

        Task<bool> PatientExists(int id);

        Task<Patient?> GetPatientWithPerson(int id);

        Task<IEnumerable<Patient>> GetAllWithPerson();
    }
}
