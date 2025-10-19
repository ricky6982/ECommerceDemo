using Microsoft.AspNetCore.Mvc;
using Ordering.Application;
using Ordering.Application.Abstractions;

namespace Ordering.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
[Produces("application/json")]
public class OrderController : ControllerBase
{
    private readonly IOrderService _orderService;

    public OrderController(IOrderService orderService)
    {
        _orderService = orderService;
    }
    
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    
    public async Task<IActionResult> CreateOrderAsync(CreateOrderRequest request)
    {
        await _orderService.CreateOrderAsync(request);

        return Ok();
    }
}