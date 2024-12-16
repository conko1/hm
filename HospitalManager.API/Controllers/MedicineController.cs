
using HospitalManager.API.Services;
using HospitalManager.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManager.API.Controllers;

[ApiController]
[Route("api/medicine")]
public class MedicineController : ControllerBase
{
    private readonly IMedicineService _medicineService;

    public MedicineController(IMedicineService medicineService)
    {
        _medicineService = medicineService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<MedicineDTO>>> GetMedicines()
    {
        var medicines = await _medicineService.GetMedicines();
        return Ok(medicines);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<MedicineDTO>> GetMedicine(int id)
    {
        var medicine = await _medicineService.GetMedicineById(id);

        if (medicine == null)
        {
            return NotFound();
        }

        return Ok(medicine);
    }
}