using Microsoft.AspNetCore.Mvc;
using Registration.DomainCore.ContextAbstraction;
using Registration.Handlers.SeedMongo;

namespace Registration.API.Controllers.Registrations;
public class SeedNoSqlController : ControllerBase
{
    private IServiceProvider _serviceProvider;
    private readonly IEnumerable<ISeedNoSql> _seedsServices;

    public SeedNoSqlController(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
        _seedsServices = _serviceProvider.GetServices<ISeedNoSql>();
    }

    [HttpPost("api/v1/seed-no-sql")]
    public async Task SeedSql()
    {
        var seedMember = _seedsServices.First(x => x.GetType() == typeof(SeedMember));
        var seedUser = _seedsServices.First(x => x.GetType() == typeof(SeedUser));

        var _listSeed = new List<ISeedNoSql>() { seedMember, seedUser };

        _listSeed.ForEach(seed =>
        {
            Console.WriteLine($"Sedd {seed.Name}");
        });
    }

    private void SeedRole()
    {

    }
}
