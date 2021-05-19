using HelixStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelixStore.Business.Customers.Public
{
    public class PublicCustomerService:IPublicCustomerService
    {
        private readonly HelixStoreContext _context;
        public PublicCustomerService()
        {
            _context = new HelixStoreContext();
        }

        public Customer ChangePassword(int id, string currentP, string newP)
        {
            var customer = _context.Customers.Where(c => c.CustomerId == id && c.CustomerPassword == CreateMd5(currentP)).FirstOrDefault();
            if(customer == null)
            {
                return null;
            }
            customer.CustomerPassword = CreateMd5(newP);

            return customer;

        }

        public Customer FindByPhoneAndPassword(string phone, string password)
        {
            var customer = _context.Customers.Where(c => c.CustomerPhone == phone && c.CustomerPassword == CreateMd5(password)).FirstOrDefault();

            return customer == null ? null : customer;
        }
       
        private string CreateMd5(string s)
        {
            using (var provider = System.Security.Cryptography.MD5.Create())
            {
                StringBuilder builder = new StringBuilder();

                foreach (byte b in provider.ComputeHash(Encoding.UTF8.GetBytes(s)))
                    builder.Append(b.ToString("x2").ToLower());

                return builder.ToString();
            }
        }


    }
}
