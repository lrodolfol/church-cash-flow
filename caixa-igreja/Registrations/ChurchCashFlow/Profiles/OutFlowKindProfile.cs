using AutoMapper;
using ChurchCashFlow.Data.ViewModels.Dtos.OutFlowKind;
using DataModelChurchCashFlow.Models.Entities;

namespace ChurchCashFlow.Profiles;
public class OutFlowKindProfile : Profile
{
    public OutFlowKindProfile()
    {
        CreateMap<OutFlowKind, ReadOutFlowKindDto>();
        CreateMap<EditOutFlowKindDto, OutFlowKind>();
    }
}