using Registration.DomainBase.Entities.Registrations;
using Registration.DomainCore.ContextAbstraction;
using Registration.Mapper.DTOs.Registration.MemberIn;
using Registration.Mapper.DTOs.Registration.MemberOut;

namespace Registration.Handlers.Handlers.Registrations;

public class MemberOutHandler
{
    private readonly IMemberOutRepository _context;

    public MemberOutHandler(IMemberOutRepository context) 
    {
        _context = context;
    }

    public async Task<bool> CreateAsync(EditMemberOutDto dto)
    {
        dto.Validate();
        if (!dto.IsValid)
        {
            return false; ;
        }

        try
        {
            var memberOut = new MemberOut(dto.Reason, dto.Day, dto.MemberId);
            await _context.Post(memberOut)!;

            return true;
        }
        catch
        {
            return false;
        }
    }

    public async Task<bool> Update(EditMemberOutDto dto)
    {
        await DeleteByMemberAsync(dto.MemberId);
        await CreateAsync(dto);

        return true;
    }

    public async Task<bool> DeleteByMemberAsync(int memberId)
    {
        var memberIn = await GetOneByMemberAsync(memberId);
        if(memberIn == null) 
            return true; 

        await _context.Delete(memberIn);
        return true;
    }

    public async Task<MemberOut> GetOneByMemberAsync(int memberId)
    {
        var memberIn = await _context.GetOneByMemberAsync(memberId);
        return memberIn!;
    }

}