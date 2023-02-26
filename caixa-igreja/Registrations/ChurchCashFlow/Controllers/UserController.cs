using AutoMapper;
using ChurchCashFlow.Data.ViewModels.Dtos.User;
using ChurchCashFlow.Extensions;
using ChurchCashFlow.Data.Entities;
using ChurchCashFlow.Data.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using ChurchCashFlow.Data.Queries;
using ChurchCashFlow.Data.Context;

namespace ChurchCashFlow.Controllers;

[ApiController]
public class UserController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly UserContext _userContext;

    public UserController(IMapper mapper, UserContext userContext)
    {
        _mapper = mapper;
        _userContext = userContext;
    }

    [HttpGet("api/v1/user")]
    public async Task<IActionResult> GetAll([FromQuery] bool active = true)
    {
        try
        {
            var userExpression = UsersQueries.GetUsersActive(active);
            var usersQuery = _userContext.GetAll(active);
            var users = await usersQuery.Where(userExpression).ToListAsync();

            var usersReadDto = _mapper.Map<IEnumerable<ReadUserDto>>(users);

            return Ok(new ResultViewModel<IEnumerable<ReadUserDto>>(usersReadDto));
        }
        catch
        {
            return StatusCode(500, new ResultViewModel<string>("Internal Error - US1101A"));
        }
    }

    [HttpGet("api/v1/user/{id:int}")]
    public async Task<IActionResult> GetOne([FromRoute] int id)
    {
        try
        {
            var user = _userContext.GetOne(id);

            if (user == null)
                return NotFound(new ResultViewModel<dynamic>("Object not found", null));

            ReadUserDto userReadDto = _mapper.Map<ReadUserDto>(user);

            return Ok(new ResultViewModel<ReadUserDto>(userReadDto));
        }
        catch
        {
            return StatusCode(500, new ResultViewModel<string>("Internal Error - US1102A"));
        }
    }

    [HttpPost("api/v1/user")]
    public async Task<IActionResult> Post([FromBody] EditUserDto userEditDto)
    {
        if (!ModelState.IsValid)
            return BadRequest(new ResultViewModel<string>(ModelState.GetErrors()));

        try
        {
            var user = _mapper.Map<User>(userEditDto);
            var newUser = await _userContext.Post(user);

            ReadUserDto userReadDto = _mapper.Map<ReadUserDto>(newUser);

            return Created($"/api/v1/user/{user!.Id}", new ResultViewModel<ReadUserDto>(userReadDto));
        }
        catch(DbUpdateException)
        {
            return StatusCode(400, new ResultViewModel<string>("Internal Error. Check the properties - US1103A"));
        }
        catch
        {
            return StatusCode(500, new ResultViewModel<string>("Internal Error. - US1103B"));
        }
    }

    [HttpPut("api/v1/user/{id:int}")]
    public async Task<IActionResult> Put([FromBody] EditUserDto userEditDto, int id)
    {
        if (!ModelState.IsValid)
            return BadRequest(new ResultViewModel<string>(ModelState.GetErrors()));

        try
        {
            var editUser = await _userContext.Put(userEditDto, id, _mapper);

            if (editUser == null)
                return NotFound(new ResultViewModel<dynamic>("Object not found", null));

            ReadUserDto userReadDto = _mapper.Map<ReadUserDto>(editUser);

            return Ok(new ResultViewModel<ReadUserDto>(userReadDto));
        }
        catch (DbUpdateException)
        {
            return StatusCode(400, new ResultViewModel<string>("Internal Error. Check the properties - US1104A"));
        }
        catch(Exception ex)
        {
            return StatusCode(500, new ResultViewModel<string>("Internal Error. - US1104B"));
        }
    }

    [HttpDelete]
    [Route("/api/v1/user/{id:int}")]
    public async Task<IActionResult> DeleteChurch(int id)
    {
        try
        {
            if(! await _userContext.Delete(id))
                return NotFound(new ResultViewModel<dynamic>("Object not found", null));

            return NoContent();
        }
        catch (DbException)
        {
            return StatusCode(500, new ResultViewModel<string>("Internal Error. Check the properties - US1104A"));
        }
        catch
        {
            return StatusCode(500, new ResultViewModel<string>("Internal Error - US1104B"));
        }
    }

}