using AutoMapper;
using ChurchCashFlow.Models;
using ChurchCashFlow.ViewModels.Dtos.Church;

namespace ChurchCashFlow.Profiles;
public class ChurchProfile : Profile
{
    public ChurchProfile()
    {
        CreateMap<Church, ReadChurchDto>();
        CreateMap<EditChurchDto, Church>();
    }
}