using Microsoft.AspNetCore.Mvc;
using Registration.API.AuthService;
using Registration.API.Extensions;
using Registration.DomainCore.ViewModelAbstraction;
using Registration.Handlers.Handlers.Registrations;
using Registration.Mapper.DTOs.Registration.UserLogin;
using ILogger = Serilog.ILogger;

namespace Registration.API.Controllers.Registrations;
public class AccountController : ControllerBase
{
    private readonly LoginHandler _handler;
    private readonly CViewModel? _viewModel;
    private readonly ILogger _logger;

    public AccountController(LoginHandler handler, CViewModel viewModel, ILogger logger)
    {
        _handler = handler;
        _viewModel = viewModel;
        _logger = logger;
    }

    [HttpPost("/api/v1/account/login")]
    public async Task<IActionResult> Login([FromBody] EditUserLogin userLogin)
    {
        if (!ModelState.IsValid)
        {
            _viewModel!.SetErrors("Invalid request for login. check the credentials");
            _viewModel!.SetErrors(ModelState.GetErrors());
            _logger.Error("Invalid request for login. check the credentials");

            return BadRequest(_viewModel);
        }

        var resultViewModel = await _handler.Login(userLogin);

        if (_handler.GetStatusCode() == 200)
        {
            var tokenUserLogin = TokenService.GenerateToken(_handler.GetUser());
            _viewModel!.SetData(tokenUserLogin);
            _logger.Information("{token}", tokenUserLogin);

            return StatusCode(_handler.GetStatusCode(), _viewModel);
        }

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }
}