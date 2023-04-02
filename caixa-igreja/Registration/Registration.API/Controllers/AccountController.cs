using Registration.Handlers.Handlers;
using Microsoft.AspNetCore.Mvc;
using Registration.API.AuthService;
using Registration.API.Extensions;
using Registration.DomainCore.ViewModelAbstraction;
using Registration.Mapper.DTOs.UserLogin;

namespace Registration.API.Controllers;
public class AccountController : ControllerBase
{
    private readonly LoginHandler _handler;
    private readonly CViewModel _viewModel;

    public AccountController(LoginHandler handler, CViewModel viewModel)
    {
        _handler = handler;
        _viewModel = viewModel;
    }

    [HttpPost("/api/v1/account/login")]
    public async Task<IActionResult> Login([FromBody] EditUserLogin userLogin)
    {
        if (!ModelState.IsValid)
        {
            _viewModel.SetErrors(ModelState.GetErrors());
            return BadRequest();
        }

        var resultViewModel = await _handler.Login(userLogin);

        if (_handler.GetStatusCode() == 200)
        {
            var tokenUserLogin = TokenService.GenerateToken(_handler.GetUser());
            _viewModel.SetData(tokenUserLogin);

            return StatusCode(_handler.GetStatusCode(), _viewModel);
        }

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }
}