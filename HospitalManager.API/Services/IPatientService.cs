using HospitalManager.API.Entities;
using HospitalManager.API.Repositories;
using HospitalManager.Shared.Models;

namespace HospitalManager.API.Services
{
    public interface IPatientService
    {
        Task<PatientDTO> GetById(int id, bool expandPerson);
        Task<IEnumerable<PatientDTO>> GetAll(bool expandPerson);
        Task Add(RegisterPatientDTO patientDto);
        Task<PatientDTO> Update(int id, PatientForUpdateDTO patientDto);
        Task Delete(int id);
    }
}
