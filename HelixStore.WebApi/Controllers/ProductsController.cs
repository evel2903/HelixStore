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

        [HttpGet]
        public ActionResult<List<Product>> GetProductsByType()
        {
            var products = _publicProductService.GetAll();
            return products == null ? NotFound() : products;
        }

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
        [HttpGet("image/{product_id}/{file_name}")]
        public async Task<IActionResult> GetImage(int product_id, string file_name)
        {
            try
            {
                string srcPath = @"C:\Users\evell\Desktop\2-2020-2021\XDPMPL\HelixStore\HelixStore.Data\Images\";
                string filePath = srcPath + product_id + @"\" + file_name;
                if (System.IO.File.Exists(filePath))
                {
                    byte[] b = System.IO.File.ReadAllBytes(filePath);
                    return File(b, "image/png");
                }
                byte[] b1 = System.IO.File.ReadAllBytes(srcPath + "Default.png");
                return File(b1, "image/png");
            }
            catch
            {
                return NotFound();
            }
        }
    }
}
