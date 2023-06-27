using AutoMapper;
using Registration.DomainBase.Entities.Registrations;
using Registration.Mapper.DTOs.Registration.OfferingKind;

namespace ChurchCashFlow.Profiles;
public class OfferingKindProfile : Profile
{
    public OfferingKindProfile()
    {
        CreateMap<OfferingKind, ReadOfferingKindDto>();
        CreateMap<EditOfferingKindDto, OfferingKind>();
    }
}
