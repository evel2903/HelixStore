using HelixStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelixStore.Application.Staffs.Public
{
    public interface IPublicStaffService
    {
        Staff FindByPhoneAndPassword(string phone, string password);

        Staff ChangePassword(int id, string currentP, string newP);
    }
}
