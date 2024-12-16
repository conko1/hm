using HospitalManager.API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManager.API.Controllers
{

    [ApiController]
    [Authorize]
    [Route("api/")]
    public class PatientController : Controller
    {
        private readonly PatientService patientService;

        public PatientController(PatientService patientService)
        {
            this.patientService = patientService;
        }


        [HttpGet("{id}")]
        public IActionResult getPatient(int id)
        {
            try
            {
                var user = this.patientService.getPatient(id);
                return Ok(user);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $" Internal server error: {ex.Message}");
            }
        }
    }
}
