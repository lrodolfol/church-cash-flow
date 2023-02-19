namespace ChurchCashFlow.ViewModels.Dtos;

public abstract class ReadModelDto
{
    public DateTime DateRequest
    {
        get
        {
            return DateTime.UtcNow;
        }
    }
}
