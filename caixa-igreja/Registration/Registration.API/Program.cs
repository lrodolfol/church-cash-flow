using Autofac;
using AutoMapper;
using ChurchCashFlow.Handlers;
using Microsoft.EntityFrameworkCore;
using Registration.DomainCore.ContextAbstraction;
using Registration.DomainCore.HandlerAbstraction;
using Registration.DomainCore.ViewModelAbstraction;
using Registration.Handlers.ViewModel;
using Registration.Infrastructure.IOC;
using Registration.Mapper.DTOs.User;
using Registration.Mapper.Profiles;
using Regristration.Repository;
using Regristration.Repository.Repository;


var builder = WebApplication.CreateBuilder(args);
ConfigureAuthentication(builder);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(UsersProfile));

//REGISTER OTHER DEPENCY INJECTIO. "ADD TO IOC USING AUTOFAC"?
AddInjection(builder);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

void AddInjection(WebApplicationBuilder builder)
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

    builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
    
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

    builder.Services.AddScoped<CViewModel, ResultViewModel>();
    builder.Services.AddScoped<LoginHandler>();
    //builder.Services.AddScoped<IHandlerChurch<ReadChurchDto,EditChurchDto>, ChurchHandler>();
    //builder.Services.AddScoped<UserHandler>();
    //builder.Services.AddScoped<LoginHandler>();
    //builder.Services.AddScoped<PostHandler>();
    //builder.Services.AddScoped<MemberHandler>();
    //builder.Services.AddScoped<MeetingKindHandler>();
    //builder.Services.AddScoped<OfferingKindHandler>();
    //builder.Services.AddScoped<OutFlowKindHandler>();
    //builder.Services.AddScoped<OutFlowHanler>();
}


//configuração de autenticação e autorização
void ConfigureAuthentication(WebApplicationBuilder builder)
{
    
}

