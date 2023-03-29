using AutoMapper;
using Registration.DomainBase.Entities;
using Registration.Mapper.DTOs.OfferingKind;

namespace ChurchCashFlow.Profiles;
public class OfferingKindProfile : Profile
{
    public OfferingKindProfile()
    {
        CreateMap<OfferingKind, ReadOfferingKindDto>();
        CreateMap<EditOfferingKindDto, OfferingKind>();
    }
}
