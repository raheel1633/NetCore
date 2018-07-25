using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Invoice
    {
        public Invoice()
        {
            AssignmentInvoice = new HashSet<AssignmentInvoice>();
            CreditAllocation = new HashSet<CreditAllocation>();
            InvoiceLine = new HashSet<InvoiceLine>();
            InvoiceSendHistory = new HashSet<InvoiceSendHistory>();
            ShipmentCommissionInvoice = new HashSet<Shipment>();
            ShipmentInvoiceNavigation = new HashSet<Shipment>();
        }

        public int InvoiceId { get; set; }
        public int ClientId { get; set; }
        public int InvoicetypeId { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime InvoiceDate { get; set; }
        public int? ShipmentId { get; set; }
        public int? BilltoCliententityId { get; set; }
        public int? RemittoCliententityId { get; set; }
        public int? TermsId { get; set; }
        public byte? Status { get; set; }
        public int? DivisionId { get; set; }
        public byte[] Rowversion { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? CurrencyId { get; set; }
        public DateTime? SendDate { get; set; }
        public short? SendTransport { get; set; }
        public string Shipments { get; set; }
        public int? DirectediId { get; set; }
        public int? SalespersonId { get; set; }
        public decimal? Rate { get; set; }
        public decimal? DiscountFromWholesale { get; set; }
        public decimal? CSeed { get; set; }
        public DateTime? FactorDate { get; set; }
        public int? EdidocumentId { get; set; }
        public string Memo { get; set; }
        public int? QboId { get; set; }

        public ClientEntity BilltoCliententity { get; set; }
        public Currency Currency { get; set; }
        public DirectEdi Directedi { get; set; }
        public Division Division { get; set; }
        public Edidocument Edidocument { get; set; }
        public ClientEntity RemittoCliententity { get; set; }
        public Salesperson Salesperson { get; set; }
        public Shipment Shipment { get; set; }
        public Terms Terms { get; set; }
        public ICollection<AssignmentInvoice> AssignmentInvoice { get; set; }
        public ICollection<CreditAllocation> CreditAllocation { get; set; }
        public ICollection<InvoiceLine> InvoiceLine { get; set; }
        public ICollection<InvoiceSendHistory> InvoiceSendHistory { get; set; }
        public ICollection<Shipment> ShipmentCommissionInvoice { get; set; }
        public ICollection<Shipment> ShipmentInvoiceNavigation { get; set; }
    }
}
