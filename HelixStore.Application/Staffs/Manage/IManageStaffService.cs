using HelixStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelixStore.Application.Staffs.Manage
{
    public interface IManageStaffService
    {
        Staff Create(Staff staff);
        bool Update(int id, Staff staff);
        Staff Delete(int id);
        List<Staff> GetAll();
        Staff FindByPhone(string phone);
    }
}
