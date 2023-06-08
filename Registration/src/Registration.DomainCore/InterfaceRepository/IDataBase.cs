using Registration.DomainBase.Entities.Operations;

namespace Registration.DomainCore.InterfaceRepository;

public interface IDataBase
{
    public Task<List<MonthlyClosing>> SelectReport(string churchId, string month, string year);
}