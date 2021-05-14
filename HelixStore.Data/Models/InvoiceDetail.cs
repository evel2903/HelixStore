using System;
using System.Collections.Generic;

#nullable disable

namespace HelixStore.Data.Models
{
    public partial class InvoiceDetail
    {
        public int InvoiceDetailId { get; set; }
        public int InvoiceDetailAmount { get; set; }
        public decimal InvoiceDetailTotal { get; set; }
        public int InvoiceId { get; set; }
        public int ProductId { get; set; }

        public virtual Invoice Invoice { get; set; }
        public virtual Product Product { get; set; }
    }
}
