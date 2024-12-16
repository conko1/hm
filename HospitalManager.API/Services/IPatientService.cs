
using HospitalManager.API.Dtos;
using HospitalManager.API.Entities;
using HospitalManager.API.Repositories;

namespace HospitalManager.API.Services
{
    public interface IPatientService
    {
        Task<PatientDTO> GetById(int id);
        Task<IEnumerable<PatientDTO>> GetAll();
        Task Add(PatientDTO patientDto);
        Task Update(PatientDTO patientDto);
        Task Delete(int id);
    }
}
