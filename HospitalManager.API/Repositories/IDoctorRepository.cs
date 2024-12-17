using HospitalManager.API.Entities;

namespace HospitalManager.API.Repositories;

public interface IDoctorRepository
{
    Task<IEnumerable<Doctor>> GetAllDoctors();
    Task<IEnumerable<Doctor>> GetDoctorsForPatient(string subjectId);
    Task<Doctor?> GetDoctorById(int id);
    Task<Doctor?> GetDoctorWithPatients(int id);
    Task<Doctor?> GetDoctorWithPerson(int id);
    Task<Doctor?> GetDoctorByUserId(int id);
    Task CreateDoctor(Doctor doctor);
    Task DeleteDoctor(int id);
    Task<bool> DoctorExists(int id);
    Task SaveChanges();
}