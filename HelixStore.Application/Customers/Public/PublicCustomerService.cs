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

        public Customer Login(string phone, string password)
        {
            var cus = _context.Customers.FirstOrDefault(c =>  c.CustomerPhone == phone && c.CustomerPassword == CreateMd5(password) );
            if (cus == null)
            {
                return null;
            }
            cus.CustomerPassword = "";
            return cus;
        }

        public Customer Signup(string fullname, string gender, string phone)
        {
            Customer customer = new Customer();
            customer.CustomerFullname = fullname;
            customer.CustomerGender = gender;
            customer.CustomerPhone = phone;
            customer.CustomerPassword = CreateMd5("123456");
            customer.RoleId = 2;
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return _context.Customers.ToList().Last();
        }


        public Customer Create(Customer customer)
        {
            customer.CustomerPassword = CreateMd5("123456");
            _context.Customers.Add(customer);
            _context.SaveChanges();

            return _context.Customers.ToList().Last();
        }

        public DeliveryAddress CreateDeliveryAddressByCustomerId(DeliveryAddress deliveryAddress)
        {
            _context.DeliveryAddresses.Add(deliveryAddress);
            _context.SaveChanges();
            return _context.DeliveryAddresses.ToList().Last();
        }

        public List<DeliveryAddress> GetDeliveryAddressByCustomerId(int id)
        {
            var list = _context.DeliveryAddresses.Where(da => da.CustomerId == id).ToList();

            return list == null ? null : list;
        }

        public DeliveryAddress GetDeliveryAddressByrId(int id)
        {
            var da = _context.DeliveryAddresses.FirstOrDefault(d => d.DeliveryAddressId == id);
            return da == null ? null : da;
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
