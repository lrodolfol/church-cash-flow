using Registration.DomainBase.Entities.Operations;

namespace Registration.Handlers;

public class ReportForge
{
    private readonly List<MonthlyClosing> _report;

    public ReportForge(List<MonthlyClosing> report)
    {
        _report = report;
    }

    public void Run()
    {
        Console.WriteLine("Running");
    }
}
