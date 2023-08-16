using Registration.Mapper.DTOs.Registration.MemberIn;
using Registration.Mapper.DTOs.Registration.MemberOut;

namespace Registration.Handlers.Handlers.Registrations;

public class MemberBridgesHandler
{
    private readonly MemberInHandler _memberInHandler;
    private readonly MemberOutHandler _memberOutHandler;
    private readonly MemberPostHandler _memberPostHandler;

    public MemberBridgesHandler(MemberInHandler memberInHandler, MemberOutHandler memberOutHandler, MemberPostHandler memberPostHandler)
    {
        _memberInHandler = memberInHandler;
        _memberOutHandler = memberOutHandler;
        _memberPostHandler = memberPostHandler;
    }

    public async Task<bool> CreateMemberInAsync(EditMemberInDto editMemberInDto) => 
        await _memberInHandler.CreateAsync(editMemberInDto);

    public async Task CreateMemberPostAsync(int memberId, int[] postsIds) =>
        await _memberPostHandler.Create(memberId, postsIds);    

    public async Task DeleteMemberInByMemberAsync(int memberId) =>
        await _memberInHandler.DeleteByMemberAsync(memberId);  

    public async Task DeleteMemberOutByMemberAsync(int memberId) =>
        await _memberOutHandler.DeleteByMemberAsync(memberId);    

    public async Task DeletePostByMemberAsync(int memberId) =>
        await _memberPostHandler.Delete(memberId);
    
    public async Task<bool> UpdateMemberOutAsync(EditMemberOutDto editMemberOutDto) =>
        await _memberOutHandler.Update(editMemberOutDto);
}
