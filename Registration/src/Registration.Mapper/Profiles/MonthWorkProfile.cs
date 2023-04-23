using AutoMapper;
using Registration.DomainBase.Entities;
using Registration.Mapper.DTOs.Offering;
using Registration.Mapper.DTOs.Tithes;

namespace Registration.Mapper.Profiles;

public class MonthWorkProfile : Profile
{
    public MonthWorkProfile()
    {
        CreateMap<MonthWork, ReadMonthWorkDto>()
            .ForMember(read => read.Church, map =>
                map.MapFrom(monthW => monthW.Church.Name))
            .ForMember(read => read.YeahMonth, map =>
                map.MapFrom(monthW => monthW.YearMonth.ToString().Substring(4, 2) + "/" + monthW.YearMonth.ToString().Substring(0,4)));
        CreateMap<EditMonthWorkDto, MonthWork>();
    }
}
