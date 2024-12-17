using HospitalManager.API.Services;
using HospitalManager.Shared.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManager.API.Controllers;

[ApiController]
[Route("api/doctor")]
public class DoctorController : ControllerBase
{
    private readonly IDoctorService _doctorService;

    public DoctorController(IDoctorService doctorService)
    {
        _doctorService = doctorService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<DoctorDTO>>> GetDoctors()
    {
        var result = await _doctorService.GetDoctors();
        return Ok(result.Data);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<DoctorDTO>> GetDoctor(int id)
    {
        var result = await _doctorService.GetDoctor(id);
        if (result is { IsSuccess: false, StatusCode: 404 })
        {
            return NotFound(result.Data);
        }
        return Ok(result.Data);
    }

    [HttpPatch("{id}")]
    public async Task<ActionResult<DoctorDTO>> UpdateDoctor(int id,
        [FromBody] JsonPatchDocument<DoctorForUpdateDTO> patchDoctor)
    {
        var result = await _doctorService.UpdateDoctor(id, patchDoctor);
        if (result is { IsSuccess: false, StatusCode: 404 })
        {
            return NotFound(result.Data);
        }

        if (result is { IsSuccess: false, StatusCode: 400 })
        {
            return BadRequest(result.Data);
        }
        
        return Ok(result.Data);
    }
    
    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteDoctor(int id)
    {
        var result = await _doctorService.DeleteDoctor(id);
        if (result is { IsSuccessful: false, StatusCode: 404 })
        {
            return NotFound(result);
        }
        return NoContent();
    }
}