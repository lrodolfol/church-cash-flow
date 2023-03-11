using DataModelChurchCashFlow.Context.Interface;
using DataModelChurchCashFlow.Entities;

namespace RegistrationTest.ContextFake;
public class UserContextFake : IUserContext
{
    public static List<User> Users { get; set; } = new();

    public UserContextFake()
    {
        Users.Add(new User(1, "Rodolfo Jesus", 1, 1));
        Users.Add(new User(2, "Kelly Cristin", 1, 2));
        Users.Add(new User(3, "Gustavo Jesus", 2, 2));
        Users.Add(new User(4, "José Carlos", 2, 1));
    }

    public IQueryable<User>? GetAll() => Users.AsQueryable();

    public async Task<User> GetOne(int id) => Users.FirstOrDefault(x => x.Id == id);

    public async Task<User> GetOneNoTracking(int id) => Users.FirstOrDefault(x => x.Id == id);

    public async Task<User> GetByCode(string code) => Users.FirstOrDefault(x => x.Code == code);

    public async Task Post(User user)
    {
        var newUser = new User(Users.Count() + 1, user.Name, user.ChurchId, user.RoleId);
        Users.Add(user);
    }

    public async Task Put(User user)
    {
        
    }

    public async Task Delete(User user)
    {
        Users.Remove(user);
    }

    private async Task Save()
    {
        
    }
}