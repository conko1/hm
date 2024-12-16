using AutoMapper;
using HospitalManager.API.Entities;
using HospitalManager.Shared.Models;

namespace HospitalManager.API.Profiles;

public class RecipeProfile : Profile
{
    public RecipeProfile()
    {
        CreateMap<Recipe, RecipeForUpdateDTO>();
        CreateMap<RecipeForUpdateDTO, Recipe>();
        CreateMap<Recipe, RecipeForCreateDTO>();
        CreateMap<RecipeForCreateDTO, Recipe>();
    }
}