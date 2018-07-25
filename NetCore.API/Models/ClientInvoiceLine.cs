using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class ClientInvoiceLine
    {
        public int ClientinvoicelineId { get; set; }
        public int ClientId { get; set; }
        public int ClientinvoiceId { get; set; }
        public int Linenumber { get; set; }
        public int? PlanoptionId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal? Amount { get; set; }
        public bool Istaxable { get; set; }
        public string Memo { get; set; }
        public byte[] Rowversion { get; set; }

        public Client Client { get; set; }
        public ClientInvoice Clientinvoice { get; set; }
        public ClientInvoiceLine Clientinvoiceline { get; set; }
        public PlanOption Planoption { get; set; }
        public ClientInvoiceLine InverseClientinvoiceline { get; set; }
    }
}
