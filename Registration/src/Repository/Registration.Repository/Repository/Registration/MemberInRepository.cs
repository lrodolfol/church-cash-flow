using Microsoft.EntityFrameworkCore;
using Registration.DomainBase.Entities.Registrations;
using Registration.DomainCore.ContextAbstraction;

namespace Registration.Repository.Repository.Registration;

public class MemberInRepository : IMemberInRepository
{
    private readonly DataContext _context;

    public MemberInRepository(DataContext context)
    {
        _context = context;
    }

    public async Task Delete(MemberIn memberIn)
    {
        memberIn.Activate(false);
        await Put(memberIn);
    }

    public async Task Post(MemberIn memberIn)
    {
        await _context.MemberIn.AddAsync(memberIn);
        await SaveAsync();
    }

    public async Task Put(MemberIn memberIn)
    {
        _context.Entry(memberIn).State = EntityState.Modified;
        await SaveAsync();
    }

    private async Task SaveAsync()
    {
        await _context.SaveChangesAsync();
    }
}