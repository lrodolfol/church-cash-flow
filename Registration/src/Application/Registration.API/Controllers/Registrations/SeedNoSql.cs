using Microsoft.AspNetCore.Mvc;

namespace Registration.API.Controllers.Registrations;
public class SeedNoSql : ControllerBase
{
    [HttpPost("api/v1/seed-no-sql")]
    public async Task SeedSql()
    {

    }

    private void SeedRole()
    {

    }
}
