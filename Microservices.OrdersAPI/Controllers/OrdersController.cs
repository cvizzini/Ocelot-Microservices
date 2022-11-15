using Microsoft.AspNetCore.Mvc;

namespace Microservices.OrdersAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrdersController : ControllerBase
{
    [HttpGet]
    public List<string> Get()
    {
        List<string> orders = new List<string>
        {
            "Order 1",
            "Order 2",
            "Order 3",
            "Order 4"
        };
        return orders;
    }
}