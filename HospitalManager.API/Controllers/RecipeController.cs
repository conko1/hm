using HospitalManager.API.Services;
using HospitalManager.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManager.API.Controllers;

[ApiController]
[Route("api/recipe")]
public class RecipeController : ControllerBase
{
    private readonly IRecipeService _recipeService;

    public RecipeController(IRecipeService recipeService)
    {
        _recipeService = recipeService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<RecipeDTO>>> GetRecipes()
    {
        var result = await _recipeService.GetRecipes(true);
        return Ok(result.Data);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<IEnumerable<RecipeDTO>>> GetRecipe(int id)
    {
        var result = await _recipeService.GetRecipe(id, true);
        if (result is { IsSuccess: false, StatusCode: 404 })
        {
            return NotFound(result.Data);
        }
        return Ok(result.Data);
    }
}