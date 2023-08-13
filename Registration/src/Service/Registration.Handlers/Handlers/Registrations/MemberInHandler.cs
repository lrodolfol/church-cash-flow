using AutoMapper;
using Registration.DomainBase.Entities.Registrations;
using Registration.DomainCore.ContextAbstraction;
using Registration.DomainCore.HandlerAbstraction;
using Registration.DomainCore.ViewModelAbstraction;
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

}