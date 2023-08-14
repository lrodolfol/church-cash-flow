using Microsoft.EntityFrameworkCore;
using Registration.DomainBase.Entities.Registrations;
using Registration.DomainCore.ContextAbstraction;

namespace Registration.Repository.Repository.Registration;

public class MemberOutRepository : IMemberOutRepository
{
    private readonly DataContext _context;

    public MemberOutRepository(DataContext context)
    {
        _context = context;
    }

    public async Task Delete(MemberOut memberOut)
    {
        memberOut.Activate(false);
        await Put(memberOut);
    }

    public Task<MemberOut> GetOneByMemberAsync(int memberId)
    {
        var memberIn = _context.MemberOut
            .FirstOrDefaultAsync(x => x.MemberId == memberId);

        return memberIn!;
    }

    public async Task Post(MemberOut memberOut)
    {
        await _context.MemberOut.AddAsync(memberOut);
        await SaveAsync();
    }

    public async Task Put(MemberOut memberOut)
    {
        _context.Entry(memberOut).State = EntityState.Modified;
        await SaveAsync();
    }

    private async Task SaveAsync()
    {
        await _context.SaveChangesAsync();
    }
}
