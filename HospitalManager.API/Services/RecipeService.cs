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
    private readonly IAuthenticationService _authenticationService;
    private readonly IRecipeRepository _recipeRepository;
    private readonly IMedicineRepository _medicineRepository;
    private readonly IMapper _mapper;

    public RecipeService(
        IAuthenticationService authenticationService,
        IRecipeRepository recipeRepository,
        IMedicineRepository medicineRepository,
        IMapper mapper)
    {
        _authenticationService = authenticationService;
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

    public async Task<ServiceResponse<RecipeDTO>> UpdateRecipe(int id, 
        JsonPatchDocument<RecipeForUpdateDTO> patchDocument)
    {
        var recipeEntity = await _recipeRepository.GetRecipeById(id, true);
        if (recipeEntity == null)
        {
            return ServiceResponse<RecipeDTO>.Failure("Recipe not found", 404);
        }
        
        var recipeToUpdate = _mapper.Map<RecipeForUpdateDTO>(recipeEntity);

        var modelState = new ModelStateDictionary();
        
        patchDocument.ApplyTo(recipeToUpdate, modelState);
        
        if (!modelState.IsValid)
        {
            var errors = modelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList();
            return ServiceResponse<RecipeDTO>.Failure(errors, 400);
        }
        
        if (recipeToUpdate.Medicines != null)
        {
            var medicinesToApply = await _medicineRepository.GetMedicinesIds(recipeToUpdate.Medicines);
            if (medicinesToApply.ToList().Count() != recipeToUpdate.Medicines.ToList().Count())
            {
                return ServiceResponse<RecipeDTO>.Failure(["Provided medicine does not exists!"], 400);
            }
            recipeEntity.Medicines = medicinesToApply;
        }
        
        _mapper.Map(recipeToUpdate, recipeEntity);
        await _recipeRepository.SaveChanges();
        
        return ServiceResponse<RecipeDTO>.Success(_mapper.Map<RecipeDTO>(recipeEntity));
    }

    public async Task<ServiceResponse<RecipeDTO>> AddRecipe(RecipeForCreateDTO createRecipe)
    {
        var recipeEntity = _mapper.Map<Recipe>(createRecipe);
        
        if (createRecipe.Medicines != null)
        {
            var medicinesToApply = await _medicineRepository.GetMedicinesIds(createRecipe.Medicines);
            if (medicinesToApply.ToList().Count() != createRecipe.Medicines.ToList().Count())
            {
                return ServiceResponse<RecipeDTO>.Failure(["Provided medicine does not exists!"], 400);
            }
            recipeEntity.Medicines = medicinesToApply;
        }
        
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