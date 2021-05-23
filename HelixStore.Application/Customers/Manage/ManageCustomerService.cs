using HelixStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelixStore.Business.Customers.Manage
{
    public class ManageCustomerService : IManageCustomerService
    {
        private readonly HelixStoreContext _context;
        public ManageCustomerService()
        {
            _context = new HelixStoreContext();
        }
        public Customer FindByPhone(string phone)
        {
            var customer = _context.Customers.FirstOrDefault(c => c.CustomerPhone == phone);
            return customer == null ? null : customer;
        }

        public List<Customer> GetAll()
        {
            var customers = _context.Customers.ToList();
            return customers == null ? null : customers;
        }
    }
}
