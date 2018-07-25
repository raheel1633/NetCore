using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class OrderLine
    {
        public OrderLine()
        {
            AllocationBatchDetail = new HashSet<AllocationBatchDetail>();
            InverseFactoryOrderline = new HashSet<OrderLine>();
            InvoiceLine = new HashSet<InvoiceLine>();
            OrderLineHistory = new HashSet<OrderLineHistory>();
            ShipmentLine = new HashSet<ShipmentLine>();
        }

        public int OrderlineId { get; set; }
        public int ClientId { get; set; }
        public int OrderId { get; set; }
        public string LineNumber { get; set; }
        public int ProductId { get; set; }
        public int InventorystatusId { get; set; }
        public int? LotId { get; set; }
        public int QuantityOrdered { get; set; }
        public int? QuantityAllocated { get; set; }
        public int? QuantityShipped { get; set; }
        public int? QuantityReceived { get; set; }
        public int? QuantityCanceled { get; set; }
        public int? PackQuantity { get; set; }
        public string Sku { get; set; }
        public decimal? Price { get; set; }
        public decimal? Tax1 { get; set; }
        public decimal? Tax2 { get; set; }
        public int? ParentOrderlineId { get; set; }
        public decimal? ExtendedPrice { get; set; }
        public int? QuantityIntransit { get; set; }
        public byte? Destination { get; set; }
        public byte? Source { get; set; }
        public decimal? RetailPrice { get; set; }
        public bool PerSizePricing { get; set; }
        public int? ProductaliasId { get; set; }
        public decimal? FactoryPrice { get; set; }
        public string ConsumerDocumentReference { get; set; }
        public int? FactoryOrderlineId { get; set; }
        public int? QuantityOpen { get; set; }
        public int? QuantityMto { get; set; }
        public byte[] Rowversion { get; set; }
        public string Edixml { get; set; }

        public Client Client { get; set; }
        public OrderLine FactoryOrderline { get; set; }
        public InventoryStatus Inventorystatus { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }
        public ProductAlias Productalias { get; set; }
        public ICollection<AllocationBatchDetail> AllocationBatchDetail { get; set; }
        public ICollection<OrderLine> InverseFactoryOrderline { get; set; }
        public ICollection<InvoiceLine> InvoiceLine { get; set; }
        public ICollection<OrderLineHistory> OrderLineHistory { get; set; }
        public ICollection<ShipmentLine> ShipmentLine { get; set; }
    }
}
