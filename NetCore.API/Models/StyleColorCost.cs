using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class StyleColorCost
    {
        public int StylecolorcostId { get; set; }
        public int StylecolorId { get; set; }
        public int StylecostId { get; set; }
        public string Color { get; set; }
        public decimal? Cost { get; set; }

        public StyleColor Stylecolor { get; set; }
        public StyleCost Stylecost { get; set; }
    }
}
