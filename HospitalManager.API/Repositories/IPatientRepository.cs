using HospitalManager.API.Entities;

namespace HospitalManager.API.Repositories
{
    public interface IPatientRepository
    {
        Patient GetById(int id);
        void Add(Patient patient);
        void Update(Patient patient);
        void Delete(Patient patient);
    }
}
