using Registration.DomainBase.Entities.Operations;
using System.Text.Json;

namespace Registration.Handlers;

sealed public class ReportForge
{
    private readonly List<MonthlyClosing> _report;

    public ReportForge(List<MonthlyClosing> report)
    {
        _report = report;
    }

    public string GenerateJsonRecord()
    {
        var orderReport = _report.OrderBy(x => x.Day).ToList();

        var jsonStr = JsonSerializer.Serialize(orderReport);

        return jsonStr;
    }
}
