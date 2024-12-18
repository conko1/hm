using HospitalManager.API.Services;
using HospitalManager.Shared.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManager.API.Controllers;

[Authorize]
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
    public async Task<ActionResult<IEnumerable<RecipeDTO>>> GetRecipes([FromQuery] int? recipesForPatient = null)
    {
        var result = await _recipeService.GetRecipes(recipesForPatient);
        return Ok(result.Data);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<IEnumerable<RecipeDTO>>> GetRecipe(int id)
    {
        var result = await _recipeService.GetRecipe(id, true);
        if (result is { IsSuccess: false, StatusCode: 404 })
        {
            return NotFound(result.Errors);
        }
        return Ok(result.Data);
    }

    [HttpPatch("{id}")]
    public async Task<ActionResult<RecipeDTO>> UpdateRecipe(int id,
        [FromBody] JsonPatchDocument<RecipeForUpdateDTO> patchRecipe)
    {
        var result = await _recipeService.UpdateRecipe(id, patchRecipe);
        if (result is { IsSuccess: false, StatusCode: 404 })
        {
            return NotFound(result.Errors);
        }

        if (result is { IsSuccess: false, StatusCode: 400 })
        {
            return BadRequest(result.Errors);
        }
        
        return Ok(result.Data);
    }

    [HttpPost]
    public async Task<ActionResult<RecipeDTO>> CreateRecipe([FromBody] RecipeForCreateDTO recipe)
    {
        var result = await _recipeService.AddRecipe(recipe);
        return CreatedAtAction(nameof(GetRecipe), new { id = result.Data.Id }, result.Data);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<RecipeDTO>> DeleteRecipe(int id)
    {
        var result = await _recipeService.DeleteRecipe(id);
        if (result is { IsSuccessful: false, StatusCode: 404 })
        {
            return NotFound(result);
        }
        
        return NoContent();
    }
}