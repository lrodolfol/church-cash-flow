using Registration.Infrastructure.IOC;
using Registration.Infrastructure.ConfigAuth;
using Serilog;
using Registration.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
var host = Host.CreateApplicationBuilder(args);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//CONTAINERS INFRASTRUCTURE
builder.LoadContainers();
builder.LoadConfigAuth();
host.Logging.AddSerilog();

builder.Services.AddLogerService();


builder.WebHost.UseUrls("https://localhost:7171");

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();