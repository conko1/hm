using HospitalManager.API.Entities;
using HospitalManager.Shared.Models;
using HospitalManager.Shared.Service;
using Microsoft.AspNetCore.JsonPatch;

namespace HospitalManager.API.Services;

public interface IExaminationService
{
    Task<ServiceResponse<IEnumerable<ExaminationDTO>>> GetExaminations();
    Task<ServiceResponse<ExaminationDTO>> GetExamination(int id);
    Task<ServiceResponse<ExaminationDTO>> UpdateExamination(int id,
        JsonPatchDocument<ExaminationForUpdateDTO> patchDocument);
    Task<ServiceResponse<ExaminationDTO>> AddExamination(ExaminationForCreateDTO createExamination);
    Task<ServiceResponse> DeleteExamination(int id);
}