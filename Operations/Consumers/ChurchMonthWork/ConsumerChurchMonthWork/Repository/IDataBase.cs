using Entitie = ConsumerChurchMonthWork.Entitie;

namespace ConsumerChurchMonthWork.Repository;

public interface IDataBase { 
    public Task<List<Entitie.MonthlyClosing>> SelectReport(string churchId, string month, string year);
}
