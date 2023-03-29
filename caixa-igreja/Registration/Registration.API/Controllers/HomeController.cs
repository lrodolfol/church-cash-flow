using Microsoft.AspNetCore.Mvc;

namespace Registration.API.Controllers;

[ApiController]
public class HomeController : Controller
{
    [HttpGet("/api/v1/test")]
    public IActionResult Index()
    {
        return Ok("Ok");
    }
}
