using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Action
    {
        public Action()
        {
            Permission = new HashSet<Permission>();
        }

        public int ActionId { get; set; }
        public string ActionCode { get; set; }
        public string Description { get; set; }

        public ICollection<Permission> Permission { get; set; }
    }
}
