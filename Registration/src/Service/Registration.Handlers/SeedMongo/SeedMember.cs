using MongoDB.Driver;
using Registration.DomainCore.ContextAbstraction;
using Registration.Repository.Repository.Mongo;
using Registration.Repository.Repository.Mysql.Registration;

namespace Registration.Handlers.SeedMongo;
public class SeedMember
{
    private readonly IMemberRepository _memberRepository;
    private readonly MongoCommandRepository<List<DomainBase.Entities.Registrations.NoSql.Member>> _mongoCommand;
    
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
}
