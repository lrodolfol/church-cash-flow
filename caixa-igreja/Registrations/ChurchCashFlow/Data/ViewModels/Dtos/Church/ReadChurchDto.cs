namespace ChurchCashFlow.Data.ViewModels.Dtos.Church;
public class ReadChurchDto : ModelDto
{
    public int id { get; set; }
    public string Name { get; set; }
    public bool Active { get; set; }
    public DataModelChurchCashFlow.Models.Entities.Address Address { get; set; }
}
