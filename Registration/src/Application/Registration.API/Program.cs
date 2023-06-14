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


//CORS POLICY
//builder.Services.AddCors(x =>
//{
//    x.AddDefaultPolicy(policyBuilder =>
//    {
//        policyBuilder.AllowAnyOrigin();
//    });
//});
builder.Services.AddCors(
    p => p.AddPolicy("corsp", build =>
    {
        build.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader();
    }
));




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

//add cors policy
//app.UseCors();
app.UseCors("corsp");

app.MapControllers();

app.Run();