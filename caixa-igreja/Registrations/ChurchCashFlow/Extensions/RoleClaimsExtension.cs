using ChurchCashFlow.Models;
using System.Security.Claims;

namespace ChurchCashFlow.Extensions;
public static class RoleClaimsExtension
{
    public static IEnumerable<Claim> GetClaims(this User user)
    {
        var result = new List<Claim>
        {
            new(ClaimTypes.Name, user.Name)
        };

        result.Add(new Claim(ClaimTypes.Name, user.Role.Name));

        return result;
    }
}
