using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class QbSalesrep
    {
        public int QbSalesrepId { get; set; }
        public int? QbcId { get; set; }
        public int? ClientId { get; set; }
        public string ListId { get; set; }
        public DateTime? TimeCreated { get; set; }
        public DateTime? TimeModified { get; set; }
        public string Initial { get; set; }
        public bool? IsActive { get; set; }
        public string SalesRepEntityRef { get; set; }
    }
}
