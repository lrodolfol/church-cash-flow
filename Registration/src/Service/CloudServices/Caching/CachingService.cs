using Microsoft.Extensions.Caching.Distributed;
using Registration.DomainCore.ServicesAbstraction;

namespace CloudServices.Caching;
public class CachingService(IDistributedCache cache) : ICacheService
{
    private readonly IDistributedCache _cache = cache;

    public async Task SetStringAsync(string key, string value) =>
        await _cache.SetStringAsync(key, value);    
}
