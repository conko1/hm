using HospitalManager.API.Entities;

namespace HospitalManager.API.Repositories;

public interface IRecipeRepository
{
    Task<IEnumerable<Recipe>> GetAllRecipes();
    Task<Recipe?> GetRecipeById(int id);
    Task DeleteRecipe(int id);
    Task SaveChanges();
}