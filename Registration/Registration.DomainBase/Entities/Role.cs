﻿namespace Registration.DomainBase.Entities;
public class Role
{
    public int Id { get; set; }
    public string Name { get; set; }
    public IList<User> Users { get; set; }

    public Role(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public Role()
    { }

}
