using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using RabbitMQ.Client;
using ConsumerChurchMonthWork.MessageBrocker.Config;
using ConsumerChurchMonthWork.MessageBrocker.Consumer;
using ConsumerChurchMonthWork.Repository.Connections;

IConfigurationRoot configuration;
Serilog.ILogger logger;

//ServiceCollection serviceCollection = new ServiceCollection();
//ConfigureServices(serviceCollection);

//void ConfigureServices(IServiceCollection serviceCollection)
//{
logger = new LoggerConfiguration()
.WriteTo.Console()
.CreateLogger();

configuration = new ConfigurationBuilder()
     .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", false)
    .Build();

//    serviceCollection.AddSingleton<IConfigurationRoot>(configuration);
//    serviceCollection.AddSingleton<ILogger>(logger);
//    serviceCollection.AddHostedService<NewUserCreatedListerner>();
//}

var host = Host.CreateDefaultBuilder(args)
            .ConfigureServices(services =>
            {
                services.AddSingleton<IConfigurationRoot>(configuration);
                services.AddSingleton<ILogger>(logger);

                services.Configure<RabbitMQConfiguration>(configuration.GetSection("MessageBroker"));

                services.AddScoped<IDataBase, MysqlDataBase>();

                services.AddSingleton(serviceProvider =>
                {
                    RabbitMQConfiguration rabbitMQConfiguration = 
                        serviceProvider.GetRequiredService<IOptions<RabbitMQConfiguration>>().Value;

                    var factory = new ConnectionFactory
                    {
                        HostName = rabbitMQConfiguration.Host,
                        UserName = rabbitMQConfiguration.Username,
                        Password = rabbitMQConfiguration.Password,
                        Port = rabbitMQConfiguration.Port
                    };

                    IConnection connection = factory.CreateConnection();
                    return connection;
                });

                services.AddHostedService(serviceProvider =>
                {
                    var config = serviceProvider.GetRequiredService<IOptions<RabbitMQConfiguration>>();
                    IConnection connection = serviceProvider.GetRequiredService<IConnection>();

                    return new NewUserCreatedListerner(connection.CreateModel(), logger);
                });

                //services.AddHostedService(serviceProvider =>
                //{
                //    IConnection connection = serviceProvider.GetRequiredService<IConnection>();
                //    return new MonthWorkListener(connection.CreateModel(), logger);
                //});



            })
            .Build();

await host.RunAsync();

//RabbitMq rabbit = new RabbitMq(configuration, logger);
//rabbit.StartConsumer();