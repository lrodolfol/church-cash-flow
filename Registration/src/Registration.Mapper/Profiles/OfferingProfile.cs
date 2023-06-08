using AutoMapper;
using Registration.DomainBase.Entities.Registrations;
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
