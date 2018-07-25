using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class ShipOrder
    {
        public int ShiporderId { get; set; }
        public int ClientId { get; set; }
        public int? ShipmentId { get; set; }
        public int EntityId { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime? Send940Time { get; set; }
        public DateTime? Ack940Time { get; set; }
        public byte[] Rowversion { get; set; }
    }
}
