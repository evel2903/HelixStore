using HelixStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelixStore.Business.Customers.Public
{
    public interface IPublicCustomerService
    {
        Customer Create(Customer customer);
        List<DeliveryAddress> GetDeliveryAddressByCustomerId(int id);
        DeliveryAddress CreateDeliveryAddressByCustomerId(DeliveryAddress deliveryAddress);
        DeliveryAddress GetDeliveryAddressByrId(int id);
    }
}
