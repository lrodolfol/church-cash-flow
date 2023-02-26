using ChurchCashFlow.Data.Entities;
using System.Linq.Expressions;

namespace ChurchCashFlow.Data.Queries;
public static class UsersQueries
{
    public static Expression<Func<User, bool>> GetUsersActive(bool active)
    {
        return (x => x.Active == active);
    }
}