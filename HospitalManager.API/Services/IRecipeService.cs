using HospitalManager.API.Entities;
using HospitalManager.Shared.Models;
using HospitalManager.Shared.Service;
using Microsoft.AspNetCore.JsonPatch;

namespace HospitalManager.API.Services;

public interface IRecipeService
{
    Task<ServiceResponse<IEnumerable<RecipeDTO>>> GetRecipes();
    Task<ServiceResponse<RecipeDTO>> GetRecipe(int id);
    Task<ServiceResponse<RecipeDTO>> UpdateRecipe(Recipe recipe, JsonPatchDocument<RecipeForUpdateDTO> patchDocument);
    Task<ServiceResponse<RecipeDTO>> AddRecipe(RecipeForCreateDTO createRecipe);
    Task<ServiceResponse> DeleteRecipe(int id);
}