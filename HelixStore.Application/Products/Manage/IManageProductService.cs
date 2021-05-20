using HelixStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelixStore.Business.Products.Manage
{
    public interface IManageProductService
    {
        Product Create(Product product);

        Product Update(int id, Product product);

        Product Delete(int id);

        Product InventoryReceiving(int amount, int product_id);
    }
}
