using Microsoft.AspNetCore.Mvc;

namespace ControllerExample.Controllers.Admin;

[ApiController]
[Route("api/[controller]")]
public class ExampleController : ControllerBase
{
    [HttpGet("hello")]
    public IActionResult GetHello()
    {
        Console.WriteLine("Hello endpoint hit!");
        return Ok("Hello from the controller!");
    }   
}
