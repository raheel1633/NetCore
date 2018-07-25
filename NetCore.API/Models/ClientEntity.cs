using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class ClientEntity
    {
        public ClientEntity()
        {
            Assignment = new HashSet<Assignment>();
            BillOfLadingCarrierCliententity = new HashSet<BillOfLading>();
            BillOfLadingConsolidatorCliententity = new HashSet<BillOfLading>();
            BillOfLadingShipfromCliententity = new HashSet<BillOfLading>();
            BillOfLadingShiptoClietnentity = new HashSet<BillOfLading>();
            Buyer = new HashSet<Buyer>();
            ClientEntityContact = new HashSet<ClientEntityContact>();
            CommissionRule = new HashSet<CommissionRule>();
            CreditRequestClientenity = new HashSet<CreditRequest>();
            CreditRequestRemittoCliententity = new HashSet<CreditRequest>();
            InvoiceBilltoCliententity = new HashSet<Invoice>();
            InvoiceRemittoCliententity = new HashSet<Invoice>();
            OrderBilltoCliententity = new HashSet<Order>();
            OrderConsolidatorCliententity = new HashSet<Order>();
            OrderRemittoCliententity = new HashSet<Order>();
            PoBilltoCliententity = new HashSet<Po>();
            PoConsolidatorCliententity = new HashSet<Po>();
            PoRemittoCliententity = new HashSet<Po>();
            ShipmentConsolidationCliententity = new HashSet<Shipment>();
            ShipmentFromCliententity = new HashSet<Shipment>();
            ShipmentMarkforCliententity = new HashSet<Shipment>();
            ShipmentToCliententity = new HashSet<Shipment>();
            Style = new HashSet<Style>();
            TermsNavigation = new HashSet<Terms>();
        }

        public int CliententityId { get; set; }
        public int ClientId { get; set; }
        public int EntityId { get; set; }
        public string VendorNo { get; set; }
        public string AccountNo { get; set; }
        public int? RemittoEntityId { get; set; }
        public int? FactorId { get; set; }
        public string DunsNumber { get; set; }
        public string Department { get; set; }
        public int? TermsId { get; set; }
        public int? Type { get; set; }
        public int? Priority { get; set; }
        public int? DiscountLimit { get; set; }
        public byte? PriceBase { get; set; }
        public decimal? PricePoints { get; set; }
        public bool? EmailShipConfirm { get; set; }
        public int? ShipviaId { get; set; }
        public decimal? CreditLimit { get; set; }
        public string Configuration { get; set; }
        public bool? Active { get; set; }
        public string DropshipConfiguration { get; set; }
        public string EdiConfiguration { get; set; }
        public int? InventoryregionId { get; set; }
        public byte[] Rowversion { get; set; }
        public Guid? Uuid { get; set; }
        public int? QboId { get; set; }

        public Client Client { get; set; }
        public Entity Entity { get; set; }
        public InventoryRegion Inventoryregion { get; set; }
        public Terms Terms { get; set; }
        public ICollection<Assignment> Assignment { get; set; }
        public ICollection<BillOfLading> BillOfLadingCarrierCliententity { get; set; }
        public ICollection<BillOfLading> BillOfLadingConsolidatorCliententity { get; set; }
        public ICollection<BillOfLading> BillOfLadingShipfromCliententity { get; set; }
        public ICollection<BillOfLading> BillOfLadingShiptoClietnentity { get; set; }
        public ICollection<Buyer> Buyer { get; set; }
        public ICollection<ClientEntityContact> ClientEntityContact { get; set; }
        public ICollection<CommissionRule> CommissionRule { get; set; }
        public ICollection<CreditRequest> CreditRequestClientenity { get; set; }
        public ICollection<CreditRequest> CreditRequestRemittoCliententity { get; set; }
        public ICollection<Invoice> InvoiceBilltoCliententity { get; set; }
        public ICollection<Invoice> InvoiceRemittoCliententity { get; set; }
        public ICollection<Order> OrderBilltoCliententity { get; set; }
        public ICollection<Order> OrderConsolidatorCliententity { get; set; }
        public ICollection<Order> OrderRemittoCliententity { get; set; }
        public ICollection<Po> PoBilltoCliententity { get; set; }
        public ICollection<Po> PoConsolidatorCliententity { get; set; }
        public ICollection<Po> PoRemittoCliententity { get; set; }
        public ICollection<Shipment> ShipmentConsolidationCliententity { get; set; }
        public ICollection<Shipment> ShipmentFromCliententity { get; set; }
        public ICollection<Shipment> ShipmentMarkforCliententity { get; set; }
        public ICollection<Shipment> ShipmentToCliententity { get; set; }
        public ICollection<Style> Style { get; set; }
        public ICollection<Terms> TermsNavigation { get; set; }
    }
}
