using MassTransit;
using Shared.Messaging.Events;

namespace Billing.Application.Consumers;

public class RecalculateStatisticsConsumer : IConsumer<OrderSubmitted>
{
    public Task Consume(ConsumeContext<OrderSubmitted> context)
    {
        Console.WriteLine($"Recalculating statistics");
        var random = new Random();
        var seconds = random.Next(1, 10) * 1000;
        Thread.Sleep(seconds);
        Console.WriteLine($"    - Time elapsed: {seconds} seconds.");
        Console.WriteLine($"    - Statistics have been recalculated.");
        return Task.CompletedTask;
    }
}