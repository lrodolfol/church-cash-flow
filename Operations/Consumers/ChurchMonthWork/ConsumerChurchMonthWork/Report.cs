using ConsumerChurchMonthWork.Repository;
using Microsoft.Extensions.Logging;
using System.Data;

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


    public void Generate() 
    {
        if (ValidateProperties())
            return;
        
        var report = _repository.SelectReport();
    }

    private bool ValidateProperties() => ChurchId == 0 || string.IsNullOrEmpty(Competence) || _repository == null;
    
}

