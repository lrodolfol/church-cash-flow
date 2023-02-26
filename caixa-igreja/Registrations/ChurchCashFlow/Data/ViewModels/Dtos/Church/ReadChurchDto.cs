using Model = ChurchCashFlow.Data.Entities;

namespace ChurchCashFlow.Data.ViewModels.Dtos.Church;
public class ReadChurchDto : ModelDto
{
    public int id { get; set; }
    public string Name { get; set; }
    public bool Active { get; set; }
    public Model.Address Address { get; set; }
}
