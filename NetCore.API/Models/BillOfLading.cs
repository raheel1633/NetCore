using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class BillOfLading
    {
        public BillOfLading()
        {
            Shipment = new HashSet<Shipment>();
        }

        public int BillofladingId { get; set; }
        public int ClientId { get; set; }
        public string BolNumber { get; set; }
        public short? Fob { get; set; }
        public int? CarrierCliententityId { get; set; }
        public int ShipfromCliententityId { get; set; }
        public int ShiptoClietnentityId { get; set; }
        public string TrailerNo { get; set; }
        public string SealNo { get; set; }
        public string ProNumber { get; set; }
        public short? FreightChargeTerms { get; set; }
        public byte[] Rownumber { get; set; }
        public int? BilltoCliententityId { get; set; }
        public DateTime? ExpectedShipDate { get; set; }
        public DateTime? ShipDate { get; set; }
        public short? MasterGroup { get; set; }
        public int? CarrierId { get; set; }
        public string SpecialInstructions { get; set; }
        public int? ConsolidatorCliententityId { get; set; }
        public string LoadId { get; set; }
        public short ShipmentType { get; set; }
        public string Configuration { get; set; }

        public ClientEntity CarrierCliententity { get; set; }
        public Client Client { get; set; }
        public ClientEntity ConsolidatorCliententity { get; set; }
        public ClientEntity ShipfromCliententity { get; set; }
        public ClientEntity ShiptoClietnentity { get; set; }
        public ICollection<Shipment> Shipment { get; set; }
    }
}
