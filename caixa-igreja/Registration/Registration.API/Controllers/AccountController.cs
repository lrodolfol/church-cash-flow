using Microsoft.AspNetCore.Mvc;
using Registration.API.Extensions;
using Registration.DomainCore.HandlerAbstraction;
using Registration.DomainCore.ViewModelAbstraction;
using Registration.Mapper.DTOs.UserLogin;

namespace ChurchCashFlow.Controllers
{
    public class AccountController : ControllerBase
    {
        private readonly IHandlerLogin<EditUserLogin> _handler;
        private readonly CViewModel _viewModel;

        public AccountController(IHandlerLogin<EditUserLogin> handler)
        {
            _handler = handler;
        }

        [HttpPost("/api/v1/account/login")]
        public async Task<IActionResult> Login([FromBody] EditUserLogin userLogin)
        {
            if (!ModelState.IsValid) {
                _viewModel.SetErrors(ModelState.GetErrors());
                return BadRequest(_viewModel);
            }

            var resultViewModel = await _handler.Login(userLogin);
            return StatusCode(_handler.GetStatusCode(), resultViewModel);
        }
    }
}
