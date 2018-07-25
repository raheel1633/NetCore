using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class OrderType
    {
        public OrderType()
        {
            Order = new HashSet<Order>();
            Po = new HashSet<Po>();
        }

        public int OrdertypeId { get; set; }
        public string OrdertypeCode { get; set; }
        public string Description { get; set; }
        public string PriyaCode { get; set; }
        public int? Group { get; set; }
        public string OrderPrefix { get; set; }

        public ICollection<Order> Order { get; set; }
        public ICollection<Po> Po { get; set; }
    }
}
