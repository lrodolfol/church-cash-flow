using Registration.DomainBase.Entities;
using Registration.Mapper.DTOs.Registration.User;
using System.Security.Claims;
using System.Linq;

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

        var rolesArr = user.UserRoles!.Select(x => x.Role).Select(r => r.Name);

        var Userclaims = (new[]
        {
            new Claim(ClaimTypes.Name, user.Name),
            new Claim("userid", user.Id.ToString()),
            new Claim("churchId", user.ChurchId.ToString()),
            new Claim("usercode", user.Code),
            new Claim("churchName", user.Church!.Name!),

        }).ToList();

        Userclaims.AddRange(rolesArr.Select(role => new Claim(ClaimTypes.Role, role!)));


        //new(ClaimTypes.Role, user.Role!.Name!),

        return Userclaims;
    }
}