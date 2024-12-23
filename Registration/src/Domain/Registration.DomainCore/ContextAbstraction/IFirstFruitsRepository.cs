﻿using Registration.DomainBase.Entities.Registrations;

namespace Registration.DomainCore.ContextAbstraction;
public interface IFirstFruitsRepository
{
    public IQueryable<FirstFruits> GetAll(int churchId);
    public Task<FirstFruits> GetOneAsync(int id);
    public Task<FirstFruits> GetOneAsNoTracking(int id);
    public Task<FirstFruits> GetOneByChurch(int churchId, int id);
    public Task Post(FirstFruits fruits);
    public Task Put(FirstFruits fruits);
    public Task Delete(FirstFruits fruits);
}