using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class TagLines
    {
        public string Brand { get; set; }
        public int? OrderId { get; set; }
        public string OrderNo { get; set; }
        public string InvoiceNo { get; set; }
        public int? ProductId { get; set; }
        public decimal? Price { get; set; }
        public int? Quantity { get; set; }
        public string LineStatus { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string RunCode { get; set; }
        public string Material { get; set; }
        public int Sequence { get; set; }
        public int? StylecolorId { get; set; }
        public string StyleCode { get; set; }
        public string Color { get; set; }
        public decimal? Discount { get; set; }
    }
}
