using ChurchCashFlow.Models;

namespace ChurchCashFlow.ViewModels.Dtos.User;
public class ReadUserDto : ModelDto
{
    public int Id { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public bool Active { get; set; }
    public string Church{ get; set; }
    public string Role{ get; set; }
}
