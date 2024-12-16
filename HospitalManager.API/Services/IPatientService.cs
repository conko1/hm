using HospitalManager.API.Entities;
using HospitalManager.API.Repositories;
using HospitalManager.Shared.Models;

namespace HospitalManager.API.Services
{
    public interface IPatientService
    {
        Task<PatientDTO> GetById(int id);
        Task<IEnumerable<PatientDTO>> GetAll();
        Task Add(RegisterPatientDTO patientDto);
        Task Update(PatientDTO patientDto);
        Task Delete(int id);
    }
}
