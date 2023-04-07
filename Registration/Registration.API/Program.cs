using Registration.Handlers.Handlers;
using Microsoft.EntityFrameworkCore;
using Registration.DomainCore.ContextAbstraction;
using Registration.DomainCore.ViewModelAbstraction;
using Registration.Handlers.ViewModel;
using Registration.Mapper.Profiles;
using Regristration.Repository;
using Regristration.Repository.Repository;
using System.Text;
using Registration.API;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using ChurchCashFlow.Profiles;

var builder = WebApplication.CreateBuilder(args);
ConfigureAuthentication(builder);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


ConfigureAutoMapper(builder);
AddInjection(builder);

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

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
    builder.Services.AddScoped<IOfferingRepository, OfferingRepository>();
    builder.Services.AddScoped<ITithesRepository, TithesRepository>();
    builder.Services.AddScoped<IFirstFruitsRepository, FirstFruitsRepository>();    

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

void ConfigureAutoMapper(WebApplicationBuilder builder)
{
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

