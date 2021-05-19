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
        Customer FindByPhoneAndPassword(string phone, string password);

        Customer ChangePassword(int id, string currentP, string newP);
    }
}
