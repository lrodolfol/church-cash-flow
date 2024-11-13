namespace Registration.DomainCore.Events;
public class monthlyClosedEvents(int churchId, string competence, string flowJsonFile) : DomainBaseEvents
{
    public int _churchId { get; set; } = churchId;
    public string _competence { get; set; } = competence;
    public string _flowJsonFile { get; set; } = flowJsonFile;
}
