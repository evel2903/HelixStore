using System;
using System.Collections.Generic;

#nullable disable

namespace HelixStore.Data.Models
{
    public partial class Product
    {
        public Product()
        {
            InventoryDeliveryVouchers = new HashSet<InventoryDeliveryVoucher>();
            InventoryReceivingVouchers = new HashSet<InventoryReceivingVoucher>();
            InvoiceDetails = new HashSet<InvoiceDetail>();
            ProductImgs = new HashSet<ProductImg>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductAmount { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductDescription { get; set; }
        public int ProductTypeId { get; set; }

        public virtual ProductType ProductType { get; set; }
        public virtual ICollection<InventoryDeliveryVoucher> InventoryDeliveryVouchers { get; set; }
        public virtual ICollection<InventoryReceivingVoucher> InventoryReceivingVouchers { get; set; }
        public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; }
        public virtual ICollection<ProductImg> ProductImgs { get; set; }
    }
}
