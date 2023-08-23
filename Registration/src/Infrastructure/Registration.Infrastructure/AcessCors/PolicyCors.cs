using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Registration.Infrastructure.AcessCors;

public static class PolicyCors
{
    private static readonly string urlChurchFron = "http://localhost:4200";

    public static void AddPolicyPermission(this WebApplicationBuilder builder)
    {
        builder.Services.AddCors(
            p => p.AddPolicy("corsp", build =>
            {
                build.WithOrigins(urlChurchFron).AllowAnyMethod().AllowAnyHeader();
            }
        ));
    }
}