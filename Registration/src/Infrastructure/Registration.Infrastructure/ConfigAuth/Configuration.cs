namespace Registration.Infrastructure.ConfigAuth;
public static class Configuration
{
    public static string JwtKey { get; private set; } = "94b60939-18cf-438b-8458-7d0f1216d2e5tnn";
    public static int TimeTokenExpireH { get; private set; } = 8;
    public static string ApiKeyName { get; private set; } = "api_key";
    public static string ApiKey { get; private set; } = "134bf5af-83d8-45fc-a159-b988b0c599fctnn";
}