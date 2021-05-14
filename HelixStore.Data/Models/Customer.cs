using System;
using System.Collections.Generic;

#nullable disable

namespace HelixStore.Data.Models
{
    public partial class Customer
    {
        public Customer()
        {
            DeliveryAddresses = new HashSet<DeliveryAddress>();
            Invoices = new HashSet<Invoice>();
        }

        public int CustomerId { get; set; }
        public string CustomerFullname { get; set; }
        public string CustomerGender { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerPassword { get; set; }
        public int RoleId { get; set; }

        public virtual Role Role { get; set; }
        public virtual ICollection<DeliveryAddress> DeliveryAddresses { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}
