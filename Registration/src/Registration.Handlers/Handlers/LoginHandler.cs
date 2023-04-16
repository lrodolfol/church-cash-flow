using SecureIdentity.Password;
using CodeLib = HttpCodeLib.NumberStatusCode;
using Registration.Mapper.DTOs.UserLogin;
using Registration.DomainCore.ViewModelAbstraction;
using Registration.Mapper.DTOs.User;
using AutoMapper;
using Registration.DomainCore.ContextAbstraction;
using Registration.DomainBase.Entities;
using Registration.DomainCore.HandlerAbstraction;

namespace Registration.Handlers.Handlers;
public class LoginHandler : Handler
{
    private IUserRepository _context;
    private EditUserDto _editUserDto;

    public LoginHandler(IUserRepository context, CViewModel viewModel, IMapper mapper) : base(mapper, viewModel)
    {
        _context = context;
    }

    public EditUserDto GetUser() => _editUserDto;

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
            _viewModel.SetErrors("Invalid username or password");

            return false;
        }

        if (!PasswordHasher.Verify(user.PasswordHash, userLoginPassword))
        {
            _statusCode = (int)CodeLib.UNAUTHORIZED;
            _viewModel.SetErrors("Invalid username or password");

            return false;
        }

        return true;
    }
}
