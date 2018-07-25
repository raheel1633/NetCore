using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class CarrierServiceLevel
    {
        public CarrierServiceLevel()
        {
            Order = new HashSet<Order>();
            ShipVia = new HashSet<ShipVia>();
            Shipment = new HashSet<Shipment>();
        }

        public int CarrierserviceId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int CarrierId { get; set; }
        public string WsKey { get; set; }

        public ICollection<Order> Order { get; set; }
        public ICollection<ShipVia> ShipVia { get; set; }
        public ICollection<Shipment> Shipment { get; set; }
    }
}
