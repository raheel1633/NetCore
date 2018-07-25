using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class StyleColor
    {
        public StyleColor()
        {
            Product = new HashSet<Product>();
            SizePrice = new HashSet<SizePrice>();
            StyleColorCost = new HashSet<StyleColorCost>();
            StyleColorInventoryRegion = new HashSet<StyleColorInventoryRegion>();
            StyleColorPrice = new HashSet<StyleColorPrice>();
            StyleColorSeason = new HashSet<StyleColorSeason>();
        }

        public int StylecolorId { get; set; }
        public int ClientId { get; set; }
        public int StyleId { get; set; }
        public string NrfColor { get; set; }
        public string Description { get; set; }
        public int? SeasonId { get; set; }
        public int? MaterialId { get; set; }
        public string QrsDesc { get; set; }
        public DateTime? EarliestShipDate { get; set; }
        public byte[] Rowversion { get; set; }
        public int? ColorId { get; set; }
        public decimal? FactoryCost { get; set; }
        public decimal? LandedCost { get; set; }
        public decimal? WholesaleCost { get; set; }
        public decimal? RetailCost { get; set; }
        public decimal? Price { get; set; }
        public DateTime? InactiveDate { get; set; }
        public int Active { get; set; }
        public decimal? FreightCost { get; set; }
        public decimal? DutyCost { get; set; }
        public decimal? BrokerageFee { get; set; }
        public decimal? CLandedCost { get; set; }
        public decimal? CStmi { get; set; }
        public decimal? CStandardgm { get; set; }
        public string Multi { get; set; }
        public string CColor { get; set; }
        public string CColormaterial { get; set; }
        public decimal? DiscountPrice { get; set; }
        public string Sku { get; set; }
        public int? CurrencyId { get; set; }
        public string CMaterial { get; set; }
        public string DropShip { get; set; }
        public DateTime? OrderStart { get; set; }
        public DateTime? OrderEnd { get; set; }
        public DateTime? ShipStart { get; set; }
        public DateTime? ShipEnd { get; set; }
        public string RgbColor { get; set; }
        public string CdnConfiguration { get; set; }
        public string HtsCode { get; set; }
        public int? QboId { get; set; }

        public Material Material { get; set; }
        public ICollection<Product> Product { get; set; }
        public ICollection<SizePrice> SizePrice { get; set; }
        public ICollection<StyleColorCost> StyleColorCost { get; set; }
        public ICollection<StyleColorInventoryRegion> StyleColorInventoryRegion { get; set; }
        public ICollection<StyleColorPrice> StyleColorPrice { get; set; }
        public ICollection<StyleColorSeason> StyleColorSeason { get; set; }
    }
}
