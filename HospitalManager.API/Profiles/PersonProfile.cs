using AutoMapper;
using HospitalManager.API.Entities;
using HospitalManager.Shared.Models;

namespace HospitalManager.API.Profiles;

public class PersonProfile : Profile
{
    public PersonProfile()
    {
        CreateMap<Person, PersonDTO>();
        CreateMap<PersonDTO, Person>();
    }
}