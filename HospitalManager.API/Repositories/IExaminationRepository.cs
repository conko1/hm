using HospitalManager.API.Entities;

namespace HospitalManager.API.Repositories;

public interface IExaminationRepository
{
    Task<IEnumerable<Examination>> GetAllExaminations();
    Task<Examination?> GetExaminationById(int id);
    Task<Examination?> AddExamination(Examination examination);
    Task DeleteExamination(Examination examination);
    Task SaveChanges();
}