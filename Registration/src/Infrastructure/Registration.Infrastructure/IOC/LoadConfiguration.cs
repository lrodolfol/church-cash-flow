using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Registration.CentralPackages;

namespace Registration.Infrastructure.IOC;

public static class LoadConfiguration
{
    public static void LoadConfig(this IServiceCollection service) =>
        LoadJsonFile(service);    

    private static void LoadJsonFile(this IServiceCollection service)
    {
        var configuration = GetConfiguration();
        LoadConfigurationBridge(configuration);

        service.AddSingleton<IConfiguration>(configuration);
    }

    private static IConfiguration GetConfiguration()
    {
        IConfiguration config = new ConfigurationBuilder()
           .SetBasePath(Directory.GetCurrentDirectory())
           .AddJsonFile("appsettings.json", optional: false)
           .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json", optional: true)
           .Build();

        return config;
    }

    private static void LoadConfigurationBridge(IConfiguration configuration)
    {
        configuration.GetSection("cloudServices:aws").Bind(ConfigurationBridge.AwsCloudConfiguration);
    }
}
