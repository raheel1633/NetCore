using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class RolePermission
    {
        public int RolepermissionId { get; set; }
        public int RoleId { get; set; }
        public int PermissionId { get; set; }

        public Permission Permission { get; set; }
        public Role Role { get; set; }
    }
}
