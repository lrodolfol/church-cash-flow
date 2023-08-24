using SecureIdentity.Password;
using CodeLib = HttpCodeLib.NumberStatusCode;
using Registration.DomainCore.ViewModelAbstraction;
using AutoMapper;
using Registration.DomainCore.ContextAbstraction;
using Registration.DomainCore.HandlerAbstraction;
using Registration.DomainBase.Entities.Registrations;
using Registration.Mapper.DTOs.Registration.User;
using Registration.Mapper.DTOs.Registration.UserLogin;
using Serilog;

namespace Registration.Handlers.Handlers.Registrations;
public class LoginHandler : BaseNormalHandler
{
    private IUserRepository _context;
    private EditUserDto _editUserDto;
    private readonly ILogger _logger;

    public LoginHandler(IUserRepository context, CViewModel viewModel, IMapper mapper, ILogger logger) 
        : base(mapper, viewModel, logger)
    {
        _context = context;
        _logger = logger;
    }

    public EditUserDto GetUser() => _editUserDto;

    public async Task<CViewModel> Login(EditUserLogin userLogin)
    {
        _logger.Information("login attempt with user {user}", userLogin.Code);

        try
        {
            var user = await _context.GetByCode(userLogin.Code);

            if (!ValidateUserLogin(user, userLogin.PasswordHash))
                return _viewModel;

            _editUserDto = _mapper.Map<EditUserDto>(user);
            _statusCode = (int)CodeLib.OK;
        }
        catch(Exception ex)
        {
            _statusCode = (int)CodeLib.INTERNAL_SERVER_ERROR;
            _logger.Error("Fail in login attemp {error} - AC1101A", ex.Message);
            _viewModel!.SetErrors("Internal Error - AC1101A");
        }

        _logger.Information("Login successul");
        return _viewModel;
    }

    private bool ValidateUserLogin(User user, string userLoginPassword)
    {
        if ( (user == null) || (!PasswordHasher.Verify(user.PasswordHash, userLoginPassword)) )
        {
            var msgErr = "Invalid username or password";

            _statusCode = (int)CodeLib.UNAUTHORIZED;
            _viewModel!.SetErrors(msgErr);
            _logger.Error(msgErr);

            return false;
        }else if(user.Active == false)
        {
            var msgErr = "User is disabled. Check the church's secretary";

            _statusCode = (int)CodeLib.UNAUTHORIZED;
            _viewModel!.SetErrors(msgErr);
            _logger.Error(msgErr);

            return false;
        }

        return true;
    }
}
