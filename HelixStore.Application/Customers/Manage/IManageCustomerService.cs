using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelixStore.Data.Models;

namespace HelixStore.Business.Customers.Manage
{
    public interface IManageCustomerService
    {
        List<Customer> GetAll();
        Customer FindByPhone(string phone);
    }
}
