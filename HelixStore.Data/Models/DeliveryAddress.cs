using System;
using System.Collections.Generic;

#nullable disable

namespace HelixStore.Data.Models
{
    public partial class DeliveryAddress
    {
        public int DeliveryAddressId { get; set; }
        public string DeliveryAddressRecipient { get; set; }
        public string DeliveryAddressAddress { get; set; }
        public string DeliveryAddressPhone { get; set; }
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
