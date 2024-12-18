using HospitalManager.Shared.Models;

namespace HospitalManager.API.Services
{
    public interface IInsuranceService
    {
        Task<InsuranceDTO> GetById(int id);
        Task<IEnumerable<InsuranceDTO>> GetAll();
    }
}
