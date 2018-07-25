using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class TagLineSheet
    {
        public string Brand { get; set; }
        public string StyleCode { get; set; }
        public string ColorCode { get; set; }
        public string MaterialCode { get; set; }
        public string NrfColor { get; set; }
        public string Color { get; set; }
        public int? StylecolorId { get; set; }
        public string Season { get; set; }
        public decimal? Wholesale { get; set; }
        public decimal? Retail { get; set; }
    }
}
