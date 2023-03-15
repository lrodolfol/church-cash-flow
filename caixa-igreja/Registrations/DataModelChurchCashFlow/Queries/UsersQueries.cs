using DataModelChurchCashFlow.Models.Entities;
using System.Linq.Expressions;

namespace DataModelChurchCashFlow.Queries;
public class UsersQueries
{
    public static Expression<Func<User, bool>> GetUsersActive(bool active)
    {
        return (x => x.Active == active);
    }
}
