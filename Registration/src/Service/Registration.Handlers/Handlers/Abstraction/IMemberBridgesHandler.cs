using Registration.Mapper.DTOs.Registration.MemberIn;
using Registration.Mapper.DTOs.Registration.MemberOut;

namespace Registration.Handlers.Handlers.Abstractions;
public interface IMemberBridgesHandler
{
    public Task<bool> CreateMemberInAsync(EditMemberInDto editMemberInDto);

    public Task CreateMemberPostAsync(int memberId, int[] postsIds);

    public Task DeleteMemberInByMemberAsync(int memberId);

    public Task DeleteMemberOutByMemberAsync(int memberId);

    public Task DeletePostByMemberAsync(int memberId);

    public Task<bool> UpdateMemberOutAsync(EditMemberOutDto editMemberOutDto);
}
