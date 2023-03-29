using Registration.DomainCore.HandlerAbstraction;
using Registration.DomainCore.ViewModel;
using SecureIdentity.Password;
using CodeLib = HttpCodeLib.NumberStatusCode;
using Registration.DomainBase.ContextAbstraction;
using Registration.Mapper.DTOs.UserLogin;
using Registration.DomainCore.AuthAbstraction;

namespace ChurchCashFlow.Handlers;
public class LoginHandler : IHandlerLogin<EditUserLogin>
{
    private IUserRepository _context;
    private readonly ITokenService _tokenService;
    private int _statusCode;

    public LoginHandler(IUserRepository context, ITokenService tokenService)
    {
        _context = context;
        _tokenService = tokenService;
    }

    public int GetStatusCode() => (int)_statusCode;
    public async Task<ResultViewModel<string>> Login(EditUserLogin userLogin)
    {
        try
        {
            var user = await _context.GetByCode(userLogin.Code);

            if (user == null)
            {
                _statusCode = (int)CodeLib.UNAUTHORIZED;
                return new ResultViewModel<string>("Usuário ou senha inválidos");
            }

            if(!PasswordHasher.Verify(user.PassWordHash, userLogin.PassWord))
            {
                _statusCode = (int)CodeLib.UNAUTHORIZED;
                return new ResultViewModel<string>("Usuário ou senha inválidos");
            }

            var token = _tokenService.GenerateToken(user);

            _statusCode = (int)CodeLib.OK;
            return new ResultViewModel<string>(token, null);
        }
        catch
        {
            _statusCode = (int)CodeLib.INTERNAL_SERVER_ERROR;
            return  new ResultViewModel<string>("Internal Error - AC1101A");
        }
    }

}
