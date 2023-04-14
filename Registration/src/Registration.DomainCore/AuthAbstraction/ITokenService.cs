using Registration.DomainBase.Entities;

namespace Registration.DomainCore.AuthAbstraction;
public interface ITokenService
{
    public string GenerateToken(User user);
}