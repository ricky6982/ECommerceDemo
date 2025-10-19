using Ordering.Application.Abstractions;

namespace Ordering.Application;

public interface IOrderService
{
    Task<Guid> CreateOrderAsync(CreateOrderRequest request);
}