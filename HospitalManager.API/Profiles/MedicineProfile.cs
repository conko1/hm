using AutoMapper;
using HospitalManager.API.Entities;
using HospitalManager.Shared.Models;

namespace HospitalManager.API.Profiles;

public class MedicineProfile : Profile
{
    public MedicineProfile()
    {
        CreateMap<MedicineDTO, Medicine>();
        CreateMap<Medicine, MedicineDTO>();
    }
}