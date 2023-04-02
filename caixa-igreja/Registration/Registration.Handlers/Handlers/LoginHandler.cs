using SecureIdentity.Password;
using CodeLib = HttpCodeLib.NumberStatusCode;
using Registration.Mapper.DTOs.UserLogin;
using Registration.DomainCore.ViewModelAbstraction;
using Registration.Mapper.DTOs.User;
using AutoMapper;
using Registration.DomainCore.ContextAbstraction;
using Registration.DomainBase.Entities;

namespace Registration.Handlers.Handlers;
public class LoginHandler
{
    private IUserRepository _context;
    private readonly CViewModel _viewModel;
    private readonly IMapper _mapper;
    private int _statusCode;
    private EditUserDto _editUserDto;

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

            if (!ValidateUserLogin(user, userLogin.PassWord))
                return _viewModel;

            _editUserDto = _mapper.Map<EditUserDto>(user);
            _viewModel.SetData(_editUserDto);
            _statusCode = (int)CodeLib.OK;            
        }
        catch
        {
            _statusCode = (int)CodeLib.INTERNAL_SERVER_ERROR;
            _viewModel.SetErrors("Internal Error - AC1101A");
        }

        return _viewModel;
    }

    private bool ValidateUserLogin(User user, string userLoginPassword)
    {
        if (user == null)
        {
            _statusCode = (int)CodeLib.UNAUTHORIZED;
            _viewModel.SetErrors("Usuário ou senha inválidos");

            return false;
        }

        if (!PasswordHasher.Verify(user.PasswordHash, userLoginPassword))
        {
            _statusCode = (int)CodeLib.UNAUTHORIZED;
            _viewModel.SetErrors("Usuário ou senha inválidos");

            return false;
        }

        return true;
    }

    public EditUserDto GetUser() => _editUserDto;
}
