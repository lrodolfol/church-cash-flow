using Entitie = ConsumerChurchMonthWork.Entitie;

namespace ConsumerChurchMonthWork.Repository.Connections;

public interface IDataBase
{
    public Task<List<Entitie.MonthlyClosing>> SelectReport(string churchId, string month, string year);
}
