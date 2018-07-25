using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class ShipmentLine
    {
        public ShipmentLine()
        {
            Inventory = new HashSet<Inventory>();
            LocationAllocation = new HashSet<LocationAllocation>();
        }

        public int ShipmentlineId { get; set; }
        public int ClientId { get; set; }
        public int ShipmentId { get; set; }
        public int OrderlineId { get; set; }
        public int? LotId { get; set; }
        public int Quantity { get; set; }
        public int? QuantityShipped { get; set; }
        public int? QuantityReceived { get; set; }
        public byte[] Rowversion { get; set; }
        public int? QuantityIntransit { get; set; }
        public int? InventoryId { get; set; }

        public Client Client { get; set; }
        public Inventory InventoryNavigation { get; set; }
        public Lot Lot { get; set; }
        public OrderLine Orderline { get; set; }
        public Shipment Shipment { get; set; }
        public ICollection<Inventory> Inventory { get; set; }
        public ICollection<LocationAllocation> LocationAllocation { get; set; }
    }
}
