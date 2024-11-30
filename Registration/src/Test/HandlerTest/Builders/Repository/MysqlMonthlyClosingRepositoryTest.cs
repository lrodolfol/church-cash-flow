using Microsoft.Extensions.Configuration;
using Registration.DomainBase.Entities.Operations;
using Registration.DomainCore.InterfaceRepository;
using Registration.Repository;

namespace HandlersTest.Builders.Repository;
internal class MysqlMonthlyClosingRepositoryTest : MysqlBase, IMonthlyClosingDataBase
{
    public MysqlMonthlyClosingRepositoryTest(IConfiguration configuration) : base(configuration)
    {
    }

    public Task<List<MonthlyClosing>> SelectReportAsync(string churchId, string month, string year)
    {
        return Task.FromResult(new List<MonthlyClosing>());
    }
}
