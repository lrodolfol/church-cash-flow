using ChurchCashFlow.Data.Entities;
using System.Linq.Expressions;

namespace ChurchCashFlow.Data.Queries;
public static class ChurchQueries
{
    public static Expression<Func<Church, bool>> GetChurchActive(bool active)
    {
        return (x => x.Active == active);
    }
}
