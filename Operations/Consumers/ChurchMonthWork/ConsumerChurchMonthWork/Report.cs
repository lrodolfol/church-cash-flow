using ConsumerChurchMonthWork.Repository.Connections;

namespace ConsumerChurchMonthWork;
public class Report
{
    private readonly IDataBase _repository;
    public Report(IDataBase repository, int churchId, string competence)
    {
        ChurchId = churchId;
        Competence = competence;
        _repository = repository;
    }

    public int ChurchId { get; private set; }
    public string Competence { get; private set; }


    public async Task<List<Entitie.MonthlyClosing>?> Generate() 
    {
        if (ValidateProperties())
            return null;

        var month = DateTime.Parse(Competence).ToString("MM");
        var year = DateTime.Parse(Competence).ToString("yyyy");

        var report = await _repository.SelectReport(ChurchId.ToString(), month, year);

        return report;
    }

    private bool ValidateProperties() => ChurchId == 0 || string.IsNullOrEmpty(Competence) || _repository == null;
    
}

