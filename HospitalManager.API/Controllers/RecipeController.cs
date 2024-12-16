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
    public async Task<ActionResult<IEnumerable<RecipeDTO>>> GetRecipes([FromQuery] bool includeMedicine = false)
    {
        var result = await _recipeService.GetRecipes(includeMedicine);
        return Ok(result.Data);
    }
}