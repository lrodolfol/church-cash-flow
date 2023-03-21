using DataModelChurchCashFlow.Context.Interface;
using DataModelChurchCashFlow.Models.Entities;

namespace RegistrationTest.ContextFake;
public class MemberContextFake : IMemberContext
{
    public static List<Member> Members { get; private set; } = new();

	public MemberContextFake()
	{
		Members.Add(new Member(1, "Leandro Siqueia", DateTime.Parse("1990-05-01"), 1, 1));
        Members.Add(new Member(1, "Joana Margarida", DateTime.Parse("1995-12-18"), 2, 1));
        Members.Add(new Member(1, "Lucas Almeida", DateTime.Parse("2000-08-10"), 2, 2));
    }

    public IQueryable<Member>? GetAllNoTracking()
    {
        throw new NotImplementedException();
    }

    public IQueryable<Member>? GetAllForChurch()
    {
        throw new NotImplementedException();
    }

    public async Task<Member> GetOne(int id)
    {
        return Members.FirstOrDefault(x => x.Id == id);
    }

    public async Task<Member> GetByCode(string code)
    {
        return Members.FirstOrDefault(x => x.Code == code);
    }

    public async Task<Member> GetOneNoTracking(int id)
    {
        return Members.FirstOrDefault(x => x.Id == id);
    }

    public async Task Post(Member editMember)
    {
        Members.Add(editMember);
    }

    public Task Put(Member editMember)
    {
        throw new NotImplementedException();
    }

    public Task Delete(Member Member)
    {
        throw new NotImplementedException();
    }
}
