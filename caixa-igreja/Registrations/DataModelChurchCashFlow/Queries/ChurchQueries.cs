using DataModelChurchCashFlow.Entities;
using System.Linq.Expressions;

namespace DataModelChurchCashFlow.Queries;
public class ChurchQueries
{
    public static Expression<Func<Church, bool>> GetChurchActive(bool active)
    {
        return (x => x.Active == active);
    }
}
