using HelixStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelixStore.Business.Products.Public
{
    public interface IPublicProductService
    {
        List<ProductType> GetProductType();

        Product GetProductById(int product_id);

        List<Product> GetProductByType(int type_id);


    }
}
