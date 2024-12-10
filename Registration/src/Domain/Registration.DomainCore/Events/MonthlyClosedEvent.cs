using Registration.DomainBase.Entities.Operations;

namespace Registration.DomainCore.Events;
public class MonthlyClosedEvent(int churchId, string churchName, string competence, List<MonthlyClosing> flowJsonFile) : DomainBaseEvents
{
    public int ChurchId { get; set; } = churchId;
    public string ChurchName { get; set; } = churchName;
    public string Competence { get; set; } = competence;
    public List<MonthlyClosing> FlowJsonFile { get; set; } = flowJsonFile;
}
