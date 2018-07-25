using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Atschange
    {
        public int AtschangeId { get; set; }
        public int ClientId { get; set; }
        public int ProductId { get; set; }
        public DateTime? Changedate { get; set; }
    }
}
