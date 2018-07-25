using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class PcStyles
    {
        public int PcStyleId { get; set; }
        public int? StyleId { get; set; }
        public int? PcItemId { get; set; }
        public DateTime? SendDate { get; set; }
        public int ClientId { get; set; }
    }
}
