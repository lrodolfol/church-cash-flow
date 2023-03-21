using AutoMapper;
using ChurchCashFlow.Extensions;
using ChurchCashFlow.Data.Entities;
using ChurchCashFlow.Services;
using ChurchCashFlow.Data.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SecureIdentity.Password;
using ChurchCashFlow.Data;
using System.Runtime.CompilerServices;
using ChurchCashFlow.Handlers;

namespace ChurchCashFlow.Controllers
{
    public class AccountController : ControllerBase
    {
        private readonly LoginHandler _handler;

        public AccountController(LoginHandler handler)
        {
            _handler = handler;
        }

        [HttpPost("/api/v1/account/login")]
        public async Task<IActionResult> Login([FromBody] UserLogin userLogin)
        {
            if (!ModelState.IsValid)
                return BadRequest(new ResultViewModel<string>(ModelState.GetErrors()));

            var resultViewModel = await _handler.Login(userLogin);
            return StatusCode(_handler.StatusCode, resultViewModel);
        }
    }
}
