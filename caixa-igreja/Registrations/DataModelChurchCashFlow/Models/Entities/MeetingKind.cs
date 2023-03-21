﻿namespace DataModelChurchCashFlow.Models.Entities;
public class MeetingKind : Entitie
{
    public string Name { get; private set; }
    public string Description { get; private set; }

    public MeetingKind(int id, string name, string description)
    {
        Id = id;
        Name = name;
        Description = description;
    }
}