using ChurchCashFlow.Data.Entities;
using ChurchCashFlow.Data.ViewModels;
using ChurchCashFlow.Services;
using DataModelChurchCashFlow.Context.Interface;
using SecureIdentity.Password;
using CodeLib = HttpCodeLib.NumberStatusCode;

namespace ChurchCashFlow.Handlers;
public class LoginHandler : Handler
{
    private IUserContext _context;
    private readonly TokenService _tokenService;

    public LoginHandler(IUserContext context, TokenService tokenService)
    {
        _context = context;
        _tokenService = tokenService;
    }

    public async Task<ResultViewModel<string>> Login(UserLogin userLogin)
    {
        try
        {
            var user = await _context.GetByCode(userLogin.Code);

            if (user == null)
            {
                StatusCode = (int)CodeLib.UNAUTHORIZED;
                return new ResultViewModel<string>("Usuário ou senha inválidos");
            }

            if(!PasswordHasher.Verify(user.PassWordHash, userLogin.PassWord))
            {
                StatusCode = (int)CodeLib.UNAUTHORIZED;
                return new ResultViewModel<string>("Usuário ou senha inválidos");
            }
             
            var token = _tokenService.GenerateToken(user);

            StatusCode = (int)CodeLib.OK;
            return new ResultViewModel<string>(token, null);
        }
        catch
        {
            StatusCode = (int)CodeLib.INTERNAL_SERVER_ERROR;
            return  new ResultViewModel<string>("Internal Error - AC1101A");
        }
    }
}
