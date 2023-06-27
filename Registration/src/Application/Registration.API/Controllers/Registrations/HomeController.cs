using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Registration.DomainCore.ViewModelAbstraction;

namespace Registration.API.Controllers.Registrations;

[ApiController]
public class HomeController : Controller
{
    private readonly CViewModel? _viewModel;

    [Authorize(Roles = "L-SCT, M-SCT, M-TRS, L-TRS")]
    [HttpGet("/api/v1/test")]
    public IActionResult Index()
    {
        _viewModel.SetData("Ok");
        return Ok(_viewModel);
    }
}
