using MongoDB.Driver;
using Registration.DomainCore.ContextAbstraction;
using Registration.Repository.Repository.Mongo;

namespace Registration.Handlers.SeedMongo;
public class SeedMember : ISeedNoSql
{
    private readonly IMemberRepository _memberRepository;
    private readonly MongoCommandRepository<List<DomainBase.Entities.Registrations.NoSql.Member>> _mongoCommand;
    string ISeedNoSql.Name
    {
        get
        {
            return "Member";
        }
        set { }
    }

    public SeedMember(IMemberRepository memberRepository) =>
        (_memberRepository) = (memberRepository);

    public void Seed()
    {
        List<DomainBase.Entities.Registrations.sql.Member> membersSql = _memberRepository.GetAllNoTracking()!.ToList();
        List<DomainBase.Entities.Registrations.NoSql.Member> membersNoSql = [];

        membersSql.ForEach(member =>
        {
            membersNoSql.Add(member);
        });

        _mongoCommand.Create(membersNoSql).Wait();
    }

    void ISeedNoSql.Seed()
    {
        throw new NotImplementedException();
    }
}
