using HospitalManager.API.Entities;

namespace HospitalManager.API.Repositories;

public interface IRecipeRepository
{
    Task<IEnumerable<Recipe>> GetAllRecipes(bool includeMedicine = false);
    Task<Recipe?> GetRecipeById(int id, bool includeMedicine = false);
    Task DeleteRecipe(Recipe recipe);
    Task<Recipe> AddRecipe(Recipe recipe);
    Task SaveChanges();
}