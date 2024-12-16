using AutoMapper;
using HospitalManager.API.Dtos;
using HospitalManager.API.Entities;

namespace HospitalManager.API.Profiles;

public class MedicineProfile : Profile
{
    public MedicineProfile()
    {
        CreateMap<MedicineDTO, Medicine>();
        CreateMap<Medicine, MedicineDTO>();
    }
}