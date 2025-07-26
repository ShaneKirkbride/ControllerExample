using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ControllerExample.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ExampleController : ControllerBase
{
    private readonly ILogger<ExampleController> _logger;

    public ExampleController(ILogger<ExampleController> logger)
    {
        _logger = logger;
    }

    [HttpGet("hello")]
    public IActionResult GetHello()
    {
        _logger.LogInformation("Hello endpoint hit!");
        return Ok("Hello from the controller!");
    }
}
