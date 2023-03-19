namespace ChurchCashFlow.Data.ViewModels.Dtos.Church;
public class ReadChurchDto : ModelDto
{
    public string Name { get; set; }
    public DataModelChurchCashFlow.Models.Entities.Address Address { get; set; }
}
