using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Material
    {
        public Material()
        {
            StyleColor = new HashSet<StyleColor>();
            StyleCost = new HashSet<StyleCost>();
        }

        public int MaterialId { get; set; }
        public int ClientId { get; set; }
        public string Name { get; set; }
        public byte[] Rowversion { get; set; }
        public bool Multi { get; set; }
        public decimal? Cost { get; set; }
        public int? CurrencyId { get; set; }
        public int? DimensionId { get; set; }
        public int? StylecostgroupId { get; set; }

        public Client Client { get; set; }
        public Currency Currency { get; set; }
        public Dimension Dimension { get; set; }
        public StyleCostGroup Stylecostgroup { get; set; }
        public ICollection<StyleColor> StyleColor { get; set; }
        public ICollection<StyleCost> StyleCost { get; set; }
    }
}
