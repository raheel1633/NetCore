using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class UserRole
    {
        public int UserroleId { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public int? ClientId { get; set; }
        public string Configuration { get; set; }

        public Client Client { get; set; }
        public Role Role { get; set; }
        public User User { get; set; }
    }
}
