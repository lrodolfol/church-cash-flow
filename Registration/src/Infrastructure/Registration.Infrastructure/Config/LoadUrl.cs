using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

namespace Registration.Infrastructure.Config;

public static class LoadUrl
{
    public static void LoadEndPoint(this WebApplicationBuilder builder)
    {
        var enviroment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

        if(enviroment!.ToLower() == "prd")
            builder.WebHost.UseUrls("http://localhost:8080");
        else if (enviroment!.ToLower() == "hom")
            builder.WebHost.UseUrls("http://localhost:8080");
        else
            builder.WebHost.UseUrls("http://localhost:8080");
    }    
}