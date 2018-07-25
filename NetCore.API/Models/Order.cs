using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Order
    {
        public Order()
        {
            Asn = new HashSet<Asn>();
            Commission = new HashSet<Commission>();
            CreditLog = new HashSet<CreditLog>();
            CreditRequest = new HashSet<CreditRequest>();
            DirectEdi = new HashSet<DirectEdi>();
            InverseFactoryOrder = new HashSet<Order>();
            InverseParentOrder = new HashSet<Order>();
            OrderLine = new HashSet<OrderLine>();
            Shipment = new HashSet<Shipment>();
        }

        public int OrderId { get; set; }
        public int ClientId { get; set; }
        public string OrderNo { get; set; }
        public int OrdertypeId { get; set; }
        public int OrderstatusId { get; set; }
        public string PoNumber { get; set; }
        public string ReferenceNo1 { get; set; }
        public string ReferenceNo2 { get; set; }
        public string ReferenceNo3 { get; set; }
        public string Department { get; set; }
        public int? BilltoCliententityId { get; set; }
        public int? ShiptoCliententityId { get; set; }
        public int? DcCliententityId { get; set; }
        public int? RemittoCliententityId { get; set; }
        public int? ShipfromCliententityId { get; set; }
        public int? ShipviaId { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? ShipDate { get; set; }
        public DateTime? ReceiveDate { get; set; }
        public DateTime? StartDate { get; set; }
        public string EdiStartDateType { get; set; }
        public DateTime? EndDate { get; set; }
        public string EdiEndDateType { get; set; }
        public int? ParentOrderId { get; set; }
        public int? TermsId { get; set; }
        public int? SeasonId { get; set; }
        public string Origin { get; set; }
        public byte[] Rowversion { get; set; }
        public bool? Bulk { get; set; }
        public bool? Backup { get; set; }
        public int? DivisionId { get; set; }
        public int? DepartmentId { get; set; }
        public int? DirectediId { get; set; }
        public int? CSeasonId { get; set; }
        public int? SalespersonId { get; set; }
        public int? CurrencyId { get; set; }
        public decimal? Discount { get; set; }
        public int? CarrierserviceId { get; set; }
        public int? PurchaseorderId { get; set; }
        public bool? Sample { get; set; }
        public bool? DropShip { get; set; }
        public string EdiDepartment { get; set; }
        public int? InventorystatusId { get; set; }
        public int? PoId { get; set; }
        public DateTime? ExtensionDate { get; set; }
        public int? LotId { get; set; }
        public DateTime? AcknowledgedDate { get; set; }
        public decimal? CSeed { get; set; }
        public decimal? FcCommission { get; set; }
        public int? FactoryOrderId { get; set; }
        public int? ConsolidatorCliententityId { get; set; }
        public bool IsFirstcost { get; set; }
        public int? FcTermsId { get; set; }
        public string ConsumerDocumentReference { get; set; }
        public bool Consignment { get; set; }
        public bool IsReplenishment { get; set; }
        public int? CBrandId { get; set; }
        public int? BrandId { get; set; }
        public DateTime? CStartDate { get; set; }
        public DateTime? CEndDate { get; set; }
        public int? EdidocumentId { get; set; }
        public bool? FactoryDirect { get; set; }
        public int? InventoryregionId { get; set; }
        public decimal? ShippingCharge { get; set; }
        public string EdiVendor { get; set; }
        public Guid? Uuid { get; set; }

        public ClientEntity BilltoCliententity { get; set; }
        public Brand Brand { get; set; }
        public CarrierServiceLevel Carrierservice { get; set; }
        public Client Client { get; set; }
        public ClientEntity ConsolidatorCliententity { get; set; }
        public Currency Currency { get; set; }
        public Edidocument Edidocument { get; set; }
        public Order FactoryOrder { get; set; }
        public Terms FcTerms { get; set; }
        public InventoryRegion Inventoryregion { get; set; }
        public InventoryStatus Inventorystatus { get; set; }
        public Lot Lot { get; set; }
        public OrderStatus Orderstatus { get; set; }
        public OrderType Ordertype { get; set; }
        public Order ParentOrder { get; set; }
        public Po Po { get; set; }
        public ClientEntity RemittoCliententity { get; set; }
        public Terms Terms { get; set; }
        public ICollection<Asn> Asn { get; set; }
        public ICollection<Commission> Commission { get; set; }
        public ICollection<CreditLog> CreditLog { get; set; }
        public ICollection<CreditRequest> CreditRequest { get; set; }
        public ICollection<DirectEdi> DirectEdi { get; set; }
        public ICollection<Order> InverseFactoryOrder { get; set; }
        public ICollection<Order> InverseParentOrder { get; set; }
        public ICollection<OrderLine> OrderLine { get; set; }
        public ICollection<Shipment> Shipment { get; set; }
    }
}
