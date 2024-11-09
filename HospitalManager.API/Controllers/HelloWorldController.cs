using Microsoft.AspNetCore.Mvc;

namespace HospitalManager.API.Controllers;

[ApiController]
[Route("api/")]
public class HelloWorldController : ControllerBase
{
    [HttpGet]
    public IActionResult GetHelloWorld()
    {
        return Ok("hello world");
    }
}