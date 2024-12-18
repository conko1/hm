using AutoMapper;
using HospitalManager.API.DbContexts;
using HospitalManager.API.Entities;
using HospitalManager.Shared.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HospitalManager.API.Controllers;

[Authorize]
[Route("api/medicine-import")]
[ApiController]
public class MedicinesController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly ApiDbContext _context;

    public MedicinesController(IMapper mapper, ApiDbContext context)
    {
        _mapper = mapper;
        _context = context;
    }
    
    [HttpGet]
    public async Task<ActionResult<IEnumerable<MedicineImportPaginatedDTO>>> GetPaginatedMedicines(
        [FromQuery] int pageNumber = 1, 
        [FromQuery] int pageSize = 10)
    {
        if (pageNumber <= 0) pageNumber = 1;
        if (pageSize <= 0) pageSize = 10;

        var totalItems = await _context.MedicineImports.CountAsync();
        Console.WriteLine("Total items: " + totalItems);
        
        var totalPages = (int)Math.Ceiling(totalItems / (double)pageSize);
        Console.WriteLine("Total Pages: " + totalPages);

        var medicines = await _context.MedicineImports
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        MedicineImportPaginatedDTO paginationMetadata = new MedicineImportPaginatedDTO()
        {
            TotalCount = totalItems,
            PageSize = pageSize,
            CurrentPage = pageNumber,
            TotalPages = totalPages,
            HasPreviousPage = pageNumber > 1,
            HasNextPage = pageNumber < totalPages,
            Results = _mapper.Map<IEnumerable<MedicineImportDTO>>(medicines.ToList()),
        };


        return Ok(paginationMetadata);
    }
    
    [HttpGet("{code}")]
    public async Task<ActionResult<MedicineImport>> GetMedicineByCode(string code)
    {
        var medicine = await _context.MedicineImports.FindAsync(code);
        if (medicine == null)
        {
            return NotFound();
        }

        return Ok(medicine);
    }
    private bool MedicineExists(string code)
    {
        return _context.MedicineImports.Any(e => e.Code == code);
    }
}