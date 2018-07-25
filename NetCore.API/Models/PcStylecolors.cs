using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class PcStylecolors
    {
        public int PcStylecolorsId { get; set; }
        public int? StylecolorId { get; set; }
        public int? PcOptionId { get; set; }
        public int? ClientId { get; set; }
    }
}
