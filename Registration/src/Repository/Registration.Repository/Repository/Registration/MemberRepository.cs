using Microsoft.EntityFrameworkCore;
using Registration.DomainCore.ContextAbstraction;
using Registration.DomainBase.Entities.Registrations;

namespace Registration.Repository.Repository.Registration;
public class MemberRepository : IMemberRepository
{
    private readonly DataContext _context;

    public MemberRepository(DataContext context)
    {
        _context = context;
    }


    public IQueryable<Member>? GetAllForChurch()
    {
        var membersQueryable = _context.Members.AsNoTracking().AsQueryable();

        return membersQueryable;
    }

    public IQueryable<Member>? GetAllNoTracking()
    {
        var membersQueryable = _context.Members.
            Include(x => x.Church).AsNoTracking().AsQueryable();

        return membersQueryable;
    }

    public async Task<Member> GetOne(int id)
    {
        var member = await _context.Members.
            Include(x => x.Church).FirstOrDefaultAsync(x => x.Id == id);

        return member;
    }

    public async Task<Member> GetOneNoTracking(int id)
    {
        var member = await _context.Members.AsNoTracking()
            .Include(x => x.Church)
            .FirstOrDefaultAsync(x => x.Id == id);

        return member;
    }

    public async Task<Member> GetByCode(string code)
    {
        var member = await _context.Members.AsNoTracking()
            .Include(x => x.Church)
            .FirstOrDefaultAsync(x => x.Code == code);

        return member;
    }

    public async Task Post(Member member)
    {
        _context.Add(member);
        await Save();
    }

    public async Task Put(Member member)
    {
        _context.Entry(member).State = EntityState.Modified;
        await Save();
    }

    public async Task Delete(Member member)
    {
        member.Activate(false);
        await Put(member);
    }

    private async Task Save()
    {
        await _context.SaveChangesAsync();
    }
}