using System;
using System.Collections.Generic;

#nullable disable

namespace HelixStore.Data.Models
{
    public partial class InventoryDeliveryVoucher
    {
        public int IdvId { get; set; }
        public int IdvAmount { get; set; }
        public DateTime IdvDate { get; set; }
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}
