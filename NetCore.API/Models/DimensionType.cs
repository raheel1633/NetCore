using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class DimensionType
    {
        public DimensionType()
        {
            Dimension = new HashSet<Dimension>();
        }

        public int DimensiontypeId { get; set; }
        public string Description { get; set; }

        public ICollection<Dimension> Dimension { get; set; }
    }
}
