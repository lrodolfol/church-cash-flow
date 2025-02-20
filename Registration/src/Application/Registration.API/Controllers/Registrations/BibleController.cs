using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;
using Registration.Handlers.Handlers.Registrations;
using Registration.Mapper.DTOs.Registration.Bible;

namespace Registration.API.Controllers.Registrations;

public class BibleController : ControllerBase
{
    [Authorize(Roles = "L-SCT, M-SCT, M-TRS, L-TRS")]
    [HttpGet("api/v1/bible")]
    [EnableRateLimiting("fixed")]
    public async Task<IActionResult> Get([FromServices] BibleHandler handler, [FromQuery] GetBibleDto dto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest();
        }

        DomainCore.ViewModelAbstraction.CViewModel result = await handler.Get(dto);

        return StatusCode(handler.StatusCode, result);
    }

    [Authorize(Roles = "L-SCT, M-SCT, M-TRS, L-TRS")]
    [HttpGet("api/v1/bible/rand")]
    [EnableRateLimiting("fixed")]
    public async Task<IActionResult> Get([FromServices] BibleHandler handler)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest();
        }

        DomainCore.ViewModelAbstraction.CViewModel result = await handler.GetRandAsync();

        return StatusCode(handler.StatusCode, result);
    }
}
