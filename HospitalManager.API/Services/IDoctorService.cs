using HospitalManager.Shared.Models;
using HospitalManager.Shared.Service;
using Microsoft.AspNetCore.JsonPatch;

namespace HospitalManager.API.Services;

public interface IDoctorService
{
    Task<ServiceResponse<IEnumerable<DoctorDTO>>> GetDoctors();
    Task<ServiceResponse<DoctorDTO>> GetDoctor(int id, bool expandPerson);
    Task<ServiceResponse<DoctorDTO>> UpdateDoctor(int doctorId, JsonPatchDocument<DoctorForUpdateDTO> patchDoctor);
    Task<ServiceResponse> DeleteDoctor(int id);
}