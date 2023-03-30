using Registration.DomainCore.HandlerAbstraction;
using SecureIdentity.Password;
using CodeLib = HttpCodeLib.NumberStatusCode;
using Registration.Mapper.DTOs.UserLogin;
using Registration.DomainCore.ViewModelAbstraction;
using Registration.Mapper.DTOs.User;
using AutoMapper;
using Registration.DomainCore.ContextAbstraction;

namespace ChurchCashFlow.Handlers;
public class LoginHandler : IHandlerLogin<EditUserLogin>
{
    private IUserRepository _context;
    private readonly CViewModel _viewModel;
    private readonly IMapper _mapper;
    private int _statusCode;

    public LoginHandler(IUserRepository context, CViewModel viewModel, IMapper mapper)
    {
        _context = context;
        _viewModel = viewModel;
        _mapper = mapper;
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

            var editUserDto = _mapper.Map<EditUserDto>(user);
            _viewModel.SetData(editUserDto);
            _statusCode = (int)CodeLib.OK;
        }
        catch
        {
            _statusCode = (int)CodeLib.INTERNAL_SERVER_ERROR;
            _viewModel.SetErrors("Internal Error - AC1101A");
        }

        return _viewModel;
    }

}
