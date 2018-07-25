using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class AdjustmentReason
    {
        public AdjustmentReason()
        {
            Adjustment = new HashSet<Adjustment>();
        }

        public int AdjustmentreasonId { get; set; }
        public string ReasonName { get; set; }
        public bool Increase { get; set; }
        public bool Decrease { get; set; }

        public ICollection<Adjustment> Adjustment { get; set; }
    }
}
