using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using ConsumerChurchMonthWork.MessageBrocker;

IConfigurationRoot configuration;
Serilog.ILogger logger;

ServiceCollection serviceCollection = new ServiceCollection();
ConfigureServices(serviceCollection);

//var churchId = 1;
//var competence = "05-2023";

//IDataBase dataBase = new MysqlDataBase(configuration);

//var report = new Report(dataBase, churchId, competence);
//var listMonthleClosing = report.Generate();

//var jsonObj = JsonSerializer.Serialize(listMonthleClosing.Result);
//var returnList = JsonSerializer.Deserialize<List<Entitie.MonthlyClosing>>(jsonObj);


void ConfigureServices(IServiceCollection serviceCollection)
{
    logger = new LoggerConfiguration()
    .WriteTo.Console()
    .CreateLogger();

    configuration = new ConfigurationBuilder()
         .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json", false)
        .Build();

    serviceCollection.AddSingleton<IConfigurationRoot>(configuration);
    serviceCollection.AddSingleton<ILogger>(logger);
}


RabbitMq rabbit = new RabbitMq(configuration, logger);
rabbit.StartConsumer();