using Registration.DomainBase.Entities;
using Registration.Mapper.DTOs.User;
using System.Security.Claims;

namespace Registration.API.AuthService;
public static class RoleClaimsExtension
{
    public static IEnumerable<Claim> GetClaims(this EditUserDto user)
    {
        var result = new List<Claim>
        {
            new(ClaimTypes.Name, user.Name),
            new(ClaimTypes.Role, user.Role.Name),
            new(ClaimTypes.NameIdentifier, user.Id.ToString())
        };

        return result;
    }
}