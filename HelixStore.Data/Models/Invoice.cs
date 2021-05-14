using System;
using System.Collections.Generic;

#nullable disable

namespace HelixStore.Data.Models
{
    public partial class Invoice
    {
        public Invoice()
        {
            InvoiceDetails = new HashSet<InvoiceDetail>();
        }

        public int InvoiceId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public decimal InvoiceProvisionalAmount { get; set; }
        public decimal InvoiceDiscount { get; set; }
        public decimal InvoiceTotal { get; set; }
        public int DeliveryAddressId { get; set; }
        public int CustomerId { get; set; }
        public int StaffId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Staff Staff { get; set; }
        public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; }
    }
}
