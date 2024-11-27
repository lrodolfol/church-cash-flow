using Registration.DomainBase.Entities.Operations;
using Registration.DomainCore.InterfaceRepository;

namespace Registration.Handlers;

sealed public class Report
{
    private readonly IMonthlyClosingDataBase _repository;
    private List<MonthlyClosing> report = [];

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

        this.report = await _repository.SelectReportAsync(ChurchId.ToString(), month, year);
        ToConsolidateReport();

        if (this.report.Count <= 0)
            return Enumerable.Empty<MonthlyClosing>();

        return this.report.AsEnumerable();
    }

    private void ToConsolidateReport()
    {
        decimal currentBalance = 0;
        short cont = 0;

        this.report.ForEach(r =>
        {
            if (IsFirstRowFromMonthMinus1(r))
            {
                r.PreviousBalance = Math.Round(r.PreviousBalance, 3);
                r.CurrentBalance = Math.Round(r.CurrentBalance, 3);

                currentBalance = r.CurrentBalance;
            }
            else
            {
                r.PreviousBalance = Math.Round(currentBalance, 3);
                r.CurrentBalance = Math.Round(r.PreviousBalance + r.AmountInputOperation - r.AmountOutPutOperation, 3);

                currentBalance = r.CurrentBalance;
            }

            cont++;

            static bool IsFirstRowFromMonthMinus1(MonthlyClosing r)
            {
                return string.IsNullOrWhiteSpace(r.Church) || r.Description == "fisrt field month minus 1";
            }
        });
    }

    private bool ValidateProperties() => ChurchId == 0 || string.IsNullOrEmpty(Competence) || _repository == null;
}