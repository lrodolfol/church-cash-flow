using ChurchCashFlow.Data.Context;
using DataModelChurchCashFlow.Context.Interface;
using DataModelChurchCashFlow.Entities;
using Microsoft.EntityFrameworkCore;

namespace RegistrationTest.ContextFake;
public class UserContextFake 
{
    public List<User> Users { get; set; } = new();

    public UserContextFake()
    {
        Users.Add(new User(1, "Rodolfo Jesus", 1, 1));
        Users.Add(new User(2, "Kelly Cristin", 1, 2));
        Users.Add(new User(3, "Gustavo Jesus", 2, 2));
        Users.Add(new User(4, "José Carlos", 2, 1));
    }

    
}