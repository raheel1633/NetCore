using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class StyleColorSeason
    {
        public int StylecolorseasonId { get; set; }
        public int ClientId { get; set; }
        public int SeasonId { get; set; }
        public int StylecolorId { get; set; }
        public decimal? Price { get; set; }
        public short? Delivery { get; set; }

        public Season Season { get; set; }
        public StyleColor Stylecolor { get; set; }
    }
}
