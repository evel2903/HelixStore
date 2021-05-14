using System;
using System.Collections.Generic;

#nullable disable

namespace HelixStore.Data.Models
{
    public partial class Staff
    {
        public Staff()
        {
            Invoices = new HashSet<Invoice>();
        }

        public int StaffId { get; set; }
        public string StaffFullname { get; set; }
        public string StaffGender { get; set; }
        public string StaffAddress { get; set; }
        public string StaffPhone { get; set; }
        public string StaffPassword { get; set; }
        public int RoleId { get; set; }

        public virtual Role Role { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}
