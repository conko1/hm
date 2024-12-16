using AutoMapper;
using HospitalManager.API.Entities;
using HospitalManager.Shared.Models;

namespace HospitalManager.API.Profiles;

public class DoctorProfile : Profile
{
    public DoctorProfile()
    {
        CreateMap<DoctorDTO, Doctor>();
        CreateMap<Doctor, DoctorDTO>();
        CreateMap<DoctorForUpdateDTO, Doctor>();
        CreateMap<Doctor, DoctorForUpdateDTO>();
        CreateMap<DoctorPersonDTO, Doctor>();
        CreateMap<Doctor, DoctorPersonDTO>();
    }
}