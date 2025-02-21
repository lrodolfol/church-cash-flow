using Registration.DomainBase.Entities.Registrations;

namespace Registration.UnitTest.Shared.Builders.Entities;
internal class UserLoginBuilder : BaseBuilderEntitie
{
    public UserLogin Get => GetValid();
    public UserLogin GetFail => GetInvalid();
    private UserLogin GetValid() =>
        new UserLogin()
        {
            Code = GetValidCode(),
            PassWord = GetValidCode()
        };

    private UserLogin GetInvalid() =>
        new UserLogin()
        {
            Code = GetValidCode(1),
            PassWord = GetValidCode(1)
        };
}
