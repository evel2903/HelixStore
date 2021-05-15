using HelixStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelixStore.Application.Staffs.Public
{
    public class PublicStaffService : IPublicStaffService
    {
        private readonly HelixStoreContext _context;
        public PublicStaffService()
        {
            _context = new HelixStoreContext();
        }

        public Staff ChangePassword(int id, string currentP, string newP)
        {
            var staff = _context.Staffs.Where(s => s.StaffId == id && s.StaffPassword == CreateMd5(currentP)).FirstOrDefault();

            if(staff == null)
            {
                return null;
            }
            staff.StaffPassword = CreateMd5(newP);

            return staff;
        }

        public Staff FindByPhoneAndPassword(string phone, string password)
        {
            var staff = _context.Staffs.Where(s => s.StaffPhone == phone && s.StaffPassword == CreateMd5(password)).FirstOrDefault();

            return staff == null ? null : staff;
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
