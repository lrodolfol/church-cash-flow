using System;

namespace Registration.API.Extensions;

public static class InitialInformation
{
    public static void ShowInitial()
    {
        var enviroment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
        Console.WriteLine($"Iniciando aplicação em {enviroment}");
    }
}