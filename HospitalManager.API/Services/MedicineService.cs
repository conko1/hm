using AutoMapper;
using HospitalManager.Shared.Models;
using HospitalManager.API.Repositories;

namespace HospitalManager.API.Services;

public class MedicineService : IMedicineService
{
    private readonly IMedicineRepository _medicineRepository;
    private readonly IMapper _mapper;

    public MedicineService(IMedicineRepository medicineRepository, IMapper mapper)
    {
        _medicineRepository = medicineRepository;
        _mapper = mapper;
    }
    
    public async Task<IEnumerable<MedicineDTO>> GetMedicines()
    {
        var medicines = await _medicineRepository.GetMedicines();
        var medicinesDto = _mapper.Map<IEnumerable<MedicineDTO>>(medicines);
        return medicinesDto;
    }

    public async Task<MedicineDTO> GetMedicineById(int id)
    {
        var medicine = await _medicineRepository.GetMedicineById(id);

        if (medicine == null)
        {
            return null;
        }
        
        var medicineDto = _mapper.Map<MedicineDTO>(medicine);
        return medicineDto;
    }
}