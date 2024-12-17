using AutoMapper;
using HospitalManager.API.Entities;
using HospitalManager.Shared.Models;

namespace HospitalManager.API.Profiles
{
    public class PatientProfile : Profile
    {
        public PatientProfile()
        {
            CreateMap<Patient, PatientDTO>()
                .ForMember(dest => dest.InsuranceId, opt => opt.MapFrom(src => src.Insurance != null ? src.Insurance.Code : 0));

            CreateMap<PatientDTO, Patient>()
                .ForMember(dest => dest.Insurance, opt => opt.Ignore());
        }
    }
}
