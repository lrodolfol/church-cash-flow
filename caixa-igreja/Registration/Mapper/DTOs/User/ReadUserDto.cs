using Registration.DomainCore.ViewModel;

namespace Registration.Mapper.DTOs.User;
public class ReadUserDto : ModelDto
{
    public string Code { get; set; }
    public string Name { get; set; }
    public string Church { get; set; }
    public string Role { get; set; }
}
