using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Currency
    {
        public Currency()
        {
            Client = new HashSet<Client>();
            Entity = new HashSet<Entity>();
            ExchangeRateBaseCurrency = new HashSet<ExchangeRate>();
            ExchangeRateTargetCurrency = new HashSet<ExchangeRate>();
            InventoryRegion = new HashSet<InventoryRegion>();
            Invoice = new HashSet<Invoice>();
            Material = new HashSet<Material>();
            Order = new HashSet<Order>();
            Po = new HashSet<Po>();
            Price = new HashSet<Price>();
            ProductAlias = new HashSet<ProductAlias>();
            SizePrice = new HashSet<SizePrice>();
            Style = new HashSet<Style>();
            StyleColorInventoryRegionFactorCostCurrency = new HashSet<StyleColorInventoryRegion>();
            StyleColorInventoryRegionLandedCostCurrency = new HashSet<StyleColorInventoryRegion>();
            StyleColorPrice = new HashSet<StyleColorPrice>();
            StyleCost = new HashSet<StyleCost>();
            StyleInventoryRegionFactorCostCurrency = new HashSet<StyleInventoryRegion>();
            StyleInventoryRegionLandedCostCurrency = new HashSet<StyleInventoryRegion>();
            StylePrice = new HashSet<StylePrice>();
        }

        public int CurrencyId { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencyName { get; set; }
        public string Symbol { get; set; }
        public string CultureInfo { get; set; }
        public decimal? ExchangeRate { get; set; }
        public DateTime? ExchangeRateDate { get; set; }
        public int? QbCurrencyId { get; set; }
        public byte[] Rowversion { get; set; }

        public QbCurrency QbCurrency { get; set; }
        public ICollection<Client> Client { get; set; }
        public ICollection<Entity> Entity { get; set; }
        public ICollection<ExchangeRate> ExchangeRateBaseCurrency { get; set; }
        public ICollection<ExchangeRate> ExchangeRateTargetCurrency { get; set; }
        public ICollection<InventoryRegion> InventoryRegion { get; set; }
        public ICollection<Invoice> Invoice { get; set; }
        public ICollection<Material> Material { get; set; }
        public ICollection<Order> Order { get; set; }
        public ICollection<Po> Po { get; set; }
        public ICollection<Price> Price { get; set; }
        public ICollection<ProductAlias> ProductAlias { get; set; }
        public ICollection<SizePrice> SizePrice { get; set; }
        public ICollection<Style> Style { get; set; }
        public ICollection<StyleColorInventoryRegion> StyleColorInventoryRegionFactorCostCurrency { get; set; }
        public ICollection<StyleColorInventoryRegion> StyleColorInventoryRegionLandedCostCurrency { get; set; }
        public ICollection<StyleColorPrice> StyleColorPrice { get; set; }
        public ICollection<StyleCost> StyleCost { get; set; }
        public ICollection<StyleInventoryRegion> StyleInventoryRegionFactorCostCurrency { get; set; }
        public ICollection<StyleInventoryRegion> StyleInventoryRegionLandedCostCurrency { get; set; }
        public ICollection<StylePrice> StylePrice { get; set; }
    }
}
