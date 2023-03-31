using AutoMapper;
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
        private readonly LoginHandler _handler;
        private readonly CViewModel _viewModel;
        private readonly IMapper _mapper;

        public AccountController(LoginHandler handler, IMapper mapper)
        {
            _handler = handler;
            _mapper = mapper;
        }

        [HttpPost("/api/v1/account/login")]
        public async Task<IActionResult> Login([FromBody] EditUserLogin userLogin)
        {
            if (!ModelState.IsValid) {
               _viewModel.SetErrors(ModelState.GetErrors());
                return BadRequest();
            }

            //var editUserDto = _mapper.Map<EditUserDto>(userLogin);  
            var editUserDto = new EditUserDto
            {
                Active = true,
                Code = userLogin.Code,
                PassWord = userLogin.PassWord
            };

            var resultViewModel = await _handler.Login(editUserDto);

            if (_handler.GetStatusCode() == 200)
            {
                TokenService.GenerateToken(editUserDto);
            }

            return StatusCode(_handler.GetStatusCode(), resultViewModel);
        }
    }
}
