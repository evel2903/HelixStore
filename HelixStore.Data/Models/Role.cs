using System;
using System.Collections.Generic;

#nullable disable

namespace HelixStore.Data.Models
{
    public partial class Role
    {
        public Role()
        {
            Customers = new HashSet<Customer>();
            staff = new HashSet<Staff>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Staff> staff { get; set; }
    }
}
