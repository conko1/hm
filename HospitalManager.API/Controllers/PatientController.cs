using HospitalManager.API.Services;
using HospitalManager.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManager.API.Controllers
{

    [ApiController]
    [Route("api/patients")]
    public class PatientController : ControllerBase
    {
        private readonly IPatientService patientService;
        public PatientController(IPatientService patientService)
        {
            this.patientService = patientService;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPatient(int id, [FromQuery] bool expandPerson = false)
        {
            try
            {
                var patient = await this.patientService.GetById(id, expandPerson);
                return Ok(patient);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $" Internal server error: {ex.Message}");
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPatients([FromQuery] bool expandPerson = false)
        {
            try
            {
                var patients = await this.patientService.GetAll(expandPerson);
                return Ok(patients);
            }
            catch (InvalidOperationException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $" Internal server error: {ex.Message}");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePatient(int id)
        {
            try
            {
                await this.patientService.Delete(id);
                return Ok();
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $" Internal server error: {ex.Message}");
            }
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> UpdatePatient(int id, [FromBody] PatientForUpdateDTO patientDto)
        {
            try
            {
                var updatedPatient = await this.patientService.Update(id, patientDto);
                return Ok(updatedPatient);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $" Internal server error: {ex.Message}");
            }
        }

        [HttpPost("register")]
        public async Task<IActionResult> AddPatient([FromBody] RegisterPatientDTO registerPatientDTO)
        {
            try
            {
                await this.patientService.Add(registerPatientDTO);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $" Internal server error: {ex.Message}");
            }
        }

    }
}
