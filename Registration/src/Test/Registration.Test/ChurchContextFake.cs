using Registration.DomainBase.Entities.Registrations;
using Registration.DomainCore.ContextAbstraction;

namespace Registration.Test;

internal class ChurchContextFake : IChurchRepository
{
    public static List<Church> churchList { get; private set; } = new();

    public Task Delete(Church church)
    {
        churchList.Remove(church);
        return Task.CompletedTask;
    }

    public IQueryable<Church>? GetAll(bool active) => churchList.AsQueryable();


    public async Task<Church> GetOne(int id)
    {
        return churchList.First(x => x.Id == id);
    }

    public Task<Church> GetOneNoTracking(int id) => this.GetOne(id);

    public Task Post(Church church)
    {
        churchList.Add(church);
        return Task.CompletedTask;
    }

    public Task Put(Church church)
    {
        throw new NotImplementedException();
    }
}
