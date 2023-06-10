using Registration.DomainBase.Entities.Operations;

namespace Registration.DomainCore.InterfaceRepository;

public interface IMonthlyClosingDataBase
{
    public Task<List<MonthlyClosing>> SelectReportAsync(string churchId, string month, string year);
    

}