using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Department
    {
        public Department()
        {
            CommissionRule = new HashSet<CommissionRule>();
            Po = new HashSet<Po>();
        }

        public int DepartmentId { get; set; }
        public int EntityId { get; set; }
        public string DepartmentCode { get; set; }
        public string Name { get; set; }

        public ICollection<CommissionRule> CommissionRule { get; set; }
        public ICollection<Po> Po { get; set; }
    }
}
