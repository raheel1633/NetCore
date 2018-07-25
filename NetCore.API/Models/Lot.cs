using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Lot
    {
        public Lot()
        {
            Adjustment = new HashSet<Adjustment>();
            Inventory = new HashSet<Inventory>();
            MontisvirLocation = new HashSet<MontisvirLocation>();
            Order = new HashSet<Order>();
            Po = new HashSet<Po>();
            ShipmentLine = new HashSet<ShipmentLine>();
        }

        public int LotId { get; set; }
        public int ClientId { get; set; }
        public string LotCode { get; set; }
        public int? SalesbranchId { get; set; }
        public byte[] Rowversion { get; set; }
        public DateTime? AvailableDate { get; set; }
        public DateTime? InactiveDate { get; set; }

        public Client Client { get; set; }
        public SalesBranch Salesbranch { get; set; }
        public ICollection<Adjustment> Adjustment { get; set; }
        public ICollection<Inventory> Inventory { get; set; }
        public ICollection<MontisvirLocation> MontisvirLocation { get; set; }
        public ICollection<Order> Order { get; set; }
        public ICollection<Po> Po { get; set; }
        public ICollection<ShipmentLine> ShipmentLine { get; set; }
    }
}
