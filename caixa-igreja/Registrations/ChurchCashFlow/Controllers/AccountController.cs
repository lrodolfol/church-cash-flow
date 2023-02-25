using AutoMapper;
using ChurchCashFlow.Extensions;
using ChurchCashFlow.Data.Entities;
using ChurchCashFlow.Services;
using ChurchCashFlow.Data.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SecureIdentity.Password;
using ChurchCashFlow.Data.Context;

namespace ChurchCashFlow.Controllers
{
    public class AccountController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly TokenService _tokenService;

        public AccountController(DataContext context, TokenService tokenService)
        {
            _context = context;
            _tokenService = tokenService;
        }

        [HttpPost("/api/v1/account/login")]
        public async Task<IActionResult> Login([FromBody] UserLogin userLogin)
        {
            if (!ModelState.IsValid)
                return BadRequest(new ResultViewModel<string>(ModelState.GetErrors()));

            try
            {
                var user = await _context.Users.AsNoTracking().Include(x => x.Role).FirstOrDefaultAsync(x => x.Code == userLogin.Code);

                if (user == null)
                    return StatusCode(401, new ResultViewModel<string>("Usuário ou senha inválidos"));

                if (!PasswordHasher.Verify(user.PassWordHash, userLogin.PassWord))
                    return StatusCode(401, new ResultViewModel<string>("Usuário ou senha inválidos"));

                var token = _tokenService.GenerateToken(user);

                return Ok(new ResultViewModel<string>(token, null));
            }
            catch
            {
                return StatusCode(500, new ResultViewModel<string>("Internal Error - AC1101A"));
            }
        }
    }
}
