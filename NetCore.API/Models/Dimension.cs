using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Dimension
    {
        public Dimension()
        {
            BoxLengthDimension = new HashSet<Box>();
            BoxWeightDimension = new HashSet<Box>();
            Material = new HashSet<Material>();
            StyleCost = new HashSet<StyleCost>();
            StyleCostGroup = new HashSet<StyleCostGroup>();
        }

        public int DimensionId { get; set; }
        public string DimensionCode { get; set; }
        public int DimensiontypeId { get; set; }
        public float Conversion { get; set; }
        public float? Offset { get; set; }
        public bool Visible { get; set; }
        public bool DefaultDimension { get; set; }

        public DimensionType Dimensiontype { get; set; }
        public ICollection<Box> BoxLengthDimension { get; set; }
        public ICollection<Box> BoxWeightDimension { get; set; }
        public ICollection<Material> Material { get; set; }
        public ICollection<StyleCost> StyleCost { get; set; }
        public ICollection<StyleCostGroup> StyleCostGroup { get; set; }
    }
}
