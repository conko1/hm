using AutoMapper;
using HospitalManager.API.Dtos;
using HospitalManager.API.Entities;

namespace HospitalManager.API.Profiles
{
    public class PatientProfile : Profile
    {
        public PatientProfile()
        {
            CreateMap<PatientDTO, Patient>();
            CreateMap<Patient, PatientDTO>();
        }
    }
}
