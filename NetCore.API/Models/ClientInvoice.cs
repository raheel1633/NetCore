using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class ClientInvoice
    {
        public ClientInvoice()
        {
            ClientInvoiceLine = new HashSet<ClientInvoiceLine>();
        }

        public int ClientinvoiceId { get; set; }
        public int ClientId { get; set; }
        public string PaymentechProfileId { get; set; }
        public DateTime InvoiceFromDate { get; set; }
        public DateTime InvoiceToDate { get; set; }
        public byte? Status { get; set; }
        public byte[] Rowversion { get; set; }
        public string InvoiceNo { get; set; }

        public ICollection<ClientInvoiceLine> ClientInvoiceLine { get; set; }
    }
}
