using HelixStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelixStore.Application.Staffs.Manage
{
    public class ManageStaffService: IManageStaffService
    {
        private readonly HelixStoreContext _context;
        public ManageStaffService()
        {
            _context = new HelixStoreContext();
        }

        public Staff Create(Staff staff)
        {
            staff.StaffPassword = null;
            _context.Staffs.Add(staff);
            _context.SaveChanges();

            return _context.Staffs.ToList().Last();
        }

        public Staff Update(int id, Staff staff)
        {
            var st = _context.Staffs
                .ToList()
                .FirstOrDefault(s => s.StaffId == id);

            if(st == null)
            {
                return null;
            }
            st.StaffFullname = staff.StaffFullname;
            st.StaffGender = staff.StaffGender;
            st.StaffAddress = staff.StaffAddress;
            st.StaffPhone = staff.StaffPhone;
            st.StaffPassword = staff.StaffPassword;
            st.RoleId = staff.RoleId;

            _context.SaveChanges();

            return st;

    }

        public Staff Delete(int id)
        {
            var st = _context.Staffs
                .ToList()
                .FirstOrDefault(s => s.StaffId == id);

            if (st == null)
            {
                return null;
            }
            _context.Staffs.Remove(st);
            _context.SaveChanges();
            return st;
        }

        public Staff FindByPhone(string phone)
        {
            var staff = _context.Staffs
                .ToList()
                .FirstOrDefault(s => s.StaffPhone == phone);

            if(staff == null)
            {
                return null;
            }
            staff.StaffPassword = "";
            return staff;

        }

        public List<Staff> GetAll()
        {
            var staffs = _context.Staffs
                .ToList();

            staffs.ForEach(s => s.StaffPassword = "");

            if(staffs == null)
            {
                return null;
            }

            return staffs;
        }

    }
}
