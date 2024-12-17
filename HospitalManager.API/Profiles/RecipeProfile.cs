using AutoMapper;
using HospitalManager.API.Entities;
using HospitalManager.Shared.Models;

namespace HospitalManager.API.Profiles;

public class RecipeProfile : Profile
{
    public RecipeProfile()
    {
        CreateMap<Recipe, RecipeForUpdateDTO>()
            .ForMember(dest => dest.Medicines, opt => opt.MapFrom(src => src.Medicines.Select(m => m.Id).ToList()));
        CreateMap<RecipeForUpdateDTO, Recipe>()
            .ForMember(dest => dest.Medicines, opt => opt.Ignore());
        CreateMap<Recipe, RecipeForCreateDTO>();
        CreateMap<RecipeForCreateDTO, Recipe>()
            .ForMember(dest => dest.Medicines, opt => opt.Ignore());
        CreateMap<RecipeDTO, Recipe>();
        CreateMap<Recipe, RecipeDTO>()
            .ForMember(dest => dest.Medicines, opt => opt.MapFrom(src => src.Medicines.Select(m => m.Id).ToList()));
    }
}