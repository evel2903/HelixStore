using System;
using System.Collections.Generic;

#nullable disable

namespace HelixStore.Data.Models
{
    public partial class InventoryReceivingVoucher
    {
        public int IrvId { get; set; }
        public int IrvAmount { get; set; }
        public DateTime IrvDate { get; set; }
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}
