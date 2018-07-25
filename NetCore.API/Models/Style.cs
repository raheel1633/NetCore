using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Style
    {
        public Style()
        {
            SizePrice = new HashSet<SizePrice>();
            StyleCost = new HashSet<StyleCost>();
            StyleDimension = new HashSet<StyleDimension>();
            StyleInventoryRegion = new HashSet<StyleInventoryRegion>();
            StylePrice = new HashSet<StylePrice>();
        }

        public int StyleId { get; set; }
        public int ClientId { get; set; }
        public string StyleCode { get; set; }
        public string StyleName { get; set; }
        public string QrsDesc { get; set; }
        public string Sku { get; set; }
        public int DivisionId { get; set; }
        public int SeasonId { get; set; }
        public int? BaseId { get; set; }
        public decimal? FactoryCost { get; set; }
        public decimal? LandedCost { get; set; }
        public decimal? WholesaleCost { get; set; }
        public decimal? RetailCost { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Length { get; set; }
        public decimal? Width { get; set; }
        public decimal? Height { get; set; }
        public int? NmfcId { get; set; }
        public DateTime? InactiveDate { get; set; }
        public int Active { get; set; }
        public byte[] Rowversion { get; set; }
        public int BrandId { get; set; }
        public bool? Type { get; set; }
        public DateTime? OrderStart { get; set; }
        public DateTime? OrderEnd { get; set; }
        public DateTime? ShipStart { get; set; }
        public DateTime? ShipEnd { get; set; }
        public string Hts { get; set; }
        public bool? Closeout { get; set; }
        public decimal? FreightCost { get; set; }
        public decimal? DutyCost { get; set; }
        public decimal? BrokerageFee { get; set; }
        public decimal? CLandedCost { get; set; }
        public decimal? CStandardgm { get; set; }
        public decimal? CStmi { get; set; }
        public decimal? DiscountPrice { get; set; }
        public int? CurrencyId { get; set; }
        public short? Delivery { get; set; }
        public int? CollectionId { get; set; }
        public decimal? RoyalityPercentage { get; set; }
        public bool? DynamicProducts { get; set; }
        public string Silhouette { get; set; }
        public int? CountryId { get; set; }
        public string Construction { get; set; }
        public string DropShip { get; set; }
        public int? FactoryCliententityId { get; set; }
        public string HtsCode { get; set; }
        public string Configuration { get; set; }
        public int? ProducttypeId { get; set; }
        public string Description { get; set; }
        public string Joor { get; set; }
        public string CdnConfiguration { get; set; }
        public int? UomId { get; set; }
        public string Tags { get; set; }
        public int? QboId { get; set; }

        public Base Base { get; set; }
        public Brand Brand { get; set; }
        public Client Client { get; set; }
        public Country Country { get; set; }
        public Currency Currency { get; set; }
        public Division Division { get; set; }
        public ClientEntity FactoryCliententity { get; set; }
        public Nmfc Nmfc { get; set; }
        public Producttype Producttype { get; set; }
        public Season Season { get; set; }
        public Uom Uom { get; set; }
        public ICollection<SizePrice> SizePrice { get; set; }
        public ICollection<StyleCost> StyleCost { get; set; }
        public ICollection<StyleDimension> StyleDimension { get; set; }
        public ICollection<StyleInventoryRegion> StyleInventoryRegion { get; set; }
        public ICollection<StylePrice> StylePrice { get; set; }
    }
}
