using HelixStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelixStore.Application.Products.Public
{
    public interface IPublicProductService
    {
        ProductType GetProductType();

        Product GetProductById(int product_id);

        List<Product> GetProductByType(int type_id);

        List<ProductImg> GetProductImgs(int product_id);

    }
}
