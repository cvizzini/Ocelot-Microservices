using Microsoft.AspNetCore.Mvc;

namespace Microservices.ProductsAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public List<string> Get()
        {
            List<string> products = new List<string>();
            products.Add("Samsung products");
            products.Add("Apple products");
            products.Add("Google products");
            products.Add("Microsoft products");
            return products;
        }
    }
}
