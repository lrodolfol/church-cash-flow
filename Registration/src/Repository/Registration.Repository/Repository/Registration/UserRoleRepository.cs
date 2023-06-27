using Microsoft.EntityFrameworkCore;
using Registration.DomainBase.Entities.Registrations;
using Registration.DomainCore.ContextAbstraction;

namespace Registration.Repository.Repository.Registration;

public class UserRoleRepository : IUserRoleRepository
{
    private readonly DataContext _context;

    public UserRoleRepository(DataContext context)
    {
        _context = context;
    }

    public async Task Delete(int userId)
    {
        var uRoles = await GetByUserId(userId);

        foreach (var uRole in uRoles)
        {
            _context.Remove(uRole);
        }

        await SaveChanges();
    }

    public async Task<IEnumerable<UserRole>> GetByUserId(int userId)
    {
        var uRoles = (IEnumerable<UserRole>) await _context.UserRole
            .Where(x => x.UserId == userId)
            .ToListAsync();

        return uRoles;
    }

    public IQueryable<UserRole> GetByIds(int[] ids)
    {
        var userRoles = _context.UserRole
            .AsNoTracking()
            .AsQueryable();

        return userRoles;
    }

    public async Task Post(UserRole userRole)
    {
        _context.Add(userRole);
        await SaveChanges();
    }

    private async Task SaveChanges()
    {
        await _context.SaveChangesAsync();
    }
}