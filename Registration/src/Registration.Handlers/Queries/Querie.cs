using Registration.DomainBase.Entities.Registrations;
using System.Linq.Expressions;

namespace Registration.Handlers.Queries
{
    public class Querie<T> where T : Entitie
    {
        public static Expression<Func<T, bool>> GetActive(bool active)
        {
            return (x => x.Active == active);
        }
    }
}
