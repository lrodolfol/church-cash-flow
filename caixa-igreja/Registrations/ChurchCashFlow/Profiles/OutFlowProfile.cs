using AutoMapper;
using ChurchCashFlow.Data.ViewModels.Dtos.OutFlow;
using DataModelChurchCashFlow.Models.Entities;

namespace ChurchCashFlow.Profiles;
public class OutFlowProfile : Profile
{
	public OutFlowProfile()
	{
		CreateMap<OutFlow, ReadOutFlowDto>()
			.ForMember(read => read.OutFlow, map =>
			map.MapFrom(outFlow => outFlow.OutFlowKind.Name))
			.ForMember(read => read.Church, map =>
			map.MapFrom(outFlow => outFlow.Church.Name));
		CreateMap<EditOutFlowDto, OutFlow>();
	}
}