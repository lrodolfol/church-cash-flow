using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Registration.DomainCore.ContextAbstraction;
using Registration.DomainCore.ViewModelAbstraction;
using Registration.Handlers.ViewModel;
using Registration.Mapper.Profiles;
using Registration.Repository;
using Registration.Handlers.Handlers.Registrations;
using Registration.Repository.Repository.Registration;
using Registration.Handlers.Handlers.Operations;
using Microsoft.Extensions.Logging;
using MessageBroker;
using MessageBroker.Messages;
using Registration.DomainCore.InterfaceRepository;
using Registration.Repository.Repository.Operations;
using Registration.DomainCore.CloudAbstration;
using CloudServices.AWS;

namespace Registration.Infrastructure.IOC;

public static class LoadContainersDI
{
    public static void LoadContainers(this WebApplicationBuilder builder)
    {
        LoadContextRepository(builder);
        LoadAutoMapperProfiles(builder);
        LoadHandlers(builder);
    }

    private static void LoadContextRepository(this WebApplicationBuilder builder)
    {
        var connectionString = builder.Configuration
            .GetConnectionString("DefaultConnectionMySQL");

        try
        {
            builder.Services.AddDbContext<DataContext>(opt =>
            {
                opt.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString), b => b.MigrationsAssembly("Registration.API"));
                opt.UseLoggerFactory(LoggerFactory.Create(builder =>
                    builder.AddFilter((category, level) =>
                        level >= LogLevel.Information)));
            });
        }
        catch (Exception ex)
        {
            builder.Services
                .BuildServiceProvider()
                .GetRequiredService<ILogger>()
                .LogError($"Migration DataBase Erro => {ex.Message}");
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
        var config = builder.Configuration;
        builder.Services.AddSingleton<BaseMessageBrokerClient>(new NewUserCreated(config));
        builder.Services.AddSingleton<IMonthlyClosingDataBase>(new MysqlMonthlyClosingRepository(config));

        var log = builder.Services.BuildServiceProvider().GetRequiredService<Serilog.ILogger>();
        builder.Services.AddSingleton<IImageStorage>(new AWSBucketS3(log));

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
    }
}