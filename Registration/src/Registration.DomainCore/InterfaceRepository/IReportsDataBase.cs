using Registration.DomainBase.Entities.Operations;
using Registration.DomainBase.Entities.Operations.RequestsControllers;

namespace Registration.DomainCore.InterfaceRepository;

public interface IReportsDataBase
{
    public Task<IEnumerable<MonthlyTithers>> SelectTitherByChurch (TithersRequest tithers);
}
