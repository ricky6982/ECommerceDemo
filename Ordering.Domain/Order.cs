namespace Ordering.Domain;

public class Order
{
    public Guid Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public OrderStatus Status { get; set; }
    
}