using AutoMapper;
using ChurchCashFlow.Data.ViewModels.Dtos.Address;
using ChurchCashFlow.Data.Entities;

namespace ChurchCashFlow.Profiles;
public class AddressProfile : Profile
{
    public AddressProfile()
    {
        CreateMap<Address, EditAddressDto>();
        CreateMap<EditAddressDto, Address>();
    }
}
