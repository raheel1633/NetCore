using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Product
    {
        public Product()
        {
            AssortmentAssortmentProduct = new HashSet<Assortment>();
            AssortmentComponentProduct = new HashSet<Assortment>();
            Box = new HashSet<Box>();
            DirectEdiitem = new HashSet<DirectEdiitem>();
            Inventory = new HashSet<Inventory>();
            InvoiceLine = new HashSet<InvoiceLine>();
            MontisvirLocation = new HashSet<MontisvirLocation>();
            OrderLine = new HashSet<OrderLine>();
            ProductAlias = new HashSet<ProductAlias>();
        }

        public int ProductId { get; set; }
        public int? ClientId { get; set; }
        public int? UpcblockId { get; set; }
        public string CompanyPrefix { get; set; }
        public int? ItemReference { get; set; }
        public byte PackageLevel { get; set; }
        public int StylecolorId { get; set; }
        public int SizeId { get; set; }
        public string Sku { get; set; }
        public double? Length { get; set; }
        public double? Width { get; set; }
        public double? Height { get; set; }
        public double? Weight { get; set; }
        public DateTime? InactiveDate { get; set; }
        public int Active { get; set; }
        public byte[] Rowversion { get; set; }
        public string Description { get; set; }
        public bool? IsCasepack { get; set; }
        public bool? IsAssortment { get; set; }
        public int IsSolidpack { get; set; }
        public string Gtin { get; set; }
        public string CDescription { get; set; }
        public int Pack { get; set; }
        public int? CPack { get; set; }
        public string Upc { get; set; }
        public string Ean13 { get; set; }
        public int? MinReplenishmentLevel { get; set; }
        public int? MaxReplenishmentLevel { get; set; }
        public int? AvgWeeklySales { get; set; }
        public int? QboId { get; set; }

        public Client Client { get; set; }
        public Size Size { get; set; }
        public StyleColor Stylecolor { get; set; }
        public Upcblock Upcblock { get; set; }
        public ICollection<Assortment> AssortmentAssortmentProduct { get; set; }
        public ICollection<Assortment> AssortmentComponentProduct { get; set; }
        public ICollection<Box> Box { get; set; }
        public ICollection<DirectEdiitem> DirectEdiitem { get; set; }
        public ICollection<Inventory> Inventory { get; set; }
        public ICollection<InvoiceLine> InvoiceLine { get; set; }
        public ICollection<MontisvirLocation> MontisvirLocation { get; set; }
        public ICollection<OrderLine> OrderLine { get; set; }
        public ICollection<ProductAlias> ProductAlias { get; set; }
    }
}
