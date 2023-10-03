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
        if (!_report.Any())
            return "";

        var orderReport = _report.OrderBy(x => x.Day).ToList();

        var jsonStr = JsonSerializer.Serialize(orderReport);

        return jsonStr;
    }

    public List<MonthlyClosing> GenerateObjectRecord(string json)
    {
        if (String.IsNullOrEmpty(json))
            new List<MonthlyClosing>();

        var obj = JsonSerializer.Deserialize<List<MonthlyClosing>>(json);
        var objSort = obj.OrderBy(x => x.Day).ToList();

        return objSort;
    }
}
