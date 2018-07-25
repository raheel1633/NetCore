using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class OrderReason
    {
        public OrderReason()
        {
            OrderLineHistory = new HashSet<OrderLineHistory>();
        }

        public int OrderreasonId { get; set; }
        public string Reason { get; set; }
        public bool Increase { get; set; }
        public bool Decrease { get; set; }
        public bool? System { get; set; }

        public ICollection<OrderLineHistory> OrderLineHistory { get; set; }
    }
}
