using ChurchCashFlow.Models;

namespace ChurchCashFlow.ViewModels.Dtos.Church;
public class ReadChurchDto : ReadModelDto
{
    public int id { get; set; }
    public string Name { get; set; }
    public Address Address { get; set; }
}
