using System.Collections.Immutable;

namespace Ordering.Application.Abstractions;

public record CreateOrderRequest(
    string CustomerEmail,
    ImmutableList<OrderItemDto> Items,
    decimal Discount
);