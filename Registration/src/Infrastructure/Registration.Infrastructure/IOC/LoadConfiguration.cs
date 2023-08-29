using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Registration.Infrastructure.IOC;

public static class LoadConfiguration
{
    public static void LoadConfig(this IServiceCollection service)
    {
        LoadJsonFile(service);
    }

    private static void LoadJsonFile(this IServiceCollection service)
    {
        IConfiguration config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false)
            .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json", optional: true)
            .Build();

        service.AddSingleton<IConfiguration>(config);
    }
}
