using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class MontisvirLocation
    {
        public int MontisvirlocationId { get; set; }
        public int ClientId { get; set; }
        public int EntityId { get; set; }
        public string LocationCode { get; set; }
        public int ProductId { get; set; }
        public int LotId { get; set; }
        public int InventorystatusId { get; set; }
        public int Quantity { get; set; }

        public Client Client { get; set; }
        public InventoryStatus Inventorystatus { get; set; }
        public Lot Lot { get; set; }
        public Product Product { get; set; }
    }
}
