namespace Registration.DomainCore.ServicesAbstraction;
public interface ICacheService
{
    Task SetStringAsync(string key, string value);
    Task<string> GetStringAsync(string key);
    Task UnsetStringAsync(string v);
}
