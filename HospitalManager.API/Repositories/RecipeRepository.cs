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

    public async Task<IEnumerable<Recipe>> GetAllRecipes(int? recipesForPatient = null)
    {
        IQueryable<Recipe> query = _context.Recipes.Include(r => r.Medicines);
        
        if (recipesForPatient != null)
        {
            query = query
                .Include(r => r.Examination.Patient)
                .Where(r => r.Examination.Patient.Id == recipesForPatient.Value);
        }
        
        return await query.ToListAsync();
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

    public async Task DeleteRecipe(Recipe recipe)
    {
        _context.Recipes.Remove(recipe);
    }

    public async Task<Recipe> AddRecipe(Recipe recipe)
    {
        await _context.Recipes.AddAsync(recipe);
        return recipe;
    }
    
    public async Task SaveChanges()
    {
        await _context.SaveChangesAsync();
    }
}