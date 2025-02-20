using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.RateLimiting;

namespace Registration.Infrastructure.AcessCors;

public static class PolicyCors
{
    private static readonly string urlChurchFron = "http://localhost:4200";
    private static readonly string urlChurchFronCloudAzure = "https://ecclesiafundo.azurewebsites.net";
    public static void AddPolicyPermission(this WebApplicationBuilder builder)
    {
        builder.Services.AddCors(
            p => p.AddPolicy("corsp", build =>
            {
                build.WithOrigins(urlChurchFron).AllowAnyMethod().AllowAnyHeader();
                build.WithOrigins(urlChurchFronCloudAzure).AllowAnyMethod().AllowAnyHeader();
            }
        ));
    }

    public static void AddRateLimit(this WebApplicationBuilder builder)
    {
        builder.Services.AddRateLimiter(opt =>
        {
            opt.RejectionStatusCode = StatusCodes.Status429TooManyRequests;
            opt.OnRejected = async (context, token) =>
            {
                if(context.Lease.TryGetMetadata(MetadataName.RetryAfter, out var retryAfter))
                {
                    await context.HttpContext.Response.WriteAsync($"Too many request, try again after {retryAfter} seconds");
                }
                else
                {
                    await context.HttpContext.Response.WriteAsync($"Too many request, try again later");
                }
            };

            opt.AddPolicy("fixed", httpContext =>
                RateLimitPartition.GetFixedWindowLimiter(
                    partitionKey: httpContext.Connection.RemoteIpAddress?.ToString(),
                    factory: let => new FixedWindowRateLimiterOptions
                    {
                        PermitLimit = 3,
                        Window = TimeSpan.FromSeconds(10)
                    }
                    )
            );
        });
    }
}