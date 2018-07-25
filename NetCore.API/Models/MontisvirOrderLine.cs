using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class MontisvirOrderLine
    {
        public int ClientId { get; set; }
        public string OrderNbr { get; set; }
        public int LineNbr { get; set; }
        public string SubLine { get; set; }
        public int Element { get; set; }
        public string Size { get; set; }
        public int? OrderQty { get; set; }
        public int? AllocQty { get; set; }
        public int? ShipQty { get; set; }
        public string Status { get; set; }
        public int? ProductId { get; set; }
        public int OrderId { get; set; }
        public int? OrderlineId { get; set; }
        public decimal? Price { get; set; }
        public string CancelCode { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateChanged { get; set; }
    }
}
