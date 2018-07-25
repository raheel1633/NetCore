using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class StyleCostGroup
    {
        public StyleCostGroup()
        {
            Material = new HashSet<Material>();
            StyleCost = new HashSet<StyleCost>();
        }

        public int StylecostgroupId { get; set; }
        public int ClientId { get; set; }
        public string Description { get; set; }
        public bool RequireMaterial { get; set; }
        public int? DimensionId { get; set; }

        public Client Client { get; set; }
        public Dimension Dimension { get; set; }
        public ICollection<Material> Material { get; set; }
        public ICollection<StyleCost> StyleCost { get; set; }
    }
}
