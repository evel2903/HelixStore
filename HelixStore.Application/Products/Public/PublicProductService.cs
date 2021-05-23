using HelixStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelixStore.Business.Products.Public
{
    public class PublicProductService : IPublicProductService
    {
        private readonly HelixStoreContext _context;
        public PublicProductService()
        {
            _context = new HelixStoreContext();
        }
        public List<Product> GetAll()
        {
            var prds = _context.Products.ToList();

            return prds.Count == 0 ? null : prds;
        }
        public Product GetProductById(int product_id)
        {
            var prd = _context.Products.FirstOrDefault(p => p.ProductId == product_id);

            return prd == null ? null : prd;
        }

        public List<Product> GetProductByType(int type_id)
        {
            var prds = _context.Products.Where(p => p.ProductTypeId == type_id).ToList();

            return prds.Count == 0 ? null : prds;
        }

        public List<ProductType> GetProductType()
        {
            var prdTypes = _context.ProductTypes.ToList();

            return prdTypes == null ? null : prdTypes;
        }
    }
}
