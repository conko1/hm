using System.Runtime.InteropServices.ComTypes;
using HospitalManager.API.DbContexts;
using HospitalManager.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace HospitalManager.API.Repositories;

public class DoctorRepository : IDoctorRepository
{
    private readonly ApiDbContext _context;

    public DoctorRepository(ApiDbContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<Doctor>> GetAllDoctors()
    {
        var doctors = await _context.Doctors
            .Include(d => d.Person)
            .ToListAsync();
        return doctors;
    }

    public async Task<IEnumerable<Doctor>> GetDoctorsForPatient(string subjectId)
    {
        var doctors = await _context.Doctors
            .Include(d => d.Person)
            .Include(d => d.Patients)
            .Where(d => d.Patients.Any(p => p.Person.User.SubjectId == subjectId))
            .ToListAsync();
        
        return doctors;
    }
    
    public async Task<Doctor?> GetDoctorById(int id)
    {
        var doctor = await _context.Doctors
            .Where(d => d.Id == id)
            .FirstOrDefaultAsync();
        return doctor;
    }

    public async Task<Doctor?> GetDoctorWithPatients(int id)
    {
        var doctor = await _context.Doctors
            .Include(d => d.Patients)
            .Where(d => d.Id == id)
            .FirstOrDefaultAsync();
        return doctor;
    }
    
    public async Task<Doctor?> GetDoctorWithPerson(int id)
    {
        var doctor = await _context.Doctors
            .Include(d => d.Person)
            .Where(d => d.Id == id)
            .FirstOrDefaultAsync();
        return doctor;
    }

    public async Task<Doctor?> GetDoctorByUserId(int id)
    {
        var doctor = await _context.Doctors
            .Include(d => d.Person)
            .ThenInclude(p => p.User)
            .FirstOrDefaultAsync(d => d.Person.User.Id == id);
        return doctor;
    }
    
    public async Task CreateDoctor(Doctor doctor)
    {
        await _context.Doctors.AddAsync(doctor);
    }

    public async Task DeleteDoctor(int id)
    {
        var doctor = await _context.Doctors.Where(d => d.Id == id).FirstOrDefaultAsync();
        _context.Doctors.Remove(doctor);
    }

    public async Task<bool> DoctorExists(int id)
    {
        var doctor = await GetDoctorById(id);
        return doctor != null;
    }
    
    public async Task SaveChanges()
    {
        await _context.SaveChangesAsync();
    }
}