using Microsoft.AspNetCore.Mvc;

namespace ThinkApp.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TestController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new { message = "¡API funcionando correctamente!", timestamp = DateTime.Now });
    }

    [HttpGet("health")]
    public IActionResult Health()
    {
        return Ok(new { status = "OK", service = "ThinkApp API" });
    }
} 