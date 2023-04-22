using System.Xml.Linq;

namespace Registration.DomainBase.Entities;

public class MonthWork : Entitie
{
    public MonthWork()
    {
    }
    public MonthWork(int id, int yearMonth, bool block, int churchId)
    {
        Id = id;
        YearMonth = yearMonth;
        Block = block;
        ChurchId = churchId;
    }

    public int YearMonth { get; set; }
    public bool? Block { get; set; }
    public int ChurchId { get; set; }

    public Church Church { get; set; }

    
    
}
