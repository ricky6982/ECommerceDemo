using MassTransit;
using Ordering.Application.Abstractions;
using Ordering.Domain;
using Shared.Messaging.Events;

namespace Ordering.Application;

public class OrderService : IOrderService
{
    private readonly IPublishEndpoint _publishEndpoint;

    public OrderService(IPublishEndpoint publishEndpoint)
    {
        _publishEndpoint = publishEndpoint;
    }
    
    public async Task<Guid> CreateOrderAsync(CreateOrderRequest request)
    {
        // TODO: Validate request
        Console.WriteLine("The order has been validated.");
        
        var orderId = Guid.NewGuid();
        
        var total = request.Items.Sum(i => i.UnitPrice * i.Quantity) - request.Discount;
        
        var order = new Order
        {
            Id = orderId,
            CreatedAt = DateTime.UtcNow,
            Status = OrderStatus.Created,
            CustomerEmail = request.CustomerEmail,
            Items = request.Items.Select(i => new OrderItem
            {
                ProductCode = i.ProductCode,
                Quantity = i.Quantity,
                UnitPrice = i.UnitPrice
            }).ToList(),
            Total = total
        };
        
        // TODO: Save order to database
        Console.WriteLine("The order has been created and saved to database.");
        
        // Publish the processed order event
        var e = new OrderSubmitted(orderId, order.CustomerEmail, order.Total);
        await _publishEndpoint.Publish(e);
        Console.WriteLine("The order has been published.");

        return orderId;
    }
}