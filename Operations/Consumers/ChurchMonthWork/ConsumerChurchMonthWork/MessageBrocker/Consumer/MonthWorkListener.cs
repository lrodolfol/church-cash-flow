using Microsoft.Extensions.Hosting;

namespace ConsumerChurchMonthWork.MessageBrocker.Consumer;
public class MonthWorkListener : BackgroundService
{
    protected override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (true)
        {
            Console.WriteLine("Hello World!");
            Thread.Sleep(1_000);
        }
    }
}
