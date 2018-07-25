using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class LocationAllocation
    {
        public int LocationallocationId { get; set; }
        public int ClientId { get; set; }
        public int LocationinventoryId { get; set; }
        public int ShipmentlineId { get; set; }
        public int? Quantity { get; set; }

        public Client Client { get; set; }
        public LocationInventory Locationinventory { get; set; }
        public ShipmentLine Shipmentline { get; set; }
    }
}
