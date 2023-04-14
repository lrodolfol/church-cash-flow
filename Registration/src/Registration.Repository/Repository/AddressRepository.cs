using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Registration.DomainBase.Entities;
using Registration.Mapper.DTOs.Address;

namespace Regristration.Repository.Repository;
public class AddressRepository
{
    private readonly DataContext _context;
    private readonly IMapper _mapper;
    public AddressRepository(DataContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<Address> Put(EditAddressDto addressEditDto, int addressId)
    {
        var address = await GetOne(addressId);
        if (address == null)
            return null;

        address = _mapper.Map(addressEditDto, address);

        await Save();

        return address;
    }

    public async Task<Address> GetOne(int id)
    {
        var address = await _context.Adresses.FirstOrDefaultAsync(x => x.Id == id);
        if (address == null)
            return null;

        return address;
    }

    private async Task Save()
    {
        await _context.SaveChangesAsync();
    }
}
