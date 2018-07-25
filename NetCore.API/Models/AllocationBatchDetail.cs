using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class AllocationBatchDetail
    {
        public int AllocationbatchdetailId { get; set; }
        public int AllocationbatchId { get; set; }
        public int ClientId { get; set; }
        public int OrderlineId { get; set; }
        public int QuantityRequested { get; set; }
        public int Priority { get; set; }

        public Client Client { get; set; }
        public OrderLine Orderline { get; set; }
    }
}
