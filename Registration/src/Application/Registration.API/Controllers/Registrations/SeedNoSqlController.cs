using Microsoft.AspNetCore.Mvc;
using Registration.DomainCore.ContextAbstraction;
using Registration.Handlers.SeedMongo;

namespace Registration.API.Controllers.Registrations;
public class SeedNoSqlController : ControllerBase
{
    private readonly ILogger _logger;
    private readonly SeedMember _seedMember;
    private List<ISeedNoSql> _listSeed;

    public SeedNoSqlController(SeedMember seedMember, ILogger logger)
    {
        _seedMember = seedMember;
        _logger = logger;

        _listSeed = [];
        _listSeed.Add(seedMember);
    }

    [HttpPost("api/v1/seed-no-sql")]
    public async Task SeedSql()
    {
        _listSeed.ForEach(seed =>
        {
            _logger.LogInformation($"Sedd {seed.Name}");
        });
    }

    private void SeedRole()
    {

    }
}
