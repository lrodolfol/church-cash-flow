namespace Registration.DomainCore.Events;
public class MonthlyOpenedEvent(int churchId, string churchName, string competence) : DomainBaseEvents
{
    public int ChurchId { get; } = churchId;
    public string ChurchName { get; } = churchName;
    public string Competence { get; } = competence;
}
