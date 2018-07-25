using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class SizePriceGroup
    {
        public SizePriceGroup()
        {
            SizePrice = new HashSet<SizePrice>();
            StyleColorPrice = new HashSet<StyleColorPrice>();
            StylePrice = new HashSet<StylePrice>();
        }

        public int SizepricegroupId { get; set; }
        public int? ClientId { get; set; }
        public int? SizematrixId { get; set; }
        public string Name { get; set; }

        public Client Client { get; set; }
        public SizeMatrix Sizematrix { get; set; }
        public ICollection<SizePrice> SizePrice { get; set; }
        public ICollection<StyleColorPrice> StyleColorPrice { get; set; }
        public ICollection<StylePrice> StylePrice { get; set; }
    }
}
