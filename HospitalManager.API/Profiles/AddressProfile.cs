using AutoMapper;
using HospitalManager.API.Entities;
using HospitalManager.Shared.Models;

namespace HospitalManager.API.Profiles
{
    public class AddressProfile : Profile
    {
        public AddressProfile() 
        {
            CreateMap<AddressDTO, Address>().ForMember(dest => dest.Id, opt => opt.Ignore()); ;
            CreateMap<Address, AddressDTO>();
        }
    }
}
