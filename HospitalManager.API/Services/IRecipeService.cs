using HospitalManager.API.Entities;
using HospitalManager.Shared.Models;
using HospitalManager.Shared.Service;
using Microsoft.AspNetCore.JsonPatch;

namespace HospitalManager.API.Services;

public interface IRecipeService
{
    Task<ServiceResponse<IEnumerable<RecipeDTO>>> GetRecipes(bool includeMedicine = false);
    Task<ServiceResponse<RecipeDTO>> GetRecipe(int id, bool includeMedicine = false);
    Task<ServiceResponse<RecipeDTO>> UpdateRecipe(int id, JsonPatchDocument<RecipeForUpdateDTO> patchDocument);
    Task<ServiceResponse<RecipeDTO>> AddRecipe(RecipeForCreateDTO createRecipe);
    Task<ServiceResponse> DeleteRecipe(int id);
}