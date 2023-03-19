using DataModelChurchCashFlow.Models.Entities;
using System.Linq.Expressions;

namespace DataModelChurchCashFlow.Queries;
public class Queries<T> where T : Entitie
{
    public static Expression<Func<T, bool>> GetActive(bool active)
    {
        return (x => x.Active == active);
    }
}