using ConsumerChurchMonthWork;
using ConsumerChurchMonthWork.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;

IConfigurationRoot configuration;

ServiceCollection serviceCollection = new ServiceCollection();
ConfigureServices(serviceCollection);
//Log.Information("Creating service collection");


var churchId = 1;
var competence = "04-2023";

IDataBase dataBase = new MysqlDataBase(configuration);

var report = new Report(dataBase, churchId, competence);
report.Generate();




void ConfigureServices(IServiceCollection serviceCollection)
{
    // Add logging
    //serviceCollection.AddSingleton(LoggerFactory.Create(builder =>
    //{
    //    builder
    //        .AddSerilog(dispose: true);
    //}));

    //serviceCollection.AddLogging();

    // Build configuration
    configuration = new ConfigurationBuilder()
         .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json", false)
        .Build();

    serviceCollection.AddSingleton<IConfigurationRoot>(configuration);
}