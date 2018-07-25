using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class OrderStatus
    {
        public OrderStatus()
        {
            Order = new HashSet<Order>();
            Po = new HashSet<Po>();
        }

        public int OrderstatusId { get; set; }
        public string StatusCode { get; set; }
        public string Description { get; set; }

        public ICollection<Order> Order { get; set; }
        public ICollection<Po> Po { get; set; }
    }
}
