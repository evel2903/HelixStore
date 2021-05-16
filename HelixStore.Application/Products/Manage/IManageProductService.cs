using HelixStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelixStore.Application.Products.Manage
{
    public interface IManageProductService
    {
        Product Create(Product product, List<ProductImg> imgs);

        Product Update(int id, Product product, List<ProductImg> imgs);
        Product Delete(int id);
    }
}
