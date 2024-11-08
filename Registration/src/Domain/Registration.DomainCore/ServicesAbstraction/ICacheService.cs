namespace Registration.DomainCore.ServicesAbstraction;
public interface ICacheService
{
    Task SetStringAsync(string key, string value);
}
