
using HospitalManager.API.Dtos;
using HospitalManager.API.Entities;
using HospitalManager.API.Repositories;

namespace HospitalManager.API.Services
{
    public interface IPatientService
    {
        Task<Patient> GetById(int id);
        Task<IEnumerable<Patient>> GetAll();
        Task Add(int id);
        Task Update(PatientDto patientDto);
        Task Delete(int id);
    }
}
