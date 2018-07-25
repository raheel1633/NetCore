using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class InventoryRegion
    {
        public InventoryRegion()
        {
            ClientEntity = new HashSet<ClientEntity>();
            Inventory = new HashSet<Inventory>();
            Order = new HashSet<Order>();
            Salesperson = new HashSet<Salesperson>();
            Shipment = new HashSet<Shipment>();
            StyleColorInventoryRegion = new HashSet<StyleColorInventoryRegion>();
            StyleInventoryRegion = new HashSet<StyleInventoryRegion>();
        }

        public int InventoryregionId { get; set; }
        public int ClientId { get; set; }
        public string Name { get; set; }
        public int CurrencyId { get; set; }
        public int? CountryId { get; set; }
        public bool? FactoryDirect { get; set; }

        public Client Client { get; set; }
        public Country Country { get; set; }
        public Currency Currency { get; set; }
        public ICollection<ClientEntity> ClientEntity { get; set; }
        public ICollection<Inventory> Inventory { get; set; }
        public ICollection<Order> Order { get; set; }
        public ICollection<Salesperson> Salesperson { get; set; }
        public ICollection<Shipment> Shipment { get; set; }
        public ICollection<StyleColorInventoryRegion> StyleColorInventoryRegion { get; set; }
        public ICollection<StyleInventoryRegion> StyleInventoryRegion { get; set; }
    }
}
