using AutoMapper;
using ChurchCashFlow.Data.Entities;
using ChurchCashFlow.Data.ViewModels.Dtos.Address;
using DataModelChurchCashFlow.Models.Entities;

namespace ChurchCashFlow.Profiles;
public class AddressProfile : Profile
{
    public AddressProfile()
    {
        CreateMap<Address, EditAddressDto>();
        CreateMap<EditAddressDto, Address>();
        CreateMap<ChurchAddress, Address>()
            .ForMember(address => address.Country, map =>
            map.MapFrom(churhAd => churhAd.EditAddressDto.Country))
            .ForMember(address => address.State, map =>
            map.MapFrom(churhAd => churhAd.EditAddressDto.State))
            .ForMember(address => address.City, map =>
            map.MapFrom(churhAd => churhAd.EditAddressDto.City))
            .ForMember(address => address.ZipCode, map =>
            map.MapFrom(churhAd => churhAd.EditAddressDto.ZipCode))
            .ForMember(address => address.District, map =>
            map.MapFrom(churhAd => churhAd.EditAddressDto.District))
            .ForMember(address => address.Street, map =>
            map.MapFrom(churhAd => churhAd.EditAddressDto.Street))
            .ForMember(address => address.Additional, map =>
            map.MapFrom(churhAd => churhAd.EditAddressDto.Additional))
            .ForMember(address => address.Number, map =>
            map.MapFrom(churhAd => churhAd.EditAddressDto.Number));
    }
}
