using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Asn
    {
        public Asn()
        {
            Asndetail = new HashSet<Asndetail>();
        }

        public int AsnId { get; set; }
        public int ClientId { get; set; }
        public int ShipmentId { get; set; }
        public string Sscc18 { get; set; }
        public short? CartonNumber { get; set; }
        public string TrackingNumber { get; set; }
        public string MasterTrackingNumber { get; set; }
        public string CubeDimension { get; set; }
        public string WeightDimension { get; set; }
        public decimal? Length { get; set; }
        public decimal? Width { get; set; }
        public decimal? Height { get; set; }
        public decimal? Cube { get; set; }
        public decimal? Weight { get; set; }
        public int? ContainerAsnId { get; set; }
        public int? EntityId { get; set; }
        public string Bin { get; set; }
        public int? AsnCartonNo { get; set; }
        public decimal? ShippingCharge { get; set; }
        public byte[] ShippingLabel { get; set; }
        public int? ReferencedOrderId { get; set; }
        public int? BoxId { get; set; }
        public int? LocationId { get; set; }
        public byte[] ReturnLabel { get; set; }

        public Box Box { get; set; }
        public Location Location { get; set; }
        public Order ReferencedOrder { get; set; }
        public ICollection<Asndetail> Asndetail { get; set; }
    }
}
