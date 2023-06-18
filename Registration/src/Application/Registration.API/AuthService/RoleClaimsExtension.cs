using Registration.DomainBase.Entities;
using Registration.Mapper.DTOs.Registration.User;
using System.Security.Claims;

namespace Registration.API.AuthService;
public static class RoleClaimsExtension
{
    public static IEnumerable<Claim> GetClaims(this EditUserDto user)
    {
        //var result = new List<Claim>
        //{
        //    new(ClaimTypes.Name, user.Name),
        //    new(ClaimTypes.Role, user.Role!.Name!),
        //    new(ClaimTypes.NameIdentifier, user.Id.ToString())
        //};

        var Userclaims = new[]
        {
            new Claim(ClaimTypes.Name, user.Name),
            new(ClaimTypes.Role, user.Role!.Name!),
            new Claim("userid", user.Id.ToString()),
            new Claim("churchId", user.ChurchId.ToString()),
            new Claim("usercode", user.Code),
            new Claim("churchName", user.Church!.Name!),
        };

        return Userclaims;
    }
}