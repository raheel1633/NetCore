using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class InventoryStatus
    {
        public InventoryStatus()
        {
            ClientWarehouse = new HashSet<ClientWarehouse>();
            Inventory = new HashSet<Inventory>();
            MontisvirLocation = new HashSet<MontisvirLocation>();
            Order = new HashSet<Order>();
            OrderLine = new HashSet<OrderLine>();
        }

        public int InventorystatusId { get; set; }
        public string StatusCode { get; set; }
        public string Description { get; set; }

        public ICollection<ClientWarehouse> ClientWarehouse { get; set; }
        public ICollection<Inventory> Inventory { get; set; }
        public ICollection<MontisvirLocation> MontisvirLocation { get; set; }
        public ICollection<Order> Order { get; set; }
        public ICollection<OrderLine> OrderLine { get; set; }
    }
}
