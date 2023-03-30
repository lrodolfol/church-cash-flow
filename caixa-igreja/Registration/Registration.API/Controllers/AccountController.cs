using ChurchCashFlow.Handlers;
using Microsoft.AspNetCore.Mvc;
using Registration.API.AuthService;
using Registration.API.Extensions;
using Registration.DomainCore.HandlerAbstraction;
using Registration.DomainCore.ViewModelAbstraction;
using Registration.Mapper.DTOs.User;
using Registration.Mapper.DTOs.UserLogin;

namespace ChurchCashFlow.Controllers
{
    public class AccountController : ControllerBase
    {
        private readonly IHandlerLogin<EditUserLogin> _handler;
        private readonly CViewModel _viewModel;

        public AccountController(LoginHandler handler)
        {
            _handler = handler;
        }

        [HttpPost("/api/v1/account/login")]
        public async Task<IActionResult> Login([FromBody] EditUserLogin userLogin)
        {
            if (!ModelState.IsValid) {
               _viewModel.SetErrors(ModelState.GetErrors());
                return BadRequest();
            }

            var resultViewModel = await _handler.Login(userLogin);
            var editUserDto = new EditUserDto();

            if (_handler.GetStatusCode() == 200)
            {
                TokenService.GenerateToken(editUserDto);
            }

            return StatusCode(_handler.GetStatusCode(), resultViewModel);
        }
    }
}
