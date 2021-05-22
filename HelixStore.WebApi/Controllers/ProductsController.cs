using HelixStore.Business.Products.Public;
using HelixStore.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelixStore.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        PublicProductService _publicProductService = new PublicProductService();


        [HttpGet("type/{type_id}")]
        public ActionResult<List<Product>> GetProductsByType(int type_id)
        {
            var products = _publicProductService.GetProductByType(type_id);
            return products == null ? NotFound() : products;
        }

        [HttpGet("view/{product_id}")]
        public ActionResult<Product> GetProductById(int product_id)
        {
            var product = _publicProductService.GetProductById(product_id);
            return product == null ? NotFound() : product;
        }
    }
}
