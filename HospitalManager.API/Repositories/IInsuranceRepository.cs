using HospitalManager.API.DbContexts;
using HospitalManager.API.Entities;

namespace HospitalManager.API.Repositories
{
    public interface IInsuranceRepository
    {
        Task<Insurance> GetById(int id);
        Task<IEnumerable<Insurance>> GetAll();
        Task Add(Insurance insurance);
    }
}
