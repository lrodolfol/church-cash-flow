using ConsumerChurchMonthWork.Entitie;

namespace ConsumerChurchMonthWork.Repository;

public interface IDataBase { 
    public IEnumerable<MonthlyClosing> SelectReport();
}
