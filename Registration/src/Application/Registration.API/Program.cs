using Registration.Infrastructure.IOC;
using Registration.Infrastructure.ConfigAuth;
using Serilog;
using Registration.DependencyInjection;
using Registration.API.Extensions;
using Registration.Infrastructure.AcessCors;
using Registration.Infrastructure.Config;

var builder = WebApplication.CreateBuilder(args);
var host = Host.CreateApplicationBuilder(args);

InitialInformation.ShowInitial();

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

host.Logging.AddSerilog();
builder.Services.AddLogerService();

//CONTAINERS INFRASTRUCTURE
builder.Services.LoadConfig();
builder.LoadContainers();
builder.LoadConfigAuth();
builder.AddPolicyPermission();

builder.LoadEndPoint();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

//app.UseHttpsRedirection();

app.UseAuthorization();

//add cors policy
//app.UseCors();
app.UseCors("corsp");

app.MapControllers();

app.Run("http://*:8181");