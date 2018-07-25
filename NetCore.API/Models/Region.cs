using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Region
    {
        public Region()
        {
            CommissionRule = new HashSet<CommissionRule>();
            Entity = new HashSet<Entity>();
        }

        public int RegionId { get; set; }
        public int EntityId { get; set; }
        public string RegionCode { get; set; }
        public string Name { get; set; }
        public string Group { get; set; }

        public ICollection<CommissionRule> CommissionRule { get; set; }
        public ICollection<Entity> Entity { get; set; }
    }
}
