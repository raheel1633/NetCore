using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Edidocument
    {
        public Edidocument()
        {
            Assignment = new HashSet<Assignment>();
            ClientWarehouse = new HashSet<ClientWarehouse>();
            EdidocumentLogEdidocumentNavigation = new HashSet<EdidocumentLog>();
            EdidocumentLogOutputDocument = new HashSet<EdidocumentLog>();
            InverseAcknowledgementDocument = new HashSet<Edidocument>();
            InverseSourceDocument = new HashSet<Edidocument>();
            Invoice = new HashSet<Invoice>();
            Order = new HashSet<Order>();
            OrderLineHistory = new HashSet<OrderLineHistory>();
            Qbwc = new HashSet<Qbwc>();
            Shipment = new HashSet<Shipment>();
        }

        public int EdidocumentId { get; set; }
        public Guid Id { get; set; }
        public int ClientId { get; set; }
        public string DocumentName { get; set; }
        public string Reference { get; set; }
        public string Documenttype { get; set; }
        public byte[] Document { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? LastActivityDate { get; set; }
        public byte DocumentState { get; set; }
        public int EdiproviderId { get; set; }
        public int EditradingpartnerId { get; set; }
        public string Direction { get; set; }
        public int? AcknowledgementDocumentId { get; set; }
        public int? SourceDocumentId { get; set; }
        public string Usageindicator { get; set; }
        public int? SourceEdidocumentlogId { get; set; }
        public bool InternalUsageIndicator { get; set; }
        public int? ControlNumber { get; set; }
        public string AcknowledgementCode { get; set; }
        public string FileExtension { get; set; }
        public int? IsaControlNumber { get; set; }
        public int? Year { get; set; }
        public int? Month { get; set; }
        public string Xml { get; set; }
        public int? EdidocumenttypeId { get; set; }
        public int? ClientEditradingpartnerId { get; set; }
        public DateTime? CCreationDate { get; set; }
        public int? CdnId { get; set; }
        public long? Size { get; set; }

        public Edidocument AcknowledgementDocument { get; set; }
        public Cdn Cdn { get; set; }
        public Client Client { get; set; }
        public EditradingPartner ClientEditradingpartner { get; set; }
        public EdidocumentState DocumentStateNavigation { get; set; }
        public EdidocumentType Edidocumenttype { get; set; }
        public Ediprovider Ediprovider { get; set; }
        public EditradingPartner Editradingpartner { get; set; }
        public Edidocument SourceDocument { get; set; }
        public EdidocumentLog SourceEdidocumentlog { get; set; }
        public ICollection<Assignment> Assignment { get; set; }
        public ICollection<ClientWarehouse> ClientWarehouse { get; set; }
        public ICollection<EdidocumentLog> EdidocumentLogEdidocumentNavigation { get; set; }
        public ICollection<EdidocumentLog> EdidocumentLogOutputDocument { get; set; }
        public ICollection<Edidocument> InverseAcknowledgementDocument { get; set; }
        public ICollection<Edidocument> InverseSourceDocument { get; set; }
        public ICollection<Invoice> Invoice { get; set; }
        public ICollection<Order> Order { get; set; }
        public ICollection<OrderLineHistory> OrderLineHistory { get; set; }
        public ICollection<Qbwc> Qbwc { get; set; }
        public ICollection<Shipment> Shipment { get; set; }
    }
}
