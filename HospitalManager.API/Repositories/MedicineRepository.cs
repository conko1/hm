using HospitalManager.API.DbContexts;
using HospitalManager.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace HospitalManager.API.Repositories;

public class MedicineRepository : IMedicineRepository
{
    private readonly ApiDbContext _context;

    public MedicineRepository(ApiDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Medicine>> GetMedicines()
    {
        var medicines = await _context.Medicines.ToListAsync();
        return medicines;
    }

    public async Task<Medicine> GetMedicineById(int id)
    {
        var medicine = await _context.Medicines
            .Where(m => m.Id == id)
            .FirstOrDefaultAsync();
        return medicine;
    }

    public async Task<IEnumerable<Medicine>> GetMedicinesIds(IEnumerable<int> medicineIds)
    {
        var medicines = await _context.Medicines
            .Where(m => medicineIds.Contains(m.Id))
            .ToListAsync();
        return medicines;
    }

    public async Task SaveChanges()
    {
        await _context.SaveChangesAsync();
    }
}