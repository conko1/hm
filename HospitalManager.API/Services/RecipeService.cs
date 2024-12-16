using AutoMapper;
using HospitalManager.API.Entities;
using HospitalManager.API.Repositories;
using HospitalManager.Shared.Models;
using HospitalManager.Shared.Service;
using Microsoft.AspNetCore.JsonPatch;

namespace HospitalManager.API.Services;

public class RecipeService : IRecipeService
{
    private readonly IRecipeRepository _recipeRepository;
    private readonly IMapper _mapper;

    public RecipeService(IRecipeRepository recipeRepository, IMapper mapper)
    {
        _recipeRepository = recipeRepository;
        _mapper = mapper;
    }

    public async Task<ServiceResponse<IEnumerable<RecipeDTO>>> GetRecipes()
    {
        // var recipes = await _recipeRepository.GetAllRecipes();
        // var recipesDto = _mapper.Map<IEnumerable<RecipeDTO>>(recipes);
        
        throw new NotImplementedException();
    }

    public Task<ServiceResponse<RecipeDTO>> GetRecipe(int id)
    {
        throw new NotImplementedException();
    }

    public Task<ServiceResponse<RecipeDTO>> UpdateRecipe(Recipe recipe, JsonPatchDocument<RecipeForUpdateDTO> patchDocument)
    {
        throw new NotImplementedException();
    }

    public Task<ServiceResponse<RecipeDTO>> AddRecipe(RecipeForCreateDTO createRecipe)
    {
        throw new NotImplementedException();
    }

    public Task<ServiceResponse> DeleteRecipe(int id)
    {
        throw new NotImplementedException();
    }
}