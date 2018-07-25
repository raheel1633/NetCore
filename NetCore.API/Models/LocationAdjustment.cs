using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class LocationAdjustment
    {
        public int LocationadjustmentId { get; set; }
        public int? TransactionId { get; set; }
        public int? InventoryId { get; set; }
        public DateTime? ActivityTime { get; set; }
        public string LocationCode { get; set; }
        public int? Quantity { get; set; }
    }
}
