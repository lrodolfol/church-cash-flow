using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Registration.API.AuthService;
using Registration.API.Extensions;
using Registration.DomainBase.Entities.Registrations;
using Registration.DomainCore.ViewModelAbstraction;
using Registration.Handlers.Handlers.Registrations;
using Registration.Infrastructure.ConfigAuth;
using Registration.Mapper.DTOs.Registration.UserLogin;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Registration.API.Controllers.Registrations;
public class AccountController : ControllerBase
{
    private readonly LoginHandler _handler;
    private readonly CViewModel? _viewModel;

    public AccountController(LoginHandler handler, CViewModel viewModel)
    {
        _handler = handler;
        _viewModel = viewModel;
    }

    [HttpPost("/api/v1/account/login")]
    public async Task<IActionResult> Login([FromBody] EditUserLogin userLogin)
    {
        Thread.Sleep(3000);

        if (!ModelState.IsValid)
        {
            _viewModel!.SetErrors(ModelState.GetErrors());
            return BadRequest();
        }

        var resultViewModel = await _handler.Login(userLogin);

        if (_handler.GetStatusCode() == 200)
        {
            var tokenUserLogin = TokenService.GenerateToken(_handler.GetUser());
            _viewModel!.SetData(tokenUserLogin);

            return StatusCode(_handler.GetStatusCode(), _viewModel);
        }

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }
}