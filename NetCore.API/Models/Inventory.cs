using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Inventory
    {
        public Inventory()
        {
            Adjustment = new HashSet<Adjustment>();
            AllocationBatchLog = new HashSet<AllocationBatchLog>();
            LocationInventory = new HashSet<LocationInventory>();
            ShipmentLine = new HashSet<ShipmentLine>();
        }

        public int InventoryId { get; set; }
        public int ClientId { get; set; }
        public int EntityId { get; set; }
        public int ProductId { get; set; }
        public int LotId { get; set; }
        public int InventorystatusId { get; set; }
        public int Quantity { get; set; }
        public DateTime? AvailableDate { get; set; }
        public int? ShipmentId { get; set; }
        public int Intransit { get; set; }
        public string Location { get; set; }
        public int? ShipmentlineId { get; set; }
        public int? Allocated { get; set; }
        public int? Available { get; set; }
        public int? InventoryregionId { get; set; }

        public Client Client { get; set; }
        public Entity Entity { get; set; }
        public InventoryRegion Inventoryregion { get; set; }
        public InventoryStatus Inventorystatus { get; set; }
        public Lot Lot { get; set; }
        public Product Product { get; set; }
        public Shipment Shipment { get; set; }
        public ShipmentLine Shipmentline { get; set; }
        public ICollection<Adjustment> Adjustment { get; set; }
        public ICollection<AllocationBatchLog> AllocationBatchLog { get; set; }
        public ICollection<LocationInventory> LocationInventory { get; set; }
        public ICollection<ShipmentLine> ShipmentLine { get; set; }
    }
}
