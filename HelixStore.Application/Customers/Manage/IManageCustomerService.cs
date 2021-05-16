using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelixStore.Data.Models;

namespace HelixStore.Application.Customers.Manage
{
    public interface IManageCustomerService
    {
        Customer Create(Customer customer);
        Customer Update(int id, Customer customer);
        Customer Delete(int id);
        List<Customer> GetAll();
        Customer FindByPhone(string phone);
    }
}
