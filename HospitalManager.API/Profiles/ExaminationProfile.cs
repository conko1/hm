using AutoMapper;
using HospitalManager.API.Entities;
using HospitalManager.Shared.Models;

namespace HospitalManager.API.Profiles;

public class ExaminationProfile : Profile
{
    public ExaminationProfile()
    {
        CreateMap<Examination, ExaminationDTO>();
        CreateMap<ExaminationDTO, Examination>();
        CreateMap<Examination, ExaminationForUpdateDTO>();
        CreateMap<ExaminationForUpdateDTO, Examination>();
        CreateMap<Examination, ExaminationForCreateDTO>();
        CreateMap<ExaminationForCreateDTO, Examination>();
    }
}