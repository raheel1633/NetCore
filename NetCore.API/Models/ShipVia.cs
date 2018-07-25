using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class ShipVia
    {
        public ShipVia()
        {
            Po = new HashSet<Po>();
            Shipment = new HashSet<Shipment>();
        }

        public int ShipviaId { get; set; }
        public string ShipviaCode { get; set; }
        public int? CarrierId { get; set; }
        public string ServiceLevel { get; set; }
        public string Description { get; set; }
        public int? ClientId { get; set; }
        public int? TransitTime { get; set; }
        public int? CarrierserviceId { get; set; }
        public string Configuration { get; set; }

        public Carrier Carrier { get; set; }
        public CarrierServiceLevel Carrierservice { get; set; }
        public ICollection<Po> Po { get; set; }
        public ICollection<Shipment> Shipment { get; set; }
    }
}
