using AutoMapper;
using ChurchCashFlow.Data.Entities;
using ChurchCashFlow.Data.ViewModels.Dtos.User;
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
            await Save();

            var newUser = await GetOne(user.Id);

            return newUser;
        }

        public async Task<User>? Put(EditUserDto editUser, int id, IMapper mapper)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);

            if (user == null)
                return null;

            user = mapper.Map(editUser,user);
            user.GeneratePassWordHash(editUser.PassWord);
            
            await Save();

            return user;
        }

        public async Task<bool> Delete(int id)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
            if (user == null)
                return false;

            user.Activate(false);
            await Save();

            return true;
        }

        private async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
