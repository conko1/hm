using HospitalManager.API.Entities;

namespace HospitalManager.API.Repositories;

public interface IMedicineRepository
{
    Task<IEnumerable<Medicine>> GetMedicines();
    Task<Medicine> GetMedicineById(int id);
    Task<IEnumerable<Medicine>> GetMedicinesIds(IEnumerable<int> medicineIds);
    Task SaveChanges();
}