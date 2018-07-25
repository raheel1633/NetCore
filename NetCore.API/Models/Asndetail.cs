using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Asndetail
    {
        public int AsndetailId { get; set; }
        public int ClientId { get; set; }
        public int AsnId { get; set; }
        public int Quantity { get; set; }
        public int ShipmentlineId { get; set; }
        public DateTime? CreationTime { get; set; }

        public Asn Asn { get; set; }
    }
}
