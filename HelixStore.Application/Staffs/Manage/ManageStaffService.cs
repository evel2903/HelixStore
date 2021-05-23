using HelixStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelixStore.Business.Staffs.Manage
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
            staff.StaffId = 0;
            
            if(staff.StaffPassword == "")
            {
                staff.StaffPassword = CreateMd5("123456");
            }
            else
            {
                staff.StaffPassword = CreateMd5(staff.StaffPassword);
            }
            
            _context.Staffs.Add(staff);
            _context.SaveChanges();

            return _context.Staffs.ToList().Last();
        }

        public Staff Update(int id, Staff staff)
        {
            var st = _context.Staffs
                .First(s => s.StaffId == id);

            if(st == null)
            {
                return null;
            }

            st.StaffPassword = CreateMd5(staff.StaffPassword);
            st.StaffFullname = staff.StaffFullname;
            st.StaffGender = staff.StaffGender;
            st.StaffAddress = staff.StaffAddress;
            st.StaffPhone = staff.StaffPhone;
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
            return staff;

        }

        public List<Staff> GetAll()
        {
            var staffs = _context.Staffs
                .ToList();

            if(staffs == null)
            {
                return null;
            }

            return staffs;
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
