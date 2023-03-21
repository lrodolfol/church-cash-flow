using AutoMapper;
using ChurchCashFlow.Data.ViewModels.Dtos.OfferingKind;
using DataModelChurchCashFlow.Models.Entities;

namespace ChurchCashFlow.Profiles;
public class OfferingKindProfile : Profile
{
    public OfferingKindProfile()
    {
        CreateMap<OfferingKind, ReadOfferingKindDto>();
        CreateMap<EditOfferingKindDto, OfferingKind>();
    }
}
