using ChurchCashFlow.Profiles;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Registration.DomainCore.ContextAbstraction;
using Registration.DomainCore.ViewModelAbstraction;
using Registration.Handlers.Handlers;
using Registration.Handlers.ViewModel;
using Registration.Mapper.Profiles;
using Regristration.Repository;
using Regristration.Repository.Repository;

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
        var connectionString = builder.Configuration.GetConnectionString("DefaultConnectionSqlServer");
        builder.Services.AddDbContext<DataContext>(opt =>
        {
            opt.UseSqlServer(connectionString, b => b.MigrationsAssembly("Registration.API"));
        });
        builder.Services.AddDbContext<DataContext>(opt =>
        {
            opt.UseSqlServer(connectionString);
        });

        builder.Services.AddScoped<AddressRepository>();
        builder.Services.AddScoped<IUserRepository, UserRepository>();
        builder.Services.AddScoped<IChurchRepository, ChurchRepository>();
        builder.Services.AddScoped<IChurchRepository, ChurchRepository>();
        builder.Services.AddScoped<IPostRepository, PostRepository>();
        builder.Services.AddScoped<IMemberRepository, MemberRepository>();
        builder.Services.AddScoped<IMeetingKindRepository, MeetingKindRepository>();
        builder.Services.AddScoped<IOfferingKindRepository, OfferingKindRepository>();
        builder.Services.AddScoped<IOutFlowKindRepository, OutFlowKindRepository>();
        builder.Services.AddScoped<IOutFlowRepository, OutFlowRepository>();
        builder.Services.AddScoped<IOfferingRepository, OfferingRepository>();
        builder.Services.AddScoped<ITithesRepository, TithesRepository>();
        builder.Services.AddScoped<IFirstFruitsRepository, FirstFruitsRepository>();
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

    }

    private static void LoadHandlers(this WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<CViewModel, ResultViewModel>();
        builder.Services.AddScoped<LoginHandler>();
        builder.Services.AddScoped<ChurchHandler>();
        builder.Services.AddScoped<UserHandler>();
        builder.Services.AddScoped<LoginHandler>();
        builder.Services.AddScoped<PostHandler>();
        builder.Services.AddScoped<MemberHandler>();
        builder.Services.AddScoped<MeetingKindHandler>();
        builder.Services.AddScoped<OfferingKindHandler>();
        builder.Services.AddScoped<OutFlowKindHandler>();
        builder.Services.AddScoped<OutFlowHanler>();
        builder.Services.AddScoped<OfferingHandler>();
        builder.Services.AddScoped<TithesHanler>();
        builder.Services.AddScoped<FirstFruitsHanler>();
    }
}