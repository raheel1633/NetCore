using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class AllocationBatchLog
    {
        public int AllocationbatchlogId { get; set; }
        public int ClientId { get; set; }
        public int AllocationbatchdetailId { get; set; }
        public int InventoryId { get; set; }
        public int Quantity { get; set; }
        public int? ShipmentId { get; set; }

        public Client Client { get; set; }
        public Inventory Inventory { get; set; }
    }
}
