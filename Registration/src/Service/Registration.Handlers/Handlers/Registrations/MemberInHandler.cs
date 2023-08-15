using Registration.DomainBase.Entities.Registrations;
using Registration.DomainCore.ContextAbstraction;
using Registration.Mapper.DTOs.Registration.MemberIn;

namespace Registration.Handlers.Handlers.Registrations;

public class MemberInHandler
{
    private readonly IMemberInRepository _context;

    public MemberInHandler(IMemberInRepository context) 
    {
        _context = context;
    }

    public async Task<bool> CreateAsync(EditMemberInDto dto)
    {
        dto.Validate();
        if (!dto.IsValid)
        {
            return false; ;
        }

        try
        {
            var memberIn = new MemberIn(dto.ChurchName, dto.LastPost, dto.LetterReceiver, dto.MemberId);
            await _context.Post(memberIn)!;

            return true;
        }
        catch
        {
            return false;
        }
    }

    public async Task<bool> Update(EditMemberInDto dto)
    {
        await DeleteByMemberAsync(dto.MemberId);
        await CreateAsync(dto);

        return true;
    }

    public async Task<bool> DeleteByMemberAsync(int memberId)
    {
        var memberIn = await GetOneByMemberAsync(memberId);
        if (memberIn == null)
            return true;

        await _context.Delete(memberIn);
        return true;
    }

    public async Task<MemberIn> GetOneByMemberAsync(int memberId)
    {
        var memberIn = await _context.GetOneByMemberAsync(memberId);
        return memberIn!;
    }

}