using HospitalManager.API.DbContexts;
using HospitalManager.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace HospitalManager.API.Repositories;

public class ExaminationRepository : IExaminationRepository
{
    private readonly ApiDbContext _context;

    public ExaminationRepository(ApiDbContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<Examination>> GetAllExaminations()
    {
        var examinations = await _context.Examinations.ToListAsync();
        return examinations;
    }

    public async Task<Examination?> GetExaminationById(int id)
    {
        var examination = await _context.Examinations
            .Where(e => e.Id == id)
            .FirstOrDefaultAsync();
        return examination;
    }

     public async Task<Examination?> AddExamination(Examination examination)
    {
        await _context.Examinations.AddAsync(examination);
        return examination;
    }

    public async Task DeleteExamination(Examination examination)
    {
        _context.Examinations.Remove(examination);
    }

    public async Task SaveChanges()
    {
        await _context.SaveChangesAsync();
    }
}