using Amazon;
using Amazon.CloudWatchLogs;
using Amazon.Runtime;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using Serilog.Events;
using Serilog.Sinks.AwsCloudWatch;

namespace Registration.DependencyInjection;

public static class LogerService
{
    private static readonly string? EnvironmentVariable = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
    private static IConfiguration Configuration = null!;

    public static void AddLogerService(this IServiceCollection service)
    {
        Configuration = service.BuildServiceProvider().GetRequiredService<IConfiguration>();
        var minimumLogEventLevel = SetLogEventLevel();

        var client = SetAwsCloudWatchClient();
        CreateLogGroupIfNotExist(client);

        Log.Logger = new LoggerConfiguration()
            .Enrich.FromLogContext()
            .Enrich.WithProperty("ApplicationName", Configuration["cloudServices:aws:loggroup"])
            .MinimumLevel.Override("Microsoft", minimumLogEventLevel)
            .WriteTo.Console()
            .WriteTo.AmazonCloudWatch(SetAwsCloudWatchOptions(), client)
            .CreateLogger();

        service.AddLogging();
        service.AddSingleton(Log.Logger);
    }

    private static CloudWatchSinkOptions SetAwsCloudWatchOptions() =>
        new CloudWatchSinkOptions()
        {
            LogGroupName = Configuration["cloudServices:aws:loggroup"],
            MinimumLogEventLevel = SetLogEventLevel(),
            TextFormatter = new CustomizedLogs()
        };

    private static AmazonCloudWatchLogsClient SetAwsCloudWatchClient()
    {
        if (string.Equals(EnvironmentVariable, "DEVELOPMENT", StringComparison.OrdinalIgnoreCase))
            return new AmazonCloudWatchLogsClient();

        var credentials = new BasicAWSCredentials(Environment.GetEnvironmentVariable("AWS_ACCESS_KEY_ID"), Environment.GetEnvironmentVariable("y9m3U6v0iDURQoxBvsaWFOrEBzUHyC0WJc+D4G3O"));
        var region = SearchRegionEndpoint(Configuration["cloudServices:aws:region"]!);
        return new AmazonCloudWatchLogsClient(credentials, region);
    }

    private static void CreateLogGroupIfNotExist(AmazonCloudWatchLogsClient client)
    {
        var nomeGrupoTeste = Configuration["cloudServices:aws:loggroup"];
        var logsGroupExisting = client.DescribeLogGroupsAsync();
        if (!logsGroupExisting.Result.LogGroups.Exists(x => x.LogGroupName.ToUpper() == nomeGrupoTeste!.ToUpper()))
        {
            client.CreateLogGroupAsync(new Amazon.CloudWatchLogs.Model.CreateLogGroupRequest()
            {
                LogGroupName = nomeGrupoTeste
            });
        }
    }

    private static RegionEndpoint SearchRegionEndpoint(string region) =>
        region.ToLower() switch
        {
            "us-east-1" => RegionEndpoint.USEast1,
            "us-east-2" => RegionEndpoint.USEast2,
            "sa-east-1" => RegionEndpoint.SAEast1,
            _ => RegionEndpoint.USEast1,
        };


    private static LogEventLevel SetLogEventLevel() =>
        EnvironmentVariable!.ToLower() switch
        {
            "dev" => LogEventLevel.Information,
            "hom" => LogEventLevel.Information,
            "prd" => LogEventLevel.Information,
            _ => LogEventLevel.Information
        };
}
