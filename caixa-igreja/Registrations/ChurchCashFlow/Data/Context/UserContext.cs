using DataModelChurchCashFlow.Context.Interface;
using DataModelChurchCashFlow.Entities;
using Microsoft.EntityFrameworkCore;

namespace ChurchCashFlow.Data.Context
{
    public class UserContext: IUserContext
    {
        private readonly DataContext _context;

        public UserContext(DataContext context)
        {
            _context = context;
        }

        public IQueryable<User>? GetAll(bool active)
        {
            var usersQueryable = _context.Users.
                Include(x => x.Church).Include(x => x.Role).AsNoTracking().AsQueryable();

            return usersQueryable;
        }

        public async Task<User> GetOne(int id) {
            var user = await _context.Users.Include(x => x.Church).Include(x => x.Role)
                .FirstOrDefaultAsync(x => x.Id == id);

            return user;
        }

        public async Task<User> GetOneNoTracking(int id)
        {
            var user = await _context.Users.AsNoTracking()
                .Include(x => x.Church).Include(x => x.Role)
                .FirstOrDefaultAsync(x => x.Id == id);

            return user;
        }

        public async Task<User> GetByCode(string code)
        {
            var user = await _context.Users.AsNoTracking()
                .Include(x => x.Church).Include(x => x.Role)
                .FirstOrDefaultAsync(x => x.Code == code);

            return user;
        }

        public async Task Post(User user)
        {
            _context.Add(user);
            await Save();
        }

        public async Task Put(User user)
        {
            _context.Entry(user).State = EntityState.Modified;
            await Save();
        }

        public async Task Delete(User user)
        {
            user.Activate(false);
            await Put(user);
        }

        private async Task Save()
        {
            await _context.SaveChangesAsync();
        }

       
    }
}
