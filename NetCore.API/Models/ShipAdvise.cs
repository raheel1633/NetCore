using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class ShipAdvise
    {
        public int ShipadviseId { get; set; }
        public int ClientId { get; set; }
        public int? ShipmentId { get; set; }
        public int OrderId { get; set; }
        public int EntityId { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime? SendTime { get; set; }
        public DateTime? AckTime { get; set; }
        public byte[] RowversionId { get; set; }
    }
}
