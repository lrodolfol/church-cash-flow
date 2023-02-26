using ChurchCashFlow.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ChurchCashFlow.Data.Context
{
    public class UserContext
    {
        private ModelContext _context;

        public UserContext(ModelContext context)
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
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);

            return user;
        }
         
        public async Task<User> Post(User user)
        {
            user.GeneratePassWordHash(user.PassWord);
            user.GenerateCode();

            _context.Add(user);
            Save();

            var newUser = await GetOne(user.Id);

            return newUser;
        }

        public async Task<User>? Put(User user, int id)
        {
            var Edituser = await GetOne(id);

            if (Edituser == null)
                return null;

            Edituser.GeneratePassWordHash(user.PassWord);
            Save();

            return Edituser;
        }

        public async Task<bool> Delete(int id)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
            if (user == null)
                return false;

            user.Activate(false);
            Save();

            return true;
        }

        private void Save()
        {
            _context.SaveChanges();
        }
    }
}
