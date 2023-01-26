using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Module5_HW2.Models;

namespace Module5_HW2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            Product product1 = new Product() { Id = 1, ProductDescription = "Product is excellent", ProductName = "Excellent product", ProductPrice = 1000 };
            Product product2 = new Product() { Id = 2, ProductDescription = "Product is good", ProductName = "Good product", ProductPrice = 500 };
            Product product3 = new Product() { Id = 3, ProductDescription = "Product is bad", ProductName = "Bad product", ProductPrice = 250 };
            Product product4 = new Product() { Id = 4, ProductDescription = "Product is disgusting", ProductName = "Disgusting product", ProductPrice = 10 };
            return new[] { product1, product2, product3, product4 };
        }
    }
}
