using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Carrier
    {
        public Carrier()
        {
            CarrierEntity = new HashSet<CarrierEntity>();
            ShipVia = new HashSet<ShipVia>();
            Shipment = new HashSet<Shipment>();
        }

        public int CarrierId { get; set; }
        public int? EntityId { get; set; }
        public byte[] Rowversion { get; set; }
        public string ScacCode { get; set; }
        public int? ClientId { get; set; }
        public string TransportationMethod { get; set; }
        public string CarrierCode { get; set; }
        public bool? VicsBol { get; set; }
        public bool? MasterBol { get; set; }
        public bool? Manifest { get; set; }
        public bool? TrackingNumbers { get; set; }
        public string ServiceLevels { get; set; }
        public bool SmallParcel { get; set; }
        public string TrackingValidation { get; set; }
        public string TrackingValidationDescription { get; set; }

        public Entity Entity { get; set; }
        public ICollection<CarrierEntity> CarrierEntity { get; set; }
        public ICollection<ShipVia> ShipVia { get; set; }
        public ICollection<Shipment> Shipment { get; set; }
    }
}
