using HospitalManager.API.Entities;

namespace HospitalManager.API.Repositories;

public interface IDoctorRepository
{
    Task<IEnumerable<Doctor>> GetAllDoctors();
    Task<Doctor?> GetDoctorById(int id);
    Task<Doctor?> GetDoctorWithPatients(int id);
    Task CreateDoctor(Doctor doctor);
    Task DeleteDoctor(int id);
    Task SaveChanges();
}