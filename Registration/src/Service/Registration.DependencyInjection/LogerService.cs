using Microsoft.Extensions.DependencyInjection;
using Serilog;
using Serilog.Events;

namespace Registration.DependencyInjection;

public static class LogerService
{
    private static readonly string? EnvironmentVariable =
        Environment.ExpandEnvironmentVariables("ASPNETCORE_ENVIRONMENT");

    public static void AddLogerService(this IServiceCollection service)
    {
        var minimumLogEventLevel = SetLogEventLevel();

        Log.Logger = new LoggerConfiguration()
            .Enrich.FromLogContext()
            .MinimumLevel.Override("Microsoft", minimumLogEventLevel)
            .WriteTo.Console()
            .CreateLogger();

        service.AddLogging();
        service.AddSingleton(Log.Logger);
    }

    private static LogEventLevel SetLogEventLevel() =>
        EnvironmentVariable!.ToLower() switch
        {
            "dev" => LogEventLevel.Information,
            "hom" => LogEventLevel.Information,
            "prd" => LogEventLevel.Information,
            _ => LogEventLevel.Information
        };
}