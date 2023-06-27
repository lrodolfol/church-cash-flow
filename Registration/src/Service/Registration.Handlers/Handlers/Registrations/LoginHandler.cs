using SecureIdentity.Password;
using CodeLib = HttpCodeLib.NumberStatusCode;
using Registration.DomainCore.ViewModelAbstraction;
using AutoMapper;
using Registration.DomainCore.ContextAbstraction;
using Registration.DomainCore.HandlerAbstraction;
using Registration.DomainBase.Entities.Registrations;
using Registration.Mapper.DTOs.Registration.User;
using Registration.Mapper.DTOs.Registration.UserLogin;
using System.Text.Json;
using Microsoft.Extensions.Configuration;
using System.Text;

namespace Registration.Handlers.Handlers.Registrations;
public class LoginHandler : BaseNormalHandler
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

            if (!ValidateUserLogin(user, userLogin.PasswordHash))
                return _viewModel;

            _editUserDto = _mapper.Map<EditUserDto>(user);
            _statusCode = (int)CodeLib.OK;
        }
        catch
        {
            _statusCode = (int)CodeLib.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error - AC1101A");
        }

        return _viewModel;
    }

    private bool ValidateUserLogin(User user, string userLoginPassword)
    {
        if ( (user == null) || (!PasswordHasher.Verify(user.PasswordHash, userLoginPassword)) )
        {
            _statusCode = (int)CodeLib.UNAUTHORIZED;
            _viewModel!.SetErrors("Invalid username or password");

            return false;
        }else if(user.Active == false)
        {
            _statusCode = (int)CodeLib.UNAUTHORIZED;
            _viewModel!.SetErrors("User is disabled. Check the church's secretary");

            return false;
        }

        return true;
    }
}
