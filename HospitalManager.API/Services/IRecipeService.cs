using HospitalManager.API.Entities;
using HospitalManager.Shared.Models;
using HospitalManager.Shared.Service;
using Microsoft.AspNetCore.JsonPatch;

namespace HospitalManager.API.Services;

public interface IRecipeService
{
    Task<ServiceResponse<IEnumerable<Recipe>>> GetRecipes();
    Task<ServiceResponse<Recipe>> GetRecipe(int id);
    Task<ServiceResponse<Recipe>> UpdateRecipe(Recipe recipe, JsonPatchDocument<RecipeForUpdateDTO> patchDocument);
    Task<ServiceResponse<Recipe>> AddRecipe(Recipe recipe);
    Task<ServiceResponse> DeleteRecipe(int id);
}