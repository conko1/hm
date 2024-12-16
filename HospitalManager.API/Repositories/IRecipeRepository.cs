using HospitalManager.API.Entities;

namespace HospitalManager.API.Repositories;

public interface IRecipeRepository
{
    Task<IEnumerable<Recipe>> GetAllRecipes(bool includeMedicine = false);
    Task<Recipe?> GetRecipeById(int id);
    Task DeleteRecipe(int id);
    Task SaveChanges();
}