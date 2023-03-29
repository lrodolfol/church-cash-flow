using Registration.DomainBase.Entities;
using System.Security.Claims;

namespace Registration.API.AuthService;
public static class RoleClaimsExtension
{
    public static IEnumerable<Claim> GetClaims(this User user)
    {
        var result = new List<Claim>
        {
            new(ClaimTypes.Name, user.Name),
            new(ClaimTypes.Role, user.Role.Name)
        };

        return result;
    }
}