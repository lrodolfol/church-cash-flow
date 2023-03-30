using Microsoft.AspNetCore.Mvc;
using Registration.API.Extensions;
using Registration.DomainCore.ViewModelAbstraction;

namespace Registration.API.Controllers;

[ApiController]
public class HomeController : Controller
{
    private readonly CViewModel _viewModel;

    [HttpGet("/api/v1/test")]
    public IActionResult Index()
    {
        _viewModel.SetData("Ok");
        return Ok(_viewModel);
    }
}
