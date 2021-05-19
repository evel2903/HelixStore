using HelixStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelixStore.Business.Products.Manage
{
    public class ManageProductService:IManageProductService
    {
        private readonly HelixStoreContext _context;
        public ManageProductService()
        {
            _context = new HelixStoreContext();
        }

        public Product Create(Product product)
        {
            product.ProductId = 0;
            _context.Products.Add(product);
            _context.SaveChanges();
            return _context.Products.ToList().Last();
        }

        public Product Update(int id, Product product)
        {
            var prd = _context.Products.First(p => p.ProductId == id);
            if (prd == null)
            {
                return null;
            }

            prd.ProductName = product.ProductName;
            prd.ProductPrice = product.ProductPrice;
            prd.ProductDescription = product.ProductDescription;
            prd.ProductTypeId = product.ProductTypeId;
            prd.ProductImg = product.ProductImg;

            _context.SaveChanges();
            return prd;
        }

        public Product Delete(int id)
        {
            var product = _context.Products.First(p => p.ProductId == id);
            if(product == null)
            {
                return null;
            }

            ClearInventoryDelivery(id);
            ClearInventoryReceiving(id);

            _context.Products.Remove(product);
            _context.SaveChanges();
            return product;

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

        private void ClearInventoryReceiving(int product_id)
        {
            var irs = _context.InventoryReceivingVouchers.Where(ir => ir.ProductId == product_id).ToList();

            if(irs == null)
            {
                return;
            }
            irs.ForEach(ir => _context.InventoryReceivingVouchers.Remove(ir));

            _context.SaveChanges();

        }

        private void ClearInventoryDelivery(int product_id)
        {
            var ids = _context.InventoryDeliveryVouchers.Where(ir => ir.ProductId == product_id).ToList();

            if (ids == null)
            {
                return;
            }
            ids.ForEach(id => _context.InventoryDeliveryVouchers.Remove(id));

            _context.SaveChanges();

        }

    }
}
