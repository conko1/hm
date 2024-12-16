using HospitalManager.API.Dtos;

namespace HospitalManager.API.Services;

public interface IMedicineService
{
    Task<IEnumerable<MedicineDTO>> GetMedicines();
    Task<MedicineDTO> GetMedicineById(int id);
}