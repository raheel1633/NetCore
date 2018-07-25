using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Bin
    {
        public int BinId { get; set; }
        public int? ClientId { get; set; }
        public string BinCode { get; set; }
        public int? AisleId { get; set; }
    }
}
