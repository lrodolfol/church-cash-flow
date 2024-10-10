namespace Registration.DomainCore.Events;
public class monthlyClosedEvents(int churchId, string competence) : DomainBaseEvents
{
    public int _churchId { get; set; } = churchId;
    public string _competence { get; set; } = competence;
}
