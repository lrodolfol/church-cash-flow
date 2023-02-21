using AutoMapper;
using ChurchCashFlow.Models;
using ChurchCashFlow.ViewModels.Dtos.Address;

namespace ChurchCashFlow.Profiles;
public class AddressProfile : Profile
{
    public AddressProfile()
    {
        CreateMap<Address, EditAddressDto>();
        CreateMap<EditAddressDto, Address>();
    }
}
