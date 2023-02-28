using ChurchCashFlow.Data.Entities;
using ChurchCashFlow.Data.ViewModels.Dtos.Church;
using ChurchCashFlow.Data.ViewModels;
using Microsoft.EntityFrameworkCore;
using ChurchCashFlow.Data.Queries;
using AutoMapper;
using System;
using ChurchCashFlow.Data.ViewModels.Dtos.Address;

namespace ChurchCashFlow.Data.Context;
public class ChurchContext
{
    private readonly DataContext _context;
    private readonly IMapper _mapper;
    private readonly AddressContext _contextAddress;

    public ChurchContext(DataContext context, IMapper mapper, AddressContext contextAddress)
    {
        _context = context;
        _mapper = mapper;
        _contextAddress = contextAddress;
    }

    public async Task<IQueryable<Church>> GetAll(bool active)
    {
        var churchQueryable = _context.Churches.AsNoTracking().Include(x => x.Address).AsQueryable();

        return churchQueryable;
    }

    public async Task<Church> GetOne(int id)
    {
        var church = await _context.Churches.
               Include(x => x.Address).FirstOrDefaultAsync(x => x.Id == id);

        if (church == null)
            return null;

        return church;
    }

    public async Task<Church> Post(Church church)
    {
        _context.Add(church);
        await Save();

        var newChurch = await GetOne(church.Id);

        return newChurch;
    }

    public async Task<Church> Put(ChurchAddress churchAddress, int id)
    {
        EditAddressDto addressEditDto = churchAddress.EditAddressDto;
        EditChurchDto churchEditDto = churchAddress.EditChurchDto;

        var church = await GetOne(id);

        if (church == null)
            return null;

        church = _mapper.Map(churchEditDto, church);

        //make PUT on AddressContext
        await _contextAddress.Put(addressEditDto, church.AddressId);

        await Save();

        return church;
    }

    public async Task<bool> Delete(int id)
    {
        var church = await GetOne(id);
        if (church == null)
            return false;

        church.Activate(false);
        await Save();

        return true;
    }

    private async Task Save()
    {
        await _context.SaveChangesAsync();
    }

}
