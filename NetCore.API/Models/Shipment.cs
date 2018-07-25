using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Shipment
    {
        public Shipment()
        {
            Inventory = new HashSet<Inventory>();
            Invoice = new HashSet<Invoice>();
            ShipmentLine = new HashSet<ShipmentLine>();
        }

        public int ShipmentId { get; set; }
        public int ClientId { get; set; }
        public int? OrderId { get; set; }
        public string ShipmentNo { get; set; }
        public string ReferenceNo1 { get; set; }
        public string ReferenceNo2 { get; set; }
        public int? ShipviaId { get; set; }
        public int? CarrierId { get; set; }
        public DateTime? RequestedShipDate { get; set; }
        public DateTime? ScheduledShipDate { get; set; }
        public DateTime? ShipDate { get; set; }
        public DateTime? RequestedReceiveDate { get; set; }
        public DateTime? EstimatedReceiveDate { get; set; }
        public DateTime? ReceiveDate { get; set; }
        public DateTime? CancelDate { get; set; }
        public int? FromCliententityId { get; set; }
        public int? ToCliententityId { get; set; }
        public int? BillofladingId { get; set; }
        public string BolNumber { get; set; }
        public int? ContainerId { get; set; }
        public byte[] Rowversion { get; set; }
        public decimal? ShippingCharge { get; set; }
        public int? ShipmentmopId { get; set; }
        public int? InvoiceId { get; set; }
        public int? MarkforCliententityId { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public int? OrdertypeId { get; set; }
        public DateTime? PrintDate { get; set; }
        public int? CarrierserviceId { get; set; }
        public int? DirectediId { get; set; }
        public decimal? HandlingCharge { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? ConsolidationCliententityId { get; set; }
        public short ShipmentType { get; set; }
        public decimal? CSeed { get; set; }
        public DateTime? AuthorizationEmailDate { get; set; }
        public string Status { get; set; }
        public int? CommissionInvoiceId { get; set; }
        public int? EdidocumentId { get; set; }
        public int? InventoryregionId { get; set; }
        public bool? PackAsSpecified { get; set; }

        public BillOfLading Billoflading { get; set; }
        public Carrier Carrier { get; set; }
        public CarrierServiceLevel Carrierservice { get; set; }
        public Client Client { get; set; }
        public Invoice CommissionInvoice { get; set; }
        public ClientEntity ConsolidationCliententity { get; set; }
        public Container Container { get; set; }
        public DirectEdi Directedi { get; set; }
        public Edidocument Edidocument { get; set; }
        public ClientEntity FromCliententity { get; set; }
        public InventoryRegion Inventoryregion { get; set; }
        public Invoice InvoiceNavigation { get; set; }
        public ClientEntity MarkforCliententity { get; set; }
        public Order Order { get; set; }
        public ShipVia Shipvia { get; set; }
        public ClientEntity ToCliententity { get; set; }
        public ICollection<Inventory> Inventory { get; set; }
        public ICollection<Invoice> Invoice { get; set; }
        public ICollection<ShipmentLine> ShipmentLine { get; set; }
    }
}
