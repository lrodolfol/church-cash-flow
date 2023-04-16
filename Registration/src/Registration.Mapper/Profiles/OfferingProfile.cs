using AutoMapper;
using Registration.DomainBase.Entities;
using Registration.Mapper.DTOs.Offering;

namespace ChurchCashFlow.Profiles;
public class OfferingProfile : Profile
{
    public OfferingProfile()
    {
        CreateMap<Offering, ReadOfferingDto>();
        CreateMap<EditOfferingDto, Offering>();
    }
}
