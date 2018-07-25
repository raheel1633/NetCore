using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class LocationInventory
    {
        public LocationInventory()
        {
            LocationAllocation = new HashSet<LocationAllocation>();
        }

        public int LocationinventoryId { get; set; }
        public int ClientId { get; set; }
        public int InventoryId { get; set; }
        public int LocationId { get; set; }
        public int Quantity { get; set; }

        public Client Client { get; set; }
        public Inventory Inventory { get; set; }
        public Location Location { get; set; }
        public ICollection<LocationAllocation> LocationAllocation { get; set; }
    }
}
