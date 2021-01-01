using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] //Optional but conventional
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public string GetProducts()
        {
            return "this will be list of products";
        }

        [HttpGet("{id}")]
        public string GetProduct()
        {
            return "single product";
        }

    }
}