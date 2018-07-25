using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class MontisvirCancelCode
    {
        public int ClientId { get; set; }
        public string CancelCode { get; set; }
        public string Description { get; set; }
        public int? OrderreasonId { get; set; }
    }
}
