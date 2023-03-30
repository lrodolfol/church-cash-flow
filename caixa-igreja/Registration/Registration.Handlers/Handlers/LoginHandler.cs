using Registration.DomainCore.HandlerAbstraction;
using SecureIdentity.Password;
using CodeLib = HttpCodeLib.NumberStatusCode;
using Registration.DomainBase.ContextAbstraction;
using Registration.Mapper.DTOs.UserLogin;
using Registration.DomainCore.AuthAbstraction;
using Registration.DomainCore.ViewModelAbstraction;
using Registration.Handlers.ViewModel;

namespace ChurchCashFlow.Handlers;
public class LoginHandler : IHandlerLogin<EditUserLogin>
{
    private IUserRepository _context;
    private readonly ITokenService _tokenService;
    private readonly CViewModel _viewModel;
    private int _statusCode;

    public LoginHandler(IUserRepository context, ITokenService tokenService, CViewModel viewModel)
    {
        _context = context;
        _tokenService = tokenService;
        _viewModel = viewModel;
    }

    public int GetStatusCode() => (int)_statusCode;
    public async Task<CViewModel> Login(EditUserLogin userLogin)
    {
        try
        {
            var user = await _context.GetByCode(userLogin.Code);

            if (user == null)
            {
                _statusCode = (int)CodeLib.UNAUTHORIZED;
                _viewModel.SetErrors("Usuário ou senha inválidos");

                return _viewModel;
            }

            if(!PasswordHasher.Verify(user.PassWordHash, userLogin.PassWord))
            {
                _statusCode = (int)CodeLib.UNAUTHORIZED;
                _viewModel.SetErrors("Usuário ou senha inválidos");

                return _viewModel;
            }

            var token = _tokenService.GenerateToken(user);

            _statusCode = (int)CodeLib.OK;
            _viewModel.SetData(token);
        }
        catch
        {
            _statusCode = (int)CodeLib.INTERNAL_SERVER_ERROR;
            _viewModel.SetErrors("Internal Error - AC1101A");
        }

        return _viewModel;
    }

}
