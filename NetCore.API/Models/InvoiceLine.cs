using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class InvoiceLine
    {
        public int InvoicelineId { get; set; }
        public int ClientId { get; set; }
        public int InvoiceId { get; set; }
        public int Linenumber { get; set; }
        public int InvoicelinetypeId { get; set; }
        public int? OrderlineId { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public int? ProductId { get; set; }
        public bool Istaxable { get; set; }
        public string Memo { get; set; }
        public byte[] Rowversion { get; set; }
        public string CMemo { get; set; }
        public int? ShipmentlineId { get; set; }
        public decimal? RolalityPercentage { get; set; }
        public decimal? Amount { get; set; }
        public string Other1 { get; set; }

        public Client Client { get; set; }
        public Invoice Invoice { get; set; }
        public InvoiceLine Invoiceline { get; set; }
        public OrderLine Orderline { get; set; }
        public Product Product { get; set; }
        public InvoiceLine InverseInvoiceline { get; set; }
    }
}
