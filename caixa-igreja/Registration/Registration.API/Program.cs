using Microsoft.EntityFrameworkCore;
using Registration.API;
using Registration.API.AuthService;
using Registration.DomainBase.ContextAbstraction;
using Registration.DomainCore.HandlerAbstraction;
using Registration.Mapper.DTOs.Church;
using Registration.Mapper.DTOs.User;
using Regristration.Repository;
using Regristration.Repository.Repository;
using System.Text;
using System.Xml.Serialization;

var builder = WebApplication.CreateBuilder(args);
ConfigureAuthentication(builder);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

    builder.Services.AddDbRepository<DataRepository>(opt =>
    {
        opt.UseSqlServer(connectionString);
    });


    builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
    builder.Services.AddTransient<TokenService>();

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


}

//configuração de autenticação e autorização
void ConfigureAuthentication(WebApplicationBuilder builder)
{
    
}