using Microsoft.Extensions.Configuration;

namespace Registration.DomainCore;
public static class EnvironmentConfiguration
{
    public static readonly IConfigurationRoot ConfigurationRoot = DefineConfiguration();

    private static IConfigurationRoot DefineConfiguration()
    {
        var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ??
            Environment.GetEnvironmentVariable("DOTNET_ENVIRONMENT") ?? "Dev";

        if (environment is null)
            return new ConfigurationBuilder().AddJsonFile("appsettings.json", false, true).Build();

        return new ConfigurationBuilder().AddJsonFile($"appsettings.{environment}.json", false, true).Build();
    }
}
