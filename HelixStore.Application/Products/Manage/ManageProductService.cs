using HelixStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelixStore.Application.Products.Manage
{
    public class ManageProductService:IManageProductService
    {
        private readonly HelixStoreContext _context;
        public ManageProductService()
        {
            _context = new HelixStoreContext();
        }

        public Product Create(Product product, List<ProductImg> imgs)
        {
            _context.Products.Add(product);

            if(imgs != null)
            {
                imgs.ForEach(img => _context.ProductImgs.Add(img));
            }

            _context.SaveChanges();
            return _context.Products.LastOrDefault();

        }

        public Product Delete(int id)
        {
            var product = _context.Products.FirstOrDefault(p => p.ProductId == id);
            if(product == null)
            {
                return null;
            }
            var imgs = _context.ProductImgs.Where(p => p.ProductId == product.ProductId).ToList();
            imgs.ForEach(i => _context.ProductImgs.Remove(i));
            _context.Products.Remove(product);

            _context.SaveChanges();

            return product;
        }

        public Product Update(int id, Product product, List<ProductImg> imgs)
        {
            var prd = _context.Products.FirstOrDefault(p => p.ProductId == id);

            if(prd == null)
            {
                return null;
            }
            var listPrevImgs = _context.ProductImgs.Where(pi => pi.ProductId == id).ToList();

            if(listPrevImgs != null)
            {
                listPrevImgs.ForEach(pi => _context.ProductImgs.Remove(pi));
            }

            if (imgs != null)
            {
                imgs.ForEach(img => _context.ProductImgs.Add(img));
            }
            _context.SaveChanges();
            return prd;

        }

        public Product InventoryReceiving(int amount, int product_id)
        {
            var product = _context.Products.FirstOrDefault(p => p.ProductId == product_id);
            if (product == null)
            {
                return null;
            }
            InventoryReceivingVoucher iR = new InventoryReceivingVoucher();
            iR.IrvAmount = amount;
            iR.IrvDate = DateTime.Now;
            iR.ProductId = product_id;

            _context.InventoryReceivingVouchers.Add(iR);
            _context.SaveChanges();



            return UpdateProductAmount(product_id);
        }

        private Product UpdateProductAmount(int product_id)
        {
            var irv = _context.InventoryReceivingVouchers.Where(i => i.ProductId == product_id).ToList(); //Nhap
            var idv = _context.InventoryDeliveryVouchers.Where(i => i.ProductId == product_id).ToList(); //Xuat

            int irvCountAmout = 0;
            int idvCountAmout = 0;

            irv.ForEach(i => irvCountAmout += i.IrvAmount);
            idv.ForEach(i => idvCountAmout += i.IdvAmount);

            var product = _context.Products.FirstOrDefault(p => p.ProductId == product_id);
            product.ProductAmount = (irvCountAmout - idvCountAmout);
            _context.SaveChanges();

            return product;

        }
    }
}
