using AutoMapper;
using HospitalManager.API.Entities;
using HospitalManager.API.Repositories;
using HospitalManager.Shared.Models;
using HospitalManager.Shared.Service;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace HospitalManager.API.Services;

public class RecipeService : IRecipeService
{
    private readonly IRecipeRepository _recipeRepository;
    private readonly IMedicineRepository _medicineRepository;
    private readonly IMapper _mapper;

    public RecipeService(
        IRecipeRepository recipeRepository,
        IMedicineRepository medicineRepository,
        IMapper mapper)
    {
        _recipeRepository = recipeRepository;
        _medicineRepository = medicineRepository;
        _mapper = mapper;
    }

    public async Task<ServiceResponse<IEnumerable<RecipeDTO>>> GetRecipes(bool includeMedicine = false)
    {
        var recipes = await _recipeRepository.GetAllRecipes(includeMedicine);
        var recipesDto = _mapper.Map<IEnumerable<RecipeDTO>>(recipes);
        return ServiceResponse<IEnumerable<RecipeDTO>>.Success(recipesDto);
    }

    public async Task<ServiceResponse<RecipeDTO>> GetRecipe(int id, bool includeMedicine = false)
    {
        var recipes = await _recipeRepository.GetRecipeById(id, includeMedicine);
        if (recipes == null)
        {
            return ServiceResponse<RecipeDTO>.Failure("Recipe not found", 404);
        }
        
        var recipeDto = _mapper.Map<RecipeDTO>(recipes);
        
        return ServiceResponse<RecipeDTO>.Success(recipeDto);
    }

    public async Task<ServiceResponse<RecipeDTO>> UpdateRecipe(int id, JsonPatchDocument<RecipeForUpdateDTO> patchDocument)
    {
        var recipeEntity = await _recipeRepository.GetRecipeById(id);
        if (recipeEntity == null)
        {
            return ServiceResponse<RecipeDTO>.Failure("Recipe not found", 404);
        }
        
        var recipeToUpdate = _mapper.Map<RecipeForUpdateDTO>(recipeEntity);

        var modelState = new ModelStateDictionary();
        
        patchDocument.ApplyTo(recipeToUpdate, modelState);

        List<Medicine>? medicines;
        if (recipeToUpdate.Medicines != null)
        {
            recipeEntity.Medicines = await _medicineRepository.GetMedicinesIds(recipeToUpdate.Medicines);
        }
        
        if (!modelState.IsValid)
        {
            var errors = modelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList();
            return ServiceResponse<RecipeDTO>.Failure(errors, 400);
        }
        
        _mapper.Map(recipeToUpdate, recipeEntity);
        await _recipeRepository.SaveChanges();
        
        return ServiceResponse<RecipeDTO>.Success(_mapper.Map<RecipeDTO>(recipeEntity));
    }

    public async Task<ServiceResponse<RecipeDTO>> AddRecipe(RecipeForCreateDTO createRecipe)
    {
        var recipeEntity = _mapper.Map<Recipe>(createRecipe);
        
        Console.WriteLine(recipeEntity.Id);
        
        await _recipeRepository.AddRecipe(recipeEntity);
        await _recipeRepository.SaveChanges();
        
        var recipeDto = _mapper.Map<RecipeDTO>(recipeEntity);
        return ServiceResponse<RecipeDTO>.Success(recipeDto);
    }

    public async Task<ServiceResponse> DeleteRecipe(int id)
    {
        var recipe = await _recipeRepository.GetRecipeById(id);
        if (recipe == null)
        {
            return ServiceResponse.Failure("Recipe not found", 404);
        }

        await _recipeRepository.DeleteRecipe(recipe);
        await _recipeRepository.SaveChanges();
        return ServiceResponse.Success();
    }
}