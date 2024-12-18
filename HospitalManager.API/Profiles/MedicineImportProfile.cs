using AutoMapper;
using HospitalManager.API.Entities;
using HospitalManager.Shared.Models;

namespace HospitalManager.API.Profiles;

public class MedicineImportProfile : Profile
{
    public MedicineImportProfile()
    {
        CreateMap<MedicineImport, MedicineImportDTO>();
        CreateMap<MedicineImportDTO, MedicineImport>();
    }
}