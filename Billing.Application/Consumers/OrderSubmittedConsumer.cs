using MassTransit;
using Shared.Messaging.Events;

namespace Billing.Application.Consumers;

public class OrderSubmittedConsumer : IConsumer<OrderSubmitted>
{
    private readonly IBillingService _billingService;

    public OrderSubmittedConsumer(IBillingService billingService)
    {
        _billingService = billingService;
    }

    public async Task Consume(ConsumeContext<OrderSubmitted> context)
    {
        Console.WriteLine($"Consumer running for Order {context.Message.OrderId}");
        await _billingService.CreateBillingAsync(context.Message.OrderId, context.Message.CustomerEmail, context.Message.Amount );
    }
}