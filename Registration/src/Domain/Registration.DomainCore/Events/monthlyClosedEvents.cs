namespace Registration.DomainCore.Events;
public class monthlyClosedEvents(int churchId, string competence, string flowJsonFile) : DomainBaseEvents
{
    public int ChurchId { get; set; } = churchId;
    public string Competence { get; set; } = competence;
    public string FlowJsonFile { get; set; } = flowJsonFile;
}
