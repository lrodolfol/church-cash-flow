using AutoMapper;
using ChurchCashFlow.Data.ViewModels.Dtos.Church;
using ChurchCashFlow.Data.Entities;

namespace ChurchCashFlow.Profiles;
public class ChurchProfile : Profile
{
    public ChurchProfile()
    {
        CreateMap<Church, ReadChurchDto>();
        CreateMap<EditChurchDto, Church>();
    }
}