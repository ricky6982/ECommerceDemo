﻿namespace Ordering.Application.Abstractions;

public record OrderItemDto
{
    public string ProductCode { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
}