using CloudServices.AWS;
using CloudServices.Caching;
using MessageBroker.Messages;
using MessageBroker.RabbitMq;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MySqlConnector;
using Registration.DomainCore.CloudAbstration;
using Registration.DomainCore.ContextAbstraction;
using Registration.DomainCore.InterfaceRepository;
using Registration.DomainCore.ServicesAbstraction;
using Registration.DomainCore.ViewModelAbstraction;
using Registration.Handlers.Handlers.Operations;
using Registration.Handlers.Handlers.Registrations;
using Registration.Handlers.ViewModel;
using Registration.Mapper.Profiles;
using Registration.Repository;
using Registration.Repository.Repository.Operations;
using Registration.Repository.Repository.Registration;
using Mongo = MongoDB.Driver;

namespace Registration.Infrastructure.IOC;

public static class LoadContainersDI
{
    public static void LoadContainers(this WebApplicationBuilder builder)
    {
        LoadContextRepository(builder);
        LoadAutoMapperProfiles(builder);
        LoadAutoServices(builder);
        LoadHandlers(builder);
    }

    private static void LoadContextRepository(this WebApplicationBuilder builder)
    {
        var connectionString = new MySqlConnectionStringBuilder
        {
            Server = builder.Configuration["DATABASE:HOST"],
            Database = builder.Configuration["DATABASE:DB"],
            UserID = builder.Configuration["DATABASE:USER"],
            Password = builder.Configuration["DATABASE:PASSWORD"],
            Port = uint.Parse(builder.Configuration["DATABASE:PORT"] ?? "3306")
        }.ConnectionString;

        try
        {
            builder.Services.AddDbContext<DataContext>(opt =>
            {
                opt.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString), b => b.MigrationsAssembly("Registration.API"));
                opt.UseLoggerFactory(LoggerFactory.Create(builder =>
                    builder.AddFilter((category, level) =>
                        level >= LogLevel.Information)));
            });


            try
            {
                var db = builder.Services.BuildServiceProvider().GetRequiredService<DataContext>();
                db.Database.Migrate();

                Console.WriteLine("Auto migration foi executado");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Ocorreu erro ao executar o auto-migration.");
                Console.WriteLine("Verifique se a string de conexão esta corretamente configurada.");
                Console.WriteLine("Por favor, tente executar o comando 'Add-Migration 'migration' manualmente");
            }
        }
        catch (Exception ex)
        {
            builder.Services
                .BuildServiceProvider()
                .GetRequiredService<ILogger>()
                .LogError($"Migration DataBase Erro => {ex.Message}");
        }


        try
        {
            var section = builder.Configuration.GetSection("MONGO");
            var mongoHost = section.GetSection("host").Value;
            var mongoPort = section.GetSection("port").Value;
            var mongoUser = section.GetSection("user").Value;
            var mongoPassword = section.GetSection("password").Value;
            var db = section.GetSection("DB").Value;

            var mongoClient = new Mongo.MongoClient($"mongodb://{mongoUser}:{mongoPassword}@{mongoHost}:{mongoPort}/");
            Mongo.IMongoDatabase mongoDatabase = mongoClient.GetDatabase(db);

            builder.Services.AddSingleton<Mongo.IMongoDatabase>(mongoDatabase);
        }
        catch (Exception ex)
        {
            builder.Services
                .BuildServiceProvider()
                .GetRequiredService<ILogger>()
                .LogError($"Mongo error => {ex.Message}");
        }

        builder.Services.AddScoped<AddressRepository>();
        builder.Services.AddScoped<IUserRepository, UserRepository>();
        builder.Services.AddScoped<IChurchRepository, ChurchRepository>();
        builder.Services.AddScoped<IChurchRepository, ChurchRepository>();
        builder.Services.AddScoped<IPostRepository, PostRepository>();
        builder.Services.AddScoped<IMemberRepository, MemberRepository>();
        builder.Services.AddScoped<IMemberInRepository, MemberInRepository>();
        builder.Services.AddScoped<IMemberOutRepository, MemberOutRepository>();
        builder.Services.AddScoped<IMeetingKindRepository, MeetingKindRepository>();
        builder.Services.AddScoped<IOfferingKindRepository, OfferingKindRepository>();
        builder.Services.AddScoped<IOutFlowKindRepository, OutFlowKindRepository>();
        builder.Services.AddScoped<IOutFlowRepository, OutFlowRepository>();
        builder.Services.AddScoped<IOfferingRepository, OfferingRepository>();
        builder.Services.AddScoped<ITithesRepository, TithesRepository>();
        builder.Services.AddScoped<IFirstFruitsRepository, FirstFruitsRepository>();
        builder.Services.AddScoped<IMonthWorkRepository, MonthWorkRepository>();
        builder.Services.AddScoped<IUserRoleRepository, UserRoleRepository>();
        builder.Services.AddScoped<IMemberPostRepository, MemberPostRepository>();
        builder.Services.AddScoped<IRoleRepository, RoleRepository>();
        builder.Services.AddScoped<IBibleRepository, BibleRepository>();
    }

    private static void LoadAutoMapperProfiles(this WebApplicationBuilder builder)
    {
        builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

        builder.Services.AddAutoMapper(typeof(UsersProfile));
        builder.Services.AddAutoMapper(typeof(AddressProfile));
        builder.Services.AddAutoMapper(typeof(ChurchProfile));
        builder.Services.AddAutoMapper(typeof(MeetingKindProfile));
        builder.Services.AddAutoMapper(typeof(MemberProfile));
        builder.Services.AddAutoMapper(typeof(OfferingKindHandler));
        builder.Services.AddAutoMapper(typeof(OutFlowKindProfile));
        builder.Services.AddAutoMapper(typeof(OutFlowProfile));
        builder.Services.AddAutoMapper(typeof(OfferingKindProfile));
        builder.Services.AddAutoMapper(typeof(TithesProfile));
        builder.Services.AddAutoMapper(typeof(FirstFruitsProfile));
        builder.Services.AddAutoMapper(typeof(MonthWorkProfile));
        builder.Services.AddAutoMapper(typeof(UserRoleProfile));

    }

    private static void LoadHandlers(this WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<CViewModel, ResultViewModel>();
        builder.Services.AddScoped<MemberBridgesHandler>();
        builder.Services.AddScoped<LoginHandler>();
        builder.Services.AddScoped<ChurchHandler>();
        builder.Services.AddScoped<UserHandler>();
        builder.Services.AddScoped<LoginHandler>();
        builder.Services.AddScoped<PostHandler>();
        builder.Services.AddScoped<MemberHandler>();
        builder.Services.AddScoped<MemberInHandler>();
        builder.Services.AddScoped<MemberOutHandler>();
        builder.Services.AddScoped<MeetingKindHandler>();
        builder.Services.AddScoped<OfferingKindHandler>();
        builder.Services.AddScoped<OutFlowKindHandler>();
        builder.Services.AddScoped<OutFlowHanler>();
        builder.Services.AddScoped<OfferingHandler>();
        builder.Services.AddScoped<TithesHanler>();
        builder.Services.AddScoped<FirstFruitsHanler>();
        builder.Services.AddScoped<OperationsHandler>();
        builder.Services.AddScoped<ReportsHandlers>();
        builder.Services.AddScoped<UserRoleHandler>();
        builder.Services.AddScoped<MemberPostHandler>();
        builder.Services.AddScoped<RoleHandler>();
        builder.Services.AddScoped<BibleHandler>();
    }

    private static void LoadAutoServices(WebApplicationBuilder builder)
    {
        var config = builder.Configuration;

        builder.Services.AddSingleton<RabbitMqBaseEvent>(new NewUserCreated(config));

        builder.Services.AddSingleton<IMonthlyClosingDataBase>(new MysqlMonthlyClosingRepository(config));

        var log = builder.Services.BuildServiceProvider().GetRequiredService<Serilog.ILogger>();
        builder.Services.AddSingleton<IGetUrlPreSigned>(new AWSBucketS3(log));

        builder.Services.AddMemoryCache();

        builder.Services.AddStackExchangeRedisCache(options =>
        {
            var section = builder.Configuration.GetSection("CACHE");
            
            var host = section.GetSection("host").Value;
            var port = section.GetSection("port").Value;
            var password = section.GetSection("password").Value;

            if (String.Equals(Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT"), "prod", StringComparison.OrdinalIgnoreCase) ||
            (String.Equals(Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT"), "uat", StringComparison.OrdinalIgnoreCase)))
            {
                options.Configuration = $"{host}:{port},password={password},ssl=false,abortConnect=false";
            }
            else
            {
                options.Configuration = $"{host}:{port},password={password}";
            }

            options.InstanceName = section.GetSection("password").Value;
        });

        builder.Services.AddSingleton<ICacheService, CachingService>();
    }
}