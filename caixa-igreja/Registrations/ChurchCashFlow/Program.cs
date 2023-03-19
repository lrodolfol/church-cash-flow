using ChurchCashFlow;
using ChurchCashFlow.Data;
using ChurchCashFlow.Data.Context;
using ChurchCashFlow.Handlers;
using ChurchCashFlow.Services;
using DataModelChurchCashFlow.Context.Interface;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
ConfigureAuthentication(builder);

// Add services to the container.

builder.Services.AddControllers().ConfigureApiBehaviorOptions (opt => { opt.SuppressModelStateInvalidFilter = true; });

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

app.UseHttpsRedirection();

app.Run();


void AddInjection(WebApplicationBuilder builder)
{
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnectionSqlServer");
    builder.Services.AddDbContext<DataContext>(opt => opt.UseSqlServer(connectionString));
    builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
    builder.Services.AddTransient<TokenService>();

    builder.Services.AddScoped<IUserContext, UserContext>();
    builder.Services.AddScoped<IChurchContext, ChurchContext>();
    builder.Services.AddScoped<IPostContext, PostContext>();
    builder.Services.AddScoped<ChurchContext>();
    builder.Services.AddScoped<AddressContext>();
    builder.Services.AddScoped<ChurchHandler>();
    builder.Services.AddScoped<UserHandler>();
    builder.Services.AddScoped<LoginHandler>();
    builder.Services.AddScoped<PostHandler>();
}

//configuração de autenticação e autorização
void ConfigureAuthentication(WebApplicationBuilder builder)
{
    var key = Encoding.ASCII.GetBytes(Configuration.JwtKey);
    builder.Services.AddAuthentication(x =>
    {
        x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    }).AddJwtBearer(x =>
    {
        x.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(key),
            ValidateIssuer = false,
            ValidateAudience = false
        };
    });
}