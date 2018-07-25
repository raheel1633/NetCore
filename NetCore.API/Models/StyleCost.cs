using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class StyleCost
    {
        public StyleCost()
        {
            StyleColorCost = new HashSet<StyleColorCost>();
        }

        public int StylecostId { get; set; }
        public int ClientId { get; set; }
        public int StyleId { get; set; }
        public int StylecostgroupId { get; set; }
        public int? MaterialId { get; set; }
        public string Description { get; set; }
        public decimal? Quantity { get; set; }
        public decimal Cost { get; set; }
        public int CurrencyId { get; set; }
        public int? DimensionId { get; set; }

        public Client Client { get; set; }
        public Currency Currency { get; set; }
        public Dimension Dimension { get; set; }
        public Material Material { get; set; }
        public Style Style { get; set; }
        public StyleCostGroup Stylecostgroup { get; set; }
        public ICollection<StyleColorCost> StyleColorCost { get; set; }
    }
}
