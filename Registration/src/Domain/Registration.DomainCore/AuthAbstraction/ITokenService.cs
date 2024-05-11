using Registration.DomainBase.Entities.Registrations.sql;

namespace Registration.DomainCore.AuthAbstraction;
public interface ITokenService
{
    public string GenerateToken(User user);
}