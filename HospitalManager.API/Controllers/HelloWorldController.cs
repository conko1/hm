using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManager.API.Controllers;

[ApiController]
[Route("api/")]
[Authorize]
public class HelloWorldController : ControllerBase
{
    [HttpGet]
    public IActionResult GetHelloWorld()
    {
        return Ok("hello world");
    }
}