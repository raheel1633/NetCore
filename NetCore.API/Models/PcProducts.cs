using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class PcProducts
    {
        public int PcProductId { get; set; }
        public int? PcStyleId { get; set; }
        public int? ProductId { get; set; }
        public int? PcItemId { get; set; }
        public DateTime? SendDate { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public int? StockQuantity { get; set; }
        public int ClientId { get; set; }
    }
}
