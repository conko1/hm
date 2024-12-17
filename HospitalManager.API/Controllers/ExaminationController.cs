using HospitalManager.API.Services;
using HospitalManager.Shared.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManager.API.Controllers;

[ApiController]
[Route("api/examination")]
public class ExaminationController : ControllerBase
{
    private readonly IExaminationService _examinationService;

    public ExaminationController(IExaminationService examinationService)
    {
        _examinationService = examinationService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ExaminationDTO>>> GetExaminations()
    {
        var result = await _examinationService.GetExaminations();
        return Ok(result.Data);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ExaminationDTO>> GetExamination(int id)
    {
        var result = await _examinationService.GetExamination(id);
        if (result is { IsSuccess: false, StatusCode: 404 })
        {
            return NotFound(result.Errors);
        }
        return Ok(result.Data);
    }

    [HttpPatch("{id}")]
    public async Task<ActionResult<ExaminationDTO>> UpdateExamination(int id,
        [FromBody] JsonPatchDocument<ExaminationForUpdateDTO> examinationPatch)
    {
        var result = await _examinationService.UpdateExamination(id, examinationPatch);
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
    public async Task<ActionResult<ExaminationDTO>> CreateExamination([FromBody] ExaminationForCreateDTO examination)
    {
        var result = await _examinationService.AddExamination(examination);
        return CreatedAtAction(nameof(GetExamination), new { id = result.Data.Id }, result.Data);
    }
}