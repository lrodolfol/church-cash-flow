using Registration.DomainBase.Entities.Registrations;

namespace Registration.DomainCore.AuthAbstraction;
public interface ITokenService
{
    public string GenerateToken(User user);
}