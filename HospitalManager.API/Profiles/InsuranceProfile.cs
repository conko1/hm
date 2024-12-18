using AutoMapper;
using HospitalManager.API.Entities;
using HospitalManager.Shared.Models;

namespace HospitalManager.API.Profiles
{
    public class InsuranceProfile : Profile
    {
        public InsuranceProfile() 
        {
            CreateMap<InsuranceDTO, Insurance>();
            CreateMap<Insurance, InsuranceDTO>();
        }
    }
}
