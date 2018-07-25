using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Aisle
    {
        public int AisleId { get; set; }
        public int? ClientId { get; set; }
        public string AisleCode { get; set; }
        public float? Width { get; set; }
    }
}
