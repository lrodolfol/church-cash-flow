using AutoMapper;
using Registration.DomainBase.Entities.Registrations.sql;
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
