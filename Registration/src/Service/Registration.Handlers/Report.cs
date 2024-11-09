using Registration.DomainBase.Entities.Operations;
using Registration.DomainCore.InterfaceRepository;

namespace Registration.Handlers;

sealed public class Report
{
    private readonly IMonthlyClosingDataBase _repository;
    public Report(IMonthlyClosingDataBase repository, int churchId, string competence)
    {
        ChurchId = churchId;
        Competence = competence;
        _repository = repository;
    }

    public int ChurchId { get; private set; }
    public string Competence { get; private set; }


    public async Task<IEnumerable<MonthlyClosing>?> Generate()
    {
        if (ValidateProperties())
            throw new InvalidDataException("Church or competence is invalid");

        var month = DateTime.Parse(Competence).ToString("MM");
        var year = DateTime.Parse(Competence).ToString("yyyy");

        var report = await _repository.SelectReportAsync(ChurchId.ToString(), month, year);
        
        if (report.Count <= 0)
            return Enumerable.Empty<MonthlyClosing>();

        //var jsonReport = CallForgeRecord(report);

        return report.AsEnumerable();
    }

    private string CallForgeRecord(List<MonthlyClosing> record)
    {
        var forge = new ReportForge(record);
        var jsonStr = forge.GenerateJsonRecord();

        return jsonStr;
    }

    private bool ValidateProperties() => ChurchId == 0 || string.IsNullOrEmpty(Competence) || _repository == null;
}