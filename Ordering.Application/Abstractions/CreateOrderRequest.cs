namespace Ordering.Application.Abstractions;

public record CreateOrderRequest
{
    public string CustomerEmail;
    public List<OrderItemDto> Items;
    public decimal Discount;
}