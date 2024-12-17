using HospitalManager.API.DbContexts;
using HospitalManager.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace HospitalManager.API.Repositories;

public class RecipeRepository : IRecipeRepository
{
    private readonly ApiDbContext _context;

    public RecipeRepository(ApiDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Recipe>> GetAllRecipes(bool includeMedicine = false)
    {
        List<Recipe> recipes;
        if (includeMedicine)
        {
            recipes = await _context.Recipes
                .Include(r => r.Medicines)
                .ToListAsync();
        }
        else
        {
            recipes = await _context.Recipes.ToListAsync();
        }
        return recipes;
    }

    public async Task<Recipe?> GetRecipeById(int id, bool includeMedicine = false)
    {
        Recipe? recipe;
        if (includeMedicine)
        {
            recipe = await _context.Recipes
                .Where(r => r.Id == id)
                .Include(r => r.Medicines)
                .FirstOrDefaultAsync();
        }
        else
        {
            recipe = await _context.Recipes
                .Where(r => r.Id == id)
                .FirstOrDefaultAsync();
        }
        return recipe;
    }

    public async Task DeleteRecipe(int id)
    {
        var recipe = await _context.Recipes
            .Where(r => r.Id == id)
            .FirstOrDefaultAsync();
        _context.Recipes.Remove(recipe);
    }

    public async Task SaveChanges()
    {
        await _context.SaveChangesAsync();
    }
}