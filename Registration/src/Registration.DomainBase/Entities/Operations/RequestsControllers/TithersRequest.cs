namespace Registration.DomainBase.Entities.Operations.RequestsControllers;

public class TithersRequest
{
    public string YearMonth { get; set; } = String.Empty;   
    public int ChurchId { get; set; }
}
