using AutoMapper;
using ChurchCashFlow.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ChurchCashFlow.DataManager;
public class ChurchContext : IChurchContext
{
    private readonly DataContext _context;
    private readonly IMapper _mapper;
    public async Task<IActionResult> DeleteChurch()
    {
        throw new NotImplementedException();
    }

    public async Task<IActionResult> GetChurch()
    {
        throw new NotImplementedException();
    }

    public async Task<IActionResult> GetChurches()
    {
        throw new NotImplementedException();
    }

    public async Task<IActionResult> GetChurchesWithAddress()
    {
        throw new NotImplementedException();
    }

    public async Task<IActionResult> PostChurch()
    {
        throw new NotImplementedException();
    }

    public async Task<IActionResult> PutChurch()
    {
        throw new NotImplementedException();
    }

    private void Save()
    {
        this._context.SaveChanges();
    }
}
