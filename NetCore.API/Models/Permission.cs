using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Permission
    {
        public Permission()
        {
            RolePermission = new HashSet<RolePermission>();
        }

        public int PermissionId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int ActionId { get; set; }

        public Action Action { get; set; }
        public ICollection<RolePermission> RolePermission { get; set; }
    }
}
