using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class StyleDimension
    {
        public int StyledimensionId { get; set; }
        public int StyleId { get; set; }
        public int Pack { get; set; }
        public int ClientId { get; set; }
        public int Dimension { get; set; }
        public decimal Value { get; set; }

        public Style Style { get; set; }
    }
}
